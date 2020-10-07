using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Ulee.Controls;

namespace Sgs.ReportIntegration
{
    public partial class CtrlEditChemicalUs : UlUserControlEng
    {
        public ChemicalMainDataSet MainSet;

        public ChemicalImageDataSet ImageSet;

        public ChemicalP2DataSet P2Set;

        public ChemicalP2ExtendDataSet P2ExtendSet;

        public List<ChemicalPage2Row> P2Rows;

        public List<ChemicalPage2ExtendRow> P2ExtendRows;

        private StaffDataSet staffSet;

        public CtrlEditChemicalUs()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            staffSet = new StaffDataSet(AppRes.DB.Connect, null, null);

            P2ExtendRows = new List<ChemicalPage2ExtendRow>();
            leadResultGrid.DataSource = P2ExtendRows;

            P2Rows = new List<ChemicalPage2Row>();
            metalResultGrid.DataSource = P2Rows;
        }

        private void chemical1Page_Resize(object sender, EventArgs e)
        {
            int width = chemical1Page.Width;

            p1ClientNameEdit.Width = width - 172;
            p1ClientAddressEdit.Width = width - 172;
            p1SampleDescriptionEdit.Width = width - 410;
            p1ItemNoEdit.Width = width - 172;
            p1OrderNoEdit.Width = width - 172;
            p1ManufacturerEdit.Width = width - 172;
            p1CountryOfDestinationEdit.Width = width - 410;
            p1TestPeriodEdit.Width = width - 410;
            p1TestMethodEdit.Width = width - 172;
            p1TestResultEdit.Width = width - 172;
            p1ReportCommentEdit.Width = width - 172;
            p1TestReqEdit.Width = width - 82;
            p1ConclusionLabel.Left = width - 74;
            p1ConclusionEdit.Left = width - 73;
        }

        private void chemical2Page_Resize(object sender, EventArgs e)
        {
            int width = chemical2Page.Width;
            int height = chemical2Page.Height;

            p2Desc1Edit.Width = width - 10;
            p2Desc2Edit.Width = width - 10;
            p2Desc3Edit.Size = new Size(width - 10, height - 448);
            p2Desc4Edit.Width = width - 10;

            leadResultGrid.Width = width - 10;
            leadResultGrid.RecordWidth = width - 173;

            int colWidth = (metalResultGrid.Width - 158) / 8;
            metalResultGrid.Width = width - 10;
            metalResultGrid.RecordWidth = colWidth;
            metalResultGrid.RowHeaderWidth = metalResultGrid.Width - (colWidth * 8) - 12;
        }

        private void chemical3Page_Resize(object sender, EventArgs e)
        {
            imagePanel.Size = new Size(chemical3Page.Width - 16, chemical3Page.Height - 70);
            p3ImageBox.Size = new Size(imagePanel.Width - 16, imagePanel.Height - 74);
            p3DescPanel.Width = imagePanel.Width - 16;

            p3FileNoPanel.Top = chemical3Page.Height - 56;
            p3FileNoPanel.Width = chemical3Page.Width - 16;
        }

        public void SetControlToDataSet()
        {
            leadResultGrid.PostEditor();
            metalResultGrid.PostEditor();

            MainSet.P1ClientName = p1ClientNameEdit.Text;
            MainSet.P1ClientAddress = p1ClientAddressEdit.Text;
            MainSet.P1FileNo = p1FileNoEdit.Text;
            MainSet.P1SampleDescription = p1SampleDescriptionEdit.Text;
            MainSet.P1ItemNo = p1ItemNoEdit.Text;
            MainSet.P1Manufacturer = p1ManufacturerEdit.Text;
            MainSet.P1CountryOfOrigin = p1CountryOfOriginEdit.Text;
            MainSet.P1CountryOfDestination = p1CountryOfDestinationEdit.Text;
            MainSet.P1ReceivedDate = p1ReceivedDateEdit.Text;
            MainSet.P1TestPeriod = p1TestPeriodEdit.Text;
            MainSet.P1TestMethod = p1TestMethodEdit.Text;
            MainSet.P1TestResults = p1TestResultEdit.Text;
            MainSet.P1Comments = p1ReportCommentEdit.Text;
            MainSet.P1TestRequested = p1TestReqEdit.Text;
            MainSet.P1Conclusion = p1ConclusionEdit.Text;
            MainSet.P1Name = p1NameEdit.Text;
            MainSet.P2Description1 = p2Desc1Edit.Text;
            MainSet.P2Description2 = p2Desc2Edit.Text;
            MainSet.P2Description3 = p2Desc3Edit.Text;
            MainSet.P3Description1 = "";
        }

