using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class PLAN_MAP {
        /// <summary>
        /// 业务ID
        /// <summary>
        public virtual long BUSI_ID { get; set; }
        /// <summary>
        /// 计划ID
        /// <summary>
        public virtual PLAN_BASIC_INFO PLAN_ID { get; set; }
        /// <summary>
        /// 规则ID
        /// <summary>
        public virtual RULE_BASIC_INFO RULE_ID { get; set; }
        /// <summary>
        /// 关键数据
        /// <summary>
        public virtual string KEY_DATA { get; set; }
        /// <summary>
        /// 优选ID集合：使用$隔开
        /// <summary>
        public virtual string PRIORITY_ID_GATHER { get; set; }
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
