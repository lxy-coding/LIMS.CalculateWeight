using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class OPERATOR_DEPLOY {
        /// <summary>
        /// 算子配比ID
        /// <summary>
        public virtual long MATCH_ID { get; set; }
        /// <summary>
        /// 计划ID
        /// <summary>
        public virtual PLAN_BASIC_INFO PLAN_ID { get; set; }
        /// <summary>
        /// 优选ID
        /// <summary>
        public virtual PRIORITY_BASIC_INFO PRIORITY_ID { get; set; }
        /// <summary>
        /// 关键数据
        /// <summary>
        public virtual string KEY_DATA { get; set; }
        /// <summary>
        /// 算子集合： 包括算子计算次数（12,1,20,1; 13,2,24,1）
        ///12和13是算子序号，1和2表示计算次数,20和24表示权重
        ///权重范围0到1000  除以1000得到百分比，最后一位1是算子类型
        /// <summary>
        public virtual string OPERATOR_GATHER { get; set; }
        /// <summary>
        /// 计算次数：集合计算次数
        /// <summary>
        public virtual short CALCULATIONS_NUMBER { get; set; }
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
