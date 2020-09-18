using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.Data;
using DevExpress.Utils;

using Ulee.Controls;
using Ulee.Utils;

namespace Sgs.ReportIntegration
{
    public partial class CtrlEditChemical : UlUserControlEng
    {
        private CtrlEditRight parent;

        private GridBookmark bookmark;

        private ChemicalMainDataSet cheMainSet;

        private ChemicalImageDataSet cheImageSet;

        private ChemicalP2DataSet cheP2Set;

        private CtrlEditChemicalUs ctrlUs;

        private CtrlEditChemicalUs ctrlEu;

        //private ChemicalReportDataSet cheReportSet;

        private ProfJobDataSet profJobSet;

        public CtrlEditChemical(CtrlEditRight parent)
        {
            this.parent = parent;

            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            cheMainSet = new ChemicalMainDataSet(AppRes.DB.Connect, null, null);
            cheImageSet = new ChemicalImageDataSet(AppRes.DB.Connect, null, null);
            cheP2Set = new ChemicalP2DataSet(AppRes.DB.Connect, null, null);
            //cheReportSet = new ChemicalReportDataSet(AppRes.DB.Connect, null, null);
            profJobSet = new ProfJobDataSet(AppRes.DB.Connect, null, null);

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
            ctrlUs.ImageSet = cheImageSet;
            ctrlUs.P2Set = cheP2Set;

            ctrlEu = new CtrlEditChemicalUs();
            ctrlEu.MainSet = cheMainSet;
            ctrlEu.ImageSet = cheImageSet;
            ctrlEu.P2Set = cheP2Set;

            SetControl(ctrlUs);
        }

        private void CtrlEditChemical_Enter(object sender, EventArgs e)
        {
            parent.SetMenu(2);
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
            set.AreaNo = EReportArea.None;
            set.ProductNo = itemNoEdit.Text.Trim();
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
            //ctrlUs.SetDataSetToControl();
        }

        private void SetReportEu()
        {
            areaPanel.Text = EReportArea.EU.ToDescription();
            reportNoEdit.Text = $"F690101/LF-CTS{cheMainSet.P1FileNo}";
            issuedDateEdit.Text = $"{cheMainSet.ReportedTime.ToString("yyyy. MM. dd")}";

            SetControl(ctrlEu);
            //ctrlEu.SetDataSetToControl();
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
                    //profJobSet.JobNo = dialog.JobNo;
                    //profJobSet.Select();
                    //profJobSet.Fetch();
                    //Insert();
                }
            }
        }
    }
}
