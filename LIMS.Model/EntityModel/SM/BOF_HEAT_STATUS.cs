using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 炉次状态
    /// </summary>
    [Serializable]
    public class BOF_HEAT_STATUS
    {
        /// <summary>
        /// 序号，主键，自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 序号，外键，转炉属性表ID
        /// <summary>
        public virtual int? BOF_ID { get; set; }
        /// <summary>
        /// 炉次号
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 工艺路径
        /// <summary>
        public virtual string HEAT_ROUTE { get; set; }
        /// <summary>
        /// 计划号
        /// <summary>
        public virtual string PLAN_NUM { get; set; }
        /// <summary>
        /// 钢种
        /// <summary>
        public virtual string STEEL_GRADE { get; set; }
        /// <summary>
        /// 对象状态表ID
        /// <summary>
        public virtual int HEAT_STATUS { get; set; }
        /// <summary>
        /// 冶炼开始时间
        /// <summary>
        public virtual DateTime? START_TIME { get; set; }
        /// <summary>
        /// 预计剩余时长，分钟
        /// <summary>
        public virtual short? REMAIN_DURAT { get; set; }
        /// <summary>
        /// 出钢温度，℃
        /// <summary>
        public virtual short? TAP_STEEL_TEMP { get; set; }
        /// <summary>
        /// 测温时刻
        /// <summary>
        public virtual DateTime? TAP_STEEL_TEMP_TIME { get; set; }
        /// <summary>
        /// 状态变化时间
        /// <summary>
        public virtual DateTime? TIME_STAMP { get; set; }
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
