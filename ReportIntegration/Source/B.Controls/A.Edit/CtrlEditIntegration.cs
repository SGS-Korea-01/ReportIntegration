using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.Data;
using DevExpress.Utils;

using Ulee.Controls;
using Ulee.Utils;

namespace Sgs.ReportIntegration
{
    public partial class CtrlEditIntegration : UlUserControlEng
    {
        private CtrlEditRight parent;

        private GridBookmark bookmark;

        private ProductDataSet productSet;

        private CtrlEditIntegrationUs ctrlUs;

        private CtrlEditIntegrationEu ctrlEu;

        public CtrlEditIntegration(CtrlEditRight parent)
        {
            this.parent = parent;

            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            productSet = new ProductDataSet(AppRes.DB.Connect, null, null);

            ctrlUs = new CtrlEditIntegrationUs();

            ctrlEu = new CtrlEditIntegrationEu();

            bookmark = new GridBookmark(integrationGridView);
            AppHelper.SetGridEvenRow(integrationGridView);

            integAreaColumn.DisplayFormat.FormatType = FormatType.Custom;
            integAreaColumn.DisplayFormat.Format = new ReportAreaFormat();

            integRegTimeColumn.DisplayFormat.FormatType = FormatType.Custom;
            integRegTimeColumn.DisplayFormat.Format = new ReportDateTimeFormat();

            areaCombo.DataSource = EnumHelper.GetNameValues<EReportArea>();
            areaCombo.DisplayMember = "Name";
            areaCombo.ValueMember = "Value";

            SetControl(null);
        }

        private void CtrlEditIntegration_Load(object sender, EventArgs e)
        {
        }

        private void CtrlEditIntegration_Enter(object sender, EventArgs e)
        {
            parent.SetMenu(3);
            resetButton.PerformClick();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            ProductDataSet set = productSet;
            bookmark.Get();

            AppHelper.ResetGridDataSource(integrationGrid);

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
            set.Code = itemNoEdit.Text.Trim();
            set.JobNo = jobNoEdit.Text.Trim();
            set.SelectByValid();

            AppHelper.SetGridDataSource(integrationGrid, set);

            bookmark.Goto();
            integrationGrid.Focus();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            dateCheck.Checked = true;
            fromDateEdit.Value = DateTime.Now.AddMonths(-1);
            toDateEdit.Value = DateTime.Now;
            areaCombo.SelectedIndex = 0;
            itemNoEdit.Text = string.Empty;
            jobNoEdit.Text = string.Empty;
            findButton.PerformClick();

            integRegTimeColumn.SortOrder = ColumnSortOrder.Descending;
        }

        private void integrationGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0)
            {
                SetReportView(EReportArea.None);
                return;
            }

            DataRow row = integrationGridView.GetDataRow(e.FocusedRowHandle);
            productSet.Fetch(row);

            SetReportView(productSet.AreaNo);
        }

        private void gridPanel_Resize(object sender, EventArgs e)
        {
            int width = gridPanel.Width;

            findButton.Left = width - 86;
            resetButton.Left = width - 86;

            itemNoEdit.Width = width - 174;
            jobNoEdit.Width = width - 60;

            integrationGrid.Size = new Size(width, gridPanel.Height - 113);
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
            //reportNoEdit.Text = $"F690101/LF-CTS{phyMainSet.P1FileNo}";
            //issuedDateEdit.Text = $"{phyMainSet.ReportedTime.ToString("yyyy. MM. dd")}";

            SetControl(ctrlUs);
            //ctrlUs.SetDataSetToControl();
        }

        private void SetReportEu()
        {
            areaPanel.Text = EReportArea.EU.ToDescription();
            //reportNoEdit.Text = $"F690101/LF-CTS{phyMainSet.P1FileNo}";
            //issuedDateEdit.Text = $"{phyMainSet.ReportedTime.ToString("yyyy. MM. dd")}";

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
    }
}
