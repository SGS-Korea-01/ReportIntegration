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

        public EReportType Type 
        { 
            get { return profJobSet.Type; } 
            set { profJobSet.Type = value; }
        }

        public EReportArea AreaNo { get; private set; }

        public string JobNo { get; private set; }

        public string ItemNo { get; private set; }

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

            reportAreaColumn.DisplayFormat.FormatType = FormatType.Custom;
            reportAreaColumn.DisplayFormat.Format = new ReportAreaFormat();

            areaCombo.DataSource = EnumHelper.GetNameValues<EReportArea>();
            areaCombo.DisplayMember = "Name";
            areaCombo.ValueMember = "Value";

            Type = EReportType.None;
            JobNo = string.Empty;
            ItemNo = string.Empty;
        }

        private void DialogProfJobListView_Load(object sender, EventArgs e)
        {
            resetButton.PerformClick();
            reportGridView.Focus();
        }

        private void DialogProfJobListView_Shown(object sender, EventArgs e)
        {
            switch (Type)
            {
                case EReportType.Physical:
                    itemNoLabel.Text = "Item No.";
                    reportItemNoColumn.Caption = "Item No.";
                    reportItemNoColumn.FieldName = "orderno";
                    reportProductColumn.Caption = "Product Name";
                    break;

                case EReportType.Chemical:
                    //areaCombo.SelectedIndex = 0;
                    //areaCombo.Enabled = false;
                    itemNoLabel.Text = "Part No.";
                    reportItemNoColumn.Caption = "Part No.";
                    reportItemNoColumn.FieldName = "jobcomments";
                    reportProductColumn.Caption = "Part Name";
                    break;
            }
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

            set.JobNo = "";
            set.AreaNo = (EReportArea)areaCombo.SelectedValue;
            set.ItemNo = itemNoEdit.Text.Trim();
            set.JobNo = string.Empty;
            set.ExtendASTM = false;
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

            AreaNo = profJobSet.AreaNo;
            JobNo = profJobSet.JobNo;
            ItemNo = profJobSet.ItemNo;
            
            Close();
        }
    }
}
