using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 翻包机属性
    /// </summary>
    [Serializable]
    public class TILTER_PROPERTY
    {
        public TILTER_PROPERTY() { }
        /// <summary>
        /// 序号，主键，ID
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 对象表ID
        /// <summary>
        public virtual int? OBJ_ID { get; set; }
        /// <summary>
        /// 1号热修位
        /// <summary>
        public virtual string WST1 { get; set; }
        /// <summary>
        /// 2号热修位
        /// <summary>
        public virtual string WST2 { get; set; }
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
