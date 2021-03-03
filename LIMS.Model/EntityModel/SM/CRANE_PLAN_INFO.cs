using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
[Serializable]
    
    public class CRANE_PLAN_INFO {
        /// <summary>
        /// GUID;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 天车属性_序号;
        /// <summary>
        public virtual int? CRA_ID { get; set; }
        /// <summary>
        /// 计划号    
        /// <summary>
        public virtual string PLAN_NUM { get; set; }
        /// <summary>
        /// 计划状态，参照对象类型状态表ID
        /// <summary>
        public virtual int? PLAN_STATUS { get; set; }
        /// <summary>
        /// 容器编号
        /// <summary>
        public virtual string CON_NUM { get; set; }
        /// <summary>
        /// 起始位置
        /// <summary>
        public virtual string START_POSIT { get; set; }
        /// <summary>
        /// 起始时间
        /// <summary>
        public virtual string START_TIME { get; set; }
        /// <summary>
        /// 结束位置
        /// <summary>
        public virtual string END_POSIT { get; set; }
        /// <summary>
        /// 结束时间
        /// <summary>
        public virtual string END_TIME { get; set; }
        /// <summary>
        /// 预留字段1
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3
        /// <summary>
        public virtual string FIELD3 { get; set; }
        /// <summary>
        /// 创建时间
        /// <summary>
        public virtual DateTime? CREATE_TIME { get; set; }
    }
}
