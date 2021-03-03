using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class ST_SCRAP_IN_POOL_PLAN {
        /// <summary>
        /// 序号，GUID
        /// <summary>
        public virtual string GUID { get; set; }
        /// <summary>
        /// 计划编号
        /// <summary>
        public virtual string PLAN_NUM { get; set; }
        /// <summary>
        /// 废钢编号
        /// <summary>
        public virtual string SCRAP_NUM { get; set; }
        /// <summary>
        /// 重量，单位kg
        /// <summary>
        public virtual int? WEIGHT { get; set; }
        /// <summary>
        /// 废钢池编号
        /// <summary>
        public virtual string POOL_ID { get; set; }
        /// <summary>
        /// 废钢间编号
        /// <summary>
        public virtual string SPA_ID { get; set; }
        /// <summary>
        /// 生成时间
        /// <summary>
        public virtual DateTime? GENER_TIME { get; set; }
        /// <summary>
        /// 修改时间
        /// <summary>
        public virtual DateTime? MODIFY_TIME { get; set; }
        /// <summary>
        /// 事件标志：1为新增；2为修改；3为删除
        /// <summary>
        public virtual short? EVENT_FLAG { get; set; }
        /// <summary>
        /// 计划状态：1为计划；2为开始；3为结束；4为中断；5为阻塞
        /// <summary>
        public virtual short? STATUS { get; set; }
        /// <summary>
        /// 计划状态变化，时间标签
        /// <summary>
        public virtual DateTime? TIME_STAMP { get; set; }
        /// <summary>
        /// 执行顺序：本计划在上层计划分解后需要执行的步骤对应的序号
        /// <summary>
        public virtual short? EXECUTE_SEQ { get; set; }
        /// <summary>
        /// 是否为最后计划：0为非，1为是
        /// <summary>
        public virtual short? IS_LAST_PLAN { get; set; }
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
