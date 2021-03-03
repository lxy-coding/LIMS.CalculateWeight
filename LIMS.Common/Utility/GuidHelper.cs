using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Common.Utility
{
    public class GuidHelper
    {
        /// <summary>
        /// 获取32位guid
        /// </summary>
        /// <returns></returns>
        public static string GetGuid()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
