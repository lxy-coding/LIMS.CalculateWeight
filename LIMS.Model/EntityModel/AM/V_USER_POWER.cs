using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 资源
    /// </summary>
    [Serializable]
    public class V_USER_POWER
    {
        public V_USER_POWER() { }
        /// <summary>
        /// 序号;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 编码;
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 名称;
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// 选中状态;
        /// <summary>
        public virtual string SELECTED { get; set; }
        /// <summary>
        /// 父资源编号;
        /// <summary>
        public virtual string PAR_RESOURCE_NUM { get; set; }
        /// <summary>
        /// 显示顺序;
        /// <summary>
        public virtual short? DISP_INDEX { get; set; }
        /// <summary>
        /// 父资源ID;
        /// <summary>
        public virtual RESOURCE_INFO PAR_RESOURCE_ID { get; set; }
        /// <summary>
        /// 地址;
        /// <summary>
        public virtual string URL { get; set; }
        /// <summary>
        /// 层级;
        /// <summary>
        public virtual short? LEVELS { get; set; }
        /// <summary>
        /// 图标;
        /// <summary>
        public virtual string ICON { get; set; }
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
        /// <summary>
        /// 角色;
        /// <summary>
        public virtual ROLE_INFO ROLE_ID { get; set; }
        /// <summary>
        /// 用户;
        /// <summary>
        public virtual USER_INFO USER_ID { get; set; }
    }
}
