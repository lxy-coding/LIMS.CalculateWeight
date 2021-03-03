using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 钢包识别
    /// </summary>
    [Serializable]
    public class LADLE_DISCERN
    {
        /// <summary>
        /// 序号,GUID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 相机编号
        /// <summary>
        public virtual string CRAMERA_NUM { get; set; }
        /// <summary>
        /// 工位信息表ID
        /// <summary>
        public virtual string WST_NUM { get; set; }
        /// <summary>
        /// 跟踪包号
        /// <summary>
        public virtual string TRACKING_NUM { get; set; }
        /// <summary>
        /// 识别包号
        /// <summary>
        public virtual string DISCERN_NUM { get; set; }
        /// <summary>
        /// 确认包号
        /// <summary>
        public virtual string CONFIRM_NUM { get; set; }
        /// <summary>
        /// 跟踪标志，默认0
        /// <summary>
        public virtual short? TRACKING_FLAG { get; set; }
        /// <summary>
        /// 识别标志，默认0
        /// <summary>
        public virtual short? DISCERN_FLAG { get; set; }
        /// <summary>
        /// 确认标志，默认0
        /// <summary>
        public virtual short? CONFIRM_FLAG { get; set; }
        /// <summary>
        /// 上下线标志，1下线，2上线，默认0
        /// <summary>
        public virtual short? DH_FLAG { get; set; }
        /// <summary>
        /// 图片路径
        /// <summary>
        public virtual string IMAGE_ADDRESS { get; set; }
        /// <summary>
        /// 预留字段1
        /// <summary>
        public virtual string FIELD4 { get; set; }
        /// <summary>
        /// 预留字段2
        /// <summary>
        public virtual string FIELD5 { get; set; }
        /// <summary>
        /// 预留字段3,Xml形式字符串
        /// <summary>
        public virtual string FIELD6 { get; set; }
    }
}
