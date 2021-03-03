using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class ST_MATCH_SCRAP {
        public ST_MATCH_SCRAP() { }
        /// <summary>
        /// 主键，GUID
        /// <summary>
        public virtual string GUID { get; set; }
        /// <summary>
        /// 外键，炉次计划表ID
        /// <summary>
        public virtual ST_HEAT_PLAN HEAT_ID { get; set; }
        /// <summary>
        /// 计划编号
        /// <summary>
        public virtual string PLAN_NUM { get; set; }
        /// <summary>
        /// 总重量，单位kg
        /// <summary>
        public virtual int? TOTAL_WEIGHT { get; set; }
        /// <summary>
        /// 废钢编号
        /// <summary>
        public virtual string SCRAP_NUM { get; set; }
        /// <summary>
        /// 重量，单位KG
        /// <summary>
        public virtual int? WEIGHT { get; set; }
        /// <summary>
        /// 废钢装配序列号
        /// <summary>
        public virtual short? MATCH_SERIAL_NUM { get; set; }
        /// <summary>
        /// 废钢供料来源：0为自吸废钢在废钢间自行装配，
        ///1为配送废钢由废钢料场装配，
        ///当为自吸废钢时需要提供计划配废钢时间
        ///
        /// <summary>
        public virtual short? SCRAP_FROM { get; set; }
        /// <summary>
        /// 事件标志：1为新增；2为修改；3为删除
        /// <summary>
        public virtual short? EVENT_FLAG { get; set; }
        /// <summary>
        /// 计划状态变化，时间标签
        /// <summary>
        public virtual DateTime? TIME_STAMP { get; set; }
        /// <summary>
        /// 计划状态：1为计划；2为开始；3为结束；4为中断；5为阻塞
        /// <summary>
        public virtual short? STATUS { get; set; }
        /// <summary>
        /// 生成时间
        /// <summary>
        public virtual DateTime? GENER_TIME { get; set; }
        /// <summary>
        /// 修改时间
        /// <summary>
        public virtual DateTime? MODIFY_TIME { get; set; }
        /// <summary>
        /// 装废钢开始时间
        /// <summary>
        public virtual DateTime? CHARGE_START_TIME { get; set; }
        /// <summary>
        /// 装废钢结束时间
        /// <summary>
        public virtual DateTime? CHARGE_END_TIME { get; set; }
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
