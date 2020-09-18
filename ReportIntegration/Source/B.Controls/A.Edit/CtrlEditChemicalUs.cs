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

        public List<ChemicalPage2Row> P2Rows;

        public CtrlEditChemicalUs()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            P2Rows = new List<ChemicalPage2Row>();
            resultGrid.DataSource = P2Rows;

            for (int i = 0; i < 8; i++)
            {
                ChemicalPage2Row p2Row = new ChemicalPage2Row();
                p2Row.RecNo = i;
                p2Row.HiLimit = "0123";
                p2Row.LoLimit = "0123";
                p2Row.ReportLimit = "0123";
                p2Row.FormatValue = "ND";
                p2Row.Name = "AA";
                P2Rows.Add(p2Row);
            }
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
            p1NameEdit.Text = "";
            p1ImageBox.Image = ImageSet.Signature;
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
            ImageSet.Fetch();
            p3ImageBox.Image = ImageSet.Picture;
            p3FileNoPanel.Text = MainSet.P1FileNo;
        }
    }
}
