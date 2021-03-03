using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class CRANE_SCRAP_INFO
    {
        public virtual int MSG_COUNTER { get; set; }
        public virtual DateTime? MSG_TIME { get; set; }
        public virtual DateTime? READ_TIME { get; set; }
        public virtual string MSG_STATUS { get; set; }
        public virtual string OP_DIV { get; set; }
        public virtual string HEAT_NO { get; set; }
        public virtual string HOPPER_NO { get; set; }
        public virtual short? MAT_COUNT { get; set; }
        public virtual float? MATWET1 { get; set; }
        public virtual float? MATWET2 { get; set; }
        public virtual float? MATWET3 { get; set; }
        public virtual float? MATWET4 { get; set; }
        public virtual float? MATWET5 { get; set; }
        public virtual float? MATWET6 { get; set; }
        public virtual float? MATWET7 { get; set; }
        public virtual float? MATWET8 { get; set; }
        public virtual float? MATWET9 { get; set; }
        public virtual float? MATWET10 { get; set; }
        public virtual float? SCRAP_WGT { get; set; }
        public virtual string SCRAP_LOAD_START_TIME { get; set; }
        public virtual string SCRAP_LOAD_END_TIME { get; set; }
        public virtual string REFE_ID { get; set; }
    }
}
