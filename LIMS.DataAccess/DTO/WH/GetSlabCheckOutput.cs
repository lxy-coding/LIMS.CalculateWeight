using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO
{
    /// <summary>
    /// 板坯核库查询输出DTO
    /// Add 2020-05-14 段勇明
    /// </summary>
    public class GetSlabCheckOutput
    {
        /// <summary>
        /// 区域ID
        /// </summary>
        public string AREA_ID { get; set; }
        /// <summary>
        /// 货位ID
        /// </summary>
        public string POSITION_ID { get; set; }
        /// <summary>
        /// 区域名称
        /// </summary>
        public string AREA_NAME { get; set; }
        /// <summary>
        /// 货位名称
        /// </summary>
        public string POSITION_NAME { get; set; }
        /// <summary>
        /// 跨ID
        /// </summary>
        public string SPA_ID { get; set; }
        /// <summary>
        /// 跨名称
        /// </summary>
        public string SPA_NAME { get; set; }
        /// <summary>
        /// 区域类型 1：板坯 2：方坯
        /// </summary>
        public string PROPERTY { get; set; }
        /// <summary>
        /// 总层数
        /// </summary>
        public string LAYERS { get; set; }
    }
}
