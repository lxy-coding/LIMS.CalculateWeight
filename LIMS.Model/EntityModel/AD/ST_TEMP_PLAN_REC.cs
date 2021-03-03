using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class ST_TEMP_PLAN_REC {
        /// <summary>
        /// 主键，GUID
        /// <summary>
        public virtual string GUID { get; set; }
        /// <summary>
        /// 计划号
        /// <summary>
        public virtual string PLAN_NUM { get; set; }
        /// <summary>
        /// 吊物类型,，关联字典
        /// <summary>
        public virtual short? ARTICLE_TYPE { get; set; }
        /// <summary>
        /// 物重，单位kg
        /// <summary>
        public virtual int? WEIGHT { get; set; }
        /// <summary>
        /// 开始位置ID，货位或工位ID
        /// <summary>
        public virtual int? START_WST_ID { get; set; }
        /// <summary>
        /// 结束位置ID，货位或工位ID
        /// <summary>
        public virtual int? END_WST_ID { get; set; }
        /// <summary>
        /// 跨ID
        /// <summary>
        public virtual int? SPA_ID { get; set; }
        /// <summary>
        /// 天车ID
        /// <summary>
        public virtual int? CRA_ID { get; set; }
        public virtual DateTime? START_TIME { get; set; }
        public virtual DateTime? END_TIME { get; set; }
        /// <summary>
        /// 占用时长，单位min
        /// <summary>
        public virtual int? OCCUPY_DURAT { get; set; }
        /// <summary>
        /// 计划状态变化，时间标签
        /// <summary>
        public virtual DateTime? TIME_STAMP { get; set; }
        /// <summary>
        /// 录入人编号
        /// <summary>
        public virtual string USER_NUM { get; set; }
        /// <summary>
        /// 1为手动录入，2为接口，3为系统计算，4为其他
        /// <summary>
        public virtual short? PLAN_ORGIN { get; set; }
        /// <summary>
        /// 计划失败原因
        /// <summary>
        public virtual string FAILURE_REASON { get; set; }
        /// <summary>
        /// 0为未作废，1为作废
        /// <summary>
        public virtual short? IS_PLAN_CANCEL { get; set; }
        /// <summary>
        /// 决策者确定计划作废的时间
        /// <summary>
        public virtual DateTime? CANCEL_TIME { get; set; }
        /// <summary>
        /// 生成时间
        /// <summary>
        public virtual DateTime? GENER_TIME { get; set; }
        /// <summary>
        /// 计划状态：1为计划；2为开始；3为结束；4为中断；5为阻塞
        /// <summary>
        public virtual short? STATUS { get; set; }
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
