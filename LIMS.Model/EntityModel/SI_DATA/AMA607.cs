using System.Collections.Generic;
using System.Text;
using System;
using Castle.ActiveRecord;


namespace LIMS.Model.EntityModel
{


    [Serializable]
    public class AMA607
    {
        /// <summary>
        /// 序号
        /// <summary>
        public virtual long MSG_COUNTER { get; set; }
        /// <summary>
        /// 消息时间
        /// <summary>
        public virtual DateTime MSG_TIME { get; set; }
        /// <summary>
        /// 读取时间
        /// <summary>
        public virtual DateTime? READ_TIME { get; set; }
        /// <summary>
        /// 消息状态
        /// <summary>
        public virtual string MSG_STATUS { get; set; }
        /// <summary>
        /// 操作类型
        /// <summary>
        public virtual string OP_DIV { get; set; }
        /// <summary>
        /// 处理号
        /// <summary>
        public virtual string PROC_NO { get; set; }
        /// <summary>
        /// 设备代码
        /// <summary>
        public virtual string DEV_CODE { get; set; }
        /// <summary>
        /// 炼钢计划号
        /// <summary>
        public virtual string SM_PLAN_NO { get; set; }
        /// <summary>
        /// 制造命令号
        /// <summary>
        public virtual string PONO { get; set; }
        /// <summary>
        /// 炉号（熔炼号）
        /// <summary>
        public virtual string HEAT_NO { get; set; }
        /// <summary>
        /// 温度值
        /// <summary>
        public virtual string TEMP_VAL { get; set; }
        /// <summary>
        /// 测温时刻
        /// <summary>
        public virtual string MEASURE_TIME { get; set; }

    }
}
