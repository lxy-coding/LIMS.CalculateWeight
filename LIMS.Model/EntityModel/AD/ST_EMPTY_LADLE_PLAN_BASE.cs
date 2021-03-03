using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class ST_EMPTY_LADLE_PLAN_BASE {
        /// <summary>
        /// 主键，GUID
        /// <summary>
        public virtual string GUID { get; set; }
        /// <summary>
        /// 点对点吊运计划编号
        /// <summary>
        public virtual string LADLE_PLAN_NUM { get; set; }
        /// <summary>
        /// 计划运输设备编号
        /// <summary>
        public virtual int? PLAN_TRANS_ID { get; set; }
        public virtual int? LADLE_ID { get; set; }
        /// <summary>
        /// 钢包当前所处工位
        /// <summary>
        public virtual int? CURRENT_WST_ID { get; set; }
        /// <summary>
        /// 目标工位
        /// <summary>
        public virtual int? RCM_WST_ID { get; set; }
        /// <summary>
        /// 生成时间
        /// <summary>
        public virtual DateTime? GENER_TIME { get; set; }
        /// <summary>
        /// 修改时间
        /// <summary>
        public virtual DateTime? MODIFY_TIME { get; set; }
        /// <summary>
        /// 决策人编号
        /// <summary>
        public virtual string USER_NUM { get; set; }
        /// <summary>
        /// 决策者确定目标工位的时间
        /// <summary>
        public virtual DateTime? ACCEPT_TIME { get; set; }
        /// <summary>
        /// 计划状态：1为计划；2为开始；3为结束；4为中断；5为阻塞
        /// <summary>
        public virtual short? STATUS { get; set; }
        /// <summary>
        /// 计划来源
        /// <summary>
        public virtual short? PLAN_ORGIN { get; set; }
        /// <summary>
        /// 计划失败原因
        /// <summary>
        public virtual string FAILURE_REASON { get; set; }
        /// <summary>
        /// 计划是否作废：0为未作废，1为作废
        /// <summary>
        public virtual short? IS_PLAN_CANCEL { get; set; }
        /// <summary>
        /// 决策者确定计划作废的时间
        /// <summary>
        public virtual DateTime? CANCEL_TIME { get; set; }
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
        /// 默认为0，人工修改1，校验流程读取2，计算流程重算3
        /// <summary>
        public virtual short? MODIFY_STATUS { get; set; }
    }
}
