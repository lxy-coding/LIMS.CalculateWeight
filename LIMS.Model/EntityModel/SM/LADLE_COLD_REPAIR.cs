using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class LADLE_COLD_REPAIR {
        public virtual string ID { get; set; }
        public virtual string LADLE_NUM { get; set; }
        public virtual DateTime? COLD_REPAIR_TIME { get; set; }
        public virtual string REPAIR_CLASS { get; set; }
        public virtual string REFRACTORY_MANU { get; set; }
        public virtual DateTime? NEW_LADLE_ONLINE_TIME { get; set; }
        public virtual DateTime? NEW_LADLE_BUILD_TIME { get; set; }
        public virtual string LAYER_LIFE { get; set; }
        public virtual DateTime? ONLINE_TIME { get; set; }
        public virtual DateTime? DOWNLINE_TIME { get; set; }
        public virtual string DOWNLINE_CLASS { get; set; }
        public virtual int? LADLE_LIFE { get; set; }
        public virtual int? ACCUMULATE_LIFE { get; set; }
        public virtual int? NEW_SLAG_BRICK_THICK { get; set; }
        public virtual int? LAST_SLAG_BRICK_THICK { get; set; }
        public virtual int? SLAG_BRICK_THICKNESS { get; set; }
        public virtual int? WALL_THICKNESS { get; set; }
        public virtual int? PUROUS_THICKNESS { get; set; }
        public virtual short? IS_ACCOUNT { get; set; }
        public virtual int? LADLE_MATERIAL_TYPE { get; set; }
        public virtual string UNPACK_REMARK { get; set; }
        public virtual string REPAIR_REMARK { get; set; }
        public virtual string DOWNLINE_REASON { get; set; }
        public virtual string FIELD1 { get; set; }
        public virtual string FIELD2 { get; set; }
        public virtual string FIELD3 { get; set; }
        public virtual int CONID { get; set; }
        public virtual string ONLINE_POSIT { get; set; }
        public virtual short? IS_ONLINE { get; set; }
        public virtual int? BOTTOM_THICKNESS { get; set; }
        public virtual DateTime? TIME_TAMP { get; set; }
    }
}
