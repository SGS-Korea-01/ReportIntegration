using System;
using System.Collections.Generic;
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

        private PhysicalP40DataSet phyP40Set;

        private PhysicalP41DataSet phyP41Set;

        private PhysicalP5DataSet phyP5Set;

        private PhysicalReportDataSet phyReportSet;

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
            phyMainSet = new PhysicalMainDataSet(AppRes.DB.Connect, null, null);
            phyImageSet = new PhysicalImageDataSet(AppRes.DB.Connect, null, null);
            phyP2Set = new PhysicalP2DataSet(AppRes.DB.Connect, null, null);
            phyP3Set = new PhysicalP3DataSet(AppRes.DB.Connect, null, null);
            phyP40Set = new PhysicalP40DataSet(AppRes.DB.Connect, null, null);
            phyP41Set = new PhysicalP41DataSet(AppRes.DB.Connect, null, null);
            phyP5Set = new PhysicalP5DataSet(AppRes.DB.Connect, null, null);
            phyReportSet = new PhysicalReportDataSet(AppRes.DB.Connect, null, null);
            profJobSet = new ProfJobDataSet(AppRes.DB.Connect, null, null);

            bookmark = new GridBookmark(physicalGridView);
            AppHelper.SetGridEvenRow(physicalGridView);

            physicalAreaColumn.DisplayFormat.FormatType = FormatType.Custom;
            physicalAreaColumn.DisplayFormat.Format = new ReportAreaFormat();

            approvalCombo.DataSource = EnumHelper.GetNameValues<EReportApproval>();
            approvalCombo.DisplayMember = "Name";
            approvalCombo.ValueMember = "Value";

            areaCombo.DataSource = EnumHelper.GetNameValues<EReportArea>();
            areaCombo.DisplayMember = "Name";
            areaCombo.ValueMember = "Value";

            ctrlUs = new CtrlEditPhysicalUs();
            ctrlUs.MainSet = phyMainSet;
            ctrlUs.ImageSet = phyImageSet;
            ctrlUs.P2Set = phyP2Set;
            ctrlUs.P3Set = phyP3Set;
            ctrlUs.P4Set = phyP41Set;
            ctrlUs.P5Set = phyP5Set;

            ctrlEu = new CtrlEditPhysicalEu();
            ctrlEu.MainSet = phyMainSet;
            ctrlEu.ImageSet = phyImageSet;
            ctrlEu.P2Set = phyP2Set;
            ctrlEu.P3Set = phyP3Set;
            ctrlEu.P40Set = phyP40Set;
            ctrlEu.P41Set = phyP41Set;
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
            physicalGrid.Size = new Size(gridPanel.Width, gridPanel.Height - 142);
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
            approvalCombo.SelectedIndex = 0;
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
                phyP2Set.Delete(trans);

                phyP3Set.MainNo = mainNo;
                phyP3Set.Delete(trans);

                phyP40Set.MainNo = mainNo;
                phyP40Set.Delete(trans);

                phyP41Set.MainNo = mainNo;
                phyP41Set.Delete(trans);

                phyP5Set.MainNo = mainNo;
                phyP5Set.Delete(trans);

                phyImageSet.MainNo = mainNo;
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

            phyReportSet.RecNo = phyMainSet.RecNo;
            phyReportSet.Select();

            phyReportSet.DataSet.Tables[0].TableName = "P1";
            phyReportSet.DataSet.Tables[1].TableName = "P2";
            phyReportSet.DataSet.Tables[2].TableName = "P3";
            phyReportSet.DataSet.Tables[3].TableName = "P40";
            phyReportSet.DataSet.Tables[4].TableName = "P41";
            phyReportSet.DataSet.Tables[5].TableName = "P5";
            phyReportSet.DataSet.Tables[6].TableName = "Image";

            BindingSource bind = new BindingSource();
            bind.DataSource = phyReportSet.DataSet;

            XtraReport report;

            if (phyMainSet.AreaNo == EReportArea.US) 
                report = new ReportUsPhysical();
            else
                report = new ReportEuPhysical();

            report.DataSource = bind;
            report.CreateDocument();
            new ReportPrintTool(report);

            DialogReportPreview dialog = new DialogReportPreview();
            dialog.Source = report;
            dialog.ShowDialog();
        }

        public void Save()
        {
            if (physicalGridView.FocusedRowHandle < 0) return;
            if (MessageBox.Show($"Would you like to save physical report of {phyMainSet.ProductNo}?",
                "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            SaveReport();
        }

        public void Cancel()
        {
            if (physicalGridView.FocusedRowHandle < 0) return;
            if (MessageBox.Show($"Would you like to cancel physical report of {phyMainSet.ProductNo}?",
                "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            SetReportView(phyMainSet.AreaNo);
        }

        private void SaveReport()
        {
            EReportArea area = phyMainSet.AreaNo;
            SqlTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                SaveMain(area, trans);
                SavePage2(area, trans);
                SavePage3(area, trans);
                SavePage4(area, trans);
                SavePage5(area, trans);

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

            phyMainSet.Update(trans);
        }

        private void SavePage2(EReportArea area, SqlTransaction trans)
        {
            List<PhysicalPage2Row> rows = (area == EReportArea.US) ? ctrlUs.P2Rows : ctrlEu.P2Rows;

            phyP2Set.MainNo = phyMainSet.RecNo;
            phyP2Set.Delete(trans);

            foreach (PhysicalPage2Row row in rows)
            {
                phyP2Set.No = row.No;
                phyP2Set.Line = row.Line;
                phyP2Set.Requested = row.Requested;
                phyP2Set.Conclusion = row.Conclusion;
                phyP2Set.Insert(trans);
            }
        }

        private void SavePage3(EReportArea area, SqlTransaction trans)
        {
            List<PhysicalPage3Row> rows = (area == EReportArea.US) ? ctrlUs.P3Rows : ctrlEu.P3Rows;

            phyP3Set.MainNo = phyMainSet.RecNo;
            phyP3Set.Delete(trans);

            foreach (PhysicalPage3Row row in rows)
            {
                phyP3Set.No = row.No;
                phyP3Set.Line = row.Line;
                phyP3Set.Clause = row.Clause;
                phyP3Set.Description = row.Description;
                phyP3Set.Result = row.Result;
                phyP3Set.Insert(trans);
            }
        }

        private void SavePage4(EReportArea area, SqlTransaction trans)
        {
            List<PhysicalPage3Row> p40Rows = (area == EReportArea.US) ? null : ctrlEu.P40Rows;
            List<PhysicalPage4Row> p41Rows = (area == EReportArea.US) ? ctrlUs.P4Rows : ctrlEu.P41Rows;

            if (p40Rows != null)
            {
                phyP40Set.MainNo = phyMainSet.RecNo;
                phyP40Set.Delete(trans);

                foreach (PhysicalPage3Row row in p40Rows)
                {
                    phyP40Set.No = row.No;
                    phyP40Set.Line = row.Line;
                    phyP40Set.Clause = row.Clause;
                    phyP40Set.Description = row.Description;
                    phyP40Set.Result = row.Result;
                    phyP40Set.Insert(trans);
                }
            }

            phyP41Set.MainNo = phyMainSet.RecNo;
            phyP41Set.Delete(trans);

            foreach (PhysicalPage4Row row in p41Rows)
            {
                phyP41Set.No = row.No;
                phyP41Set.Line = row.Line;
                phyP41Set.Sample = row.Sample;
                phyP41Set.BurningRate = row.BurningRate;
                phyP41Set.Insert(trans);
            }
        }

        private void SavePage5(EReportArea area, SqlTransaction trans)
        {
            List<PhysicalPage5Row> rows = (area == EReportArea.US) ? ctrlUs.P5Rows : ctrlEu.P5Rows;

            phyP5Set.MainNo = phyMainSet.RecNo;
            phyP5Set.Delete(trans);

            foreach (PhysicalPage5Row row in rows)
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
            EReportArea area = profJobSet.AreaNo;

            if (profJobSet.Empty == true) return;
            if (area == EReportArea.None) return;
            if (string.IsNullOrWhiteSpace(profJobSet.ProductNo) == true) return;

            phyMainSet.From = "";
            phyMainSet.To = "";
            phyMainSet.AreaNo = area;
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
                InsertMain(area, trans);
                InsertImage(trans);
                InsertPage2(area, trans);
                InsertPage3(area, trans);
                InsertPage4(area, trans);
                InsertPage5(area, trans);

                AppRes.DB.CommitTrans();
            }  
            catch
            {
                AppRes.DB.RollbackTrans();
            }

            findButton.PerformClick();
        }

        private void InsertMain(EReportArea area, SqlTransaction trans)
        {
            phyMainSet.RegTime = profJobSet.RegTime;
            phyMainSet.ReceivedTime = profJobSet.ReceivedTime;
            phyMainSet.RequiredTime = profJobSet.RequiredTime;
            phyMainSet.ReportedTime = profJobSet.ReportedTime;
            phyMainSet.Approval = false;
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
            phyMainSet.P1Packaging = "Yes, provided";
            phyMainSet.P1Instruction = "Not provided";
            phyMainSet.P1Buyer = "-";
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

            if (area == EReportArea.US)
            {
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
                phyMainSet.P4Description3 = "";
                
                phyMainSet.P5Description1 =
                    "Suffing Materials(Clause 4.3.7)\r\n\r\n" +
                    "Method: With reference to ASTM F963-17 Clause 8.29. Visual inspection is performed using a stereo widerfield\r\n" +
                    "microscope, or equivalent, at 10 x magnification and adequate illumination.";
                phyMainSet.P5Description2 = "Polyester fiber";
            }
            else
            {
                phyMainSet.P3Description1 =
                    "European Standard on Safety of Toys\r\n" +
                    "- Mechanical & Physical Properties\r\n" +
                    "As specified in European standard on safety of toys EN 71 Part 1:2014 + A1:2018";
                phyMainSet.P3Description2 = "";
                
                phyMainSet.P4Description1 =
                    "- Flammability of Toys\r\n" +
                    "As specified in European standard on safety of toys EN71 PART 2: 2011 + A1:2014";
                phyMainSet.P4Description2 =
                    "* Surface Flash of Pile Fabrics (Clause 4.1)";
                phyMainSet.P4Description3 =
                    "NSFO = No surface flash occurred\r\n" +
                    "DNI = Did not ignite\r\n" +
                    "IBE = Ignite But Self-Extinguished\r\n" +
                    "N / A = Not applicable since the requirements of this sub - clause do not apply to toys with a greatest dimension of 150mm or less\r\n" +
                    "SE = Self - Extinguishing\r\n\r\n\r\n" +
                    "N.B. : Only applicable clauses were shown.";
                phyMainSet.P5Description1 = 
                    "Labeling requirement (Washing/Cleaning Label, CE mark, importer / manufacturer mark (name, address), product identification) according to the Directive 2009/48/EC - Safety of toys";
                phyMainSet.P5Description2 =
                    "1. According to Directive 2009/48/EC, a toy intended for use by children under 36 months must be designed and\r\n" +
                    "   manufactured in such a way that it can be cleaned. A textile toy must, to this end, be washable, except if it\r\n" +
                    "   contains a mechanism that may be damaged if soak washed. The manufacturer should, if applicable, provide\r\n" +
                    "   instructions on how the toy has to be cleaned.\r\n\r\n" +
                    "2. CE marking should be visible from outside the packaging and its height must be at least 5 mm.\r\n\r\n" +
                    "3. Manufacturer’s and Importers name, registered trade name or registered trade mark and the address at which\r\n" +
                    "   the manufacturer can be contacted must be indicated on the toy or, where that is not possible, on its packaging\r\n" +
                    "   or in a document accompanying the toy.\r\n\r\n";
                    //"4. Manufacturers must ensure that their toys bear a type, batch, serial or model number or other element allowing\r\n" +
                    //"   their identification, or where the size or nature of the toy does not allow it, that the required information is\r\n" +
                    //"   provided on the packaging or in a document accompanying the toy.";
            }

            phyMainSet.Insert(trans);
        }

        private void InsertImage(SqlTransaction trans)
        {
            phyImageSet.MainNo = phyMainSet.RecNo;
            phyImageSet.Signature = null;
            phyImageSet.Picture = profJobSet.Image;
            phyImageSet.Insert(trans);
        }

        private void InsertPage2(EReportArea area, SqlTransaction trans)
        {
            if (area == EReportArea.US)
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
            else
            {
                phyP2Set.MainNo = phyMainSet.RecNo;
                phyP2Set.No = 0;
                phyP2Set.Line = false;
                phyP2Set.Requested = "EN 71 Part 1:2014+A1:2018 - Mechanical and Physical Properties";
                phyP2Set.Conclusion = "PASS";
                phyP2Set.Insert(trans);

                phyP2Set.No = 1;
                phyP2Set.Line = false;
                phyP2Set.Requested = "EN 71 Part 2:2011+A1:2014 - Flammability of Toys";
                phyP2Set.Conclusion = "PASS";
                phyP2Set.Insert(trans);

                phyP2Set.No = 2;
                phyP2Set.Line = false;
                phyP2Set.Requested = "Labeling requirement (Washing/Cleaning Label, CE mark, importer / manufacturer mark (name, address), product identification) according to the Directive 2009/48/EC-Safety of toys";
                phyP2Set.Conclusion = "See note1*";
                phyP2Set.Insert(trans);
            }
        }

        private void InsertPage3(EReportArea area, SqlTransaction trans)
        {
            if (area == EReportArea.US)
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
            else 
            {
                phyP3Set.MainNo = phyMainSet.RecNo;
                phyP3Set.No = 0;
                phyP3Set.Line = false;
                phyP3Set.Clause = "4";
                phyP3Set.Description = "General requirements";
                phyP3Set.Result = "-";
                phyP3Set.Insert(trans);

                phyP3Set.No = 1;
                phyP3Set.Line = false;
                phyP3Set.Clause = " 4.1";
                phyP3Set.Description = "Material cleanliness";
                phyP3Set.Result = "Pass";
                phyP3Set.Insert(trans);

                phyP3Set.No = 2;
                phyP3Set.Line = false;
                phyP3Set.Clause = " 4.7";
                phyP3Set.Description = "Edges";
                phyP3Set.Result = "Pass";
                phyP3Set.Insert(trans);

                phyP3Set.No = 3;
                phyP3Set.Line = true;
                phyP3Set.Clause = " 4.8";
                phyP3Set.Description = "Points and metallic wires";
                phyP3Set.Result = "Pass";
                phyP3Set.Insert(trans);

                phyP3Set.No = 4;
                phyP3Set.Line = false;
                phyP3Set.Clause = "5";
                phyP3Set.Description = "Toys intended for children under 36 months";
                phyP3Set.Result = "-";
                phyP3Set.Insert(trans);

                phyP3Set.No = 5;
                phyP3Set.Line = false;
                phyP3Set.Clause = " 5.1";
                phyP3Set.Description = "General requirements";
                phyP3Set.Result = "Pass";
                phyP3Set.Insert(trans);

                phyP3Set.No = 6;
                phyP3Set.Line = false;
                phyP3Set.Clause = "";
                phyP3Set.Description = "5.1a Small part requirements on toys & removable components";
                phyP3Set.Result = "Pass";
                phyP3Set.Insert(trans);

                phyP3Set.No = 7;
                phyP3Set.Line = false;
                phyP3Set.Clause = "";
                phyP3Set.Description = "     (Test method 8.2)";
                phyP3Set.Result = "-";
                phyP3Set.Insert(trans);

                phyP3Set.No = 8;
                phyP3Set.Line = false;
                phyP3Set.Clause = "";
                phyP3Set.Description = "5.1b Torque test(Test method 8.3)";
                phyP3Set.Result = "Pass";
                phyP3Set.Insert(trans);

                phyP3Set.No = 9;
                phyP3Set.Line = false;
                phyP3Set.Clause = "";
                phyP3Set.Description = "     Tension test(Test method 8.4)";
                phyP3Set.Result = "Pass";
                phyP3Set.Insert(trans);

                phyP3Set.No = 10;
                phyP3Set.Line = false;
                phyP3Set.Clause = "";
                phyP3Set.Description = "     Drop test(Test method 8.5)";
                phyP3Set.Result = "Pass";
                phyP3Set.Insert(trans);

                phyP3Set.No = 11;
                phyP3Set.Line = false;
                phyP3Set.Clause = "";
                phyP3Set.Description = "     Impact test(Test method 8.7)";
                phyP3Set.Result = "Pass";
                phyP3Set.Insert(trans);

                phyP3Set.No = 12;
                phyP3Set.Line = false;
                phyP3Set.Clause = "";
                phyP3Set.Description = "     Sharp edge(Test method 8.11)";
                phyP3Set.Result = "Pass";
                phyP3Set.Insert(trans);

                phyP3Set.No = 13;
                phyP3Set.Line = false;
                phyP3Set.Clause = "";
                phyP3Set.Description = "     Sharp point(Test method 8.12)";
                phyP3Set.Result = "Pass";
                phyP3Set.Insert(trans);

                phyP3Set.No = 14;
                phyP3Set.Line = false;
                phyP3Set.Clause = " 5.2";
                phyP3Set.Description = "Soft-filled toys and soft-filled parts of a toy";
                phyP3Set.Result = "Pass";
                phyP3Set.Insert(trans);
            }
        }

        private void InsertPage4(EReportArea area, SqlTransaction trans)
        {
            if (area == EReportArea.US)
            {
                phyP41Set.MainNo = phyMainSet.RecNo;
                phyP41Set.No = 0;
                phyP41Set.Line = false;
                phyP41Set.Sample = "Panda toy";
                phyP41Set.BurningRate = "0.1*";
                phyP41Set.Insert(trans);
            }
            else
            {
                phyP40Set.MainNo = phyMainSet.RecNo;
                phyP40Set.No = 0;
                phyP40Set.Line = true;
                phyP40Set.Clause = "4.1";
                phyP40Set.Description = "General requirements";
                phyP40Set.Result = "Pass (See note *)";
                phyP40Set.Insert(trans);

                phyP40Set.No = 1;
                phyP40Set.Line = true;
                phyP40Set.Clause = "4.5";
                phyP40Set.Description = "Soft - filled toys(animals and doll, etc.) with a piled or textile surface";
                phyP40Set.Result = "NA";
                phyP40Set.Insert(trans);

                phyP41Set.MainNo = phyMainSet.RecNo;
                phyP41Set.No = 0;
                phyP41Set.Line = false;
                phyP41Set.Sample = "Santa mini toy";
                phyP41Set.BurningRate = "NSFO";
                phyP41Set.Insert(trans);
            }
        }

        private void InsertPage5(EReportArea area, SqlTransaction trans)
        {
            if (area == EReportArea.US)
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
            else
            {
                phyP5Set.MainNo = phyMainSet.RecNo;
                phyP5Set.No = 0;
                phyP5Set.Line = true;
                phyP5Set.TestItem = "Washing/Cleaning instruction";
                phyP5Set.Result = "Present";
                phyP5Set.Requirement = "Affixed label and Hangtag";
                phyP5Set.Insert(trans);

                phyP5Set.No = 1;
                phyP5Set.Line = true;
                phyP5Set.TestItem = "CE mark";
                phyP5Set.Result = "Present";
                phyP5Set.Requirement = "Affixed label and Hangtag";
                phyP5Set.Insert(trans);

                phyP5Set.No = 2;
                phyP5Set.Line = true;
                phyP5Set.TestItem = "Importer’s Name & Address";
                phyP5Set.Result = "Present";
                phyP5Set.Requirement = "Affixed label and Hangtag";
                phyP5Set.Insert(trans);

                phyP5Set.No = 3;
                phyP5Set.Line = true;
                phyP5Set.TestItem = "Manufacturer’s Name & Address";
                phyP5Set.Result = "Present";
                phyP5Set.Requirement = "Affixed label and Hangtag";
                phyP5Set.Insert(trans);

                phyP5Set.No = 4;
                phyP5Set.Line = true;
                phyP5Set.TestItem = "Product ID";
                phyP5Set.Result = "Present";
                phyP5Set.Requirement = "Affixed label and Hangtag";
                phyP5Set.Insert(trans);
            }
        }
    }
}
