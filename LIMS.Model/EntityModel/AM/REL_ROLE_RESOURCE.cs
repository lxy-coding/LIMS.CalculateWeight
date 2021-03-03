using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 角色与资源关系
    /// </summary>
    [Serializable]
    public class REL_ROLE_RESOURCE
    {
        /// <summary>
        /// 序号;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 资源信息_序号;
        /// <summary>
        public virtual RESOURCE_INFO RES_ID { get; set; }
        /// <summary>
        /// 角色信息_序号;
        /// <summary>
        public virtual ROLE_INFO ROL_ID { get; set; }
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
