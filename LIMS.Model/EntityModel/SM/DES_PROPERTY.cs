using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    /// <summary>
    /// 脱硫属性
    /// </summary>
    [Serializable]

    public class DES_PROPERTY
    {
        public DES_PROPERTY() { }
        /// <summary>
        /// 序号，主键，自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 对象表中ID
        /// <summary>
        public virtual int? OBJ_ID { get; set; }
        /// <summary>
        /// 吊包位编号
        /// <summary>
        public virtual string HOIST_WST { get; set; }
        /// <summary>
        /// 处理位编号
        /// <summary>
        public virtual string DEAL_WST { get; set; }
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
