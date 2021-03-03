using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 车牌号识别
    /// </summary>
    [Serializable]
    public class VEHICLE_DISCRIMINATE_RECORD
    {
        /// <summary>
        /// 序号; 自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 相机编号;
        /// <summary>
        public virtual string CAMERA_NUM { get; set; }
        /// <summary>
        /// 识别结果;
        /// <summary>
        public virtual string DISCRIMINATE_RESULT { get; set; }
        /// <summary>
        /// 精确等级;
        /// <summary>
        public virtual string ACCURACY { get; set; }
        /// <summary>
        /// 识别图片;
        /// <summary>
        public virtual string DISCRIMINATE_IMAGE { get; set; }
        /// <summary>
        /// 工位;
        /// <summary>
        public virtual string WST_NUM { get; set; }
        /// <summary>
        /// 跟踪结果;
        /// <summary>
        public virtual string TRACKING_RESULT { get; set; }
        /// <summary>
        /// 校正结果;
        /// <summary>
        public virtual string RECTIFY_RESULT { get; set; }
        /// <summary>
        /// 识别时间;
        /// <summary>
        public virtual DateTime? TIME_STAMP { get; set; }
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
