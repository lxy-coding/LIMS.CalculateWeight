using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Common.Enums
{
    /// <summary>
    /// Enum 帮助类
    /// 段勇明 Add 20200526
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// 获取枚举描述信息
        /// </summary>
        /// <param name="enumMember"></param>
        /// <returns></returns>
        public static string GetDescription(object enumMember)
        {
            FieldInfo fi = enumMember.GetType().GetField(enumMember.ToString());
            DescriptionAttribute attr =
                fi.GetCustomAttribute<DescriptionAttribute>(false);
            return attr != null ? attr.Description : enumMember.ToString();
        }

        /// <summary>
        /// 获取枚举描述信息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetEnumName<T>(int value) where T : new()
        {
            Type t = typeof(T);
            MemberInfo[] mInfos = t.GetMember(t.GetEnumName(value));
            foreach (MemberInfo mInfo in mInfos)
            {
                foreach (var attr in mInfo.GetCustomAttributes<DescriptionAttribute>())
                {
                    return attr.Description;
                }
            }
            return "";
        }

        /// <summary>
        /// 获取枚举描述信息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetEnumName<T>(string value) where T : new()
        {
            Type t = typeof(T);
            MemberInfo[] mInfos = t.GetMember(value);
            foreach (MemberInfo mInfo in mInfos)
            {
                if (mInfo.Name == value)
                {
                    foreach (var attr in mInfo.GetCustomAttributes<DescriptionAttribute>())
                    {
                        return attr.Description;
                    }
                }
            }
            return "";
        }
    }
}