        public void SetDataSetToControl()
        {
            SetDataSetToPage1();

            P2Set.MainNo = MainSet.RecNo;
            P2Set.Select();
            P2ExtendSet.RecNo = MainSet.RecNo;
            P2ExtendSet.Select();
            SetDataSetToPage2();

            ImageSet.RecNo = MainSet.RecNo;
            ImageSet.Select();
            SetDataSetToPage3();

            RefreshGrid();
        }

        private void SetDataSetToPage1()
        {
            p1ClientNameEdit.Text = MainSet.P1ClientName;
            p1ClientAddressEdit.Text = MainSet.P1ClientAddress;
            p1FileNoEdit.Text = MainSet.P1FileNo;
            p1SampleDescriptionEdit.Text = MainSet.P1SampleDescription;
            p1ItemNoEdit.Text = MainSet.P1ItemNo;
            p1OrderNoEdit.Text = MainSet.P1OrderNo;
            p1ManufacturerEdit.Text = MainSet.P1Manufacturer;
            p1CountryOfOriginEdit.Text = MainSet.P1CountryOfOrigin;
            p1CountryOfDestinationEdit.Text = MainSet.P1CountryOfDestination;
            p1ReceivedDateEdit.Text = MainSet.P1ReceivedDate;
            p1TestPeriodEdit.Text = MainSet.P1TestPeriod;
            p1TestMethodEdit.Text = MainSet.P1TestMethod;
            p1TestResultEdit.Text = MainSet.P1TestResults;
            p1ReportCommentEdit.Text = MainSet.P1Comments;
            p1TestReqEdit.Text = MainSet.P1TestRequested;
            p1ConclusionEdit.Text = MainSet.P1Conclusion;
            p2Desc1Edit.Text = MainSet.P2Description1;
            p2Desc2Edit.Text = MainSet.P2Description2;
            p2Desc3Edit.Text = MainSet.P2Description3;
        }

        private void SetDataSetToPage2()
        {
            P2ExtendRows.Clear();
            for (int i = 0; i < P2ExtendSet.RowCount; i++)
            {
                P2ExtendSet.Fetch(i);

                ChemicalPage2ExtendRow p2ExtendRow = new ChemicalPage2ExtendRow();
                p2ExtendRow.RecNo = P2ExtendSet.RecNo;
                p2ExtendRow.TotalLimit = "100";
                p2ExtendRow.ReportLimit = P2ExtendSet.ReportValue;
                p2ExtendRow.Message = "Total Result(s)(mg/kg)";
                p2ExtendRow.FormatValue = P2ExtendSet.FormatValue;
                p2ExtendRow.Name = P2ExtendSet.Name;
                P2ExtendRows.Add(p2ExtendRow);
            }

            P2Rows.Clear();
            for (int i = 0; i < P2Set.RowCount; i++)
            {
                P2Set.Fetch(i);

                ChemicalPage2Row p2Row = new ChemicalPage2Row();
                p2Row.RecNo = P2Set.RecNo;
                p2Row.HiLimit = P2Set.HiValue;
                p2Row.LoLimit = P2Set.LoValue;
                p2Row.ReportLimit = P2Set.ReportValue;
                p2Row.FormatValue = P2Set.FormatValue;
                p2Row.Name = P2Set.Name;
                P2Rows.Add(p2Row);
            }
        }

        private void SetDataSetToPage3()
        {
            ImageSet.Fetch();

            p3ImageBox.Image = ImageSet.Picture;
            p3FileNoPanel.Text = MainSet.P1FileNo;

            if (string.IsNullOrWhiteSpace(MainSet.StaffNo) == false)
            {
                staffSet.StaffNo = MainSet.StaffNo;
                staffSet.Select();
                staffSet.Fetch();

                if (staffSet.Signature != null)
                {
                    p1ImageBox.Image = staffSet.Signature;
                    p1NameEdit.Text = staffSet.FirstName + " " + staffSet.LastName;
                }
            }
        }

        private void RefreshGrid()
        {
            leadResultGrid.BeginUpdate();

            try
            {
                leadResultGrid.Refresh();
            }
            finally
            {
                leadResultGrid.EndUpdate();
            }

            metalResultGrid.BeginUpdate();

            try
            {
                metalResultGrid.Refresh();
            }
            finally
            {
                metalResultGrid.EndUpdate();
            }
        }
    }
}
