using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 对象类型
    /// </summary>
    [Serializable]
    public class OBJECT_TYPE
    {
        /// <summary>
        /// 序号; 自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 对象编号;
        /// <summary>
        public virtual string OBJ_NUM { get; set; }
        /// <summary>
        /// 对象类型名称;
        /// <summary>
        public virtual string OBJ_TYPE_NAME { get; set; }
        /// <summary>
        /// 描述;
        /// <summary>
        public virtual string DESCRIPTION { get; set; }
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
    }
}
