using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

using Ulee.Database.SqlServer;

namespace Sgs.ReportIntegration
{
    public static class AppHelper
    {
        public static byte[] ToByte(double[] fData)
        {
            if (fData == null) return null;
            if (fData.Length == 0) return null;

            byte[] raw = new byte[fData.Length * sizeof(double)];
            Buffer.BlockCopy(fData, 0, raw, 0, raw.Length);

            return raw;
        }

        public static double[] ToDouble(byte[] byData)
        {
            if (byData == null) return null;
            if (byData.Length == 0) return null;

            double[] raw = new double[byData.Length / sizeof(double)];
            Buffer.BlockCopy(byData, 0, raw, 0, byData.Length);

            return raw;
        }

        public static void ResetGridDataSource(GridControl grid)
        {
            grid.DataSource = null;
        }

        public static void SetGridDataSource(GridControl grid, UlSqlDataSet set)
        {
            grid.DataSource = (set.Empty == true) ? null : set.DataSet.Tables[0];
        }

        public static void SetGridEvenRow(GridView view)
        {
            view.Appearance.EvenRow.BackColor = Color.FromArgb(244, 244, 236);
            view.OptionsView.EnableAppearanceEvenRow = true;
        }

        public static void ResetGridSortOrder(GridView view)
        {
            foreach (GridColumn col in view.Columns)
            {
                col.SortOrder = ColumnSortOrder.None;
            }
        }

        public static void RefreshGridData(GridView view)
        {
            view.BeginUpdate();

            try
            {
                view.RefreshData();
            }
            finally
            {
                view.EndUpdate();
            }
        }
    }
}
