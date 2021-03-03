using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class CRANE_HMI_CONFIG_INFO {
        /// <summary>
        /// 序号，自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 跨区表ID
        /// <summary>
        public virtual int SPA_ID { get; set; }
        /// <summary>
        /// 天车属性表ID
        /// <summary>
        public virtual int CRANE_ID { get; set; }
        /// <summary>
        /// 天车X允许偏差，mm
        /// <summary>
        public virtual int DEV_X { get; set; }
        /// <summary>
        /// 天车Y允许偏差，mm
        /// <summary>
        public virtual int DEV_Y { get; set; }
        /// <summary>
        /// 天车Z允许偏差，mm
        /// <summary>
        public virtual int DEV_Z { get; set; }
        /// <summary>
        /// 跨线最大X，mm
        /// <summary>
        public virtual int? MAX_SPA_X { get; set; }
        /// <summary>
        /// 跨线最大Y，mm
        /// <summary>
        public virtual int? MAX_SPA_Y { get; set; }
        /// <summary>
        /// X方向校准值，mm
        /// <summary>
        public virtual int CANVAS_RECT_X { get; set; }
        /// <summary>
        /// Y方向校准值，mm
        /// <summary>
        public virtual int CANVAS_RECT_Y { get; set; }
        /// <summary>
        /// 动画区域配置表ID
        /// <summary>
        public virtual int? CONFIG_ID { get; set; }
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
