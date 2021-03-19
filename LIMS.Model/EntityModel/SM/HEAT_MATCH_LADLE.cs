using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 炉次配包
    /// </summary>
    [Serializable]
    public class HEAT_MATCH_LADLE
    {
        /// <summary>
        /// 序号;主键，自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 钢包号;
        /// <summary>
        public virtual string LADLE_NUM { get; set; }
        /// <summary>
        /// 转炉编号;
        /// <summary>
        public virtual string BOF_NUM { get; set; }
        /// <summary>
        /// 热修记录ID;
        /// <summary>
        public virtual string HOT_REPAIR_ID { get; set; }
        /// <summary>
        /// 时间戳;状态变化时间
        /// <summary>
        public virtual DateTime? TIME_STAMP { get; set; }
        /// <summary>
        /// 预留字段1;
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2;
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3;
        /// <summary>
        public virtual string FIELD3 { get; set; }
        /// <summary>
        /// 钢种
        /// <summary>
        public virtual string GRADE { get; set; }
        /// <summary>
        /// 计划号;
        /// <summary>
        public virtual string PLAN_NUM { get; set; }
    }
}
