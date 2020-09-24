using System;
using System.Collections.Generic;
using System.Drawing;

using DevExpress.Data;

using Ulee.Controls;

namespace Sgs.ReportIntegration
{
    public partial class CtrlEditPhysicalUs : UlUserControlEng
    {
        public PhysicalMainDataSet MainSet;

        public PhysicalImageDataSet ImageSet;

        public PhysicalP2DataSet P2Set;

        public PhysicalP3DataSet P3Set;

        public PhysicalP41DataSet P4Set;

        public PhysicalP5DataSet P5Set;

        public List<PhysicalPage2Row> P2Rows;

        public List<PhysicalPage3Row> P3Rows;

        public List<PhysicalPage4Row> P4Rows;

        public List<PhysicalPage5Row> P5Rows;

        private GridBookmark p2Bookmark;

        private GridBookmark p3Bookmark;

        private GridBookmark p4Bookmark;

        private GridBookmark p5Bookmark;

        public CtrlEditPhysicalUs()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            p2Bookmark = new GridBookmark(p2ResultGridView);
            P2Rows = new List<PhysicalPage2Row>();
            p2ResultGrid.DataSource = P2Rows;
            AppHelper.SetGridEvenRow(p2ResultGridView);

            p3Bookmark = new GridBookmark(p3ClauseGridView);
            P3Rows = new List<PhysicalPage3Row>();
            p3ClauseGrid.DataSource = P3Rows;
            AppHelper.SetGridEvenRow(p3ClauseGridView);

            p4Bookmark = new GridBookmark(p4FlameGridView);
            P4Rows = new List<PhysicalPage4Row>();
            p4FlameGrid.DataSource = P4Rows;
            AppHelper.SetGridEvenRow(p4FlameGridView);

            p5Bookmark = new GridBookmark(p5StuffGridView);
            P5Rows = new List<PhysicalPage5Row>();
            p5StuffGrid.DataSource = P5Rows;
            AppHelper.SetGridEvenRow(p5StuffGridView);
        }

        private void CtrlEditPhysicalUs_Load(object sender, EventArgs e)
        {
        }

        private void CtrlEditPhysicalUs_Enter(object sender, EventArgs e)
        {
        }

        private void physicalTab_Resize(object sender, EventArgs e)
        {
        }

        private void physical1Page_Resize(object sender, EventArgs e)
        {
            int width = physical1Page.Width;

            p1ClientNameEdit.Width = width - 172;
            p1ClientAddressEdit.Width = width - 172;
            p1SampleDescriptionEdit.Width = width - 410;
            p1DetailOfSampleEdit.Width = width - 172;
            p1OrderNoEdit.Width = width - 410;
            p1ManufacturerEdit.Width = width - 172;
            p1CountryOfDestinationEdit.Width = width - 410;
            p1LabeledAgeEdit.Width = width - 172;
            p1TestAgeEdit.Width = width - 172;
            p1AssessedAgeEdit.Width = width - 172;
            p1ReceivedDateEdit.Width = width - 172;
            p1TestPeriodEdit.Width = width - 172;
            p1TestMethodEdit.Width = width - 172;
            p1TestResultEdit.Width = width - 172;
            p1ReportCommentEdit.Width = width - 172;
        }

        private void physical2Page_Resize(object sender, EventArgs e)
        {
            int width = physical2Page.Width;
            int height = physical2Page.Height;

            p2ResultGrid.Size = new Size(width - 8, height - 37);
            p2ResultTestRequestedColumn.Width = width - 142;
            p2RowUpButton.Left = width - 106;
            p2RowDownButton.Left = width - 80;
            p2RowPluseButton.Left = width - 54;
            p2RowMinusButton.Left = width - 28;
        }

        private void physical3Page_Resize(object sender, EventArgs e)
        {
            int width = physical3Page.Width;
            int height = physical3Page.Height;

            p3ClauseGrid.Size = new Size(width - 8, height - 201);
            p3ClauseDescriptionColumn.Width = width - 242;

            p3RowUpButton.Left = width - 106;
            p3RowDownButton.Left = width - 80;
            p3RowPluseButton.Left = width - 54;
            p3RowMinusButton.Left = width - 28;

            p3Desc1Edit.Width = width - 8;
            p3Desc2Edit.Top = height - 72;
            p3Desc2Edit.Width = width - 8;
        }

