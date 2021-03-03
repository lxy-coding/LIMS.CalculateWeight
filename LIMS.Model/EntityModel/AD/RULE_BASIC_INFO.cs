using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class RULE_BASIC_INFO {
        public RULE_BASIC_INFO() { }
        /// <summary>
        /// 规则ID
        /// <summary>
        public virtual int RULE_ID { get; set; }
        /// <summary>
        /// 规则类型
        /// <summary>
        public virtual short? RULE_TYPE { get; set; }
        /// <summary>
        /// 优选ID集合：使用$隔开
        /// <summary>
        public virtual string PRIORITY_ID_GATHER { get; set; }
        /// <summary>
        /// 规则名称
        /// <summary>
        public virtual string RULE_NAME { get; set; }
        /// <summary>
        /// 规则类名：编码类名
        /// <summary>
        public virtual string RULE_CLASS { get; set; }
        /// <summary>
        /// 规则功能注释
        /// <summary>
        public virtual string RULE_ANNOTATION { get; set; }
        /// <summary>
        /// 流程类型：0为计算流程，1为校验流程
        /// <summary>
        public virtual short? PROCESS_TYPE { get; set; }
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
