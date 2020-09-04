
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using DevExpress.Data;
using DevExpress.Spreadsheet;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;

using Ulee.Controls;
using Ulee.Utils;

namespace Sgs.ReportIntegration
{
    public partial class CtrlEditBom : UlUserControlEng
    {
        private CtrlEditRight parent;

        private GridBookmark bookmark;
        
        private BomDataSet bomSet;

        private ProductDataSet productSet;

        private PartDataSet partSet;

        private BomColumns bomRec;

        public CtrlEditBom(CtrlEditRight parent)
        {
            this.parent = parent;

            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            bomSet = new BomDataSet(AppRes.DB.Connect, null, null);
            productSet = new ProductDataSet(AppRes.DB.Connect, null, null);
            partSet = new PartDataSet(AppRes.DB.Connect, null, null);

            bomRec = new BomColumns();

            bookmark = new GridBookmark(bomGridView);

            AppHelper.SetGridEvenRow(bomGridView);
            AppHelper.SetGridEvenRow(productGridView);
            AppHelper.SetGridEvenRow(partGridView);

            bomAreaColumn.DisplayFormat.FormatType = FormatType.Custom;
            bomAreaColumn.DisplayFormat.Format = new ReportAreaFormat();

            bomAreaCombo.DataSource = EnumHelper.GetNameValues<EReportArea>();
            bomAreaCombo.DisplayMember = "Name";
            bomAreaCombo.ValueMember = "Value";
        }

        private void CtrlEditBom_Load(object sender, EventArgs e)
        {
            bomResetButton.PerformClick();
        }

        private void CtrlEditBom_Resize(object sender, EventArgs e)
        {
        }

        private void gridPanel_Resize(object sender, EventArgs e)
        {
            bomFindButton.Left = gridPanel.Width - 68;
            bomResetButton.Left = gridPanel.Width - 68;
            bomNameEdit.Width = gridPanel.Width - 56;
            bomGrid.Size = new Size(gridPanel.Width, gridPanel.Height - 110);
        }

        private void bomFindButton_Click(object sender, EventArgs e)
        {
            BomDataSet set = bomSet;
            bookmark.Get();

            AppHelper.ResetGridDataSource(bomGrid);

            if (bomDateCheck.Checked == true)
            {
                set.From = bomFromDateEdit.Value.ToString(AppRes.csDateFormat);
                set.To = bomToDateEdit.Value.ToString(AppRes.csDateFormat);
            }
            else 
            {
                set.From = "";
                set.To = "";
            }
            set.AreaNo = (EReportArea)bomAreaCombo.SelectedValue;
            set.FName = bomNameEdit.Text.Trim();
            set.Select();

            AppHelper.SetGridDataSource(bomGrid, set);

            bookmark.Goto();
            bomGrid.Focus();
        }

        private void bomResetButton_Click(object sender, EventArgs e)
        {
            bomDateCheck.Checked = true;
            bomFromDateEdit.Value = DateTime.Now.AddDays(-30);
            bomToDateEdit.Value = DateTime.Now;
            bomAreaCombo.SelectedIndex = 0;
            bomNameEdit.Text = string.Empty;
            bomFindButton.PerformClick();

            bomRegTimeColumn.SortOrder = ColumnSortOrder.Descending;
            AppHelper.ResetGridSortOrder(productGridView);
            AppHelper.ResetGridSortOrder(partGridView);
        }

        private void bomGridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            AppHelper.ResetGridDataSource(productGrid);

            if (e.FocusedRowHandle < 0) return;

            DataRow row = bomGridView.GetDataRow(e.FocusedRowHandle);
            bomSet.Fetch(row);

            productSet.BomNo = bomSet.RecNo; 
            productSet.Select();

            AppHelper.SetGridDataSource(productGrid, productSet);
        }

        private void productGridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            AppHelper.ResetGridDataSource(partGrid);

            if (e.FocusedRowHandle < 0) return;

            DataRow row = productGridView.GetDataRow(e.FocusedRowHandle);
            productSet.Fetch(row);

            partSet.ProductNo = productSet.RecNo;
            partSet.Select();