        private void physical4Page_Resize(object sender, EventArgs e)
        {
            int width = physical4Page.Width;
            int height = physical4Page.Height;

            p4FlameGrid.Size = new Size(width - 8, height - 161);
            p4FlameSampleColumn.Width = (width - 62) / 2;
            p4FlameBurningRateColumn.Width = (width - 62) / 2;

            p4RowUpButton.Left = width - 106;
            p4RowDownButton.Left = width - 80;
            p4RowPluseButton.Left = width - 54;
            p4RowMinusButton.Left = width - 28;

            p4Desc1Edit.Width = width - 8;
            p4Desc2Edit.Top = height - 69;
            p4Desc2Edit.Width = width - 8;
        }

        private void physical5Page_Resize(object sender, EventArgs e)
        {
            int width = physical5Page.Width;
            int height = physical5Page.Height;

            p5StuffGrid.Size = new Size(width - 8, height - 143);
            p5StuffTestItemColumn.Width = width - 242;

            p5RowUpButton.Left = width - 106;
            p5RowDownButton.Left = width - 80;
            p5RowPluseButton.Left = width - 54;
            p5RowMinusButton.Left = width - 28;

            p5Desc1Edit.Width = width - 8;
        }

        private void physical6Page_Resize(object sender, EventArgs e)
        {
            imagePanel.Size = new Size(physical6Page.Width - 16, physical6Page.Height - 70);
            p6ImageBox.Size = new Size(imagePanel.Width - 16, imagePanel.Height - 74);
            p6DescPanel.Width = imagePanel.Width - 16;

            p6FileNoPanel.Top = physical6Page.Height - 56;
            p6FileNoPanel.Width = physical6Page.Width - 16;
        }

        private void physicalTab_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void p2RowUpButton_Click(object sender, EventArgs e)
        {
            int index = p2ResultGridView.FocusedRowHandle;

            if (index <= 0) return;

            PhysicalPage2Row row = NewP2Row();
            row.No = P2Rows[index].No;
            row.Line = P2Rows[index].Line;
            row.Requested = P2Rows[index].Requested;
            row.Conclusion = P2Rows[index].Conclusion;

            p2Bookmark.Get();
            P2Rows.RemoveAt(index);
            P2Rows.Insert(index - 1, row);
            ReorderP2Rows();
            AppHelper.RefreshGridData(p2ResultGridView);
            
            p2Bookmark.Goto();
            p2ResultGridView.MoveBy(-1);

            p2ResultGrid.Focus();
        }

        private void p2RowDownButton_Click(object sender, EventArgs e)
        {
            int index = p2ResultGridView.FocusedRowHandle;

            if (index >= P2Rows.Count - 1) return;

            PhysicalPage2Row row = NewP2Row();
            row.No = P2Rows[index].No;
            row.Line = P2Rows[index].Line;
            row.Requested = P2Rows[index].Requested;
            row.Conclusion = P2Rows[index].Conclusion;

            p2Bookmark.Get();
            P2Rows.RemoveAt(index);

            if (index < P2Rows.Count - 1)
            {
                P2Rows.Insert(index + 1, row);
            }
            else
            {
                P2Rows.Add(row);
            }
            
            ReorderP2Rows();
            AppHelper.RefreshGridData(p2ResultGridView);

            p2Bookmark.Goto();
            p2ResultGridView.MoveBy(1);

            p2ResultGrid.Focus();
        }

        private void p2RowPluseButton_Click(object sender, EventArgs e)
        {
            int index = p2ResultGridView.FocusedRowHandle;

            p2Bookmark.Get();

            if ((index < 0) || (index == P2Rows.Count-1))
            {
                P2Rows.Add(NewP2Row());
            }
            else
            {
                P2Rows.Insert(index+1, NewP2Row());
            }

            ReorderP2Rows();
            AppHelper.RefreshGridData(p2ResultGridView);

            p2Bookmark.Goto();
            p2ResultGridView.MoveBy(1);
            
            p2ResultGrid.Focus();
        }

        private void p2RowMinusButton_Click(object sender, EventArgs e)
        {
            int index = p2ResultGridView.FocusedRowHandle;

            if (index < 0) return;

            p2Bookmark.Get();
            P2Rows.RemoveAt(index);

            ReorderP2Rows();
            AppHelper.RefreshGridData(p2ResultGridView);

            p2Bookmark.Goto();

            p2ResultGrid.Focus();
        }

