using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class ST_PLAN_MATCH_SLOT_REC {
        public virtual string GUID { get; set; }
        public virtual string PLAN_NUM { get; set; }
        public virtual string HEAT_NUM { get; set; }
        public virtual string SLOT_1_NUM { get; set; }
        public virtual string SLOT_2_NUM { get; set; }
        public virtual string SLOT_3_NUM { get; set; }
        public virtual DateTime? GENER_TIME { get; set; }
        public virtual string SLOT_NUM { get; set; }
        public virtual DateTime? MATCH_TIME { get; set; }
        public virtual string USER_NUM { get; set; }
        public virtual short? FLAG { get; set; }
    }
}
