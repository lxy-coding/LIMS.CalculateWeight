using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 精炼炉次状态记录
    /// </summary>
    [Serializable]
    public class REFINE_HEAT_STATUS
    {
        /// <summary>
        /// 序号，主键，自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 序号，外键，精炼站属性表ID
        /// <summary>
        public virtual int? REF_ID { get; set; }
        /// <summary>
        /// 炉次号
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 计划号
        /// <summary>
        public virtual string PLAN_NUM { get; set; }
        /// <summary>
        /// 工艺路径
        /// <summary>
        public virtual string HEAT_ROUTE { get; set; }
        /// <summary>
        /// 钢种
        /// <summary>
        public virtual string STEEL_GRADE { get; set; }
        /// <summary>
        /// 炉次状态
        /// <summary>
        public virtual int? HEAT_STATUS { get; set; }
        /// <summary>
        /// 钢包号
        /// <summary>
        public virtual string LADLE_NUM { get; set; }
        /// <summary>
        /// 冶炼位置，1东，2西，3南，4北
        /// <summary>
        public virtual short? SMELT_POSIT { get; set; }
        /// <summary>
        /// 冶炼前温度，℃
        /// <summary>
        public virtual short? BEFORE_SMELT_TEMP { get; set; }
        /// <summary>
        /// 冶炼后温度，℃
        /// <summary>
        public virtual short? AFTER_SMELT_TEMP { get; set; }
        /// <summary>
        /// 时间戳
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