        private void p3RowUpButton_Click(object sender, EventArgs e)
        {
            int index = p3ClauseGridView.FocusedRowHandle;

            if (index <= 0) return;

            PhysicalPage3Row row = NewP3Row();
            row.No = P3Rows[index].No;
            row.Line = P3Rows[index].Line;
            row.Clause = P3Rows[index].Clause;
            row.Description = P3Rows[index].Description;
            row.Result = P3Rows[index].Result;

            p3Bookmark.Get();
            P3Rows.RemoveAt(index);
            P3Rows.Insert(index - 1, row);
            ReorderP3Rows();
            AppHelper.RefreshGridData(p3ClauseGridView);

            p3Bookmark.Goto();
            p3ClauseGridView.MoveBy(-1);

            p3ClauseGridView.Focus();
        }

        private void p3RowDownButton_Click(object sender, EventArgs e)
        {
            int index = p3ClauseGridView.FocusedRowHandle;

            if (index >= P3Rows.Count - 1) return;

            PhysicalPage3Row row = NewP3Row();
            row.No = P3Rows[index].No;
            row.Line = P3Rows[index].Line;
            row.Clause = P3Rows[index].Clause;
            row.Description = P3Rows[index].Description;
            row.Result = P3Rows[index].Result;

            p3Bookmark.Get();
            P3Rows.RemoveAt(index);

            if (index < P3Rows.Count - 1)
            {
                P3Rows.Insert(index + 1, row);
            }
            else
            {
                P3Rows.Add(row);
            }

            ReorderP3Rows();
            AppHelper.RefreshGridData(p3ClauseGridView);

            p3Bookmark.Goto();
            p3ClauseGridView.MoveBy(1);

            p3ClauseGrid.Focus();
        }

        private void p3RowPluseButton_Click(object sender, EventArgs e)
        {
            int index = p3ClauseGridView.FocusedRowHandle;

            p3Bookmark.Get();

            if ((index < 0) || (index == P3Rows.Count - 1))
            {
                P3Rows.Add(NewP3Row());
            }
            else
            {
                P3Rows.Insert(index + 1, NewP3Row());
            }

            ReorderP3Rows();
            AppHelper.RefreshGridData(p3ClauseGridView);

            p3Bookmark.Goto();
            p3ClauseGridView.MoveBy(1);

            p3ClauseGrid.Focus();
        }

        private void p3RowMinusButton_Click(object sender, EventArgs e)
        {
            int index = p3ClauseGridView.FocusedRowHandle;

            if (index < 0) return;

            p3Bookmark.Get();
            P3Rows.RemoveAt(index);

            ReorderP3Rows();
            AppHelper.RefreshGridData(p3ClauseGridView);

            p3Bookmark.Goto();

            p3ClauseGrid.Focus();
        }

        private void p4RowUpButton_Click(object sender, EventArgs e)
        {
            int index = p4FlameGridView.FocusedRowHandle;

            if (index <= 0) return;

            PhysicalPage4Row row = NewP4Row();
            row.No = P4Rows[index].No;
            row.Line = P4Rows[index].Line;
            row.Sample = P4Rows[index].Sample;
            row.BurningRate = P4Rows[index].BurningRate;

            p4Bookmark.Get();
            P4Rows.RemoveAt(index);
            P4Rows.Insert(index - 1, row);
            ReorderP4Rows();
            AppHelper.RefreshGridData(p4FlameGridView);

            p4Bookmark.Goto();
            p4FlameGridView.MoveBy(-1);

            p4FlameGrid.Focus();
        }

        private void p4RowDownButton_Click(object sender, EventArgs e)
        {
            int index = p4FlameGridView.FocusedRowHandle;

            if (index >= P4Rows.Count - 1) return;

            PhysicalPage4Row row = NewP4Row();
            row.No = P4Rows[index].No;
            row.Line = P4Rows[index].Line;
            row.Sample = P4Rows[index].Sample;
            row.BurningRate = P4Rows[index].BurningRate;

            p4Bookmark.Get();
            P4Rows.RemoveAt(index);

            if (index < P4Rows.Count - 1)
            {
                P4Rows.Insert(index + 1, row);
            }
            else
            {
                P4Rows.Add(row);
            }

            ReorderP4Rows();
            AppHelper.RefreshGridData(p4FlameGridView);

            p4Bookmark.Goto();
            p4FlameGridView.MoveBy(1);

            p4FlameGrid.Focus();
        }

