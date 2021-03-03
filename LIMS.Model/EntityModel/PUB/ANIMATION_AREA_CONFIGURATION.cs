using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 动画区域配置
    /// </summary>
    [Serializable]
    public class ANIMATION_AREA_CONFIGURATION
    {
        public ANIMATION_AREA_CONFIGURATION() { }
        /// <summary>
        /// ID
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 编码
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 名称
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// X轴基准点
        /// <summary>
        public virtual int? CENTRE_X { get; set; }
        /// <summary>
        /// Y轴基准点
        /// <summary>
        public virtual int? CENTRE_Y { get; set; }
        /// <summary>
        /// 长
        /// <summary>
        public virtual int? LENGTH { get; set; }
        /// <summary>
        /// 宽
        /// <summary>
        public virtual int? WIDTH { get; set; }
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
        /// 区域类型;
        /// <summary>
        public virtual short? AREA_TYPE { get; set; }
    }
}
