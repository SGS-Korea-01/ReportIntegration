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
    public partial class CtrlEditChemicalEu : UlUserControlEng
    {
        public ChemicalMainDataSet MainSet;

        public ChemicalImageDataSet ImageSet;

        public ChemicalP2DataSet P2Set;

        public List<ChemicalPage2Row> P2Rows;

        private StaffDataSet staffSet;

        public CtrlEditChemicalEu()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            staffSet = new StaffDataSet(AppRes.DB.Connect, null, null);

            P2Rows = new List<ChemicalPage2Row>();
            resultGrid.DataSource = P2Rows;
        }

        private void approveButton_Click(object sender, EventArgs e)
        {
            switch (approveButton.Text)
            {
                case "Approve":
                    SetApproval(AppRes.UserId);
                    break;

                case "Disapprove":
                    SetApproval("");
                    break;
            }
        }

        private void chemical1Page_Resize(object sender, EventArgs e)
        {
            int width = chemical1Page.Width;

            p1ClientNameEdit.Width = width - 134;
            p1ClientAddressEdit.Width = width - 134;
            p1FileNoEdit.Width = width - 134;
            p1SampleDescriptionEdit.Width = width - 134;
            p1ItemNoEdit.Width = width - 134;
            p1OrderNoEdit.Width = width - 134;
            p1ManufacturerEdit.Width = width - 134;
            p1CountryOfOriginEdit.Width = width - 134;
            p1CountryOfDestinationEdit.Width = width - 134;
            p1ReceivedDateEdit.Width = width - 134;
            p1TestPeriodEdit.Width = width - 134;
            p1TestResultEdit.Width = width - 134;
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

            resultGrid.Width = width - 10;
            resultGrid.Height = height - 198;

            resultItemColumn.Width = width - 362;

            p2SampleDescLabel.Top = height - 62;
            p2Desc3Edit.Top = height - 37;
            p2Desc3Edit.Width = width - 10;
        }

        private void chemical3Page_Resize(object sender, EventArgs e)
        {
            int width = chemical3Page.Width;
            int height = chemical3Page.Height;

            p3Desc1Edit.Width = width - 16;

            imagePanel.Size = new Size(width - 16, height - 162);
            p3ImageBox.Size = new Size(imagePanel.Width - 16, imagePanel.Height - 72);

            p3DescPanel.Width = imagePanel.Width - 16;
            p3FileNoPanel.Top = height - 56;
            p3FileNoPanel.Width = width - 16;
        }

        public void SetControlToDataSet()
        {
            resultGridView.PostEditor();

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
            MainSet.P1TestResults = p1TestResultEdit.Text;
            MainSet.P1TestRequested = p1TestReqEdit.Text;
            MainSet.P1Conclusion = p1ConclusionEdit.Text;
            MainSet.P1Name = p1NameEdit.Text;
            MainSet.P2Description1 = p2Desc1Edit.Text;
            MainSet.P2Description2 = p2Desc2Edit.Text;
            MainSet.P2Description3 = p2Desc3Edit.Text;
            MainSet.P2Description4 = "";
            MainSet.P3Description1 = p3Desc1Edit.Text;
        }

        public void SetDataSetToControl()
        {
            SetDataSetToPage1();

            P2Set.MainNo = MainSet.RecNo;
            P2Set.Select();
            SetDataSetToPage2();

            ImageSet.RecNo = MainSet.RecNo;
            ImageSet.Select();
            SetDataSetToPage3();

            AppHelper.RefreshGridData(resultGridView);
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
            p1TestResultEdit.Text = MainSet.P1TestResults;
            p1TestReqEdit.Text = MainSet.P1TestRequested;
            p1ConclusionEdit.Text = MainSet.P1Conclusion;
            p2Desc1Edit.Text = MainSet.P2Description1;
            p2Desc2Edit.Text = MainSet.P2Description2;
            p2Desc3Edit.Text = MainSet.P2Description3;
        }

        private void SetDataSetToPage2()
        {
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
            p3Desc1Edit.Text = MainSet.P3Description1;

            ImageSet.Fetch();

            p3ImageBox.Image = ImageSet.Picture;
            p3FileNoPanel.Text = MainSet.P1FileNo;

            if (string.IsNullOrWhiteSpace(MainSet.StaffNo) == false)
            {
                SetApproval(MainSet.StaffNo);
            }

            approveButton.Visible = (AppRes.Authority == EReportAuthority.Manager) ? true : false;
        }

        private void SetApproval(string staffNo)
        {
            if (string.IsNullOrWhiteSpace(staffNo) == true)
            {
                p1ImageBox.Image = null;
                p1NameEdit.Text = "";
                approveButton.Text = "Approve";
            }
            else
            {
                staffSet.StaffNo = staffNo;
                staffSet.Select();
                staffSet.Fetch();

                if (staffSet.Signature != null)
                {
                    p1ImageBox.Image = staffSet.Signature;
                    p1NameEdit.Text = staffSet.FirstName + " " + staffSet.LastName;
                    approveButton.Text = "Disapprove";
                }
                else
                {
                    approveButton.Text = "Approve";
                }
            }
        }
    }
}
