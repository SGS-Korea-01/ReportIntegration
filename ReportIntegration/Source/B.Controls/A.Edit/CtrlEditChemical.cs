using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraReports.UI;

using Ulee.Controls;
using Ulee.Utils;

namespace Sgs.ReportIntegration
{
    public partial class CtrlEditChemical : UlUserControlEng
    {
        private CtrlEditRight parent;

        private GridBookmark bookmark;

        private ChemicalMainDataSet cheCheckSet;

        private ChemicalMainDataSet cheMainSet;

        private ChemicalItemJoinDataSet cheJoinSet;

        private ChemicalImageDataSet cheImageSet;

        private ChemicalP2DataSet cheP2Set;

        private ChemicalReportDataSet cheReportSet;

        private ProfJobDataSet profJobSet;

        private ProfJobSchemeDataSet profJobSchemeSet;

        private StaffDataSet staffSet;

        private CtrlEditChemicalUs ctrlUs;

        private CtrlEditChemicalEu ctrlEu;

        public CtrlEditChemical(CtrlEditRight parent)
        {
            this.parent = parent;

            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            cheCheckSet = new ChemicalMainDataSet(AppRes.DB.Connect, null, null);
            cheMainSet = new ChemicalMainDataSet(AppRes.DB.Connect, null, null);
            cheJoinSet = new ChemicalItemJoinDataSet(AppRes.DB.Connect, null, null);
            cheImageSet = new ChemicalImageDataSet(AppRes.DB.Connect, null, null);
            cheP2Set = new ChemicalP2DataSet(AppRes.DB.Connect, null, null);
            cheReportSet = new ChemicalReportDataSet(AppRes.DB.Connect, null, null);
            profJobSet = new ProfJobDataSet(AppRes.DB.Connect, null, null);
            profJobSchemeSet = new ProfJobSchemeDataSet(AppRes.DB.Connect, null, null);
            staffSet = new StaffDataSet(AppRes.DB.Connect, null, null);

            bookmark = new GridBookmark(chemicalGridView);
            AppHelper.SetGridEvenRow(chemicalGridView);

            chemicalAreaColumn.DisplayFormat.FormatType = FormatType.Custom;
            chemicalAreaColumn.DisplayFormat.Format = new ReportAreaFormat();

            approvalCombo.DataSource = EnumHelper.GetNameValues<EReportApproval>();
            approvalCombo.DisplayMember = "Name";
            approvalCombo.ValueMember = "Value";

            areaCombo.DataSource = EnumHelper.GetNameValues<EReportArea>();
            areaCombo.DisplayMember = "Name";
            areaCombo.ValueMember = "Value";

            ctrlUs = new CtrlEditChemicalUs();
            ctrlUs.MainSet = cheMainSet;
            ctrlUs.P2Set = cheP2Set;
            ctrlUs.ImageSet = cheImageSet;
            ctrlUs.P2Set = cheP2Set;

            ctrlEu = new CtrlEditChemicalEu();
            ctrlEu.MainSet = cheMainSet;
            ctrlEu.ImageSet = cheImageSet;
            ctrlEu.P2Set = cheP2Set;

            SetControl(null);
        }

        private void CtrlEditChemical_Load(object sender, EventArgs e)
        {
        }

        private void CtrlEditChemical_Enter(object sender, EventArgs e)
        {
            parent.SetMenu(2);
            resetButton.PerformClick();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            ChemicalMainDataSet set = cheMainSet;
            bookmark.Get();

            AppHelper.ResetGridDataSource(chemicalGrid);

            if (dateCheck.Checked == true)
            {
                set.From = fromDateEdit.Value.ToString(AppRes.csDateFormat);
                set.To = toDateEdit.Value.ToString(AppRes.csDateFormat);
            }
            else
            {
                set.From = "";
                set.To = "";
            }

            set.RecNo = "";
            set.AreaNo = (EReportArea)areaCombo.SelectedValue;
            set.ReportApproval = (EReportApproval)approvalCombo.SelectedValue;
            set.MaterialNo = itemNoEdit.Text.Trim();
            set.Select();

            AppHelper.SetGridDataSource(chemicalGrid, set);

            bookmark.Goto();
            chemicalGrid.Focus();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            dateCheck.Checked = true;
            fromDateEdit.Value = DateTime.Now.AddDays(-30);
            toDateEdit.Value = DateTime.Now;
            approvalCombo.SelectedIndex = 0;
            areaCombo.SelectedIndex = 0;
            itemNoEdit.Text = string.Empty;
            findButton.PerformClick();

            chemicalRegTimeColumn.SortOrder = ColumnSortOrder.Descending;
        }

