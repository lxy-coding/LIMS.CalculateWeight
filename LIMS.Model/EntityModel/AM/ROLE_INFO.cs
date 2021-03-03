using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 角色
    /// </summary>
    [Serializable]
    public class ROLE_INFO
    {
        public ROLE_INFO() { }
        /// <summary>
        /// 序号;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 角色编号;
        /// <summary>
        public virtual string ROLE_NUM { get; set; }
        /// <summary>
        /// 角色名称;
        /// <summary>
        public virtual string ROLE_NAM { get; set; }
        /// <summary>
        /// 创建该角色的用户账号;该角色由哪个用户创建，对应用户表中的账号
        /// <summary>
        public virtual string CREATE_USER_NUM { get; set; }
        /// <summary>
        /// 是否启用;
        /// <summary>
        public virtual short? ENABLE_FLAG { get; set; }
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
