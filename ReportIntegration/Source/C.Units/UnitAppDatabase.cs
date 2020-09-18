using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

using Ulee.Database.SqlServer;
using Ulee.Utils;

namespace Sgs.ReportIntegration
{
    public class AppDatabase : UlSqlServer
    {
        public SqlConnection Connect { get { return connect; } }

        public AppDatabase(string connectString = null) : base(connectString)
        {
        }

        public new void Open()
        {
            base.Open();
            AppRes.DbLog[ELogTag.Note] = $"Open MS-SQL Server";
        }

        public new void Close()
        {
            base.Close();
            AppRes.DbLog[ELogTag.Note] = $"Close MS-SQL Server";
        }
    }

    public class BomDataSet : UlSqlDataSet
    {
        public Int64 RecNo { get; set; }

        public DateTime RegTime { get; set; }

        public EReportArea AreaNo { get; set; }

        public string FName { get; set; }

        public string FPath { get; set; }

        public string FullFName
        {
            get { return Path.Combine(FPath, FName); }
            set 
            {
                FName = Path.GetFileName(value);
                FPath = Path.GetDirectoryName(value); 
            }
        }

        public string From { get; set; }

        public string To { get; set; }

        public BomDataSet(SqlConnection connect, SqlCommand command, SqlDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(SqlTransaction trans = null)
        {
            string sql = " select * from TB_BOM where pk_recno>0 ";

            if (AreaNo != EReportArea.None)
            {
                sql += $" and areano={(int)AreaNo} ";
            }
            if (string.IsNullOrWhiteSpace(FName) == false)
            {
                sql += $" and fname like '%%{FName}%%' ";
            }
            if (string.IsNullOrWhiteSpace(From) == false)
            {
                if (From == To)
                {
                    sql += $" and regtime like '{From}%%' ";
                }
                else
                {
                    sql += $" and (regtime>='{From} 00:00:00.000' ";
                    sql += $" and regtime<='{To} 23:59:59.999') ";
                }
            }

            SetTrans(trans);
            command.CommandText = sql;
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(SqlTransaction trans = null)
        {
            string sql =
                $" insert into TB_BOM values " +
                $" ('{RegTime.ToString(AppRes.csDateTimeFormat)}', {(int)AreaNo}, '{FName}', '{FPath}'); " +
                $" select cast(scope_identity() as bigint); ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                RecNo = (Int64)command.ExecuteScalar();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                RegTime = DateTime.Now;
                AreaNo = EReportArea.US;
                FName = "";
                FPath = "";
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            RegTime = Convert.ToDateTime(row["regtime"]);
            AreaNo = (EReportArea)Convert.ToInt32(row["areano"]);
            FName = Convert.ToString(row["fname"]);
            FPath = Convert.ToString(row["fpath"]);
        }
    }

    public class ProductDataSet : UlSqlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 BomNo { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public Bitmap Image { get; set; }

        private ImageConverter imageConvert;

        public ProductDataSet(SqlConnection connect, SqlCommand command, SqlDataAdapter adapter)
            : base(connect, command, adapter)
        {
            imageConvert = new ImageConverter();
        }

        public void Select(SqlTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_PRODUCT " +
                $" where fk_bomno={BomNo} ";
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(SqlTransaction trans = null)
        {
            string sql =
                $" insert into TB_PRODUCT values " +
                $" ({BomNo}, '{Code}', '{Name}', @image); " +
                $" select cast(scope_identity() as bigint); ";

            byte[] imageRaw = (Image == null) ? null : (byte[])imageConvert.ConvertTo(Image, typeof(byte[]));

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;

                command.Parameters.Clear();
                command.Parameters.Add("@image", SqlDbType.Image);
                command.Parameters["@image"].Value = imageRaw;

                RecNo = (Int64)command.ExecuteScalar();

                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                BomNo = 0;
                Code = "";
                Name = "";
                Image = null;
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            BomNo = Convert.ToInt64(row["fk_bomno"]);
            Code = Convert.ToString(row["code"]);
            Name = Convert.ToString(row["name"]);
            byte[] imageRaw = (byte[])row["image"];

            if (imageRaw == null) 
                Image = null;
            else 
                Image = new Bitmap(new MemoryStream(imageRaw));
        }
    }

    public class PartDataSet : UlSqlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 ProductNo { get; set; }

        public string Name { get; set; }

        public string MaterialNo { get; set; }

        public string MaterialName { get; set; }

        public PartDataSet(SqlConnection connect, SqlCommand command, SqlDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(SqlTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_PART " +
                $" where fk_productno={ProductNo} ";
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(SqlTransaction trans = null)
        {
            string sql =
                $" insert into TB_PART values " +
                $" ({ProductNo}, '{Name}', '{MaterialNo}', '{MaterialName}'); " +
                $" select cast(scope_identity() as bigint); ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                RecNo = (Int64)command.ExecuteScalar();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                ProductNo = 0;
                Name = "";
                MaterialNo = "";
                MaterialName = "";
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            ProductNo = Convert.ToInt64(row["fk_productno"]);
            Name = Convert.ToString(row["name"]);
            MaterialNo = Convert.ToString(row["materialno"]);
            MaterialName = Convert.ToString(row["materialname"]);
        }
    }

    public class PhysicalReportDataSet : UlSqlDataSet
    {
        public Int64 RecNo { get; set; }

        public PhysicalReportDataSet(SqlConnection connect, SqlCommand command, SqlDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(SqlTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_PHYMAIN where pk_recno={RecNo}; " +
                $" select * from TB_PHYP2 where fk_phymainno={RecNo}; " +
                $" select * from TB_PHYP3 where fk_phymainno={RecNo}; " +
                $" select * from TB_PHYP40 where fk_phymainno={RecNo}; " +
                $" select * from TB_PHYP41 where fk_phymainno={RecNo}; " +
                $" select * from TB_PHYP5 where fk_phymainno={RecNo}; " +
                $" select * from TB_PHYIMAGE where fk_phymainno={RecNo}; ";
            dataSet.Clear();
            dataSet.Tables.Clear();
            dataAdapter.Fill(dataSet);
        }
    }

    public class PhysicalMainDataSet : UlSqlDataSet
    {
        public Int64 RecNo { get; set; }

        public DateTime RegTime { get; set; }

        public DateTime ReceivedTime { get; set; }

        public DateTime RequiredTime { get; set; }

        public DateTime ReportedTime { get; set; }

        public bool Approval { get; set; }

        public EReportArea AreaNo { get; set; }

        public string ProductNo { get; set; }

        public string JobNo { get; set; }

        public string P1ClientNo { get; set; }

        public string P1ClientName { get; set; }

        public string P1ClientAddress { get; set; }

        public string P1FileNo { get; set; }

        public string P1SampleDescription { get; set; }

        public string P1DetailOfSample { get; set; }

        public string P1ItemNo { get; set; }

        public string P1OrderNo { get; set; }

        public string P1Packaging { get; set; }

        public string P1Instruction { get; set; }

        public string P1Buyer { get; set; }

        public string P1Manufacturer { get; set; }

        public string P1CountryOfOrigin { get; set; }

        public string P1CountryOfDestination { get; set; }

        public string P1LabeledAge { get; set; }

        public string P1TestAge { get; set; }

        public string P1AssessedAge { get; set; }

        public string P1ReceivedDate { get; set; }

        public string P1TestPeriod { get; set; }

        public string P1TestMethod { get; set; }

        public string P1TestResults { get; set; }

        public string P1Comments { get; set; }

        public string P2Name { get; set; }

        public string P3Description1 { get; set; }

        public string P3Description2 { get; set; }

        public string P4Description1 { get; set; }

        public string P4Description2 { get; set; }

        public string P4Description3 { get; set; }

        public string P5Description1 { get; set; }

        public string P5Description2 { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public EReportApproval ReportApproval { get; set; }

        public PhysicalMainDataSet(SqlConnection connect, SqlCommand command, SqlDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(SqlTransaction trans = null)
        {
            string sql = " select * from TB_PHYMAIN where pk_recno>0 ";

            if (ReportApproval != EReportApproval.None)
            {
                sql += $" and approval={(int)ReportApproval} ";
            }
            if (AreaNo != EReportArea.None)
            {
                sql += $" and areano={(int)AreaNo} ";
            }
            if (string.IsNullOrWhiteSpace(ProductNo) == false)
            {
                sql += $" and productno like '{ProductNo}%%' ";
            }
            if (string.IsNullOrWhiteSpace(From) == false)
            {
                if (From == To)
                {
                    sql += $" and regtime like '{From}%%' ";
                }
                else
                {
                    sql += $" and (regtime>='{From} 00:00:00.000' ";
                    sql += $" and regtime<='{To} 23:59:59.999') ";
                }
            }

            SetTrans(trans);
            command.CommandText = sql;
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(SqlTransaction trans = null)
        {
            string sql =
                $" insert into TB_PHYMAIN values ( " +
                $" '{RegTime.ToString(AppRes.csDateTimeFormat)}', '{ReceivedTime.ToString(AppRes.csDateTimeFormat)}', " +
                $" '{RequiredTime.ToString(AppRes.csDateTimeFormat)}', '{ReportedTime.ToString(AppRes.csDateTimeFormat)}', " +
                $" {Convert.ToInt32(Approval)}, {(int)AreaNo}, '{ProductNo.Replace("'", "''")}', '{JobNo.Replace("'", "''")}', " + 
                $" '{P1ClientNo.Replace("'", "''")}', '{P1ClientName.Replace("'", "''")}', '{P1ClientAddress.Replace("'", "''")}', " +
                $" '{P1FileNo.Replace("'", "''")}', '{P1SampleDescription.Replace("'", "''")}', '{P1DetailOfSample.Replace("'", "''")}', " +
                $" '{P1ItemNo.Replace("'", "''")}', '{P1OrderNo.Replace("'", "''")}', '{P1Packaging.Replace("'", "''")}', " +
                $" '{P1Instruction.Replace("'", "''")}', '{P1Buyer.Replace("'", "''")}', '{P1Manufacturer.Replace("'", "''")}', " + 
                $" '{P1CountryOfOrigin.Replace("'", "''")}', '{P1CountryOfDestination.Replace("'", "''")}', '{P1LabeledAge.Replace("'", "''")}', " +
                $" '{P1TestAge.Replace("'", "''")}', '{P1AssessedAge.Replace("'", "''")}', '{P1ReceivedDate.Replace("'", "''")}', " +
                $" '{P1TestPeriod.Replace("'", "''")}', '{P1TestMethod.Replace("'", "''")}', '{P1TestResults.Replace("'", "''")}', " + 
                $" '{P1Comments.Replace("'", "''")}', '{P2Name.Replace("'", "''")}', '{P3Description1.Replace("'", "''")}', " +
                $" '{P3Description2.Replace("'", "''")}', '{P4Description1.Replace("'", "''")}', '{P4Description2.Replace("'", "''")}', " + 
                $" '{P4Description3.Replace("'", "''")}', '{P5Description1.Replace("'", "''")}', '{P5Description2.Replace("'", "''")}'); " +
                $" select cast(scope_identity() as bigint); ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                RecNo = (Int64)command.ExecuteScalar();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Update(SqlTransaction trans = null)
        {
            string sql =
                $" update TB_PHYMAIN set approval={Convert.ToInt32(Approval)}, areano={(int)AreaNo}, productno='{ProductNo.Replace("'", "''")}', jobno='{JobNo.Replace("'", "''")}', " +
                $" p1clientno='{P1ClientNo.Replace("'", "''")}', p1clientname='{P1ClientName.Replace("'", "''")}', p1clientaddress='{P1ClientAddress.Replace("'", "''")}', p1fileno='{P1FileNo.Replace("'", "''")}', " +
                $" p1sampledesc='{P1SampleDescription.Replace("'", "''")}', p1detailsample='{P1DetailOfSample.Replace("'", "''")}', p1itemno='{P1ItemNo.Replace("'", "''")}', p1orderno='{P1OrderNo.Replace("'", "''")}', " +
                $" p1packaging='{P1Packaging.Replace("'", "''")}', p1instruction='{P1Instruction.Replace("'", "''")}', p1buyer='{P1Buyer.Replace("'", "''")}', p1manufacturer='{P1Manufacturer.Replace("'", "''")}', " +
                $" p1countryorigin='{P1CountryOfOrigin.Replace("'", "''")}', p1countrydest='{P1CountryOfDestination.Replace("'", "''")}', p1labelage='{P1LabeledAge.Replace("'", "''")}', " +
                $" p1testage='{P1TestAge.Replace("'", "''")}', p1assessedage='{P1AssessedAge.Replace("'", "''")}', p1recevdate='{P1ReceivedDate.Replace("'", "''")}', p1testperiod='{P1TestPeriod.Replace("'", "''")}', " +
                $" p1testmethod='{P1TestMethod.Replace("'", "''")}', p1testresult='{P1TestResults.Replace("'", "''")}', p1comment='{P1Comments.Replace("'", "''")}', p2name='{P2Name.Replace("'", "''")}', " +
                $" p3desc1='{P3Description1.Replace("'", "''")}', p3desc2='{P3Description2.Replace("'", "''")}', p4desc1='{P4Description1.Replace("'", "''")}', p4desc2='{P4Description2.Replace("'", "''")}', " +
                $" p4desc3='{P4Description3.Replace("'", "''")}', p5desc1='{P5Description1.Replace("'", "''")}', p5desc2='{P5Description2.Replace("'", "''")}' " +
                $" where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(SqlTransaction trans = null)
        {
            string sql =
                $" delete from TB_PHYMAIN " +
                $" where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                RegTime = DateTime.Now;
                ReceivedTime = DateTime.Now;
                RequiredTime = DateTime.Now;
                ReportedTime = DateTime.Now;
                Approval = false;
                AreaNo = EReportArea.None;
                ProductNo = "";
                JobNo = "";
                P1ClientNo = "";
                P1ClientName = "";
                P1ClientAddress = "";
                P1FileNo = "";
                P1SampleDescription = "";
                P1DetailOfSample = "";
                P1ItemNo = "";
                P1OrderNo = "";
                P1Packaging = "";
                P1Instruction = "";
                P1Buyer = "";
                P1Manufacturer = "";
                P1CountryOfOrigin = "";
                P1CountryOfDestination = "";
                P1LabeledAge = "";
                P1TestAge = "";
                P1AssessedAge = "";
                P1ReceivedDate = "";
                P1TestPeriod = "";
                P1TestMethod = "";
                P1TestResults = "";
                P1Comments = "";
                P2Name = "";
                P3Description1 = "";
                P3Description2 = "";
                P4Description1 = "";
                P4Description2 = "";
                P4Description3 = "";
                P5Description1 = "";
                P5Description2 = "";
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            RegTime = Convert.ToDateTime(row["regtime"]);
            ReceivedTime = Convert.ToDateTime(row["receivedtime"]);
            RequiredTime = Convert.ToDateTime(row["requiredtime"]);
            ReportedTime = Convert.ToDateTime(row["reportedtime"]);
            Approval = Convert.ToBoolean(row["approval"]);
            AreaNo = (EReportArea)Convert.ToInt32(row["areano"]);
            ProductNo = Convert.ToString(row["productno"]);
            JobNo = Convert.ToString(row["jobno"]);
            P1ClientNo = Convert.ToString(row["p1clientno"]);
            P1ClientName = Convert.ToString(row["p1clientname"]);
            P1ClientAddress = Convert.ToString(row["p1clientaddress"]);
            P1FileNo = Convert.ToString(row["p1fileno"]);
            P1SampleDescription = Convert.ToString(row["p1sampledesc"]);
            P1DetailOfSample = Convert.ToString(row["p1detailsample"]);
            P1ItemNo = Convert.ToString(row["p1itemno"]);
            P1OrderNo = Convert.ToString(row["p1orderno"]);
            P1Packaging = Convert.ToString(row["p1packaging"]);
            P1Instruction = Convert.ToString(row["p1instruction"]);
            P1Buyer = Convert.ToString(row["p1buyer"]);
            P1Manufacturer = Convert.ToString(row["p1manufacturer"]);
            P1CountryOfOrigin = Convert.ToString(row["p1countryorigin"]);
            P1CountryOfDestination = Convert.ToString(row["p1countrydest"]);
            P1LabeledAge = Convert.ToString(row["p1labelage"]);
            P1TestAge = Convert.ToString(row["p1testage"]);
            P1AssessedAge = Convert.ToString(row["p1assessedage"]);
            P1ReceivedDate = Convert.ToString(row["p1recevdate"]);
            P1TestPeriod = Convert.ToString(row["p1testperiod"]);
            P1TestMethod = Convert.ToString(row["p1testmethod"]);
            P1TestResults = Convert.ToString(row["p1testresult"]);
            P1Comments = Convert.ToString(row["p1comment"]);
            P2Name = Convert.ToString(row["p2name"]);
            P3Description1 = Convert.ToString(row["p3desc1"]);
            P3Description2 = Convert.ToString(row["p3desc2"]);
            P4Description1 = Convert.ToString(row["p4desc1"]);
            P4Description2 = Convert.ToString(row["p4desc2"]);
            P4Description3 = Convert.ToString(row["p4desc3"]);
            P5Description1 = Convert.ToString(row["p5desc1"]);
            P5Description2 = Convert.ToString(row["p5desc2"]);
        }
    }

    public class PhysicalP2DataSet : UlSqlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 MainNo { get; set; }

        public int No { get; set; }

        public bool Line { get; set; }

        public string Requested { get; set; }

        public string Conclusion { get; set; }

        public PhysicalP2DataSet(SqlConnection connect, SqlCommand command, SqlDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(SqlTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_PHYP2 " +
                $" where fk_phymainno={MainNo} " +
                $" order by no asc ";
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(SqlTransaction trans = null)
        {
            string sql =
                $" insert into TB_PHYP2 values " +
                $" ({MainNo}, {No}, {Convert.ToInt32(Line)}, '{Requested.Replace("'", "''")}', '{Conclusion.Replace("'", "''")}'); " +
                $" select cast(scope_identity() as bigint); ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                RecNo = (Int64)command.ExecuteScalar();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(SqlTransaction trans = null)
        {
            string sql =
                $" delete from TB_PHYP2 " +
                $" where fk_phymainno={MainNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                MainNo = 0;
                No = 0;
                Line = false;
                Requested = "";
                Conclusion = "";
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            MainNo = Convert.ToInt64(row["fk_phymainno"]);
            No = Convert.ToInt32(row["no"]);
            Line = Convert.ToBoolean(row["line"]);
            Requested = Convert.ToString(row["requested"]);
            Conclusion = Convert.ToString(row["conclusion"]);
        }
    }

    public class PhysicalP3DataSet : UlSqlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 MainNo { get; set; }

        public int No { get; set; }

        public bool Line { get; set; }

        public string Clause { get; set; }

        public string Description { get; set; }

        public string Result { get; set; }

        public PhysicalP3DataSet(SqlConnection connect, SqlCommand command, SqlDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(SqlTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_PHYP3 " +
                $" where fk_phymainno={MainNo} " +
                $" order by no asc ";
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(SqlTransaction trans = null)
        {
            string sql =
                $" insert into TB_PHYP3 values " +
                $" ({MainNo}, {No}, {Convert.ToInt32(Line)}, '{Clause.Replace("'", "''")}', '{Description.Replace("'", "''")}', '{Result.Replace("'", "''")}'); " +
                $" select cast(scope_identity() as bigint); ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                RecNo = (Int64)command.ExecuteScalar();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(SqlTransaction trans = null)
        {
            string sql =
                $" delete from TB_PHYP3 " +
                $" where fk_phymainno={MainNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                MainNo = 0;
                No = 0;
                Line = false;
                Clause = "";
                Description = "";
                Result = "";
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            MainNo = Convert.ToInt64(row["fk_phymainno"]);
            No = Convert.ToInt32(row["no"]);
            Line = Convert.ToBoolean(row["line"]);
            Clause = Convert.ToString(row["clause"]);
            Description = Convert.ToString(row["description"]);
            Result = Convert.ToString(row["result"]);
        }
    }

    public class PhysicalP40DataSet : UlSqlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 MainNo { get; set; }

        public int No { get; set; }

        public bool Line { get; set; }

        public string Clause { get; set; }

        public string Description { get; set; }

        public string Result { get; set; }

        public PhysicalP40DataSet(SqlConnection connect, SqlCommand command, SqlDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(SqlTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_PHYP40 " +
                $" where fk_phymainno={MainNo} " +
                $" order by no asc ";
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(SqlTransaction trans = null)
        {
            string sql =
                $" insert into TB_PHYP40 values " +
                $" ({MainNo}, {No}, {Convert.ToInt32(Line)}, '{Clause.Replace("'", "''")}', '{Description.Replace("'", "''")}', '{Result.Replace("'", "''")}'); " +
                $" select cast(scope_identity() as bigint); ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                RecNo = (Int64)command.ExecuteScalar();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(SqlTransaction trans = null)
        {
            string sql =
                $" delete from TB_PHYP40 " +
                $" where fk_phymainno={MainNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                MainNo = 0;
                No = 0;
                Line = false;
                Clause = "";
                Description = "";
                Result = "";
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            MainNo = Convert.ToInt64(row["fk_phymainno"]);
            No = Convert.ToInt32(row["no"]);
            Line = Convert.ToBoolean(row["line"]);
            Clause = Convert.ToString(row["clause"]);
            Description = Convert.ToString(row["description"]);
            Result = Convert.ToString(row["result"]);
        }
    }

    public class PhysicalP41DataSet : UlSqlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 MainNo { get; set; }

        public int No { get; set; }

        public bool Line { get; set; }

        public string Sample { get; set; }

        public string BurningRate { get; set; }

        public PhysicalP41DataSet(SqlConnection connect, SqlCommand command, SqlDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(SqlTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_PHYP41 " +
                $" where fk_phymainno={MainNo} " +
                $" order by no asc ";
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(SqlTransaction trans = null)
        {
            string sql =
                $" insert into TB_PHYP41 values " +
                $" ({MainNo}, {No}, {Convert.ToInt32(Line)}, '{Sample.Replace("'", "''")}', '{BurningRate.Replace("'", "''")}'); " +
                $" select cast(scope_identity() as bigint); ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                RecNo = (Int64)command.ExecuteScalar();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(SqlTransaction trans = null)
        {
            string sql =
                $" delete from TB_PHYP41 " +
                $" where fk_phymainno={MainNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                MainNo = 0;
                No = 0;
                Line = false;
                Sample = "";
                BurningRate = "";
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            MainNo = Convert.ToInt64(row["fk_phymainno"]);
            No = Convert.ToInt32(row["no"]);
            Line = Convert.ToBoolean(row["line"]);
            Sample = Convert.ToString(row["sample"]);
            BurningRate = Convert.ToString(row["burningrate"]);
        }
    }

    public class PhysicalP5DataSet : UlSqlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 MainNo { get; set; }

        public int No { get; set; }

        public bool Line { get; set; }

        public string TestItem { get; set; }

        public string Result { get; set; }

        public string Requirement { get; set; }

        public PhysicalP5DataSet(SqlConnection connect, SqlCommand command, SqlDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(SqlTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_PHYP5 " +
                $" where fk_phymainno={MainNo} " +
                $" order by no asc ";
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(SqlTransaction trans = null)
        {
            string sql =
                $" insert into TB_PHYP5 values " +
                $" ({MainNo}, {No}, {Convert.ToInt32(Line)}, '{TestItem.Replace("'", "''")}', '{Result.Replace("'", "''")}', '{Requirement.Replace("'", "''")}'); " +
                $" select cast(scope_identity() as bigint); ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                RecNo = (Int64)command.ExecuteScalar();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(SqlTransaction trans = null)
        {
            string sql =
                $" delete from TB_PHYP5 " +
                $" where fk_phymainno={MainNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                MainNo = 0;
                No = 0;
                Line = false;
                TestItem = "";
                Result = "";
                Requirement = "";
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            MainNo = Convert.ToInt64(row["fk_phymainno"]);
            No = Convert.ToInt32(row["no"]);
            Line = Convert.ToBoolean(row["line"]);
            TestItem = Convert.ToString(row["testitem"]);
            Result = Convert.ToString(row["result"]);
            Requirement = Convert.ToString(row["requirement"]);
        }
    }

    public class PhysicalImageDataSet : UlSqlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 MainNo { get; set; }

        public Bitmap Signature { get; set; }

        public Bitmap Picture { get; set; }

        private ImageConverter imageConvert;

        public PhysicalImageDataSet(SqlConnection connect, SqlCommand command, SqlDataAdapter adapter)
            : base(connect, command, adapter)
        {
            imageConvert = new ImageConverter();
        }

        public void Select(SqlTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_PHYIMAGE " +
                $" where fk_phymainno={MainNo} ";
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(SqlTransaction trans = null)
        {
            string sql =
                $" insert into TB_PHYIMAGE values " +
                $" ({MainNo}, @signature, @picture); " +
                $" select cast(scope_identity() as bigint); ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;

                command.Parameters.Clear();

                if (Signature == null)
                {
                    SqlParameter signatureParam = new SqlParameter("@signature", SqlDbType.Image);
                    signatureParam.Value = DBNull.Value;
                    command.Parameters.Add(signatureParam);
                }
                else
                {
                    command.Parameters.Add("@signature", SqlDbType.Image);
                    command.Parameters["@signature"].Value = (byte[])imageConvert.ConvertTo(Signature, typeof(byte[]));
                }

                if (Picture == null)
                {
                    SqlParameter pictureParam = new SqlParameter("@picture", SqlDbType.Image);
                    pictureParam.Value = DBNull.Value;
                    command.Parameters.Add(pictureParam);
                }
                else
                {
                    command.Parameters.Add("@picture", SqlDbType.Image);
                    command.Parameters["@picture"].Value = (byte[])imageConvert.ConvertTo(Picture, typeof(byte[]));
                }

                RecNo = (Int64)command.ExecuteScalar();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(SqlTransaction trans = null)
        {
            string sql =
                $" delete from TB_PHYIMAGE " +
                $" where fk_phymainno={MainNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                MainNo = 0;
                Signature = null;
                Picture = null;
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            MainNo = Convert.ToInt64(row["fk_phymainno"]);

            if (row["signature"] == DBNull.Value) Signature = null;
            else
            {
                byte[] signatureRaw = (byte[])row["signature"];
                Signature = (signatureRaw == null) ? null : new Bitmap(new MemoryStream(signatureRaw));
            }

            if (row["picture"] == DBNull.Value) Picture = null;
            else
            {
                byte[] pictureRaw = (byte[])row["picture"];
                Picture = (pictureRaw == null) ? null : new Bitmap(new MemoryStream(pictureRaw));
            }
        }
    }

    public class ChemicalMainDataSet : UlSqlDataSet
    {
        public Int64 RecNo { get; set; }

        public DateTime RegTime { get; set; }

        public DateTime ReceivedTime { get; set; }

        public DateTime RequiredTime { get; set; }

        public DateTime ReportedTime { get; set; }

        public bool Approval { get; set; }

        public EReportArea AreaNo { get; set; }

        public string ProductNo { get; set; }

        public string JobNo { get; set; }

        public string P1ClientNo { get; set; }

        public string P1ClientName { get; set; }

        public string P1ClientAddress { get; set; }

        public string P1FileNo { get; set; }

        public string P1SampleDescription { get; set; }

        public string P1ItemNo { get; set; }

        public string P1OrderNo { get; set; }

        public string P1Manufacturer { get; set; }

        public string P1CountryOfOrigin { get; set; }

        public string P1CountryOfDestination { get; set; }

        public string P1ReceivedDate { get; set; }

        public string P1TestPeriod { get; set; }

        public string P1TestMethod { get; set; }

        public string P1TestResults { get; set; }

        public string P1Comments { get; set; }

        public string P1TestRequested { get; set; }

        public string P1Conclusion { get; set; }

        public string P2Description1 { get; set; }

        public string P2Description2 { get; set; }

        public string P2Description3 { get; set; }

        public string P3Description1 { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public EReportApproval ReportApproval { get; set; }

        public ChemicalMainDataSet(SqlConnection connect, SqlCommand command, SqlDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(SqlTransaction trans = null)
        {
            string sql = " select * from TB_CHEMAIN where pk_recno>0 ";

            if (ReportApproval != EReportApproval.None)
            {
                sql += $" and approval={(int)ReportApproval} ";
            }
            if (AreaNo != EReportArea.None)
            {
                sql += $" and areano={(int)AreaNo} ";
            }
            if (string.IsNullOrWhiteSpace(ProductNo) == false)
            {
                sql += $" and productno like '{ProductNo}%%' ";
            }
            if (string.IsNullOrWhiteSpace(From) == false)
            {
                if (From == To)
                {
                    sql += $" and regtime like '{From}%%' ";
                }
                else
                {
                    sql += $" and (regtime>='{From} 00:00:00.000' ";
                    sql += $" and regtime<='{To} 23:59:59.999') ";
                }
            }

            SetTrans(trans);
            command.CommandText = sql;
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(SqlTransaction trans = null)
        {
            string sql =
                $" insert into TB_CHEMAIN values ( " +
                $" '{RegTime.ToString(AppRes.csDateTimeFormat)}', '{ReceivedTime.ToString(AppRes.csDateTimeFormat)}', " +
                $" '{RequiredTime.ToString(AppRes.csDateTimeFormat)}', '{ReportedTime.ToString(AppRes.csDateTimeFormat)}', " +
                $" {Convert.ToInt32(Approval)}, {(int)AreaNo}, '{ProductNo.Replace("'", "''")}', '{JobNo.Replace("'", "''")}', " +
                $" '{P1ClientNo.Replace("'", "''")}', '{P1ClientName.Replace("'", "''")}', '{P1ClientAddress.Replace("'", "''")}', " +
                $" '{P1FileNo.Replace("'", "''")}', '{P1SampleDescription.Replace("'", "''")}', '{P1ItemNo.Replace("'", "''")}', " +
                $" '{P1OrderNo.Replace("'", "''")}', '{P1Manufacturer.Replace("'", "''")}', '{P1CountryOfOrigin.Replace("'", "''")}', " +
                $" '{P1CountryOfDestination.Replace("'", "''")}', '{P1ReceivedDate.Replace("'", "''")}', '{P1TestPeriod.Replace("'", "''")}', " +
                $" '{P1TestMethod.Replace("'", "''")}', '{P1TestResults.Replace("'", "''")}', '{P1Comments.Replace("'", "''")}', " +
                $" '{P1TestRequested.Replace("'", "''")}', '{P1Conclusion.Replace("'", "''")}', '{P2Description1.Replace("'", "''")}', " +
                $" '{P2Description2.Replace("'", "''")}', '{P2Description3.Replace("'", "''")}', '{P3Description1.Replace("'", "''")}'); " +
                $" select cast(scope_identity() as bigint); ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                RecNo = (Int64)command.ExecuteScalar();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Update(SqlTransaction trans = null)
        {
            string sql =
                $" update TB_CHEMAIN set " +
                $" approval={Convert.ToInt32(Approval)}, areano={(int)AreaNo}, productno='{ProductNo.Replace("'", "''")}', " +
                $" jobno='{JobNo.Replace("'", "''")}', p1clientno='{P1ClientNo.Replace("'", "''")}', " +
                $" p1clientname='{P1ClientName.Replace("'", "''")}', p1clientaddress='{P1ClientAddress.Replace("'", "''")}', " +
                $" p1fileno='{P1FileNo.Replace("'", "''")}', p1sampledesc ='{P1SampleDescription.Replace("'", "''")}', " +
                $" p1itemno='{P1ItemNo.Replace("'", "''")}', p1orderno='{P1OrderNo.Replace("'", "''")}', " +
                $" p1manufacturer='{P1Manufacturer.Replace("'", "''")}', p1countryorigin='{P1CountryOfOrigin.Replace("'", "''")}', " +
                $" p1countrydest='{P1CountryOfDestination.Replace("'", "''")}', p1recevdate='{P1ReceivedDate.Replace("'", "''")}', " +
                $" p1testperiod='{P1TestPeriod.Replace("'", "''")}', p1testmethod='{P1TestMethod.Replace("'", "''")}', " +
                $" p1testresult='{P1TestResults.Replace("'", "''")}', p1comment='{P1Comments.Replace("'", "''")}', " +
                $" p1testrequested='{P1TestRequested.Replace("'", "''")}', p1conclusion='{P1Conclusion.Replace("'", "''")}', " +
                $" p2desc1='{P2Description1.Replace("'", "''")}', p2desc2='{P2Description2.Replace("'", "''")}', " + 
                $" p2desc3='{P2Description3.Replace("'", "''")}', p3desc1='{P3Description1.Replace("'", "''")}' " +
                $" where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(SqlTransaction trans = null)
        {
            string sql =
                $" delete from TB_CHEMAIN " +
                $" where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                RegTime = DateTime.Now;
                ReceivedTime = DateTime.Now;
                RequiredTime = DateTime.Now;
                ReportedTime = DateTime.Now;
                Approval = false;
                AreaNo = EReportArea.None;
                ProductNo = "";
                JobNo = "";
                P1ClientNo = "";
                P1ClientName = "";
                P1ClientAddress = "";
                P1FileNo = "";
                P1SampleDescription = "";
                P1ItemNo = "";
                P1OrderNo = "";
                P1Manufacturer = "";
                P1CountryOfOrigin = "";
                P1CountryOfDestination = "";
                P1ReceivedDate = "";
                P1TestPeriod = "";
                P1TestMethod = "";
                P1TestResults = "";
                P1Comments = "";
                P1TestRequested = "";
                P1Conclusion = "";
                P2Description1 = "";
                P2Description2 = "";
                P2Description3 = "";
                P3Description1 = "";
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            RegTime = Convert.ToDateTime(row["regtime"]);
            ReceivedTime = Convert.ToDateTime(row["receivedtime"]);
            RequiredTime = Convert.ToDateTime(row["requiredtime"]);
            ReportedTime = Convert.ToDateTime(row["reportedtime"]);
            Approval = Convert.ToBoolean(row["approval"]);
            AreaNo = (EReportArea)Convert.ToInt32(row["areano"]);
            ProductNo = Convert.ToString(row["productno"]);
            JobNo = Convert.ToString(row["jobno"]);
            P1ClientNo = Convert.ToString(row["p1clientno"]);
            P1ClientName = Convert.ToString(row["p1clientname"]);
            P1ClientAddress = Convert.ToString(row["p1clientaddress"]);
            P1FileNo = Convert.ToString(row["p1fileno"]);
            P1SampleDescription = Convert.ToString(row["p1sampledesc"]);
            P1ItemNo = Convert.ToString(row["p1itemno"]);
            P1OrderNo = Convert.ToString(row["p1orderno"]);
            P1Manufacturer = Convert.ToString(row["p1manufacturer"]);
            P1CountryOfOrigin = Convert.ToString(row["p1countryorigin"]);
            P1CountryOfDestination = Convert.ToString(row["p1countrydest"]);
            P1ReceivedDate = Convert.ToString(row["p1recevdate"]);
            P1TestPeriod = Convert.ToString(row["p1testperiod"]);
            P1TestMethod = Convert.ToString(row["p1testmethod"]);
            P1TestResults = Convert.ToString(row["p1testresult"]);
            P1Comments = Convert.ToString(row["p1comment"]);
            P1TestRequested = Convert.ToString(row["p1testrequested"]);
            P1Conclusion = Convert.ToString(row["p1conclusion"]);
            P2Description1 = Convert.ToString(row["p2desc1"]);
            P2Description2 = Convert.ToString(row["p2desc2"]);
            P2Description3 = Convert.ToString(row["p2desc3"]);
            P3Description1 = Convert.ToString(row["p3desc1"]);
        }
    }
    public class ChemicalImageDataSet : UlSqlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 MainNo { get; set; }

        public Bitmap Signature { get; set; }

        public Bitmap Picture { get; set; }

        private ImageConverter imageConvert;

        public ChemicalImageDataSet(SqlConnection connect, SqlCommand command, SqlDataAdapter adapter)
            : base(connect, command, adapter)
        {
            imageConvert = new ImageConverter();
        }

        public void Select(SqlTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_CHEIMAGE " +
                $" where fk_chemainno={MainNo} ";
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(SqlTransaction trans = null)
        {
            string sql =
                $" insert into TB_CHEIMAGE values " +
                $" ({MainNo}, @signature, @picture); " +
                $" select cast(scope_identity() as bigint); ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;

                command.Parameters.Clear();

                if (Signature == null)
                {
                    SqlParameter signatureParam = new SqlParameter("@signature", SqlDbType.Image);
                    signatureParam.Value = DBNull.Value;
                    command.Parameters.Add(signatureParam);
                }
                else
                {
                    command.Parameters.Add("@signature", SqlDbType.Image);
                    command.Parameters["@signature"].Value = (byte[])imageConvert.ConvertTo(Signature, typeof(byte[]));
                }

                if (Picture == null)
                {
                    SqlParameter pictureParam = new SqlParameter("@picture", SqlDbType.Image);
                    pictureParam.Value = DBNull.Value;
                    command.Parameters.Add(pictureParam);
                }
                else
                {
                    command.Parameters.Add("@picture", SqlDbType.Image);
                    command.Parameters["@picture"].Value = (byte[])imageConvert.ConvertTo(Picture, typeof(byte[]));
                }

                RecNo = (Int64)command.ExecuteScalar();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(SqlTransaction trans = null)
        {
            string sql =
                $" delete from TB_CHEIMAGE " +
                $" where fk_chemainno={MainNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                MainNo = 0;
                Signature = null;
                Picture = null;
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            MainNo = Convert.ToInt64(row["fk_chemainno"]);

            if (row["signature"] == DBNull.Value) Signature = null;
            else
            {
                byte[] signatureRaw = (byte[])row["signature"];
                Signature = (signatureRaw == null) ? null : new Bitmap(new MemoryStream(signatureRaw));
            }

            if (row["picture"] == DBNull.Value) Picture = null;
            else
            {
                byte[] pictureRaw = (byte[])row["picture"];
                Picture = (pictureRaw == null) ? null : new Bitmap(new MemoryStream(pictureRaw));
            }
        }
    }

    public class ChemicalP2DataSet : UlSqlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 MainNo { get; set; }

        public string Name { get; set; }

        public string LoValue { get; set; }

        public string HiValue { get; set; }

        public string ReportValue { get; set; }

        public string FormatValue { get; set; }

        public ChemicalP2DataSet(SqlConnection connect, SqlCommand command, SqlDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(SqlTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_CHEP2 " +
                $" where fk_chemainno={MainNo} " +
                $" order by pk_recno ";
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(SqlTransaction trans = null)
        {
            string sql =
                $" insert into TB_CHEP2 values " +
                $" ({MainNo}, '{Name}', '{LoValue}', '{HiValue}', '{ReportValue}', '{FormatValue}'); " +
                $" select cast(scope_identity() as bigint); ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                RecNo = (Int64)command.ExecuteScalar();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(SqlTransaction trans = null)
        {
            string sql =
                $" delete from TB_CHEP2 " +
                $" where fk_chemainno={MainNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                MainNo = 0;
                Name = "";
                LoValue = "";
                HiValue = "";
                ReportValue = "";
                FormatValue = "";
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            MainNo = Convert.ToInt64(row["fk_chemainno"]);
            Name = Convert.ToString(row["itemname"]);
            LoValue = Convert.ToString(row["lovalue"]);
            HiValue = Convert.ToString(row["hivalue"]);
            ReportValue = Convert.ToString(row["reportvalue"]);
            FormatValue = Convert.ToString(row["formatvalue"]);
        }
    }

    public class ProfJobDataSet : UlSqlDataSet
    {
        public EReportType Type { get;set; }

        public EReportArea AreaNo { get; set; }

        public string OrderNo { get; set; }

        // CLIENT.CLI_CODE
        public string ClientNo { get; set; }

        // CLIENT.CLI_NAME
        public string ClientName { get; set; }

        // CLIENT.ADDRESS1 + ADDRESS2 + ADDRESS3 + STATE + COUNTRY
        public string ClientAddress { get; set; }

        // PROFJOB.PRO_JOB
        public string JobNo { get; set; }

        // PROFJOB.PRO_PROJ
        public string FileNo { get; set; }

        // PROFJOB.REGISTERED
        public DateTime RegTime { get; set; }

        // PROFJOB.RECEIVED
        public DateTime ReceivedTime { get; set; }

        // PROFJOB.REQUIRED
        public DateTime RequiredTime { get; set; }

        // PROFJOB.LASTREPORTED
        public DateTime ReportedTime { get; set; }

        // PROFJOBUSER.JOBCOMMENTS
        public string ItemNo { get; set; }

        // PROFJOBUSER.COMMENTS1
        public string ReportComments { get; set; }

        // PROFJOB_CUIDUSER.SAM_REMARKS
        public string SampleDescription { get; set; }

        // PROFJOB_CUIDUSER.DESCRIPTION_1
        public string DetailOfSample { get; set; }

        // PROFJOB_CUIDUSER.DESCRIPTION_4
        public string Manufacturer { get; set; }

        // PROFJOB_CUIDUSER.DESCRIPTION_3
        public string CountryOfOrigin { get; set; }

        // USERPROFJOB_PHOTORTF.PHOTO
        public Bitmap Image { get; set; }

        private ImageConverter imageConvert;

        public string From { get; set; }

        public string To { get; set; }

        public ProfJobDataSet(SqlConnection connect, SqlCommand command, SqlDataAdapter adapter)
            : base(connect, command, adapter)
        {
            imageConvert = new ImageConverter();
        }

        public void Select(SqlTransaction trans = null)
        {
            string sql =
                " select t2.cli_code, t2.cli_name, t2.address1, t2.address2,         " +
                "     t2.address3, t2.state, t2.country, t1.orderno, t1.pro_job,     " +
                "     t1.pro_proj, t1.registered, t1.received, t1.required,          " +
                "     t1.lastreported, t3.jobcomments, t3.comments1, t4.sam_remarks, " +
                "     t4.description_1, t4.description_3, t4.description_4, t5.photo " +
                " from PROFJOB t1                                                    " +
                "     join CLIENT t2 on t2.cli_code=t1.cli_code                      " +
                "     join PROFJOBUSER t3 on t3.pro_job=t1.pro_job                   " +
                "     join PROFJOB_CUIDUSER t4 on t4.pro_job=t1.pro_job              " +
                "     join USERPROFJOB_PHOTORTF t5 on t5.pro_job=t1.pro_job          " +
                " where t1.labcode<>''                                               ";

            if (string.IsNullOrWhiteSpace(JobNo) == false)
            {
                sql += $" and t1.pro_job='{JobNo}' ";
            }
            else
            {
                switch (Type)
                {
                    case EReportType.Physical:
                        if (string.IsNullOrWhiteSpace(OrderNo) == false)
                        {
                            if (AreaNo == EReportArea.None)
                            {
                                sql += $" and t3.jobcomments like '{OrderNo}%%' ";
                            }
                            else
                            {
                                sql += $" and t3.jobcomments='{OrderNo} -{AreaNo.ToDescription()}' ";
                            }
                        }
                        sql += $" and t1.pro_job in (select pro_job from PROFJOB_CUID_SCHEME_ANALYTE where formattedvalue is null)";
                        break;

                    case EReportType.Chemical:
                        if (string.IsNullOrWhiteSpace(OrderNo) == false)
                        {
                            sql += $" and t3.jobcomments like '%%{OrderNo}%%' ";
                        }
                        sql += $" and t1.pro_job in (select pro_job from PROFJOB_CUID_SCHEME_ANALYTE where formattedvalue is not null)";
                        break;
                }

                if (string.IsNullOrWhiteSpace(From) == false)
                {
                    if (From == To)
                    {
                        sql += $" and t1.registered like '{From}%%' ";
                    }
                    else
                    {
                        sql += $" and (t1.registered>='{From} 00:00:00.000' ";
                        sql += $" and t1.registered<='{To} 23:59:59.999') ";
                    }
                }
            }

            SetTrans(trans);
            command.CommandText = sql;
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                Type = EReportType.None;
                AreaNo = EReportArea.None;
                OrderNo = "";
                ClientNo = "";
                ClientName = "";
                ClientAddress = "";
                JobNo = "";
                FileNo = "";
                RegTime = DateTime.Now;
                ReceivedTime = DateTime.Now;
                RequiredTime = DateTime.Now;
                ReportedTime = DateTime.Now;
                ItemNo = "";
                ReportComments = "";
                SampleDescription = "";
                DetailOfSample = "";
                Manufacturer = "";
                CountryOfOrigin = "";
                Image = null;
            }
        }

        public void Fetch(DataRow row)
        {
            AreaNo = EReportArea.None;
            OrderNo = Convert.ToString(row["orderno"]);

            if (Type == EReportType.Physical)
            {
                string[] strs = OrderNo.Split('-');

                if (strs.Length > 1)
                {
                    switch (strs[1].ToUpper().Trim())
                    {
                        case "ASTM":
                            AreaNo = EReportArea.US;
                            break;

                        case "EN":
                            AreaNo = EReportArea.EU;
                            break;
                    }

                    OrderNo = strs[0].Trim();
                }
                else
                {
                    OrderNo = "";
                }
            }

            ClientNo = Convert.ToString(row["cli_code"]);
            ClientName = Convert.ToString(row["cli_name"]);
            ClientAddress = Convert.ToString(row["address1"]) + ", " + 
                Convert.ToString(row["address2"]) + ", " +
                Convert.ToString(row["address3"]) + "\r\n" + 
                Convert.ToString(row["state"]) + "\r\n" + 
                Convert.ToString(row["country"]);
            JobNo = Convert.ToString(row["pro_job"]);
            FileNo = Convert.ToString(row["pro_proj"]);
            RegTime = Convert.ToDateTime(row["registered"]);
            ReceivedTime = Convert.ToDateTime(row["received"]);
            RequiredTime = Convert.ToDateTime(row["required"]);
            ReportedTime = Convert.ToDateTime(row["lastreported"]);
            ItemNo = Convert.ToString(row["jobcomments"]);
            ReportComments = Convert.ToString(row["comments1"]);
            SampleDescription = Convert.ToString(row["sam_remarks"]);
            DetailOfSample = Convert.ToString(row["description_1"]);
            Manufacturer = Convert.ToString(row["description_4"]);
            CountryOfOrigin = Convert.ToString(row["description_3"]);
            byte[] imageRaw = (byte[])row["photo"];

            if (imageRaw == null)
                Image = null;
            else
                Image = new Bitmap(new MemoryStream(imageRaw));
        }
    }

    public class ProfJobSchemeDataSet : UlSqlDataSet
    {
        public EReportArea Area { get; set; }

        public string MaterialNo { get; set; }

        public string Name { get; set; }

        public string LoValue { get; set; }

        public string HiValue { get; set; }

        public string ReportValue { get; set; }

        public string FormatValue { get; set; }

        public ProfJobSchemeDataSet(SqlConnection connect, SqlCommand command, SqlDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(SqlTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select t2.sch_code, t3.description, " +
                $"     t2.lvl1lowerlimit, t2.lvl1upperlimit, " +
                $"     t2.repdetlimit, t1.formattedvalue " +
                $" from PROFJOB t0 " +
                $"     Join PROFJOB_CUID_SCHEME_ANALYTE t1 on " +
                $"         (t1.pro_job=t0.pro_job) " +
                $"     join PROFJOB_SCHEME_ANALYTE t2 on " +
                $"         (t2.labcode=t1.labcode and t2.pro_job=t1.pro_job and " +
                $"         t2.sch_code=t1.sch_code and t2.analytecode=t1.analytecode) " +
                $"     join SCHEME_ANALYTE t3 on " +
                $"         (t3.labcode=t1.labcode and t3.sch_code=t1.sch_code and " +
                $"         t3.schversion=t1.schversion and t3.analytecode=t1.analytecode) " +
                $" where t0.orderno='{MaterialNo}' ";
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                Area = EReportArea.US;
                //JobNo = "";
                Name = "";
                LoValue = "";
                HiValue = "";
                ReportValue = "";
                FormatValue = "";
            }
        }

        public void Fetch(DataRow row)
        {
            string area = Convert.ToString(row["sch_code"]);
            //JobNo = Convert.ToString(row["pro_job"]);
            Name = Convert.ToString(row["description"]);
            LoValue = Convert.ToString(row["lvl1lowerlimit"]);
            HiValue = Convert.ToString(row["lvl1upperlimit"]);
            ReportValue = Convert.ToString(row["repdetlimit"]);
            FormatValue = Convert.ToString(row["formattedlimit"]);

            if (area.Substring(4, 2) == "AS")
            {
                Area = EReportArea.US;
            }
            else
            {
                Area = EReportArea.EU;
            }

            if (string.IsNullOrWhiteSpace(FormatValue) == true)
            {
                FormatValue = "--";
            }
            else if (FormatValue.Substring(0, 1) == "<")
            {
                FormatValue = "ND";
            }
        }
    }
}
