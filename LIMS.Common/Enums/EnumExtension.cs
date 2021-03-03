using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Common.Enums
{
    public static class EnumExtension
    {
        /// <summary>
        /// 获取枚举Int值
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static int GetInt(this Enum e)
        {
            return Convert.ToInt32(e);
        }

    }
}