        private void p4RowPluseButton_Click(object sender, EventArgs e)
        {
            int index = p4FlameGridView.FocusedRowHandle;

            p4Bookmark.Get();

            if ((index < 0) || (index == P4Rows.Count - 1))
            {
                P4Rows.Add(NewP4Row());
            }
            else
            {
                P4Rows.Insert(index + 1, NewP4Row());
            }

            ReorderP4Rows();
            AppHelper.RefreshGridData(p4FlameGridView);

            p4Bookmark.Goto();
            p4FlameGridView.MoveBy(1);

            p4FlameGrid.Focus();
        }

        private void p4RowMinusButton_Click(object sender, EventArgs e)
        {
            int index = p4FlameGridView.FocusedRowHandle;

            if (index < 0) return;

            p4Bookmark.Get();
            P4Rows.RemoveAt(index);

            ReorderP4Rows();
            AppHelper.RefreshGridData(p4FlameGridView);

            p4Bookmark.Goto();

            p4FlameGrid.Focus();
        }

        private void p5RowUpButton_Click(object sender, EventArgs e)
        {
            int index = p5StuffGridView.FocusedRowHandle;

            if (index <= 0) return;

            PhysicalPage5Row row = NewP5Row();
            row.No = P5Rows[index].No;
            row.Line = P5Rows[index].Line;
            row.TestItem = P5Rows[index].TestItem;
            row.Result = P5Rows[index].Result;
            row.Requirement = P5Rows[index].Requirement;

            p5Bookmark.Get();
            P5Rows.RemoveAt(index);
            P5Rows.Insert(index - 1, row);
            ReorderP5Rows();
            AppHelper.RefreshGridData(p5StuffGridView);

            p5Bookmark.Goto();
            p5StuffGridView.MoveBy(-1);

            p5StuffGrid.Focus();
        }

        private void p5RowDownButton_Click(object sender, EventArgs e)
        {
            int index = p5StuffGridView.FocusedRowHandle;

            if (index >= P5Rows.Count - 1) return;

            PhysicalPage5Row row = NewP5Row();
            row.No = P5Rows[index].No;
            row.Line = P5Rows[index].Line;
            row.TestItem = P5Rows[index].TestItem;
            row.Result = P5Rows[index].Result;
            row.Requirement = P5Rows[index].Requirement;

            p5Bookmark.Get();
            P5Rows.RemoveAt(index);

            if (index < P5Rows.Count - 1)
            {
                P5Rows.Insert(index + 1, row);
            }
            else
            {
                P5Rows.Add(row);
            }

            ReorderP5Rows();
            AppHelper.RefreshGridData(p5StuffGridView);

            p5Bookmark.Goto();
            p5StuffGridView.MoveBy(1);

            p5StuffGrid.Focus();
        }

        private void p5RowPluseButton_Click(object sender, EventArgs e)
        {
            int index = p5StuffGridView.FocusedRowHandle;

            p5Bookmark.Get();

            if ((index < 0) || (index == P5Rows.Count - 1))
            {
                P5Rows.Add(NewP5Row());
            }
            else
            {
                P5Rows.Insert(index + 1, NewP5Row());
            }

            ReorderP5Rows();
            AppHelper.RefreshGridData(p5StuffGridView);

            p5Bookmark.Goto();
            p5StuffGridView.MoveBy(1);

            p5StuffGrid.Focus();
        }

        private void p5RowMinusButton_Click(object sender, EventArgs e)
        {
            int index = p5StuffGridView.FocusedRowHandle;

            if (index < 0) return;

            p5Bookmark.Get();
            P5Rows.RemoveAt(index);

            ReorderP5Rows();
            AppHelper.RefreshGridData(p5StuffGridView);

            p5Bookmark.Goto();

            p5StuffGrid.Focus();
        }

        private PhysicalPage2Row NewP2Row()
        {
            PhysicalPage2Row row = new PhysicalPage2Row();

            row.No = 0;
            row.Line = false;
            row.Requested = "";
            row.Conclusion = "";

            return row;
        }

        private PhysicalPage3Row NewP3Row()
        {
            PhysicalPage3Row row = new PhysicalPage3Row();

            row.No = 0;
            row.Line = false;
            row.Clause = "";
            row.Description = "";
            row.Result = "";

            return row;
        }