        private void chemicalGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0)
            {
                SetReportView(EReportArea.None);
                return;
            }

            DataRow row = chemicalGridView.GetDataRow(e.FocusedRowHandle);
            cheMainSet.Fetch(row);

            SetReportView(cheMainSet.AreaNo);
        }

        private void gridPanel_Resize(object sender, EventArgs e)
        {
            findButton.Left = gridPanel.Width - 86;
            resetButton.Left = gridPanel.Width - 86;
            chemicalGrid.Size = new Size(gridPanel.Width, gridPanel.Height - 142);
        }

        private void reportPanel_Resize(object sender, EventArgs e)
        {
            reportPagePanel.Size = new Size(reportPanel.Width, reportPanel.Height - 30);
        }

        private void fromDateEdit_ValueChanged(object sender, EventArgs e)
        {
            if (fromDateEdit.Value > toDateEdit.Value)
            {
                toDateEdit.Value = fromDateEdit.Value;
            }
        }

        private void toDateEdit_ValueChanged(object sender, EventArgs e)
        {
            if (toDateEdit.Value < fromDateEdit.Value)
            {
                fromDateEdit.Value = toDateEdit.Value;
            }
        }

        private void SetReportView(EReportArea area)
        {
            switch (area)
            {
                case EReportArea.None:
                    ClearReport();
                    break;

                case EReportArea.US:
                    SetReportUs();
                    break;

                case EReportArea.EU:
                    SetReportEu();
                    break;
            }
        }

        private void ClearReport()
        {
            areaPanel.Text = EReportArea.None.ToDescription();
            reportNoEdit.Text = "";
            issuedDateEdit.Text = "";
            SetControl(null);
        }

        private void SetReportUs()
        {
            areaPanel.Text = EReportArea.US.ToDescription();
            reportNoEdit.Text = $"F690101/LF-CTS{cheMainSet.P1FileNo}";
            issuedDateEdit.Text = $"{cheMainSet.ReportedTime.ToString("yyyy. MM. dd")}";

            SetControl(ctrlUs);
            ctrlUs.SetDataSetToControl();
        }

        private void SetReportEu()
        {
            areaPanel.Text = EReportArea.EU.ToDescription();
            reportNoEdit.Text = $"F690101/LF-CTS{cheMainSet.P1FileNo}";
            issuedDateEdit.Text = $"{cheMainSet.ReportedTime.ToString("yyyy. MM. dd")}";

            SetControl(ctrlEu);
            ctrlEu.SetDataSetToControl();
        }

        private void SetControl(UlUserControlEng ctrl)
        {
            reportPagePanel.Controls.Clear();

            if (ctrl == null)
            {
                reportPagePanel.BevelOuter = EUlBevelStyle.Single;
            }
            else
            {
                reportPagePanel.Controls.Add(ctrl);
                reportPagePanel.BevelInner = EUlBevelStyle.None;
                reportPagePanel.BevelOuter = EUlBevelStyle.None;
                ctrl.Dock = DockStyle.Fill;
            }
        }

        public void Import()
        {
            DialogProfJobListView dialog = new DialogProfJobListView();

            try
            {
                dialog.Type = EReportType.Chemical;
                dialog.ShowDialog();
            }
            finally
            {
                if (dialog.DialogResult == DialogResult.OK)
                {
                    profJobSet.Type = EReportType.Chemical;
                    profJobSet.JobNo = dialog.JobNo;
                    profJobSet.Select();
                    profJobSet.Fetch();
                    Insert();
                }
            }
        }

        public void Delete()
        {
            if (chemicalGridView.FocusedRowHandle < 0) return;
            if (MessageBox.Show($"Would you like to delete chemical report of {cheMainSet.MaterialNo}?",
                "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            string mainNo = cheMainSet.RecNo;
            SqlTransaction trans = AppRes.DB.BeginTrans();

            try
            {

                cheImageSet.RecNo = mainNo;
                cheImageSet.Delete(trans);

                cheJoinSet.RecNo = mainNo;
                cheJoinSet.Delete(trans);

                cheP2Set.MainNo = mainNo;
                cheP2Set.Delete(trans);

                cheMainSet.Delete(trans);

                AppRes.DB.CommitTrans();
            }
            catch
            {
                AppRes.DB.RollbackTrans();
            }

            findButton.PerformClick();
        }

        public void Print()
        {
            if (chemicalGridView.FocusedRowHandle < 0) return;

            cheReportSet.RecNo = cheMainSet.RecNo;
            cheReportSet.Select();

            cheReportSet.DataSet.Tables[0].TableName = "P1";
            cheReportSet.DataSet.Tables[1].TableName = "P2";
            cheReportSet.DataSet.Tables[2].TableName = "Image";

            BindingSource bind = new BindingSource();
            bind.DataSource = cheReportSet.DataSet;

            XtraReport report;

            if (cheMainSet.AreaNo == EReportArea.US)
                report = new ReportUsChemical();
            else
                report = new ReportEuChemical();

            report.DataSource = bind;
            report.CreateDocument();
            new ReportPrintTool(report);

            DialogReportPreview dialog = new DialogReportPreview();
            dialog.Source = report;
            dialog.ShowDialog();
        }

        public void Save()
        {
            if (chemicalGridView.FocusedRowHandle < 0) return;
            if (MessageBox.Show($"Would you like to save chesical report of {cheMainSet.MaterialNo}?",
                "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            SaveReport();
        }

        public void Cancel()
        {
            if (chemicalGridView.FocusedRowHandle < 0) return;
            if (MessageBox.Show($"Would you like to cancel chesical report of {cheMainSet.MaterialNo}?",
                "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            SetReportView(cheMainSet.AreaNo);
        }

        private void SaveReport()
        {
            EReportArea area = cheMainSet.AreaNo;
            SqlTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                SaveMain(area, trans);
                SavePage2(area, trans);

                AppRes.DB.CommitTrans();
            }
            catch
            {
                AppRes.DB.RollbackTrans();
            }

            findButton.PerformClick();
        }

        private void SaveMain(EReportArea area, SqlTransaction trans)
        {
            if (area == EReportArea.US)
                ctrlUs.SetControlToDataSet();
            else
                ctrlEu.SetControlToDataSet();

            cheMainSet.Update(trans);
        }

        private void SavePage2(EReportArea area, SqlTransaction trans)
        {
            List<ChemicalPage2Row> rows = (area == EReportArea.US) ? ctrlUs.P2Rows : ctrlEu.P2Rows;

            foreach (ChemicalPage2Row row in rows)
            {
                cheP2Set.RecNo = row.RecNo;
                cheP2Set.FormatValue = row.FormatValue;
                cheP2Set.Update(trans);
            }
        }

        private void Insert()
        {
            EReportArea area = profJobSet.AreaNo;

            if (profJobSet.Empty == true) return;
            if (area == EReportArea.None) return;
            if (string.IsNullOrWhiteSpace(profJobSet.ItemNo) == true) return;

            if (string.IsNullOrWhiteSpace(profJobSet.StaffNo) == false)
            {
                staffSet.RecNo = profJobSet.StaffNo;
                staffSet.Select();
                staffSet.Fetch();
            }
            else
            {
                staffSet.DataSet.Clear();
            }

            cheCheckSet.RecNo = profJobSet.JobNo;
            cheCheckSet.Select();

            if (cheCheckSet.Empty == false)
            {
                MessageBox.Show("Can't import chemical report because this report already exist in DB!",
                    "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                InsertMain(area, trans);
                InsertJoin(trans);
                InsertImage(trans);
                InsertPage2(trans);

                AppRes.DB.CommitTrans();
            }
            catch (Exception e)
            {
                AppRes.DbLog["Note"] = e.ToString();
                AppRes.DB.RollbackTrans();
            }

            findButton.PerformClick();
        }

        private void InsertMain(EReportArea area, SqlTransaction trans)
        {
            cheMainSet.RecNo = profJobSet.JobNo;
            cheMainSet.RegTime = profJobSet.RegTime;
            cheMainSet.ReceivedTime = profJobSet.ReceivedTime;
            cheMainSet.RequiredTime = profJobSet.RequiredTime;
            cheMainSet.ReportedTime = profJobSet.ReportedTime;
            cheMainSet.Approval = false;
            cheMainSet.AreaNo = profJobSet.AreaNo;
            cheMainSet.MaterialNo = profJobSet.ItemNo;
            cheMainSet.P1ClientNo = profJobSet.ClientNo;
            cheMainSet.P1ClientName = profJobSet.ClientName;
            cheMainSet.P1ClientAddress = profJobSet.ClientAddress;
            cheMainSet.P1FileNo = profJobSet.FileNo;
            cheMainSet.P1SampleDescription = profJobSet.SampleRemark;
            cheMainSet.P1ItemNo = profJobSet.ItemNo;
            cheMainSet.P1OrderNo = "-";
            cheMainSet.P1Manufacturer = profJobSet.Manufacturer;
            cheMainSet.P1CountryOfOrigin = profJobSet.CountryOfOrigin;
            cheMainSet.P1CountryOfDestination = "-";
            cheMainSet.P1ReceivedDate = profJobSet.ReceivedTime.ToString("yyyy. MM. dd");
            cheMainSet.P1TestPeriod = $"{profJobSet.ReceivedTime.ToString("yyyy. MM. dd")}  to  {profJobSet.RequiredTime.ToString("yyyy. MM. dd")}";
            cheMainSet.P1TestMethod = "For further details, please refer to following page(s)";
            cheMainSet.P1TestResults = "For further details, please refer to following page(s)";
            cheMainSet.P1Comments = profJobSet.ReportComments;

            if (staffSet.Empty == true)
            {
                cheMainSet.Approval = false;
                cheMainSet.P1Name = "";
            }
            else
            {
                cheMainSet.Approval = true;
                cheMainSet.P1Name = staffSet.Name;
            }

            if (area == EReportArea.US)
            {
                cheMainSet.P1TestRequested =
                    "Selected test(s) as requested by applicant for compliance with Public Law 110-314(Consumer Product Safety Improvement Act of 2008, CPSIA):-\r\n" +
                    "- To determine Heavy Elements in the submitted samples with reference to ASTM F963-16\r\n" +
                    "    4.3.5.2-Heavy Metal in Substrate Materials";
                cheMainSet.P1Conclusion = "\r\n\r\n-\r\nPASS";
                cheMainSet.P2Description1 = "ASTM F963-16, Clause 4.3.5.2 - Heavy Elements in Toys Substrate Materials";
                cheMainSet.P2Description2 = "Method: With reference to ASTM F963-16 Clause 8.3. Analysis was performed by ICP-OES.";
                cheMainSet.P2Description3 =
                    "1. Black textile\r\n\r\n" +
                    "Note:    -   Soluble results shown are of the adjusted analytical result.\r\n" +
                    "         -   ND = Not Detected(<MDL)";
                cheMainSet.P3Description1 = "";
            }
            else
            {
                cheMainSet.P1TestRequested =
                    "EN71-3:2013+A3:2018-Migration of certain elements\r\n" +
                    "(By first action method testing only)";
                cheMainSet.P1Conclusion = "PASS";
                cheMainSet.P2Description1 = "EN71-3:2013+A3:2018 - Migration of certain elements";
                cheMainSet.P2Description2 = "Method : With reference to EN71-3:2013+A3:2018. Analysis of general elements was performed by ICP-OES.";
                cheMainSet.P2Description3 = profJobSet.SampleDescription;
                cheMainSet.P3Description1 = 
                    "Note. 1. mg/kg = milligram per kilogram\r\n" +
                    "      2. ND = Not Detected(< MDL)\r\n" +
                    "      3. 1% = 10000 mg/kg = 10000 ppm\r\n" +
                    "      4. Soluble Chromium(III) = Soluble Total Chromium – Soluble Chromium(VI)\r\n" +
                    "      5. ^ = Confirmation test of soluble organic tin is not required in case of soluble tin, after conversion, does not exceed the soluble organic tin requirement as specified in EN71-3:2019.";
            }

            cheMainSet.Insert(trans);
        }

        private void InsertJoin(SqlTransaction trans)
        {
            string[] items = cheMainSet.P1ItemNo.Split(',');

            cheJoinSet.RecNo = cheMainSet.RecNo;
            foreach (string item in items)
            {
                cheJoinSet.PartNo = item.Trim();
                cheJoinSet.Insert(trans);
            }
        }

        private void InsertImage(SqlTransaction trans)
        {
            Bitmap signImage = null;

            if (staffSet.Empty == false)
            {
                if (string.IsNullOrWhiteSpace(staffSet.FName) == false)
                {
                    signImage = new Bitmap(staffSet.FName);
                }
            }

            cheImageSet.RecNo = cheMainSet.RecNo;
            cheImageSet.Signature = signImage;
            cheImageSet.Picture = profJobSet.Image;
            cheImageSet.Insert(trans);
        }

        private void InsertPage2(SqlTransaction trans)
        {
            profJobSchemeSet.JobNo = cheMainSet.RecNo;
            profJobSchemeSet.Select(trans);
            profJobSchemeSet.Fetch();

            cheP2Set.MainNo = cheMainSet.RecNo;

            for (int i=0; i<profJobSchemeSet.RowCount; i++)
            {
                profJobSchemeSet.Fetch(i);

                cheP2Set.Name = profJobSchemeSet.Name;
                cheP2Set.LoValue = profJobSchemeSet.LoValue;
                cheP2Set.HiValue = profJobSchemeSet.HiValue;
                cheP2Set.ReportValue = profJobSchemeSet.ReportValue;
                cheP2Set.FormatValue = profJobSchemeSet.FormatValue;
                cheP2Set.Insert(trans);
            }
        }
    }
}
