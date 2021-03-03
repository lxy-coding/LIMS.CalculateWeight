using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO
{
    /// <summary>
    /// 核库层数查询输出DTO
    /// Add 2020-05-14 段勇明
    /// </summary>
    public class GetCheckLayersOutput
    {
        /// <summary>
        /// 货位编号
        /// </summary>
        public string POSITION_NAME { get; set; }
        /// <summary>
        /// 层数
        /// </summary>
        public string LAYER { get; set; }
        /// <summary>
        /// 坯料号
        /// </summary>
        public string STEEL_NUM { get; set; }

    }
}
