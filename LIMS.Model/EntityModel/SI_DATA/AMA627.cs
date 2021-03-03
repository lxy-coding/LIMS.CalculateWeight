using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class AMA627 {
        public virtual long MSG_COUNTER { get; set; }
        public virtual DateTime MSG_TIME { get; set; }
        public virtual DateTime? READ_TIME { get; set; }
        public virtual string MSG_STATUS { get; set; }
        public virtual string OP_DIV { get; set; }
        public virtual string PROD_SHIFT_NO { get; set; }
        public virtual string PROD_SHIFT_GROUP { get; set; }
        public virtual string PROD_MAKER { get; set; }
        public virtual string VEHICLE_NO { get; set; }
        public virtual string HOPPER_NO { get; set; }
        public virtual string REFE_ID { get; set; }
    }
}
