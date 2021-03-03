using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class PLAN_BASIC_INFO {
        public PLAN_BASIC_INFO() { }
        /// <summary>
        /// 计划ID：自增ID
        /// <summary>
        public virtual int PLAN_ID { get; set; }
        /// <summary>
        /// 计划类型
        /// <summary>
        public virtual short? PLAN_TYPE { get; set; }
        /// <summary>
        /// 规则ID集合
        /// <summary>
        public virtual string RULE_ID_GATHER { get; set; }
        /// <summary>
        /// 计划名
        /// <summary>
        public virtual string PLAN_NAME { get; set; }
        /// <summary>
        /// 计划类名
        /// <summary>
        public virtual string PLAN_CLASS { get; set; }
        /// <summary>
        /// 计划注释
        /// <summary>
        public virtual string PLAN_ANNOTATION { get; set; }
        /// <summary>
        /// 是否启用：0为非，1为是
        /// <summary>
        public virtual short? IS_ENABLE { get; set; }
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
    }
}
