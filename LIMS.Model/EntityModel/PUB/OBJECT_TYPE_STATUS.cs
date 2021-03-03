using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 对象类型状态
    /// </summary>
    [Serializable]
    public class OBJECT_TYPE_STATUS
    {
        /// <summary>
        /// 序号; 自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 对象类型_序号;
        /// <summary>
        public virtual OBJECT_TYPE OBJ_TYPE_ID { get; set; }
        /// <summary>
        /// 状态类型;
        /// <summary>
        public virtual string STATUS_TYPE { get; set; }
        /// <summary>
        /// 状态编号; 唯一性约束
        /// <summary>
        public virtual string STATUS_NUM { get; set; }
        /// <summary>
        /// 状态名称;
        /// <summary>
        public virtual string STATUS_NAM { get; set; }
        /// <summary>
        /// 状态描述;
        /// <summary>
        public virtual string STATUS_DESCRIBE { get; set; }
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
