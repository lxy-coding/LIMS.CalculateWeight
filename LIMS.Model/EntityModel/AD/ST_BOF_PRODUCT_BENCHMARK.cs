using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class ST_BOF_PRODUCT_BENCHMARK {
        public virtual int ID { get; set; }
        public virtual string GRADE { get; set; }
        public virtual int? MIN_SCRAP_WEIGHT { get; set; }
        public virtual int? MAX_SCRAP_WEIGHT { get; set; }
        public virtual int? MAX_COMMON_IRON { get; set; }
        public virtual int? MIN_LOW_NI_IRON { get; set; }
        public virtual int? MIN_DREGS_STEEL { get; set; }
        public virtual int? MIN_UNIFY_MATERIAL { get; set; }
        public virtual int? MIN_CLASS1_SCRAP { get; set; }
        public virtual int? MIN_CLASS2_SCRAP { get; set; }
        public virtual int? MIN_COMMON_IRON { get; set; }
        public virtual int? MAX_LOW_NI_IRON { get; set; }
        public virtual int? MAX_DREGS_STEEL { get; set; }
        public virtual int? MAX_UNIFY_MATERIAL { get; set; }
        public virtual int? MAX_CLASS1_SCRAP { get; set; }
        public virtual int? MAX_CLASS2_SCRAP { get; set; }
        public virtual int? MIN_IRON_WEIGHT { get; set; }
        public virtual int? MAX_IRON_WEIGHT { get; set; }
        public virtual float? MIN_C { get; set; }
        public virtual float? MAX_C { get; set; }
        public virtual float? MIN_SI { get; set; }
        public virtual float? MAX_SI { get; set; }
        public virtual float? MIN_MN { get; set; }
        public virtual float? MAX_MN { get; set; }
        public virtual float? MIN_P { get; set; }
        public virtual float? MAX_P { get; set; }
        public virtual float? MIN_S { get; set; }
        public virtual float? MAX_S { get; set; }
        public virtual float? MIN_AS { get; set; }
        public virtual float? MAX_AS { get; set; }
        public virtual float? CLASS2_SCRAP_WEIGHT { get; set; }
        public virtual float? MIN_TI { get; set; }
        public virtual float? MAX_TI { get; set; }
        public virtual DateTime? ACCEPT_TIME { get; set; }
        public virtual DateTime? UPDATE_TIME { get; set; }
    }
}
