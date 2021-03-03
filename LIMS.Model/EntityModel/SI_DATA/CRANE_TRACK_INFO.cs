using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 天车物流跟踪信息Model
    /// </summary>
    public class CRANE_TRACK_INFO
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
        /// 计划顺序号
        /// <summary>
        public string SM_PLAN_NO { get; set; }

        /// <summary>
        /// 炉次号
        /// <summary>
        public string HEAT_NO { get; set; }

        /// <summary>
        /// 包号
        /// <summary>
        public string LADLE_NO { get; set; }

        /// <summary>
        /// 包龄
        /// <summary>
        public long LADLE_AGE { get; set; }

        /// <summary>
        /// 包况
        /// <summary>
        public string LADLE_STATUS { get; set; }

        /// <summary>
        /// 工位号
        /// <summary>
        public string PROD_MAKER { get; set; }

        /// <summary>
        /// 毛重
        /// <summary>
        public int GRASS_WT { get; set; }

        /// <summary>
        /// 皮重
        /// <summary>
        public int TARE_WT { get; set; }

        /// <summary>
        /// 净重
        /// <summary>
        public int NET_WT { get; set; }

        /// <summary>
        /// 事件类型
        /// <summary>
        public string RUN_SIGNAL { get; set; }

        /// <summary>
        /// 事件发生时刻
        /// <summary>
        public DateTime? START_TIME_EVENT { get; set; }

    }
}