            AppHelper.SetGridDataSource(partGrid, partSet);
        }

        private void productGrid_DoubleClick(object sender, EventArgs e)
        {
            if (productGridView.DataRowCount == 0) return;

            DialogProductView view = new DialogProductView();
            view.ItemNo = productSet.Code;
            view.Product = productSet.Name;
            view.ImageBox = productSet.Image;
            view.ShowDialog();
        }

        private void bomFromDateEdit_ValueChanged(object sender, EventArgs e)
        {
            if (bomFromDateEdit.Value > bomToDateEdit.Value)
            {
                bomToDateEdit.Value = bomFromDateEdit.Value;
            }

        }

        private void bomToDateEdit_ValueChanged(object sender, EventArgs e)
        {
            if (bomToDateEdit.Value < bomFromDateEdit.Value)
            {
                bomFromDateEdit.Value = bomToDateEdit.Value;
            }
        }

        private void bomTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bomTab.SelectedIndex == 0) return;

            string newFName = Path.Combine(bomSet.FPath, bomSet.FName);
            string curFName = bomExcelSheet.Options.Save.CurrentFileName;

            if (curFName != newFName)
            {
                Cursor.Current = Cursors.WaitCursor;

                try
                {
                    bomExcelSheet.LoadDocument(newFName);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        public void LoadBom(EReportArea area, string fName)
        {
            bomSet.AreaNo = area;
            bomSet.FName = Path.GetFileName(fName);
            bomSet.Select();

            // if BOM already exist in DB?
            if (bomSet.Empty == false)
            {
                MessageBox.Show("Can't add BOM because that already exist in DB!",
                    "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                bomFindButton.PerformClick();
                return;
            }

            if (bomExcelSheet.LoadDocument(fName) == true)
            {
                bomRec.Clear();
                bomRec.RegTime = DateTime.Now;
                bomRec.AreaNo = area;
                bomRec.FName = Path.GetFileName(fName);
                bomRec.FPath = Path.GetDirectoryName(fName);

                if (ExtractProduct(bomExcelSheet.Document.Worksheets[0]) == true)
                {
                    try
                    {
                        InsertBom();
                    }
                    finally
                    {
                        bomFindButton.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("Can't load BOM file because of its invalid format!",
                        "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ExtractProduct(Worksheet sheet)
        {
            SearchOptions options = new SearchOptions();
            options.MatchEntireCellContents = true;
            options.SearchIn = SearchIn.Values;

            // Find Cells in spreadsheet by 'Item Number' 
            IEnumerable<Cell> productCells = sheet.Search("Item Number", options);
            if (productCells == null) return false;

            // Find Cells in spreadsheet by 'PartName' 
            IEnumerable<Cell> partCells = sheet.Search("PartName", options);
            if (partCells == null) return false;

            int i = 0;
            foreach (Cell c1 in productCells)
            {
                ProductColumns productRec = new ProductColumns();
                // Read Item Number
                productRec.Code = sheet.Cells[c1.RowIndex, c1.ColumnIndex + 1].Value.ToString().Trim();
                // Read Product Description
                productRec.Name = sheet.Cells[c1.RowIndex + 1, c1.ColumnIndex + 1].Value.ToString().Trim();
                // Read Product Picture
                productRec.Image = new Bitmap(sheet.Pictures[i].Image.NativeImage,
                    new Size(300, (int)(sheet.Pictures[i].Image.NativeImage.Height * (300.0 / sheet.Pictures[i].Image.NativeImage.Width))));

                int j = 1;
                Cell c2 = partCells.ElementAt<Cell>(i);

                while (j > 0)
                {
                    PartColumns partRec = new PartColumns();
                    // Read PartName
                    partRec.Name = sheet.Cells[c2.RowIndex + j, c2.ColumnIndex].Value.ToString().Trim();
                    // Read Materials
                    partRec.MaterialNo = sheet.Cells[c2.RowIndex + j, c2.ColumnIndex + 1].Value.ToString().Trim();
                    // Read Materiral Name
                    partRec.MaterialName = sheet.Cells[c2.RowIndex + j, c2.ColumnIndex + 2].Value.ToString().Trim();

                    if (string.IsNullOrWhiteSpace(partRec.Name) == false)
                    {
                        productRec.Add(partRec);
                        j++;
                    }
                    else
                    {
                        j = 0;
                    }
                }

                bomRec.Add(productRec);
                i++;
            }

            return true;
        }

        private void InsertBom()
        {
            SqlTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                bomSet.RegTime = bomRec.RegTime;
                bomSet.AreaNo = bomRec.AreaNo;
                bomSet.FName = bomRec.FName;
                bomSet.FPath = bomRec.FPath;
                bomSet.Insert(trans);

                foreach (ProductColumns productRec in bomRec.Products)
                {
                    productSet.BomNo = bomSet.RecNo;
                    productSet.Code = productRec.Code;
                    productSet.Name = productRec.Name;
                    productSet.Image = productRec.Image;
                    productSet.Insert(trans);

                    foreach (PartColumns partRec in productRec.Parts)
                    {
                        partSet.ProductNo = productSet.RecNo;
                        partSet.Name = partRec.Name;
                        partSet.MaterialNo = partRec.MaterialNo;
                        partSet.MaterialName = partRec.MaterialName;
                        partSet.Insert(trans);
                    }
                }

                AppRes.DB.CommitTrans();
            }
            catch (Exception e)
            {
                AppRes.DbLog[ELogTag.Exception] = e.ToString();
                AppRes.DB.RollbackTrans();
            }
        }
    }
}
