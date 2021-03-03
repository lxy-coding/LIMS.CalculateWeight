using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 翻包机信号
    /// </summary>
    [Serializable]

    public class TILTER_SIGNAL
    {
        /// <summary>
        /// 序号，主键，自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 序号，外键，翻包机属性表ID
        /// <summary>
        public virtual TILTER_PROPERTY TIL_ID { get; set; }
        /// <summary>
        /// 钢包号
        /// <summary>
        public virtual string LADLE_NUM { get; set; }
        /// <summary>
        /// 对象状态表ID
        /// <summary>
        public virtual int? WORK_STATUS { get; set; }
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
