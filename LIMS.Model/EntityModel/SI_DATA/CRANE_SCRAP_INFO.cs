using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 废钢配比信息Model
    /// </summary>

    public class CRANE_SCRAP_INFO
    {
        /// <summary>
        /// 序号
        /// <summary>
        public long MSG_COUNTER { get; set; }
        public DateTime? MSG_TIME { get; set; }

        public DateTime? READ_TIME { get; set; }

        public string MSG_STATUS { get; set; }

        /// <summary>
        /// 操作类型，I:Insert;U:Update;D:Delete 
        /// <summary>
        public string OP_DIV { get; set; }

        /// <summary>
        /// 熔炼号
        /// </summary>
        public string HEAT_NO { get; set; }
        /// <summary>
        /// 斗号
        /// </summary>
        public string HOPPER_NO { get; set; }
        /// <summary>
        /// 原料种类数量
        /// </summary>
        public short MAT_COUNT { get; set; }
        /// <summary>
        /// 普通生铁重量
        /// </summary>
        public float MATWET1 { get; set; }
        /// <summary>
        /// 低镍生铁）重量
        /// </summary>
        public float MATWET2 { get; set; }
        /// <summary>
        /// 渣钢重量
        /// </summary>
        public float MATWET3 { get; set; }
        /// <summary>
        /// 统料重量
        /// </summary>
        public float MATWET4 { get; set; }
        /// <summary>
        /// 一类废钢重量
        /// </summary>
        public float MATWET5 { get; set; }
        /// <summary>
        /// 二类废钢重量
        /// </summary>
        public float MATWET6 { get; set; }

        /// <summary>
        /// 废钢总量
        /// </summary>
        public float SCRAP_WGT { get; set; }
        /// <summary>
        /// 废钢加入开始时刻
        /// </summary>
        public DateTime? SCRAP_LOAD_START_TIME { get; set; }
        /// <summary>
        /// 废钢加入完成时刻
        /// </summary>
        public DateTime? SCRAP_LOAD_END_TIME { get; set; }
        /// <summary>
        /// 计量委托单号
        /// </summary>
        public string REFE_ID { get; set; }

        public float SCALE_WGT { get; set; }
    }
}
