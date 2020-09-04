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
                command.ExecuteNonQuery();
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

        public EReportArea AreaNo { get; set; }

        public string ProductNo { get; set; }

        public string ClientNo { get; set; }

        public string ClientName { get; set; }

        public string ClientAddress { get; set; }

        public string JobNo { get; set; }

        public string FileNo { get; set; }

        public DateTime RegTime { get; set; }

        public DateTime ReceivedTime { get; set; }

        public DateTime RequiredTime { get; set; }

        public DateTime ReportedTime { get; set; }

        public string ItemNo { get; set; }

        public string ReportComments { get; set; }

        public string SampleDescription { get; set; }

        public string DetailOfSample { get; set; }

        public string Manufacturer { get; set; }

        public string CountryOfOrigin { get; set; }

        public Bitmap Image { get; set; }

        private ImageConverter imageConvert;

        public string From { get; set; }

        public string To { get; set; }

        public PhysicalMainDataSet(SqlConnection connect, SqlCommand command, SqlDataAdapter adapter)
            : base(connect, command, adapter)
        {
            imageConvert = new ImageConverter();
        }

        public void Select(SqlTransaction trans = null)
        {
            string sql = " select * from TB_PHYSICAL_M where pk_recno>0 ";

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
                $" insert into TB_PHYSICAL_M values " +
                $" ('{RegTime.ToString(AppRes.csDateTimeFormat)}', '{ReceivedTime.ToString(AppRes.csDateTimeFormat)}', " +
                $" '{RequiredTime.ToString(AppRes.csDateTimeFormat)}', '{ReportedTime.ToString(AppRes.csDateTimeFormat)}', " +
                $" {(int)AreaNo}, '{ProductNo}', '{ClientNo}', '{ClientName}', @clientaddress, '{JobNo}', '{FileNo}', '{ItemNo}', " +
                $" '{ReportComments}', '{SampleDescription}', '{DetailOfSample}', '{Manufacturer}', '{CountryOfOrigin}', @image); " +
                $" select cast(scope_identity() as bigint); ";

            byte[] imageRaw = (Image == null) ? null : (byte[])imageConvert.ConvertTo(Image, typeof(byte[]));

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;

                command.Parameters.Clear();
                command.Parameters.Add("@clientaddress", SqlDbType.VarChar);
                command.Parameters["@clientaddress"].Value = ClientAddress;
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
            RecNo = Convert.ToInt64(row["pk_recno"]);
            AreaNo = (EReportArea)Convert.ToInt32(row["areano"]);
            ProductNo = Convert.ToString(row["productno"]);
            ClientNo = Convert.ToString(row["clientno"]);
            ClientName = Convert.ToString(row["clientname"]);
            ClientAddress = Convert.ToString(row["clientaddr"]);
            JobNo = Convert.ToString(row["jobno"]);
            FileNo = Convert.ToString(row["fileno"]);
            RegTime = Convert.ToDateTime(row["regtime"]);
            ReceivedTime = Convert.ToDateTime(row["receivedtime"]);
            RequiredTime = Convert.ToDateTime(row["requiredtime"]);
            ReportedTime = Convert.ToDateTime(row["reportedtime"]);
            ItemNo = Convert.ToString(row["itemno"]);
            ReportComments = Convert.ToString(row["reportcomments"]);
            SampleDescription = Convert.ToString(row["sampledesc"]);
            DetailOfSample = Convert.ToString(row["detailofsample"]);
            Manufacturer = Convert.ToString(row["manufacturer"]);
            CountryOfOrigin = Convert.ToString(row["country"]);
            byte[] imageRaw = (byte[])row["image"];

            if (imageRaw == null)
                Image = null;
            else
                Image = new Bitmap(new MemoryStream(imageRaw));
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
