using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Base;

using Ulee.Controls;
using Ulee.Utils;
using Sgs.ReportIntegration.Source;

namespace Sgs.ReportIntegration
{
    public partial class CtrlEditPhysical : UlUserControlEng
    {
        private CtrlEditRight parent;

        private GridBookmark bookmark;

        private PhysicalMainDataSet phyMainSet;

        private PhysicalImageDataSet phyImageSet;

        private PhysicalP2DataSet phyP2Set;

        private PhysicalP3DataSet phyP3Set;

        private PhysicalP4DataSet phyP4Set;

        private PhysicalP5DataSet phyP5Set;

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
            phyMainSet = new PhysicalMainDataSet(AppRes.DB.Connect, null, null);
            phyImageSet = new PhysicalImageDataSet(AppRes.DB.Connect, null, null);
            phyP2Set = new PhysicalP2DataSet(AppRes.DB.Connect, null, null);
            phyP3Set = new PhysicalP3DataSet(AppRes.DB.Connect, null, null);
            phyP4Set = new PhysicalP4DataSet(AppRes.DB.Connect, null, null);
            phyP5Set = new PhysicalP5DataSet(AppRes.DB.Connect, null, null);
            profJobSet = new ProfJobDataSet(AppRes.DB.Connect, null, null);

            bookmark = new GridBookmark(physicalGridView);

            AppHelper.SetGridEvenRow(physicalGridView);

            physicalAreaColumn.DisplayFormat.FormatType = FormatType.Custom;
            physicalAreaColumn.DisplayFormat.Format = new ReportAreaFormat();

            areaCombo.DataSource = EnumHelper.GetNameValues<EReportArea>();
            areaCombo.DisplayMember = "Name";
            areaCombo.ValueMember = "Value";

            ctrlUs = new CtrlEditPhysicalUs();
            ctrlUs.MainSet = phyMainSet;
            ctrlUs.ImageSet = phyImageSet;
            ctrlUs.P2Set = phyP2Set;
            ctrlUs.P3Set = phyP3Set;
            ctrlUs.P4Set = phyP4Set;
            ctrlUs.P5Set = phyP5Set;

            ctrlEu = new CtrlEditPhysicalEu();
            ctrlEu.MainSet = phyMainSet;
            ctrlEu.ImageSet = phyImageSet;
            ctrlEu.P2Set = phyP2Set;
            ctrlEu.P3Set = phyP3Set;
            ctrlEu.P4Set = phyP4Set;
            ctrlEu.P5Set = phyP5Set;

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
            PhysicalMainDataSet set = phyMainSet;
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
            phyMainSet.Fetch(row);

            SetReportView(phyMainSet.AreaNo);
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
            reportNoEdit.Text = $"F690101/LF-CTS{phyMainSet.P1FileNo}";
            issuedDateEdit.Text = $"{phyMainSet.ReportedTime.ToString("yyyy. MM. dd")}";

            SetControl(ctrlUs);
            ctrlUs.SetDataSetToControl();
        }

