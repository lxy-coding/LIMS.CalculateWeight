using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// HOOK
    /// </summary>
    [Serializable]
    public class HOOK
    {
        /// <summary>
        /// 序号; 自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 对象类型ID; 逻辑关联对象类型表
        /// <summary>
        public virtual OBJECT_TYPE OBJ_TYPE_ID { get; set; }
        /// <summary>
        /// 吊钩编号;
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 吊钩名称;
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// 净重; 单位kg
        /// <summary>
        public virtual int? BASE_WEIGHT { get; set; }
        /// <summary>
        /// 限重; 单位kg
        /// <summary>
        public virtual int? LIMIT_WEIGHT { get; set; }
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
