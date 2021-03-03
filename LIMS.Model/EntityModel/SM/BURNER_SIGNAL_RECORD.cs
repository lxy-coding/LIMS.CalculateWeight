using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    /// <summary>
    /// 烤包器实时数据记录
    /// </summary>
    [Serializable]

    public class BURNER_SIGNAL_RECORD
    {
        /// <summary>
        /// 序号;主键，GUID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 对象表ID;
        /// <summary>
        public virtual int? OBJ_ID { get; set; }
        /// <summary>
        /// 煤气快切阀开; 0：未开；1：开
        /// <summary>
        public virtual short? GAS_VALVE_OPEN { get; set; }
        /// <summary>
        /// 火焰熄灭; 0：未熄灭；1：熄灭
        /// <summary>
        public virtual short? FLAME_EXTINGUISH { get; set; }
        /// <summary>
        /// 火焰类型;
        /// <summary>
        public virtual short? FIRE_TYPE { get; set; }
        /// <summary>
        /// 煤气流量; m3/h
        /// <summary>
        public virtual float? GAS_FLUX { get; set; }
        /// <summary>
        /// 煤气压力; kpa
        /// <summary>
        public virtual float? GAS_PRESS { get; set; }
        /// <summary>
        /// 工作状态; 对象状态表ID
        /// <summary>
        public virtual int? WORK_STATUS { get; set; }
        /// <summary>
        /// 烘烤状态; 参照对象状态表ID
        /// <summary>
        public virtual int? REHEAT_STATUS { get; set; }
        /// <summary>
        /// 钢包号;
        /// <summary>
        public virtual string LADLE_NUM { get; set; }
        /// <summary>
        /// 烘烤开始时间;
        /// <summary>
        public virtual DateTime? START_TIME { get; set; }
        /// <summary>
        /// 烘烤结束时间;
        /// <summary>
        public virtual DateTime? END_TIME { get; set; }
        /// <summary>
        /// 记录生成时间;
        /// <summary>
        public virtual DateTime? TIME_STAMP { get; set; }
        /// <summary>
        /// 预留字段1;
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2;
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3;
        /// <summary>
        public virtual string FIELD3 { get; set; }
    }
}
