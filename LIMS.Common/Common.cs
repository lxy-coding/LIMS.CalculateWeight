using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LIMS.Common
{
    /// <summary>
    /// 常用工具集
    /// </summary>
    public class Common
    {
        /// <summary>
        /// 得到字符,从object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetStrFromObj(object obj)
        {
            string sRtn = "";
            if (obj != null)
            {
                sRtn = obj.ToString();
            }
            return sRtn;
        }

        /// <summary>
        /// 数据类型转换，从object到int
        /// </summary>
        /// <param name="obj">object转换对象</param>
        /// <returns></returns>
        public static int GetIntFromObj(object obj)
        {
            int iRtn = 0;
            if (obj != null)
            {
                int.TryParse(obj.ToString(), out iRtn);
            }
            return iRtn;
        }

        /// <summary>
        /// 数据类型转换，从object到decimal
        /// </summary>
        /// <param name="obj">object转换对象</param>
        /// <returns></returns>
        public static decimal GetFloatFromObj(object obj)
        {
            decimal iRtn = 0M;

            if (obj != null)
            {
                string sVal = string.Format("{0:F3}", obj);

                decimal.TryParse(sVal, out iRtn);
            }
            return iRtn;
        }

        /// <summary>
        /// 从指定的数据行DataRow中获取指定列的string值
        /// </summary>
        /// <param name="dr">DataRow数据行</param>
        /// <param name="sName">列名</param>
        /// <returns></returns>
        public static string GetStrFromDR(DataRow dr, string sName)
        {
            string sRtn = "";
            if (dr.Table.Columns.Contains(sName))
            {
                sRtn = dr[sName] == null ? "" : dr[sName].ToString();
            }

            return sRtn;
        }

        /// <summary>
        /// 从指定的数据行DataRow中获取指定列的int值
        /// </summary>
        /// <param name="dr">DataRow数据行</param>
        /// <param name="sName">列名</param>
        /// <returns></returns>
        public static int GetIntFromDR(DataRow dr, string sName)
        {
            int iRtn = 0;
            int.TryParse(GetStrFromDR(dr, sName), out iRtn);

            return iRtn;
        }

        /// <summary>
        /// 从指定的数据行DataRow中获取指定列的double值
        /// </summary>
        /// <param name="dr">DataRow数据行</param>
        /// <param name="sName">列名</param>
        /// <returns></returns>
        public static double GetDoubleFromDR(DataRow dr, string sName)
        {
            double iRtn = 0;
            double.TryParse(GetStrFromDR(dr, sName), out iRtn);

            return iRtn;
        }

        /// <summary>
        /// 从指定的数据行DataRow中获取指定列的float值
        /// </summary>
        /// <param name="dr">DataRow数据行</param>
        /// <param name="sName">列名</param>
        /// <returns></returns>
        public static float GetFloatFromDR(DataRow dr, string sName)
        {
            float iRtn = 0;
            float.TryParse(GetStrFromDR(dr, sName), out iRtn);

            return iRtn;
        }

        /// <summary>
        /// 从指定的数据行DataRow中获取指定列的decimal值
        /// </summary>
        /// <param name="dr">DataRow数据行</param>
        /// <param name="sName">列名</param>
        /// <returns></returns>
        public static decimal GetDecimalFromDR(DataRow dr, string sName)
        {
            decimal iRtn = 0;
            decimal.TryParse(GetStrFromDR(dr, sName), out iRtn);
            return iRtn;
        }

        public static int _iUnKownFlag = 100;
        /// <summary>
        /// 生成系统未知卷
        /// </summary>
        /// <returns></returns>
        public static string GetUnknownSteelNo()
        {
            if (_iUnKownFlag >= 999)
            {
                _iUnKownFlag = 100;
            }
            _iUnKownFlag = _iUnKownFlag + 1;
            return string.Format("QM{0}{1}", DateTime.Now.ToString("yyyyMMddHHmmss"), _iUnKownFlag);
        }

        /// <summary>
        /// 根据给定格式从字符串中解析日期时间
        /// </summary>
        /// <param name="datestr"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static DateTime ParseDateByFormat(string datestr, string format)
        {
            DateTime rv = new DateTime();
            try
            {
                rv = DateTime.ParseExact(datestr, format, System.Globalization.CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {
                string strex = ex.Message;
            }
            return rv;
        }
    }

    /// <summary>
    /// 扩展方法
    /// </summary>
    public static class ExMethod
    {
        /// <summary>
        /// object转字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToStr(this object obj)
        {
            string sRtn = "";
            if (obj != null)
            {
                sRtn = obj.ToString();
            }
            return sRtn;
        }

        /// <summary>
        /// object转字Int类型
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int ToInt(this object obj)
        {
            int sRtn = 0;
            if (obj != null)
            {
                int.TryParse(obj.ToString(), out sRtn);
            }
            return sRtn;
        }

        /// <summary>
        /// object转字Decimal
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static decimal ToDecimal(this object obj)
        {
            decimal sRtn = 0M;
            if (obj != null)
            {
                string sVal = string.Format("{0:F3}", obj);

                decimal.TryParse(sVal, out sRtn);
            }
            return sRtn;
        }

        /// <summary>
        /// object转字DateTime
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this object str)
        {
            DateTime dt = DateTime.MinValue;
            if (str != null)
            {
                if (DateTime.TryParse(str.ToStr(), out dt))
                {
                    dt = Convert.ToDateTime(str);
                }
            }
            return dt;
        }

        /// <summary>
        /// 数字字符串转字DateTime
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static DateTime ToDateTimeOn(this string str)
        {
            DateTime dt = DateTime.MinValue;
            if (str != null)
            {
                dt = Convert.ToDateTime(str.Substring(0, 4) + "-" + str.Substring(4, 2) + "-" + str.Substring(6, 2) + " " + str.Substring(8, 2) + ":" + str.Substring(10, 2) + ":" + str.Substring(12, 2));
            }
            return dt;
        }

    }

    /// <summary>
    /// 验证方法
    /// </summary>
    public static class VerifyMethod
    {
        /// <summary>
        /// 是否数字
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNumeric(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*[.]?\d*$");
        }

        /// <summary>
        /// 是否Int
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsInt(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*$");
        }
    }
}
