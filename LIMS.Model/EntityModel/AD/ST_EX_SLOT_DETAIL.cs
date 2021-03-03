using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class ST_EX_SLOT_DETAIL {
        public virtual string GUID { get; set; }
        public virtual string AUTO_NUM { get; set; }
        public virtual int? SLOT_ID { get; set; }
        public virtual int? WEIGHT { get; set; }
        public virtual int? COMMON_IRON_WEIGHT { get; set; }
        public virtual int? LOW_NI_IRON_WEIGHT { get; set; }
        public virtual int? DREGS_STEEL_WEIGHT { get; set; }
        public virtual int? UNIFY_MATERIAL_WEIGHT { get; set; }
        public virtual int? CLASS1_SCRAP_WEIGHT { get; set; }
        public virtual int? CLASS2_SCRAP_WEIGHT { get; set; }
        public virtual DateTime? ACCEPT_TIME { get; set; }
        public virtual DateTime? UPDATE_TIME { get; set; }
        /// <summary>
        /// 0未开始匹配，1待匹配，2已匹配
        /// <summary>
        public virtual short? READ_FLAG { get; set; }
    }
}
