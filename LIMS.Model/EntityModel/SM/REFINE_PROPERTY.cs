using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 精炼炉属性
    /// </summary>
    [Serializable]
    public class REFINE_PROPERTY
    {
        public REFINE_PROPERTY() { }
        /// <summary>
        /// 序号，主键，自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 对象ID
        /// <summary>
        public virtual int? OBJ_ID { get; set; }
        /// <summary>
        /// 1处理位
        /// <summary>
        public virtual string DEAL_WST1 { get; set; }
        /// <summary>
        /// 1吊包位
        /// <summary>
        public virtual string HOIST_WST1 { get; set; }
        /// <summary>
        /// 2处理位
        /// <summary>
        public virtual string DEAL_WST2 { get; set; }
        /// <summary>
        /// 2吊包位
        /// <summary>
        public virtual string HOIST_WST2 { get; set; }
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
