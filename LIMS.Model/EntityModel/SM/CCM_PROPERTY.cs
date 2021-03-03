using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 连铸属性
    /// </summary>
    [Serializable]

    public class CCM_PROPERTY
    {
        /// <summary>
        /// 序号，主键，自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 对象ID
        /// <summary>
        public virtual int? OBJ_ID { get; set; }
        /// <summary>
        /// 吊包位编号
        /// <summary>
        public virtual int? CRANE_ID { get; set; }
        /// <summary>
        /// 浇铸位编号
        /// <summary>
        public virtual int? HANDLE_ID { get; set; }
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
