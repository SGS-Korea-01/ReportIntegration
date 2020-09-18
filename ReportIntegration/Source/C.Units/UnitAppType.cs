using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

using Ulee.Utils;

namespace Sgs.ReportIntegration
{
    #region Enum
    public enum EReportArea
    {
        [Description("None")]
        None = -1,
        [Description("ASTM")]
        US = 0,
        [Description("EN")]
        EU = 1
    }

    public enum EReportApproval
    {
        [Description("None")]
        None = -1,
        [Description("Not Approved")]
        NotApproved = 0,
        [Description("Approved")]
        Approved = 1
    }

    public enum EReportType
    {
        [Description("None")]
        None = -1,
        [Description("Physical")]
        Physical = 0,
        [Description("Chemical")]
        Chemical = 1,
        [Description("Integration")]
        Integration = 2
    }

    #endregion

    #region GridTypeFormat
    class ReportAreaFormat : IFormatProvider, ICustomFormatter
    {
        public ReportAreaFormat()
        {
        }

        public object GetFormat(Type type)
        {
            return this;
        }

        public string Format(string formatString, object arg, IFormatProvider formatProvider)
        {
            return ((EReportArea)arg).ToDescription();
        }
    }
    #endregion

    #region Class
    public class BomColumns
    {
        public Int64 RecNo { get; set; }
        public DateTime RegTime { get; set; }
        public EReportArea AreaNo { get; set; }
        public string FName { get; set; }
        public string FPath { get; set; }

        public List<ProductColumns> Products { get; set; }

        public BomColumns()
        {
            Products = new List<ProductColumns>();
            Clear();
        }

        public void Clear()
        {
            RecNo = 0;
            RegTime = DateTime.Now;
            AreaNo = EReportArea.US;
            FName = "";
            FPath = "";

            foreach (ProductColumns product in Products)
            {
                product.Clear();
            }

            Products.Clear();
        }

        public void Add(ProductColumns col)
        {
            Products.Add(col);
        }
    }

    public class ProductColumns
    {
        public Int64 RecNo { get; set; }
        public Int64 BomNo { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Bitmap Image { get; set; }

        public List<PartColumns> Parts { get; set; }

        public ProductColumns()
        {
            Parts = new List<PartColumns>();
            Clear();
        }

        public void Clear()
        {
            RecNo = 0;
            BomNo = 0;
            Code = "";
            Name = "";
            Image = null;

            Parts.Clear();
        }

        public void Add(PartColumns col)
        {
            Parts.Add(col);
        }
    }

    public class PartColumns
    {
        public Int64 RecNo { get; set; }
        public Int64 ProductNo { get; set; }
        public string Name { get; set; }
        public string MaterialNo { get; set; }
        public string MaterialName { get; set; }

        public PartColumns()
        {
            RecNo = 0;
            ProductNo = 0;
            Name = "";
            MaterialNo = "";
            MaterialName = "";
        }
    }

    public class PhysicalPage2Row
    {
        public int No { get; set; }

        public bool Line { get; set; }

        public string Requested { get; set; }

        public string Conclusion { get; set; }

        public PhysicalPage2Row()
        {
            No = 0;
            Line = false;
            Requested = "";
            Conclusion = "";
        }
    }

    public class PhysicalPage3Row
    {
        public int No { get; set; }

        public bool Line { get; set; }

        public string Clause { get; set; }

        public string Description { get; set; }

        public string Result { get; set; }

        public PhysicalPage3Row()
        {
            No = 0;
            Line = false;
            Clause = "";
            Description = "";
            Result = "";
        }
    }

    public class PhysicalPage4Row
    {
        public int No { get; set; }

        public bool Line { get; set; }

        public string Sample { get; set; }

        public string BurningRate { get; set; }

        public PhysicalPage4Row()
        {
            No = 0;
            Line = false;
            Sample = "";
            BurningRate = "";
        }
    }

    public class PhysicalPage5Row
    {
        public int No { get; set; }

        public bool Line { get; set; }

        public string TestItem { get; set; }

        public string Result { get; set; }

        public string Requirement { get; set; }

        public PhysicalPage5Row()
        {
            No = 0;
            Line = false;
            TestItem = "";
            Result = "";
            Requirement = "";
        }
    }

    public class ChemicalPage2Row
    {
        public Int64 RecNo { get; set; }

        public string HiLimit { get; set; }

        public string LoLimit { get; set; }

        public string ReportLimit { get; set; }

        public string FormatValue { get; set; }

        public string Name { get; set; }

        public ChemicalPage2Row()
        {
            RecNo = 0;
            HiLimit = "";
            LoLimit = "";
            ReportLimit = "";
            FormatValue = "";
            Name = "";
        }
    }
    #endregion
}
