using DevExpress.XtraSpreadsheet.PrintLayoutEngine;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;

namespace Sgs.ReportIntegration
{
    public class ChemicalQuery
    {
        public ChemicalMainDataSet MainSet { get; set; }

        public ChemicalImageDataSet ImageSet { get; set; }

        public ChemicalItemJoinDataSet JoinSet { get; set; }

        public ChemicalP2DataSet P2Set { get; set; }

        public StaffDataSet StaffSet { get; set; }

        public ProfJobDataSet ProfJobSet { get; set; }

        public ProfJobSchemeDataSet ProfJobSchemeSet { get; set; }

        public CtrlEditChemicalUs CtrlUs { get; set; }

        public CtrlEditChemicalEu CtrlEu { get; set; }

        private bool local;

        private ProductDataSet productSet { get; set; }

        private PartDataSet partSet { get; set; }

        public ChemicalQuery(bool local = false)
        {
            this.local = local;

            if (local == true)
            {
                MainSet = new ChemicalMainDataSet(AppRes.DB.Connect, null, null);
                ImageSet = new ChemicalImageDataSet(AppRes.DB.Connect, null, null);
                JoinSet = new ChemicalItemJoinDataSet(AppRes.DB.Connect, null, null);
                P2Set = new ChemicalP2DataSet(AppRes.DB.Connect, null, null);
                ProfJobSet = new ProfJobDataSet(AppRes.DB.Connect, null, null);
                ProfJobSchemeSet = new ProfJobSchemeDataSet(AppRes.DB.Connect, null, null);
                StaffSet = new StaffDataSet(AppRes.DB.Connect, null, null);
                CtrlUs = null;
                CtrlEu = null;
            }

            productSet = new ProductDataSet(AppRes.DB.Connect, null, null);
            partSet = new PartDataSet(AppRes.DB.Connect, null, null);
        }

        public void Insert(SqlTransaction trans = null)
        {
            EReportArea area = ProfJobSet.AreaNo;

            if (local == false)
            {
                trans = AppRes.DB.BeginTrans();
            }

            try
            {
                InsertMain(area, trans);
                InsertJoin(trans);
                InsertImage(trans);
                InsertPage2(trans);

                if (local == false)
                {
                    SetReportValidation(trans);
                    AppRes.DB.CommitTrans();
                }
            }
            catch (Exception e)
            {
                if (local == false)
                {
                    AppRes.DB.RollbackTrans();
                }
                else
                {
                    throw e;
                }
            }
        }

        public void Update()
        {
            if (local == true)
            {
                throw new Exception("Can't call ChemicalQuery.Update() method in Local transaction mode!");
            }

            EReportArea area = ProfJobSet.AreaNo;
            SqlTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                SaveMain(area, trans);
                SavePage2(area, trans);

                AppRes.DB.CommitTrans();
            }
            catch
            {
                AppRes.DB.RollbackTrans();
            }
        }

        public void Delete(SqlTransaction trans = null)
        {
            if (local == true)
            {
                throw new Exception("Can't call ChemicalQuery.Delete() method in Local transaction mode!");
            }

            string mainNo = MainSet.RecNo;
            trans = AppRes.DB.BeginTrans();

            try
            {
                ImageSet.RecNo = mainNo;
                ImageSet.Delete(trans);
                JoinSet.RecNo = mainNo;
                JoinSet.Delete(trans);
                P2Set.MainNo = mainNo;
                P2Set.Delete(trans);
                MainSet.Delete(trans);
                ResetReportValidation(trans);

                AppRes.DB.CommitTrans();
            }
            catch
            {
                AppRes.DB.RollbackTrans();
            }
        }

