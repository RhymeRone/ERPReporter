using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DashboardCommon;

namespace NebimV3Reporter
{
    public static class MyExtensions
    {
        public static List<T> ToList<T>(this DataTable dataTable,int column)
        {
            var list = new List<T>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add((T)row[column]);
            }
            return list;
        }
        public static List<T> ToList<T>(this DataTable dataTable, string column)
        {
            var list = new List<T>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add((T)row[column]);
            }
            return list;
        }
        public static List<string> GetColumnNames(this DataTable dataTable)
        {
            List<string> list = new List<string>();

            foreach (DataColumn column in dataTable.Columns)
            {
                list.Add(column.ColumnName);
            }
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataTable">Grid sütunlarına dönüştürülerek olan tablo </param>
        /// <param name="numberTypeBases">Sayı temelli sütun tiplerini measure column tipine dönüştürür</param>
        /// <returns></returns>
        public static List<GridColumnBase> GridColumnBases(this DataTable dataTable, params string[] numberTypeBases)
        {
            List<GridColumnBase> gridColumnBases = new List<GridColumnBase>();
            GridColumnTotal totalCount = new GridColumnTotal(totalType: GridColumnTotalType.Count);
            GridColumnTotal totalSum = new GridColumnTotal(totalType: GridColumnTotalType.Sum);
            GridColumnTotal totalMax = new GridColumnTotal(totalType: GridColumnTotalType.Max);
            GridColumnTotal totalMin = new GridColumnTotal(totalType: GridColumnTotalType.Min);
            bool flag = true;
            foreach (DataColumn column in dataTable.Columns)
            {
                if (Array.Exists(numberTypeBases, e => e == column.ColumnName))
                {
                    GridMeasureColumn gridMeasureColumn = new GridMeasureColumn(new Measure(column.ColumnName));
                    gridMeasureColumn.Measure.ShowTotals = false;
                    gridMeasureColumn.Measure.ShowGrandTotals = true;
                    gridMeasureColumn.Measure.ShowValues = true;
                    gridMeasureColumn.Measure.NumericFormat.CurrencyCultureName = "tr-TR";
                    gridMeasureColumn.Measure.NumericFormat.FormatType = DataItemNumericFormatType.Currency;
                    gridMeasureColumn.Measure.NumericFormat.IncludeGroupSeparator = true;
                    gridMeasureColumn.Measure.NumericFormat.Unit = DataItemNumericUnit.Ones;
                    gridMeasureColumn.Totals.AddRange(totalSum,totalMax,totalMin);
                    gridColumnBases.Add((gridMeasureColumn));
                }
                else
                {
                    GridDimensionColumn gridDimensionColumn = new GridDimensionColumn(new Dimension(column.ColumnName));
                    gridDimensionColumn.Dimension.NumericFormat.FormatType = DataItemNumericFormatType.General;
                    gridDimensionColumn.Dimension.DateTimeFormat.DateTimeFormat = DateTimeFormat.Short;
                    gridDimensionColumn.Dimension.SortOrder = DimensionSortOrder.Descending;
                    gridDimensionColumn.WidthType = GridColumnFixedWidthType.FitToContent;
                    gridDimensionColumn.Dimension.DateTimeGroupInterval = DateTimeGroupInterval.DateHourMinute;
                    if (flag)
                    {
                        gridDimensionColumn.Totals.AddRange(totalCount, totalMax, totalMin);
                        flag = false;
                    }
                    gridColumnBases.Add(gridDimensionColumn);
                }
            }
            return gridColumnBases;
        }

    }
}
