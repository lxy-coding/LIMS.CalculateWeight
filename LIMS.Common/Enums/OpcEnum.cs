using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Common.Enums
{
    /// <summary>
    /// 数据类型
    /// </summary>
    public enum E_DataType
    {
        /// <summary>
        /// 布尔
        /// </summary>
        Bool=11,
        /// <summary>
        /// 字节
        /// </summary>
        Byte=17,
        /// <summary>
        /// 128位浮点数
        /// </summary>
        Decimal=14,
        /// <summary>
        /// 双精度浮点数
        /// </summary>
        Double = 5,
        /// <summary>
        /// 整型
        /// </summary>
        Int=2,
        /// <summary>
        /// 双整型
        /// </summary>
        Long=3,
        /// <summary>
        /// 单精度浮点数
        /// </summary>
        Single=4,
        /// <summary>
        /// 字符串
        /// </summary>
        String=8,
        /// <summary>
        /// 日期
        /// </summary>
        DateTime=1,
    }
}