        private void InsertMain(EReportArea area, SqlTransaction trans)
        {
            MainSet.RecNo = ProfJobSet.JobNo;
            MainSet.RegTime = ProfJobSet.RegTime;
            MainSet.ReceivedTime = ProfJobSet.ReceivedTime;
            MainSet.RequiredTime = ProfJobSet.RequiredTime;
            MainSet.ReportedTime = ProfJobSet.ReportedTime;
            MainSet.Approval = false;
            MainSet.AreaNo = ProfJobSet.AreaNo;
            MainSet.MaterialNo = "";
            MainSet.P1ClientNo = ProfJobSet.ClientNo;
            MainSet.P1ClientName = ProfJobSet.ClientName;
            MainSet.P1ClientAddress = ProfJobSet.ClientAddress;
            MainSet.P1FileNo = ProfJobSet.FileNo;
            MainSet.P1SampleDescription = ProfJobSet.SampleRemark;
            MainSet.P1ItemNo = ProfJobSet.ItemNo;
            MainSet.P1OrderNo = "-";
            MainSet.P1Manufacturer = ProfJobSet.Manufacturer;
            MainSet.P1CountryOfOrigin = ProfJobSet.CountryOfOrigin;
            MainSet.P1CountryOfDestination = "-";
            MainSet.P1ReceivedDate = ProfJobSet.ReceivedTime.ToString("yyyy. MM. dd");
            MainSet.P1TestPeriod = $"{ProfJobSet.ReceivedTime.ToString("yyyy. MM. dd")}  to  {ProfJobSet.RequiredTime.ToString("yyyy. MM. dd")}";
            MainSet.P1TestMethod = "For further details, please refer to following page(s)";
            MainSet.P1TestResults = "For further details, please refer to following page(s)";
            MainSet.P1Comments = ProfJobSet.ReportComments;

            if (StaffSet.Empty == true)
            {
                MainSet.Approval = false;
                MainSet.P1Name = "";
            }
            else
            {
                MainSet.Approval = true;
                MainSet.P1Name = StaffSet.Name;
            }

            if (area == EReportArea.US)
            {
                MainSet.P1TestRequested =
                    "Selected test(s) as requested by applicant for compliance with Public Law 110-314(Consumer Product Safety Improvement Act of 2008, CPSIA):-\r\n" +
                    "- To determine Heavy Elements in the submitted samples with reference to ASTM F963-16\r\n" +
                    "    4.3.5.2-Heavy Metal in Substrate Materials";
                MainSet.P1Conclusion = "\r\n\r\n-\r\nPASS";
                MainSet.P2Description1 = "ASTM F963-16, Clause 4.3.5.2 - Heavy Elements in Toys Substrate Materials";
                MainSet.P2Description2 = "Method: With reference to ASTM F963-16 Clause 8.3. Analysis was performed by ICP-OES.";
                MainSet.P2Description3 =
                    "1. Black textile\r\n\r\n" +
                    "Note:    -   Soluble results shown are of the adjusted analytical result.\r\n" +
                    "         -   ND = Not Detected(<MDL)";
                MainSet.P3Description1 = "";
            }
            else
            {
                MainSet.P1TestRequested =
                    "EN71-3:2013+A3:2018-Migration of certain elements\r\n" +
                    "(By first action method testing only)";
                MainSet.P1Conclusion = "PASS";
                MainSet.P2Description1 = "EN71-3:2013+A3:2018 - Migration of certain elements";
                MainSet.P2Description2 = "Method : With reference to EN71-3:2013+A3:2018. Analysis of general elements was performed by ICP-OES.";
                MainSet.P2Description3 = ProfJobSet.SampleDescription;
                MainSet.P3Description1 =
                    "Note. 1. mg/kg = milligram per kilogram\r\n" +
                    "      2. ND = Not Detected(< MDL)\r\n" +
                    "      3. 1% = 10000 mg/kg = 10000 ppm\r\n" +
                    "      4. Soluble Chromium(III) = Soluble Total Chromium – Soluble Chromium(VI)\r\n" +
                    "      5. ^ = Confirmation test of soluble organic tin is not required in case of soluble tin, after conversion, does not exceed the soluble organic tin requirement as specified in EN71-3:2019.";
            }

            MainSet.Insert(trans);
        }

        private void InsertJoin(SqlTransaction trans)
        {
            string[] items = MainSet.P1ItemNo.Split(',');

            JoinSet.RecNo = MainSet.RecNo;
            foreach (string item in items)
            {
                JoinSet.PartNo = item.Trim();
                JoinSet.Insert(trans);
            }
        }

        private void InsertImage(SqlTransaction trans)
        {
            Bitmap signImage = null;

            if (StaffSet.Empty == false)
            {
                if (string.IsNullOrWhiteSpace(StaffSet.FName) == false)
                {
                    signImage = new Bitmap(StaffSet.FName);
                }
            }

            ImageSet.RecNo = MainSet.RecNo;
            ImageSet.Signature = signImage;
            ImageSet.Picture = ProfJobSet.Image;
            ImageSet.Insert(trans);
        }

        private void InsertPage2(SqlTransaction trans)
        {
            ProfJobSchemeSet.JobNo = MainSet.RecNo;
            ProfJobSchemeSet.Select(trans);
            ProfJobSchemeSet.Fetch();

            P2Set.MainNo = MainSet.RecNo;

            for (int i = 0; i < ProfJobSchemeSet.RowCount; i++)
            {
                ProfJobSchemeSet.Fetch(i);

                P2Set.Name = ProfJobSchemeSet.Name;
                P2Set.LoValue = ProfJobSchemeSet.LoValue;
                P2Set.HiValue = ProfJobSchemeSet.HiValue;
                P2Set.ReportValue = ProfJobSchemeSet.ReportValue;
                P2Set.FormatValue = ProfJobSchemeSet.FormatValue;
                P2Set.Insert(trans);
            }
        }

        private void SaveMain(EReportArea area, SqlTransaction trans)
        {
            if (area == EReportArea.US)
                CtrlUs.SetControlToDataSet();
            else
                CtrlEu.SetControlToDataSet();

            MainSet.Update(trans);
        }

        private void SavePage2(EReportArea area, SqlTransaction trans)
        {
            List<ChemicalPage2Row> rows = (area == EReportArea.US) ? CtrlUs.P2Rows : CtrlEu.P2Rows;

            foreach (ChemicalPage2Row row in rows)
            {
                P2Set.RecNo = row.RecNo;
                P2Set.FormatValue = row.FormatValue;
                P2Set.Update(trans);
            }
        }

        private void SetReportValidation(SqlTransaction trans)
        {
            partSet.Update(ProfJobSet.AreaNo, ProfJobSet.ItemNo.Split(','), ProfJobSet.JobNo, trans);
            productSet.UpdateValidSet(trans);
        }

        private void ResetReportValidation(SqlTransaction trans)
        {
            partSet.Update(MainSet.AreaNo, MainSet.P1ItemNo.Split(','), trans);
            productSet.UpdateValidReset(trans);
        }
    }
}
