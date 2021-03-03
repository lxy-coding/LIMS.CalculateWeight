using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO.SM
{
    /// <summary>
    /// 炉次执行信息
    /// </summary>
    public class HeatinfoDto
    {
        /// <summary>
        /// 炉次号
        /// </summary>
        public string HEAT_NUM { get; set; }

        /// <summary>
        /// 转炉号
        /// </summary>
        public string DEVICE { get; set; }

        /// <summary>
        /// 炉批号
        /// </summary>
        public string ODD { get; set; }

        /// <summary>
        /// 记录生成时间
        /// </summary>
        public DateTime? TIME_TAMP { get; set; }
    }
}
