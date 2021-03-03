using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class ST_THERMAL_INFO {
        public virtual int ID { get; set; }
        public virtual string THERMAL_STATUS { get; set; }
        public virtual double? MAX_TEMP { get; set; }
        public virtual double? MIN_TEMP { get; set; }
        public virtual double? DROP_NUM { get; set; }
    }
}
