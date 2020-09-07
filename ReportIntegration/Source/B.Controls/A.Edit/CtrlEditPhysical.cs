using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;

using Ulee.Controls;
using Ulee.Utils;

namespace Sgs.ReportIntegration
{
    public partial class CtrlEditPhysical : UlUserControlEng
    {
        private CtrlEditRight parent;

        private GridBookmark bookmark;

        private PhysicalMainDataSet physicalMainSet;

        private ProfJobDataSet profJobSet;

        private CtrlEditPhysicalUs ctrlUs;

        private CtrlEditPhysicalEu ctrlEu;

        public CtrlEditPhysical(CtrlEditRight parent)
        {
            this.parent = parent;

            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            physicalMainSet = new PhysicalMainDataSet(AppRes.DB.Connect, null, null);
            profJobSet = new ProfJobDataSet(AppRes.DB.Connect, null, null);

            bookmark = new GridBookmark(physicalGridView);

            AppHelper.SetGridEvenRow(physicalGridView);

            physicalAreaColumn.DisplayFormat.FormatType = FormatType.Custom;
            physicalAreaColumn.DisplayFormat.Format = new ReportAreaFormat();

            areaCombo.DataSource = EnumHelper.GetNameValues<EReportArea>();
            areaCombo.DisplayMember = "Name";
            areaCombo.ValueMember = "Value";

            ctrlUs = new CtrlEditPhysicalUs(physicalMainSet);
            ctrlEu = new CtrlEditPhysicalEu(physicalMainSet);

            SetControl(null);
        }

        private void CtrlEditPhysical_Load(object sender, EventArgs e)
        {
            resetButton.PerformClick();
        }

        private void CtrlEditPhysical_Enter(object sender, EventArgs e)
        {
            parent.SetMenu(0);
        }

        private void CtrlEditPhysical_Resize(object sender, EventArgs e)
        {
        }

        private void gridPanel_Resize(object sender, EventArgs e)
        {
            findButton.Left = gridPanel.Width - 86;
            resetButton.Left = gridPanel.Width - 86;
            itemNoEdit.Width = gridPanel.Width - 174;
            physicalGrid.Size = new Size(gridPanel.Width, gridPanel.Height - 84);
        }

        private void reportPanel_Resize(object sender, EventArgs e)
        {
            reportPagePanel.Size = new Size(reportPanel.Width, reportPanel.Height - 30);
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            PhysicalMainDataSet set = physicalMainSet;
            bookmark.Get();

            AppHelper.ResetGridDataSource(physicalGrid);

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
            set.AreaNo = (EReportArea)areaCombo.SelectedValue;
            set.ProductNo = itemNoEdit.Text.Trim();
            set.Select();

            AppHelper.SetGridDataSource(physicalGrid, set);

            bookmark.Goto();
            physicalGrid.Focus();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            dateCheck.Checked = true;
            fromDateEdit.Value = DateTime.Now.AddDays(-30);
            toDateEdit.Value = DateTime.Now;
            areaCombo.SelectedIndex = 0;
            itemNoEdit.Text = string.Empty;
            findButton.PerformClick();

            physicalRegTimeColumn.SortOrder = ColumnSortOrder.Descending;
        }

        private void physicalGridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0)
            {
                SetReportView(EReportArea.None);
                return;
            }

            DataRow row = physicalGridView.GetDataRow(e.FocusedRowHandle);
            physicalMainSet.Fetch(row);

            SetReportView(physicalMainSet.AreaNo);
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
            reportNoEdit.Text = $"F690101/LF-CTS{physicalMainSet.FileNo}";
            issuedDateEdit.Text = $"{physicalMainSet.ReportedTime.ToString("yyyy. MM. dd")}";
            SetControl(ctrlUs);
            ctrlUs.Clear();
        }

        private void SetReportEu()
        {
            areaPanel.Text = EReportArea.EU.ToDescription();
            reportNoEdit.Text = $"F690101/LF-CTS{physicalMainSet.FileNo}";
            issuedDateEdit.Text = $"{physicalMainSet.ReportedTime.ToString("yyyy. MM. dd")}";
            SetControl(ctrlEu);
        }

        private void SetControl(UlUserControlEng ctrl)
        {
            if (ctrl == null)
            {
                reportPagePanel.Controls.Clear();
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
                dialog.ShowDialog();
            }
            finally
            {
                if (dialog.DialogResult == DialogResult.OK)
                {
                    profJobSet.JobNo = dialog.JobNo;
                    profJobSet.Select();
                    profJobSet.Fetch();

                    Insert(profJobSet, physicalMainSet);
                }
            }
        }

        private void Insert(ProfJobDataSet srcSet, PhysicalMainDataSet desSet)
        {
            if (srcSet.Empty == true) return;
            if (srcSet.AreaNo == EReportArea.None) return;
            if (string.IsNullOrWhiteSpace(srcSet.ProductNo) == true) return;

            desSet.From = "";
            desSet.To = "";
            desSet.AreaNo = srcSet.AreaNo;
            desSet.ProductNo = srcSet.ProductNo;
            desSet.Select();

            if (desSet.Empty == false)
            {
                MessageBox.Show("Can't import physical report because this report already exist in DB!",
                    "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            desSet.RegTime = srcSet.RegTime;
            desSet.ReceivedTime = srcSet.ReceivedTime;
            desSet.RequiredTime = srcSet.RequiredTime;
            desSet.ReportedTime = srcSet.ReportedTime;
            desSet.AreaNo = srcSet.AreaNo;
            desSet.ProductNo = srcSet.ProductNo;
            desSet.ClientNo = srcSet.ClientNo;
            desSet.ClientName = srcSet.ClientName;
            desSet.ClientAddress = srcSet.ClientAddress;
            desSet.JobNo = srcSet.JobNo;
            desSet.FileNo = srcSet.FileNo;
            desSet.ItemNo = srcSet.ItemNo;
            desSet.ReportComments = srcSet.ReportComments;
            desSet.SampleDescription = srcSet.SampleDescription;
            desSet.DetailOfSample = srcSet.DetailOfSample;
            desSet.Manufacturer = srcSet.Manufacturer;
            desSet.CountryOfOrigin = srcSet.CountryOfOrigin;
            desSet.Image = srcSet.Image;
            desSet.Insert();

            findButton.PerformClick();
        }
    }
}
