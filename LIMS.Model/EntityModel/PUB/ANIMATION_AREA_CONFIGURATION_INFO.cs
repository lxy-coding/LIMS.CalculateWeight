using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 动画区域配置详细表
    /// </summary>
    [Serializable]
    public class ANIMATION_AREA_CONFIGURATION_INFO
    {
        /// <summary>
        /// ID
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 配置表ID
        /// <summary>
        public virtual ANIMATION_AREA_CONFIGURATION CONFIGURATION_ID { get; set; }
        /// <summary>
        /// 对象ID
        /// <summary>
        public virtual int OBJ_ID { get; set; }
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
