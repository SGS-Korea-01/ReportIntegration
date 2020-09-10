using DevExpress.DataAccess.EntityFramework;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public class PhysicalMainDataSet : UlSqlDataSet
    {
        public Int64 RecNo { get; set; }

        public DateTime RegTime { get; set; }

        public DateTime ReceivedTime { get; set; }

        public DateTime RequiredTime { get; set; }

        public DateTime ReportedTime { get; set; }

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

        public string P5Description1 { get; set; }

        public string P5Description2 { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public PhysicalMainDataSet(SqlConnection connect, SqlCommand command, SqlDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(SqlTransaction trans = null)
        {
            string sql = " select * from TB_PHYMAIN where pk_recno>0 ";

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
                $" insert into TB_PHYMAIN values " +
                $" ('{RegTime.ToString(AppRes.csDateTimeFormat)}', '{ReceivedTime.ToString(AppRes.csDateTimeFormat)}', " +
                $" '{RequiredTime.ToString(AppRes.csDateTimeFormat)}', '{ReportedTime.ToString(AppRes.csDateTimeFormat)}', " +
                $" {(int)AreaNo}, '{ProductNo}', '{JobNo}', '{P1ClientNo}', '{P1ClientName}', '{P1ClientAddress}', " +
                $" '{P1FileNo}', '{P1SampleDescription}', '{P1DetailOfSample}', '{P1ItemNo}', '{P1OrderNo}', '{P1Manufacturer}', " +
                $" '{P1CountryOfOrigin}', '{P1CountryOfDestination}', '{P1LabeledAge}', '{P1TestAge}', '{P1AssessedAge}', " +
                $" '{P1ReceivedDate}', '{P1TestPeriod}', '{P1TestMethod}', '{P1TestResults}', '{P1Comments}', '{P2Name}', " +
                $" '{P3Description1}', '{P3Description2}', '{P4Description1}', '{P4Description2}', '{P5Description1}', '{P5Description2}'); " +
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
                $" update TB_PHYMAIN set " +
                $" regtime='{RegTime.ToString(AppRes.csDateTimeFormat)}', receivedtime='{ReceivedTime.ToString(AppRes.csDateTimeFormat)}', " +
                $" requiredtime='{RequiredTime.ToString(AppRes.csDateTimeFormat)}', reportedtime='{ReportedTime.ToString(AppRes.csDateTimeFormat)}', " +
                $" areano={(int)AreaNo}, productno='{ProductNo}', jobno='{JobNo}', p1clientno='{P1ClientNo}', p1clientname='{P1ClientName}', " +
                $" p1clientaddress='{P1ClientAddress}', p1fileno='{P1FileNo}', p1sampledesc='{P1SampleDescription}', " +
                $" p1detailsample='{P1DetailOfSample}', p1itemno='{P1ItemNo}', p1orderno='{P1OrderNo}', p1manufacturer='{P1Manufacturer}', " +
                $" p1countryorigin='{P1CountryOfOrigin}', p1countrydest='{P1CountryOfDestination}', p1labelage='{P1LabeledAge}', " +
                $" p1testage='{P1TestAge}', p1assessedage='{P1AssessedAge}', p1recevdate='{P1ReceivedDate}', p1testperiod='{P1TestPeriod}', " +
                $" p1testmethod='{P1TestMethod}', p1testresult='{P1TestResults}', p1comment='{P1Comments}', p2name='{P2Name}', " +
                $" p3desc1='{P3Description1}', p3desc2='{P3Description2}', p4desc1='{P4Description1}', p4desc2='{P4Description2}', " +
                $" p5desc1='{P5Description1}', p5desc2='{P5Description2}' " +
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
                $" ({MainNo}, {No}, {Convert.ToInt32(Line)}, '{Requested}', '{Conclusion}'); " +
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
                $" ({MainNo}, {No}, {Convert.ToInt32(Line)}, '{Clause}', '{Description}', '{Result}'); " +
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

    public class PhysicalP4DataSet : UlSqlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 MainNo { get; set; }

        public int No { get; set; }

        public bool Line { get; set; }

        public string Sample { get; set; }

        public string BurningRate { get; set; }

        public PhysicalP4DataSet(SqlConnection connect, SqlCommand command, SqlDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(SqlTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_PHYP4 " +
                $" where fk_phymainno={MainNo} " +
                $" order by no asc ";
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(SqlTransaction trans = null)
        {
            string sql =
                $" insert into TB_PHYP4 values " +
                $" ({MainNo}, {No}, {Convert.ToInt32(Line)}, '{Sample}', '{BurningRate}'); " +
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
                $" delete from TB_PHYP4 " +
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
                $" ({MainNo}, {No}, {Convert.ToInt32(Line)}, '{TestItem}', '{Result}', '{Requirement}'); " +
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

    public class ProfJobDataSet : UlSqlDataSet
    {
        public EReportArea AreaNo { get; set; }

        public string ProductNo { get; set; }

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
                if (string.IsNullOrWhiteSpace(ProductNo) == false)
                {
                    if (AreaNo == EReportArea.None)
                    {
                        sql += $" and t1.orderno like '{ProductNo}%%' ";
                    }
                    else
                    {
                        sql += $" and t1.orderno='{ProductNo} -{AreaNo.ToDescription()}' ";
                    }
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
                AreaNo = EReportArea.None;
                ProductNo = "";
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
            string[] strs = Convert.ToString(row["orderno"]).Split('-');

            if (strs.Length > 1)
            {
                switch (strs[1].ToUpper().Trim())
                {
                    case "ASTM":
                        AreaNo = EReportArea.US;
                        break;

                    case "EU":
                        AreaNo = EReportArea.EU;
                        break;

                    default:
                        AreaNo = EReportArea.None;
                        break;
                }

                ProductNo = strs[0].Trim();
            }
            else
            {
                AreaNo = EReportArea.None;
                ProductNo = "";
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
}
