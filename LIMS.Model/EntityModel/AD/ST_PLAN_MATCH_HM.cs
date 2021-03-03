using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class ST_PLAN_MATCH_HM {
        public virtual string GUID { get; set; }
        public virtual string PLAN_NUM { get; set; }
        public virtual string HEAT_NUM { get; set; }
        public virtual string HM1_NUM { get; set; }
        public virtual string HM_2_NUM { get; set; }
        public virtual string HM_3_NUM { get; set; }
        public virtual DateTime? GENER_TIME { get; set; }
        public virtual string HM_NUM { get; set; }
        public virtual DateTime? MATCH_TIME { get; set; }
        public virtual string USER_NUM { get; set; }
        public virtual short? FLAG { get; set; }
    }
}