        private PhysicalPage4Row NewP4Row()
        {
            PhysicalPage4Row row = new PhysicalPage4Row();

            row.No = 0;
            row.Line = false;
            row.Sample = "";
            row.BurningRate = "";

            return row;
        }

        private PhysicalPage5Row NewP5Row()
        {
            PhysicalPage5Row row = new PhysicalPage5Row();

            row.No = 0;
            row.Line = false;
            row.TestItem = "";
            row.Result = "";
            row.Requirement = "";

            return row;
        }

        private void ReorderP2Rows()
        {
            for (int i=0; i<P2Rows.Count; i++)
            {
                P2Rows[i].No = i;
            }
        }

        private void ReorderP3Rows()
        {
            for (int i = 0; i < P3Rows.Count; i++)
            {
                P3Rows[i].No = i;
            }
        }

        private void ReorderP4Rows()
        {
            for (int i = 0; i < P4Rows.Count; i++)
            {
                P4Rows[i].No = i;
            }
        }

        private void ReorderP5Rows()
        {
            for (int i = 0; i < P5Rows.Count; i++)
            {
                P5Rows[i].No = i;
            }
        }

        private void RefreshGrid()
        {
            AppHelper.RefreshGridData(p2ResultGridView);
            AppHelper.RefreshGridData(p3ClauseGridView);
            AppHelper.RefreshGridData(p4FlameGridView);
            AppHelper.RefreshGridData(p5StuffGridView);
        }

        public void SetControlToDataSet()
        {
            p2ResultGridView.PostEditor();
            p3ClauseGridView.PostEditor();
            p4FlameGridView.PostEditor();
            p5StuffGridView.PostEditor();

            MainSet.P1ClientName = p1ClientNameEdit.Text;
            MainSet.P1ClientAddress = p1ClientAddressEdit.Text;
            MainSet.P1FileNo = p1FileNoEdit.Text;
            MainSet.P1SampleDescription = p1SampleDescriptionEdit.Text;
            MainSet.P1DetailOfSample = p1DetailOfSampleEdit.Text;
            MainSet.P1ItemNo = p1ItemNoEdit.Text;
            MainSet.P1Manufacturer = p1ManufacturerEdit.Text;
            MainSet.P1CountryOfOrigin = p1CountryOfOriginEdit.Text;
            MainSet.P1CountryOfDestination = p1CountryOfDestinationEdit.Text;
            MainSet.P1LabeledAge = p1LabeledAgeEdit.Text;
            MainSet.P1TestAge = p1TestAgeEdit.Text;
            MainSet.P1AssessedAge = p1AssessedAgeEdit.Text;
            MainSet.P1ReceivedDate = p1ReceivedDateEdit.Text;
            MainSet.P1TestPeriod = p1TestPeriodEdit.Text;
            MainSet.P1TestMethod = p1TestMethodEdit.Text;
            MainSet.P1TestResults = p1TestResultEdit.Text;
            MainSet.P1Comments = p1ReportCommentEdit.Text;
            MainSet.P2Name = p2NameEdit.Text;
            MainSet.P3Description1 = p3Desc1Edit.Text;
            MainSet.P3Description2 = p3Desc2Edit.Text;
            MainSet.P4Description1 = p4Desc1Edit.Text;
            MainSet.P4Description2 = p4Desc2Edit.Text;
            MainSet.P5Description1 = p5Desc1Edit.Text;
            MainSet.P5Description2 = p5Desc2Edit.Text;
        }

        public void SetDataSetToControl()
        {
            SetDataSetToPage1();

            P2Set.MainNo = MainSet.RecNo;
            P2Set.Select();
            SetDataSetToPage2();

            P3Set.MainNo = MainSet.RecNo;
            P3Set.Select();
            SetDataSetToPage3();

            P4Set.MainNo = MainSet.RecNo;
            P4Set.Select();
            SetDataSetToPage4();

            P5Set.MainNo = MainSet.RecNo;
            P5Set.Select();
            SetDataSetToPage5();

            ImageSet.RecNo = MainSet.RecNo;
            ImageSet.Select();
            SetDataSetToPage6();

            RefreshGrid();
        }

