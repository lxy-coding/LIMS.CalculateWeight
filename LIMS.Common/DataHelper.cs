using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Common
{
    /// <summary>
    /// 数据工具
    /// </summary>
    public static class DataHelper
    {

        /// <summary>
        /// 将List转换成DataTable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable dt = new DataTable();
            for (int i = 0; i < properties.Count; i++)
            {
                PropertyDescriptor property = properties[i];
                try
                {
                    // 当字段类型是Nullable<>时
                    Type colType = property.PropertyType;
                    if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                    {
                        colType = colType.GetGenericArguments()[0];
                    }
                    dt.Columns.Add(property.Name, colType);
                }
                catch (Exception ex)
                {
                }

            }
            object[] values = new object[properties.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = properties[i].GetValue(item);
                }
                dt.Rows.Add(values);
            }
            return dt;
        }

        /// <summary>
        /// 将DataRow[]转换成DataTable
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable ToDataTable(DataRow[] data)
        {
            try
            {
                if (data == null)
                    return null;
                if (data.Count() > 0)
                {
                    DataTable dt = data[0].Table.Clone(); ;
                    foreach (DataRow item in data)
                    {
                        dt.ImportRow(item);
                    }
                    return dt;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }

        }

        /// <summary>
        /// datatable转List（数据量大，不推荐使用）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <returns></returns>
        public static IList<T> ToIList<T>(DataTable table)
        {
            if (table == null)
            {
                return null;

            }
            List<DataRow> rows = new List<DataRow>();
            foreach (DataRow row in table.Rows)
            {
                rows.Add(row);
            }
            return ConvertTo<T>(rows);
        }

        /// <summary>
        /// datatable转换成List-- 方法1(有缺陷，T中的字段只能是string,建议使用方法2)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public static List<T> DatatableToList<T>(DataTable dataTable)
        {
            var columnNames = dataTable.Columns.Cast<DataColumn>().Select(c => c.ColumnName).ToList();
            var properties = typeof(T).GetProperties();
            return dataTable.AsEnumerable().Select(row =>
            {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {
                    if (columnNames.Contains(pro.Name))
                    {
                        object value = row[pro.Name].ToString();

                        if (value != DBNull.Value)
                            pro.SetValue(objT, value, null);
                    }

                }
                return objT;

            }).ToList();
        }

        /// <summary>
        /// datatable转换成List --方法2
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <returns></returns>
        public static IList<T> DataTableToList2<T>(DataTable table) where T : class
        {
            if (!IsHaveRows(table))
                return new List<T>();

            IList<T> list = new List<T>();
            T model = default(T);
            foreach (DataRow dr in table.Rows)
            {
                model = Activator.CreateInstance<T>();

                foreach (DataColumn dc in dr.Table.Columns)
                {
                    object drValue = dr[dc.ColumnName];
                    PropertyInfo pi = model.GetType().GetProperty(dc.ColumnName);

                    if (pi != null && pi.CanWrite && (drValue != null && !Convert.IsDBNull(drValue)))
                    {
                        pi.SetValue(model, drValue, null);
                    }
                }

                list.Add(model);
            }
            return list;
        }

        public static bool IsHaveRows(DataTable dt)
        {
            if (dt != null && dt.Rows.Count > 0)
                return true;

            return false;
        }

        static IList<T> ConvertTo<T>(IList<DataRow> rows)
        {
            IList<T> list = null;
            if (rows != null)
            {
                list = new List<T>();
                foreach (DataRow row in rows)
                {
                    T item = CreateItem<T>(row);
                    list.Add(item);
                }
            }
            return list;
        }



        static T CreateItem<T>(DataRow row)
        {
            T obj = default(T);
            if (row != null)
            {
                obj = Activator.CreateInstance<T>();
                foreach (DataColumn column in row.Table.Columns)
                {
                    PropertyInfo prop = obj.GetType().GetProperty(column.ColumnName);

                    try
                    {
                        object value = row[column.ColumnName];
                        prop.SetValue(obj, value, null);
                    }
                    catch
                    {  //You can log something here     

                        //throw;    
                    }
                }
            }
            return obj;
        }
    }
}