        private void SetReportEu()
        {
            areaPanel.Text = EReportArea.EU.ToDescription();
            reportNoEdit.Text = $"F690101/LF-CTS{phyMainSet.P1FileNo}";
            issuedDateEdit.Text = $"{phyMainSet.ReportedTime.ToString("yyyy. MM. dd")}";
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
                    Insert();
                }
            }
        }

        public void Delete()
        {
            if (physicalGridView.FocusedRowHandle < 0) return;
            if (MessageBox.Show($"Would you like to delete physical report of {phyMainSet.ProductNo}?",
                "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Int64 mainNo = phyMainSet.RecNo;
            SqlTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                phyP2Set.MainNo = mainNo;
                phyP3Set.MainNo = mainNo;
                phyP4Set.MainNo = mainNo;
                phyP5Set.MainNo = mainNo;
                phyImageSet.MainNo = mainNo;

                phyP2Set.Delete(trans);
                phyP3Set.Delete(trans);
                phyP4Set.Delete(trans);
                phyP5Set.Delete(trans);
                phyImageSet.Delete(trans);
                phyMainSet.Delete(trans);

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
            if (physicalGridView.FocusedRowHandle < 0) return;

            BindingSource bind = new BindingSource();
            bind.DataSource = phyMainSet;

            ReportUsPhysical report = new ReportUsPhysical();
            report.DataSource = bind;

            DialogReportPreview dialog = new DialogReportPreview();
            dialog.Source = report;
            dialog.ShowDialog();
        }

        public void Save()
        {
            if (physicalGridView.FocusedRowHandle < 0) return;
            if (MessageBox.Show($"Would you like to save physical report of {phyMainSet.ProductNo}?",
                "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            switch (phyMainSet.AreaNo)
            {
                case EReportArea.US:
                    SaveUs();
                    break;

                case EReportArea.EU:
                    break;
            }
        }

        public void Cancel()
        {
            if (physicalGridView.FocusedRowHandle < 0) return;
            if (MessageBox.Show($"Would you like to cancel physical report of {phyMainSet.ProductNo}?",
                "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            SetReportView(phyMainSet.AreaNo);
        }

        private void SaveUs()
        {
            SqlTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                SaveMain(trans);
                SavePage2(trans);
                SavePage3(trans);
                SavePage4(trans);
                SavePage5(trans);

                AppRes.DB.CommitTrans();
            }
            catch
            {
                AppRes.DB.RollbackTrans();
            }

            findButton.PerformClick();
        }

        private void SaveMain(SqlTransaction trans)
        {
            ctrlUs.SetControlToDataSet();
            phyMainSet.Update(trans);
        }

        private void SavePage2(SqlTransaction trans)
        {
            phyP2Set.MainNo = phyMainSet.RecNo;
            phyP2Set.Delete(trans);

            foreach (PhysicalPage2Row row in ctrlUs.P2Rows)
            {
                phyP2Set.No = row.No;
                phyP2Set.Line = row.Line;
                phyP2Set.Requested = row.Requested;
                phyP2Set.Conclusion = row.Conclusion;
                phyP2Set.Insert(trans);
            }
        }

        private void SavePage3(SqlTransaction trans)
        {
            phyP3Set.MainNo = phyMainSet.RecNo;
            phyP3Set.Delete(trans);

            foreach (PhysicalPage3Row row in ctrlUs.P3Rows)
            {
                phyP3Set.No = row.No;
                phyP3Set.Line = row.Line;
                phyP3Set.Clause = row.Clause;
                phyP3Set.Description = row.Description;
                phyP3Set.Result = row.Result;
                phyP3Set.Insert(trans);
            }
        }

        private void SavePage4(SqlTransaction trans)
        {
            phyP4Set.MainNo = phyMainSet.RecNo;
            phyP4Set.Delete(trans);

            foreach (PhysicalPage4Row row in ctrlUs.P4Rows)
            {
                phyP4Set.No = row.No;
                phyP4Set.Line = row.Line;
                phyP4Set.Sample = row.Sample;
                phyP4Set.BurningRate = row.BurningRate;
                phyP4Set.Insert(trans);
            }
        }

        private void SavePage5(SqlTransaction trans)
        {
            phyP5Set.MainNo = phyMainSet.RecNo;
            phyP5Set.Delete(trans);

            foreach (PhysicalPage5Row row in ctrlUs.P5Rows)
            {
                phyP5Set.No = row.No;
                phyP5Set.Line = row.Line;
                phyP5Set.TestItem = row.TestItem;
                phyP5Set.Result = row.Result;
                phyP5Set.Requirement = row.Requirement;
                phyP5Set.Insert(trans);
            }
        }

        private void Insert()
        {
            if (profJobSet.Empty == true) return;
            if (profJobSet.AreaNo == EReportArea.None) return;
            if (string.IsNullOrWhiteSpace(profJobSet.ProductNo) == true) return;

            phyMainSet.From = "";
            phyMainSet.To = "";
            phyMainSet.AreaNo = profJobSet.AreaNo;
            phyMainSet.ProductNo = profJobSet.ProductNo;
            phyMainSet.Select();

            if (phyMainSet.Empty == false)
            {
                MessageBox.Show("Can't import physical report because this report already exist in DB!",
                    "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                InsertMain(trans);
                InsertImage(trans);
                InsertPage2(trans);
                InsertPage3(trans);
                InsertPage4(trans);
                InsertPage5(trans);

                AppRes.DB.CommitTrans();
            }  
            catch
            {
                AppRes.DB.RollbackTrans();
            }

            findButton.PerformClick();
        }

        private void InsertMain(SqlTransaction trans)
        {
            phyMainSet.RegTime = profJobSet.RegTime;
            phyMainSet.ReceivedTime = profJobSet.ReceivedTime;
            phyMainSet.RequiredTime = profJobSet.RequiredTime;
            phyMainSet.ReportedTime = profJobSet.ReportedTime;
            phyMainSet.AreaNo = profJobSet.AreaNo;
            phyMainSet.ProductNo = profJobSet.ProductNo;
            phyMainSet.JobNo = profJobSet.JobNo;
            phyMainSet.P1ClientNo = profJobSet.ClientNo;
            phyMainSet.P1ClientName = profJobSet.ClientName;
            phyMainSet.P1ClientAddress = profJobSet.ClientAddress;
            phyMainSet.P1FileNo = profJobSet.FileNo;
            phyMainSet.P1SampleDescription = profJobSet.SampleDescription;
            phyMainSet.P1DetailOfSample = profJobSet.DetailOfSample;
            phyMainSet.P1ItemNo = profJobSet.ItemNo;
            phyMainSet.P1OrderNo = "-";
            phyMainSet.P1Manufacturer = profJobSet.Manufacturer;
            phyMainSet.P1CountryOfOrigin = profJobSet.CountryOfOrigin;
            phyMainSet.P1CountryOfDestination = "-";
            phyMainSet.P1LabeledAge = "None";
            phyMainSet.P1TestAge = "None";
            phyMainSet.P1AssessedAge = "All ages";
            phyMainSet.P1ReceivedDate = profJobSet.ReceivedTime.ToString("yyyy. MM. dd");
            phyMainSet.P1TestPeriod = $"{profJobSet.ReceivedTime.ToString("yyyy. MM. dd")}  to  {profJobSet.RequiredTime.ToString("yyyy. MM. dd")}";
            phyMainSet.P1TestMethod = "For further details, please refer to following page(s)";
            phyMainSet.P1TestResults = "For further details, please refer to following page(s)";
            phyMainSet.P1Comments = profJobSet.ReportComments;
            phyMainSet.P2Name = "";
            phyMainSet.P3Description1 = "As specified in ASTM F963-17 standard consumer safety specification on toys safety.";
            phyMainSet.P3Description2 =
                 "N/A = Not Applicable                **Visual Examination\r\n" +
                "NT = Not tested as per clients request.\r\n\r\n" +
                "N.B. : - Only applicable clauses were shown";
            phyMainSet.P4Description1 = "Flammability Test(Clause 4.2)";
            phyMainSet.P4Description2 =
                "*Burning rate has been rounded to the nearest one tenth of an inch per second.\r\n\r\n" +
                "Requirement: A toy / component is considered a \"flammable solid\" if it ignites and burns with a self-sustaining\r\n" +
                "             flame at a rate greater than 0.1 in./s along its major axis.";
            phyMainSet.P5Description1 =
                "Suffing Materials(Clause 4.3.7)\r\n\r\n" +
                "Method: With reference to ASTM F963-17 Clause 8.29. Visual inspection is performed using a stereo widerfield\r\n" +
                "microscope, or equivalent, at 10 x magnification and adequate illumination.";
            phyMainSet.P5Description2 = "Polyester fiber";

            phyMainSet.Insert(trans);
        }

        private void InsertImage(SqlTransaction trans)
        {
            phyImageSet.MainNo = phyMainSet.RecNo;
            phyImageSet.Signature = null;
            phyImageSet.Picture = profJobSet.Image;
            phyImageSet.Insert(trans);
        }

        private void InsertPage2(SqlTransaction trans)
        {
            phyP2Set.MainNo = phyMainSet.RecNo;
            phyP2Set.No = 0;
            phyP2Set.Line = false;
            phyP2Set.Requested = "US Public Law 110-314(Comsumer Plroduct Safety Improvement Act of 2008, CPSIA):";
            phyP2Set.Conclusion = "-";
            phyP2Set.Insert(trans);

            phyP2Set.No = 1;
            phyP2Set.Line = false;
            phyP2Set.Requested = "- ASTM F963-17: Standard Consumer Safety Specification on Toy Safety\r\n  (Excluding clause 4.3.5 Heavy Element)";
            phyP2Set.Conclusion = "PASS";
            phyP2Set.Insert(trans);

            phyP2Set.No = 2;
            phyP2Set.Line = false;
            phyP2Set.Requested = "Flammability of toys(16 C.F.R. 1500.44)";
            phyP2Set.Conclusion = "PASS";
            phyP2Set.Insert(trans);

            phyP2Set.No = 3;
            phyP2Set.Line = false;
            phyP2Set.Requested = "Small part(16 C.F.R. 1501)";
            phyP2Set.Conclusion = "PASS";
            phyP2Set.Insert(trans);

            phyP2Set.No = 4;
            phyP2Set.Line = false;
            phyP2Set.Requested = "Sharp points and edges(16 C.F.R. 1500.48 and 49)";
            phyP2Set.Conclusion = "PASS";
            phyP2Set.Insert(trans);
        }

        private void InsertPage3(SqlTransaction trans)
        {
            phyP3Set.MainNo = phyMainSet.RecNo;
            phyP3Set.No = 0;
            phyP3Set.Line = false;
            phyP3Set.Clause = "4";
            phyP3Set.Description = "Safety Requirements";
            phyP3Set.Result = "-";
            phyP3Set.Insert(trans);

            phyP3Set.No = 1;
            phyP3Set.Line = false;
            phyP3Set.Clause = " 4.1";
            phyP3Set.Description = "Material Quality**";
            phyP3Set.Result = "Pass";
            phyP3Set.Insert(trans);

            phyP3Set.No = 2;
            phyP3Set.Line = false;
            phyP3Set.Clause = " 4.2";
            phyP3Set.Description = "Flammability Test(16 C.F.R. 1500.44)";
            phyP3Set.Result = "Pass(See Note 1)";
            phyP3Set.Insert(trans);

            phyP3Set.No = 3;
            phyP3Set.Line = false;
            phyP3Set.Clause = " 4.3";
            phyP3Set.Description = "Toxicology";
            phyP3Set.Result = "-";
            phyP3Set.Insert(trans);

            phyP3Set.No = 4;
            phyP3Set.Line = false;
            phyP3Set.Clause = " 4.3.5";
            phyP3Set.Description = "Heavy Elements";
            phyP3Set.Result = "";
            phyP3Set.Insert(trans);

            phyP3Set.No = 5;
            phyP3Set.Line = false;
            phyP3Set.Clause = "";
            phyP3Set.Description = "4.3.5.1 Hravy Elements in Paint/Similar Coating Materials";
            phyP3Set.Result = "";
            phyP3Set.Insert(trans);

            phyP3Set.No = 6;
            phyP3Set.Line = false;
            phyP3Set.Clause = "";
            phyP3Set.Description = "4.3.5.2 Heavy Metal in Substrate Materials";
            phyP3Set.Result = "";
            phyP3Set.Insert(trans);

            phyP3Set.No = 7;
            phyP3Set.Line = false;
            phyP3Set.Clause = " 4.3.7";
            phyP3Set.Description = "Styffing Materials";
            phyP3Set.Result = "Pass(See Note 2)";
            phyP3Set.Insert(trans);

            phyP3Set.No = 8;
            phyP3Set.Line = false;
            phyP3Set.Clause = " 4.6";
            phyP3Set.Description = "Small Objects";
            phyP3Set.Result = "-";
            phyP3Set.Insert(trans);

            phyP3Set.No = 9;
            phyP3Set.Line = false;
            phyP3Set.Clause = " 4.6.1";
            phyP3Set.Description = "Small Objects";
            phyP3Set.Result = "Pass";
            phyP3Set.Insert(trans);

            phyP3Set.No = 10;
            phyP3Set.Line = false;
            phyP3Set.Clause = " 4.7";
            phyP3Set.Description = "Accessible Edges(16 C.F.R. 1500.49)";
            phyP3Set.Result = "Pass";
            phyP3Set.Insert(trans);

            phyP3Set.No = 11;
            phyP3Set.Line = false;
            phyP3Set.Clause = " 4.9";
            phyP3Set.Description = "Accessible Points(16 C.F.R. 1500.48)";
            phyP3Set.Result = "Pass";
            phyP3Set.Insert(trans);

            phyP3Set.No = 12;
            phyP3Set.Line = false;
            phyP3Set.Clause = " 4.14";
            phyP3Set.Description = "Cords, Straps and Elastic";
            phyP3Set.Result = "Pass";
            phyP3Set.Insert(trans);

            phyP3Set.No = 13;
            phyP3Set.Line = true;
            phyP3Set.Clause = " 4.27";
            phyP3Set.Description = "Stuffed and Beanbag-Type Toys";
            phyP3Set.Result = "Pass";
            phyP3Set.Insert(trans);

            phyP3Set.No = 14;
            phyP3Set.Line = false;
            phyP3Set.Clause = "5";
            phyP3Set.Description = "Safety Labeling Requirements";
            phyP3Set.Result = "-";
            phyP3Set.Insert(trans);

            phyP3Set.No = 15;
            phyP3Set.Line = true;
            phyP3Set.Clause = " 4.2";
            phyP3Set.Description = "Age Grading Labeling";
            phyP3Set.Result = "Pass";
            phyP3Set.Insert(trans);

            phyP3Set.No = 16;
            phyP3Set.Line = false;
            phyP3Set.Clause = "7";
            phyP3Set.Description = "Producers Markings";
            phyP3Set.Result = "-";
            phyP3Set.Insert(trans);

            phyP3Set.No = 17;
            phyP3Set.Line = true;
            phyP3Set.Clause = " 7.1";
            phyP3Set.Description = "Producers Markings";
            phyP3Set.Result = "Present";
            phyP3Set.Insert(trans);

            phyP3Set.No = 18;
            phyP3Set.Line = false;
            phyP3Set.Clause = "8";
            phyP3Set.Description = "Test Methods";
            phyP3Set.Result = "-";
            phyP3Set.Insert(trans);

            phyP3Set.No = 19;
            phyP3Set.Line = false;
            phyP3Set.Clause = " 8.5";
            phyP3Set.Description = "Normal Use Testing";
            phyP3Set.Result = "Pass";
            phyP3Set.Insert(trans);

            phyP3Set.No = 20;
            phyP3Set.Line = false;
            phyP3Set.Clause = " 8.7";
            phyP3Set.Description = "Impact Test";
            phyP3Set.Result = "Pass";
            phyP3Set.Insert(trans);

            phyP3Set.No = 21;
            phyP3Set.Line = false;
            phyP3Set.Clause = " 8.8";
            phyP3Set.Description = "Torque Test";
            phyP3Set.Result = "Pass";
            phyP3Set.Insert(trans);

            phyP3Set.No = 22;
            phyP3Set.Line = false;
            phyP3Set.Clause = " 8.9";
            phyP3Set.Description = "Tension Test";
            phyP3Set.Result = "Pass";
            phyP3Set.Insert(trans);

            phyP3Set.No = 23;
            phyP3Set.Line = false;
            phyP3Set.Clause = " 8.23";
            phyP3Set.Description = "Test for Loops and Cords";
            phyP3Set.Result = "Pass";
            phyP3Set.Insert(trans);

            phyP3Set.No = 24;
            phyP3Set.Line = true;
            phyP3Set.Clause = " 8.29";
            phyP3Set.Description = "Stuffing Materials Evaluation";
            phyP3Set.Result = "Pass";
            phyP3Set.Insert(trans);
        }

        private void InsertPage4(SqlTransaction trans)
        {
            phyP4Set.MainNo = phyMainSet.RecNo;
            phyP4Set.No = 0;
            phyP4Set.Line = false;
            phyP4Set.Sample = "Panda toy";
            phyP4Set.BurningRate = "0.1*";
            phyP4Set.Insert(trans);
        }

        private void InsertPage5(SqlTransaction trans)
        {
            phyP5Set.MainNo = phyMainSet.RecNo;
            phyP5Set.No = 0;
            phyP5Set.Line = true;
            phyP5Set.TestItem =
                "   1. Objectionable matter originating from\r\n" +
                "      Insect, bird and rodent or other animal\r\n" +
                "      infestation";
            phyP5Set.Result = "Absent";
            phyP5Set.Requirement = "Absent";
            phyP5Set.Insert(trans);

            phyP5Set.No = 1;
            phyP5Set.Line = false;
            phyP5Set.TestItem = "Comment";
            phyP5Set.Result = "PASS";
            phyP5Set.Requirement = "-";
            phyP5Set.Insert(trans);
        }
    }
}
