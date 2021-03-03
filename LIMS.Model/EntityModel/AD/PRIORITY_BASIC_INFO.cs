using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class PRIORITY_BASIC_INFO {
        public PRIORITY_BASIC_INFO() { }
        /// <summary>
        /// 优选ID
        /// <summary>
        public virtual int PRIORITY_ID { get; set; }
        /// <summary>
        /// 优选类型
        /// <summary>
        public virtual short? PRIORITY_TYPE { get; set; }
        /// <summary>
        /// 优选名称：描述名称
        /// <summary>
        public virtual string PRIORITY_NAME { get; set; }
        /// <summary>
        /// 优选类名：编码类名
        /// <summary>
        public virtual string PRIORITY_CLASS { get; set; }
        /// <summary>
        /// 优选功能注释
        /// <summary>
        public virtual string PRIORITY_ANNOTATION { get; set; }
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