        private void SetDataSetToPage1()
        {
            p1ClientNameEdit.Text = MainSet.P1ClientName;
            p1ClientAddressEdit.Text = MainSet.P1ClientAddress;
            p1FileNoEdit.Text = MainSet.P1FileNo;
            p1SampleDescriptionEdit.Text = MainSet.P1SampleDescription;
            p1DetailOfSampleEdit.Text = MainSet.P1DetailOfSample;
            p1ItemNoEdit.Text = MainSet.P1ItemNo;
            p1OrderNoEdit.Text = MainSet.P1OrderNo;
            p1ManufacturerEdit.Text = MainSet.P1Manufacturer;
            p1CountryOfOriginEdit.Text = MainSet.P1CountryOfOrigin;
            p1CountryOfDestinationEdit.Text = MainSet.P1CountryOfDestination;
            p1LabeledAgeEdit.Text = MainSet.P1LabeledAge;
            p1TestAgeEdit.Text = MainSet.P1TestAge;
            p1AssessedAgeEdit.Text = MainSet.P1AssessedAge;
            p1ReceivedDateEdit.Text = MainSet.P1ReceivedDate;
            p1TestPeriodEdit.Text = MainSet.P1TestPeriod;
            p1TestMethodEdit.Text = MainSet.P1TestMethod;
            p1TestResultEdit.Text = MainSet.P1TestResults;
            p1ReportCommentEdit.Text = MainSet.P1Comments;
        }

        private void SetDataSetToPage2()
        {
            P2Rows.Clear();
            for (int i = 0; i < P2Set.RowCount; i++)
            {
                P2Set.Fetch(i);

                PhysicalPage2Row p2Row = new PhysicalPage2Row();
                p2Row.No = P2Set.No;
                p2Row.Line = P2Set.Line;
                p2Row.Requested = P2Set.Requested;
                p2Row.Conclusion = P2Set.Conclusion;
                P2Rows.Add(p2Row);
            }

            p2ResultNoColumn.SortOrder = ColumnSortOrder.Ascending;
        }

        private void SetDataSetToPage3()
        {
            p3Desc1Edit.Text = MainSet.P3Description1;
            p3Desc2Edit.Text = MainSet.P3Description2;

            P3Rows.Clear();
            for (int i = 0; i < P3Set.RowCount; i++)
            {
                P3Set.Fetch(i);

                PhysicalPage3Row p3Row = new PhysicalPage3Row();
                p3Row.No = P3Set.No;
                p3Row.Line = P3Set.Line;
                p3Row.Clause = P3Set.Clause;
                p3Row.Description = P3Set.Description;
                p3Row.Result = P3Set.Result;
                P3Rows.Add(p3Row);
            }

            p3ClauseNoColumn.SortOrder = ColumnSortOrder.Ascending;
        }

        private void SetDataSetToPage4()
        {
            p4Desc1Edit.Text = MainSet.P4Description1;
            p4Desc2Edit.Text = MainSet.P4Description2;

            P4Rows.Clear();
            for (int i = 0; i < P4Set.RowCount; i++)
            {
                P4Set.Fetch(i);

                PhysicalPage4Row p4Row = new PhysicalPage4Row();
                p4Row.No = P4Set.No;
                p4Row.Line = P4Set.Line;
                p4Row.Sample = P4Set.Sample;
                p4Row.BurningRate = P4Set.BurningRate;
                P4Rows.Add(p4Row);
            }

            p4FlameNoColumn.SortOrder = ColumnSortOrder.Ascending;
        }

        private void SetDataSetToPage5()
        {
            p5Desc1Edit.Text = MainSet.P5Description1;
            p5Desc2Edit.Text = MainSet.P5Description2;

            P5Rows.Clear();
            for (int i = 0; i < P5Set.RowCount; i++)
            {
                P5Set.Fetch(i);

                PhysicalPage5Row p5Row = new PhysicalPage5Row();
                p5Row.No = P5Set.No;
                p5Row.Line = P5Set.Line;
                p5Row.TestItem = P5Set.TestItem;
                p5Row.Result = P5Set.Result;
                p5Row.Requirement = P5Set.Requirement;
                P5Rows.Add(p5Row);
            }

            p5StuffNoColumn.SortOrder = ColumnSortOrder.Ascending;
        }

        private void SetDataSetToPage6()
        {
            ImageSet.Fetch();

            p2ImageBox.Image = ImageSet.Signature;
            p2NameEdit.Text = MainSet.P2Name;

            p6ImageBox.Image = ImageSet.Picture;
            p6FileNoPanel.Text = MainSet.P1FileNo;
        }
    }
}
