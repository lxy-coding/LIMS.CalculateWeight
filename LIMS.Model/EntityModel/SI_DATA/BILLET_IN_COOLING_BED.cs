using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class BILLET_IN_COOLING_BED {
        public virtual long MSG_COUNTER { get; set; }
        public virtual DateTime? MSG_TIME { get; set; }
        public virtual DateTime? READ_TIME { get; set; }
        public virtual string MSG_STATUS { get; set; }
        public virtual string OP_DIV { get; set; }
        public virtual string PLANT_NO { get; set; }
        public virtual string POSIT { get; set; }
        public virtual string EXTERNAL1_BILLET_NO { get; set; }
        public virtual string EXTERNAL1_HEAT_NO { get; set; }
        public virtual short? EXTERNAL1_STRAND_NO { get; set; }
        public virtual string EXTERNAL2_BILLET_NO { get; set; }
        public virtual string EXTERNAL2_HEAT_NO { get; set; }
        public virtual short? EXTERNAL2_STRAND_NO { get; set; }
        public virtual string EXTERNAL3_BILLET_NO { get; set; }
        public virtual string EXTERNAL3_HEAT_NO { get; set; }
        public virtual short? EXTERNAL3_STRAND_NO { get; set; }
        public virtual string EXTERNAL4_BILLET_NO { get; set; }
        public virtual string EXTERNAL4_HEAT_NO { get; set; }
        public virtual short? EXTERNAL4_STRAND_NO { get; set; }
        public virtual string EXTERNAL5_BILLET_NO { get; set; }
        public virtual string EXTERNAL5_HEAT_NO { get; set; }
        public virtual short? EXTERNAL5_STRAND_NO { get; set; }
        public virtual string EXTERNAL6_BILLET_NO { get; set; }
        public virtual string EXTERNAL6_HEAT_NO { get; set; }
        public virtual short? EXTERNAL6_STRAND_NO { get; set; }
        public virtual string EXTERNAL7_BILLET_NO { get; set; }
        public virtual string EXTERNAL7_HEAT_NO { get; set; }
        public virtual short? EXTERNAL7_STRAND_NO { get; set; }
        public virtual DateTime? TIME_STAMP { get; set; }
        public virtual string FIELD1 { get; set; }
        public virtual string FIELD2 { get; set; }
        public virtual string FIELD3 { get; set; }
    }
}
