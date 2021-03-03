using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class OPERATOR_BASIC_INFO {
        /// <summary>
        /// 算子ID
        /// <summary>
        public virtual int OPERATOR_ID { get; set; }
        /// <summary>
        /// 算子类型：1筛选 2优选 3计划计算 4计划分解
        /// <summary>
        public virtual short OPERATOR_TYPE { get; set; }
        /// <summary>
        /// 优选类型集合：使用$隔开
        /// <summary>
        public virtual string PRIORITY_TYPE_GATHER { get; set; }
        /// <summary>
        /// 算子名称：描述名称
        /// <summary>
        public virtual string OPERATOR_NAME { get; set; }
        /// <summary>
        /// 算子类名：编码类名
        /// <summary>
        public virtual string OPERATOR_CLASS { get; set; }
        /// <summary>
        /// 算子功能注释
        /// <summary>
        public virtual string OPERATOR_ANNOTATION { get; set; }
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
