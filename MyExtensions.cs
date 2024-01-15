using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
