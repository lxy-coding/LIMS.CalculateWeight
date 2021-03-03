using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class ST_IN_HM_DETAIL {
        public virtual string GUID { get; set; }
        public virtual string IRON_NUM { get; set; }
        public virtual int? HM_ID { get; set; }
        public virtual int? WEIGHT { get; set; }
        public virtual float? C { get; set; }
        public virtual float? SI { get; set; }
        public virtual float? MN { get; set; }
        public virtual float? P { get; set; }
        public virtual float? S { get; set; }
        /// <summary>
        /// AS含量
        /// <summary>
        public virtual float? C_AS { get; set; }
        public virtual float? TI { get; set; }
        public virtual DateTime? ACCEPT_TIME { get; set; }
        public virtual DateTime? UPDATE_TIME { get; set; }
        /// <summary>
        /// 0未开始匹配，1待匹配，2已匹配
        /// <summary>
        public virtual short? READ_FLAG { get; set; }
    }
}
