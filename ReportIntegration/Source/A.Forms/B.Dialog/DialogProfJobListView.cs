using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

using Ulee.Utils;
using Ulee.Controls;

namespace Sgs.ReportIntegration
{ 
    public partial class DialogProfJobListView : UlFormEng
    {
        private GridBookmark bookmark;

        private ProfJobDataSet profJobSet;

        public string JobNo { get; private set; }

        public DialogProfJobListView()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            profJobSet = new ProfJobDataSet(AppRes.DB.Connect, null, null);
            bookmark = new GridBookmark(reportGridView);
            AppHelper.SetGridEvenRow(reportGridView);

            areaCombo.DataSource = EnumHelper.GetNameValues<EReportArea>();
            areaCombo.DisplayMember = "Name";
            areaCombo.ValueMember = "Value";

            JobNo = string.Empty;
        }

        private void DialogProfJobListView_Load(object sender, EventArgs e)
        {
            resetButton.PerformClick();
            reportGridView.Focus();
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

        private void reportGridView_DoubleClick(object sender, EventArgs e)
        {
            GridHitInfo info =
                (sender as GridView).CalcHitInfo((e as DXMouseEventArgs).Location);

            if (info.InDataRow == true)
            {
                okButton.PerformClick();
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            ProfJobDataSet set = profJobSet;

            bookmark.Get();
            AppHelper.ResetGridDataSource(reportGrid);

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
            set.JobNo = string.Empty;
            set.Select();

            AppHelper.SetGridDataSource(reportGrid, set);

            bookmark.Goto();
            reportGrid.Focus();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            dateCheck.Checked = true;
            fromDateEdit.Value = DateTime.Now.AddMonths(-1);
            toDateEdit.Value = DateTime.Now;
            areaCombo.SelectedIndex = 0;
            itemNoEdit.Text = string.Empty;
            findButton.PerformClick();

            reportRegTimeColumn.SortOrder = ColumnSortOrder.Descending;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (reportGridView.FocusedRowHandle < 0) return;

            DataRow row = reportGridView.GetDataRow(reportGridView.FocusedRowHandle);
            profJobSet.Fetch(row);
            JobNo = profJobSet.JobNo;
            Close();
        }
    }
}
