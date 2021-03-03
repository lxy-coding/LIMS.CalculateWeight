using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Common.Enums
{
    public class ScrapEnum
    {
        /// <summary>
        /// 工位类型(按Object_Type表中的ID)
        /// </summary>
        public enum PositionType
        {
            /// <summary>
            /// 废钢池
            /// </summary>
            ScrapPool = 3,
            /// <summary>
            /// 轨道
            /// </summary>
            Rail = 24,
            /// <summary>
            /// 废钢斗
            /// </summary>
            Slot = 16,
            /// <summary>
            /// 台车
            /// </summary>
            Trolley = 2
        }

    }
}
