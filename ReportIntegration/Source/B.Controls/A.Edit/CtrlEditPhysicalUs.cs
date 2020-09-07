using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ulee.Controls;
using DevExpress.Data;

namespace Sgs.ReportIntegration
{
    public partial class CtrlEditPhysicalUs : UlUserControlEng
    {
        private PhysicalMainDataSet dataSet;

        private List<PhysicalPage2Row> page2Rows;

        private List<PhysicalPage3Row> page3Rows;

        private List<PhysicalPage4Row> page4Rows;

        private List<PhysicalPage5Row> page5Rows;

        public CtrlEditPhysicalUs(PhysicalMainDataSet set)
        {
            dataSet = set;
            page2Rows = new List<PhysicalPage2Row>();
            page3Rows = new List<PhysicalPage3Row>();
            page4Rows = new List<PhysicalPage4Row>();
            page5Rows = new List<PhysicalPage5Row>();

            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            p2ResultGrid.DataSource = page2Rows;
            AppHelper.SetGridEvenRow(p2ResultGridView);

            p3ClauseGrid.DataSource = page3Rows;
            AppHelper.SetGridEvenRow(p3ClauseGridView);

            p4FlameGrid.DataSource = page4Rows;
            AppHelper.SetGridEvenRow(p4FlameGridView);

            p5StuffGrid.DataSource = page5Rows;
            AppHelper.SetGridEvenRow(p5StuffGridView);
        }

        private void physicalTab_Resize(object sender, EventArgs e)
        {
        }

        private void physical1Page_Resize(object sender, EventArgs e)
        {
            int width = physical1Page.Width;

            p1ClientNameEdit.Width = width - 172;
            p1ClientAddressEdit.Width = width - 172;
            p1FileNoEdit.Width = width - 172;
            p1SampleDescriptionEdit.Width = width - 172;
            p1DetailOfSampleEdit.Width = width - 172;
            p1ItemNoEdit.Width = width - 172;
            p1ManufacturerEdit.Width = width - 172;
            p1CountryOfOriginEdit.Width = width - 172;
            p1CountryOfDestinationEdit.Width = width - 172;
            p1LabeledAgeEdit.Width = width - 172;
            p1TestAgeEdit.Width = width - 172;
            p1AssessedAgeEdit.Width = width - 172;
            p1ReceivedDateEdit.Width = width - 172;
            p1TestPeriodEdit.Width = width - 172;
            p1ReportCommentEdit.Width = width - 172;
        }

        private void physical2Page_Resize(object sender, EventArgs e)
        {
            int width = physical2Page.Width;
            int height = physical2Page.Height;

            p2ResultGrid.Size = new Size(width - 8, height - 187);
            p2ResultTestRequestedColumn.Width = width - 110;
            p2RowPluseButton.Left = width - 54;
            p2RowMinusButton.Left = width - 28;

            p2SgsNameLabel.Left = width - 224;
            p2SgsNameLabel.Top = height - 152;

            p2ImageBox.Left = width - 224;
            p2ImageBox.Top = height - 127;

            p2NameEdit.Left = width - 224;
            p2NameEdit.Top = height - 30;
        }

