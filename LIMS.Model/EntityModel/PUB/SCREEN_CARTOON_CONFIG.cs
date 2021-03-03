using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class SCREEN_CARTOON_CONFIG
    {
        /// <summary>
        /// 序号;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 对象类型_序号; 自增
        /// <summary>
        public virtual OBJECT_TYPE OBJ_TYPE_ID { get; set; }
        /// <summary>
        /// 权限管理资源表;
        /// <summary>
        public virtual int? RESOURCE_NUM { get; set; }
        /// <summary>
        /// 是否显示;
        /// <summary>
        public virtual short? IS_SHOW { get; set; }
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
