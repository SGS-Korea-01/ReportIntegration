using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

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
        [Description("EU")]
        EU = 1
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
    #endregion
}