        private void physical3Page_Resize(object sender, EventArgs e)
        {
            int width = physical3Page.Width;
            int height = physical3Page.Height;

            p3ClauseGrid.Size = new Size(width - 8, height - 201);
            p3ClauseDescriptionColumn.Width = width - 242;

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
            p4FlameSampleColumn.Width = (width - 30) / 2;
            p4FlameBurningRateColumn.Width = (width - 30) / 2;

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
            p5StuffTestItemColumn.Width = width - 210;

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

        public void Clear()
        {
            p1ClientNameEdit.Text = dataSet.ClientName;
            p1ClientAddressEdit.Text = dataSet.ClientAddress;
            p1FileNoEdit.Text = dataSet.FileNo;
            p1SampleDescriptionEdit.Text = dataSet.SampleDescription;
            p1DetailOfSampleEdit.Text = dataSet.DetailOfSample;
            p1ItemNoEdit.Text = dataSet.ItemNo;
            p1ManufacturerEdit.Text = dataSet.Manufacturer;
            p1CountryOfOriginEdit.Text = dataSet.CountryOfOrigin;
            p1CountryOfDestinationEdit.Text = "-";
            p1LabeledAgeEdit.Text = "None";
            p1TestAgeEdit.Text = "None";
            p1AssessedAgeEdit.Text = "All ages";
            p1ReceivedDateEdit.Text = dataSet.ReceivedTime.ToString("yyyy. MM. dd");
            p1TestPeriodEdit.Text = $"{dataSet.ReceivedTime.ToString("yyyy. MM. dd")}  to  {dataSet.RequiredTime.ToString("yyyy. MM. dd")}";
            p1ReportCommentEdit.Text = dataSet.ReportComments;

            PhysicalPage2Row p2Row = new PhysicalPage2Row();
            p2Row.No = 0;
            p2Row.Requested = "US Public Law 110-314(Comsumer Plroduct Safety Improvement Act of 2008, CPSIA):";
            p2Row.Conclusion = "-";
            page2Rows.Add(p2Row);

            p2Row = new PhysicalPage2Row();
            p2Row.No = 1;
            p2Row.Requested = "- ASTM F963-17: Standard Consumer Safety Specification on Toy Safety\r\n  (Excluding clause 4.3.5 Heavy Element)";
            p2Row.Conclusion = "PASS";
            page2Rows.Add(p2Row);

            p2Row = new PhysicalPage2Row();
            p2Row.No = 2;
            p2Row.Requested = "Flammability of toys(16 C.F.R. 1500.44)";
            p2Row.Conclusion = "PASS";
            page2Rows.Add(p2Row);

            p2Row = new PhysicalPage2Row();
            p2Row.No = 3;
            p2Row.Requested = "Small part(16 C.F.R. 1501)";
            p2Row.Conclusion = "PASS";
            page2Rows.Add(p2Row);

            p2Row = new PhysicalPage2Row();
            p2Row.No = 4;
            p2Row.Requested = "Sharp points and edges(16 C.F.R. 1500.48 and 49)";
            p2Row.Conclusion = "PASS";
            page2Rows.Add(p2Row);

            p2ResultNoColumn.SortOrder = ColumnSortOrder.Ascending;

            p3Desc1Edit.Text = "As specified in ASTM F963-17 standard consumer safety specification on toys safety.";
            p3Desc2Edit.Text = 
                "N/A = Not Applicable                **Visual Examination\r\n" + 
                "NT = Not tested as per client's request.\r\n\r\n" +
                "N.B. : - Only applicable clauses were shown";

            PhysicalPage3Row p3Row = new PhysicalPage3Row();
            p3Row.No = 0;
            p3Row.UnderLine = false;
            p3Row.Clause = "4";
            p3Row.Description = "Safety Requirements";
            p3Row.Result = "-";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 1;
            p3Row.UnderLine = false;
            p3Row.Clause = " 4.1";
            p3Row.Description = "Material Quality**";
            p3Row.Result = "Pass";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 2;
            p3Row.UnderLine = false;
            p3Row.Clause = " 4.2";
            p3Row.Description = "Flammability Test(16 C.F.R. 1500.44)";
            p3Row.Result = "Pass(See Note 1)";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 3;
            p3Row.UnderLine = false;
            p3Row.Clause = " 4.3";
            p3Row.Description = "Toxicology";
            p3Row.Result = "-";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 4;
            p3Row.UnderLine = false;
            p3Row.Clause = " 4.3.5";
            p3Row.Description = "Heavy Elements";
            p3Row.Result = "";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 5;
            p3Row.UnderLine = false;
            p3Row.Clause = "";
            p3Row.Description = "4.3.5.1 Hravy Elements in Paint/Similar Coating Materials";
            p3Row.Result = "";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 6;
            p3Row.UnderLine = false;
            p3Row.Clause = "";
            p3Row.Description = "4.3.5.2 Heavy Metal in Substrate Materials";
            p3Row.Result = "";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 7;
            p3Row.UnderLine = false;
            p3Row.Clause = " 4.3.7";
            p3Row.Description = "Styffing Materials";
            p3Row.Result = "Pass(See Note 2)";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 8;
            p3Row.UnderLine = false;
            p3Row.Clause = " 4.6";
            p3Row.Description = "Small Objects";
            p3Row.Result = "-";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 9;
            p3Row.UnderLine = false;
            p3Row.Clause = " 4.6.1";
            p3Row.Description = "Small Objects";
            p3Row.Result = "Pass";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 10;
            p3Row.UnderLine = false;
            p3Row.Clause = " 4.7";
            p3Row.Description = "Accessible Edges(16 C.F.R. 1500.49)";
            p3Row.Result = "Pass";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 11;
            p3Row.UnderLine = false;
            p3Row.Clause = " 4.9";
            p3Row.Description = "Accessible Points(16 C.F.R. 1500.48)";
            p3Row.Result = "Pass";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 12;
            p3Row.UnderLine = false;
            p3Row.Clause = " 4.14";
            p3Row.Description = "Cords, Straps and Elastic";
            p3Row.Result = "Pass";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 13;
            p3Row.UnderLine = true;
            p3Row.Clause = " 4.27";
            p3Row.Description = "Stuffed and Beanbag-Type Toys";
            p3Row.Result = "Pass";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 14;
            p3Row.UnderLine = false;
            p3Row.Clause = " 5";
            p3Row.Description = "Safety Labeling Requirements";
            p3Row.Result = "-";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 15;
            p3Row.UnderLine = true;
            p3Row.Clause = " 5.2";
            p3Row.Description = "Age Grading Labeling";
            p3Row.Result = "Pass";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 16;
            p3Row.UnderLine = false;
            p3Row.Clause = "7";
            p3Row.Description = "Producer's Markings";
            p3Row.Result = "-";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 17;
            p3Row.UnderLine = true;
            p3Row.Clause = " 7.1";
            p3Row.Description = "Producer's Markings";
            p3Row.Result = "Present";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 18;
            p3Row.UnderLine = false;
            p3Row.Clause = "8";
            p3Row.Description = "Test Methods";
            p3Row.Result = "-";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 19;
            p3Row.UnderLine = false;
            p3Row.Clause = " 8.5";
            p3Row.Description = "Normal Use Testings";
            p3Row.Result = "Pass";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 20;
            p3Row.UnderLine = false;
            p3Row.Clause = " 8.7";
            p3Row.Description = "Impact Test";
            p3Row.Result = "Pass";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 21;
            p3Row.UnderLine = false;
            p3Row.Clause = " 8.8";
            p3Row.Description = "Torque Test";
            p3Row.Result = "Pass";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 22;
            p3Row.UnderLine = false;
            p3Row.Clause = " 8.9";
            p3Row.Description = "Tension Test";
            p3Row.Result = "Pass";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 23;
            p3Row.UnderLine = false;
            p3Row.Clause = " 8.23";
            p3Row.Description = "Test for Loops and Cords";
            p3Row.Result = "Pass";
            page3Rows.Add(p3Row);

            p3Row = new PhysicalPage3Row();
            p3Row.No = 24;
            p3Row.UnderLine = false;
            p3Row.Clause = " 8.29";
            p3Row.Description = "Stuffing Materials Evaluation";
            p3Row.Result = "Pass";
            page3Rows.Add(p3Row);

            p3ClauseNoColumn.SortOrder = ColumnSortOrder.Ascending;

            p4Desc1Edit.Text = "Flammability Test(Clause 4.2)";
            p4Desc2Edit.Text =
                "*Burning rate has been rounded to the nearest one tenth of an inch per second.\r\n\r\n" +
                "Requirement: A toy / component is considered a \"flammable solid\" if it ignites and burns with a self-sustaining\r\n" +
                "             flame at a rate greater than 0.1 in./s along its major axis.";

            PhysicalPage4Row p4Row = new PhysicalPage4Row();
            p4Row.No = 0;
            p4Row.Sample = "Panda toy";
            p4Row.BurningRate = "0.1*";
            page4Rows.Add(p4Row);

            p4FlameNoColumn.SortOrder = ColumnSortOrder.Ascending;

            p5Desc1Edit.Text =
                "Suffing Materials(Clause 4.3.7)\r\n\r\n" +
                "Method: With reference to ASTM F963-17 Clause 8.29. Visual inspection is performed using a stereo widerfield\r\n" +
                "microscope, or equivalent, at 10 x magnification and adequate illumination.";
            p5Desc2Edit.Text = "Polyester fiber";

            PhysicalPage5Row p5Row = new PhysicalPage5Row();
            p5Row.No = 0;
            p5Row.TestItem = 
                "   1. Objectionable matter originating from\r\n" +
                "      Insect, bird and rodent or other animal\r\n" +
                "      infestation";
            p5Row.Result = "Absent";
            p5Row.Requirement = "Absent";
            page5Rows.Add(p5Row);

            p5Row = new PhysicalPage5Row();
            p5Row.No = 1;
            p5Row.TestItem = "Comment";
            p5Row.Result = "PASS";
            p5Row.Requirement = "-";
            page5Rows.Add(p5Row);

            p5StuffNoColumn.SortOrder = ColumnSortOrder.Ascending;

            p6ImageBox.Image = dataSet.Image;
            p6FileNoPanel.Text = dataSet.FileNo;
        }
    }

    public class PhysicalPage2Row
    {
        public int No { get; set; }

        public string Requested { get; set; }

        public string Conclusion { get; set; }

        public PhysicalPage2Row()
        {
            No = 0;
            Requested = "";
            Conclusion = "";
        }
    }

    public class PhysicalPage3Row
    {
        public int No { get; set; }

        public bool UnderLine { get; set; }

        public string Clause { get; set; }

        public string Description { get; set; }

        public string Result { get; set; }

        public PhysicalPage3Row()
        {
            No = 0;
            UnderLine = false;
            Clause = "";
            Description = "";
            Result = "";
        }
    }

    public class PhysicalPage4Row
    {
        public int No { get; set; }

        public string Sample { get; set; }

        public string BurningRate { get; set; }

        public PhysicalPage4Row()
        {
            No = 0;
            Sample = "";
            BurningRate = "";
        }
    }

    public class PhysicalPage5Row
    {
        public int No { get; set; }

        public string TestItem { get; set; }

        public string Result { get; set; }

        public string Requirement { get; set; }

        public PhysicalPage5Row()
        {
            No = 0;
            TestItem = "";
            Result = "";
            Requirement = "";
        }
    }
}
