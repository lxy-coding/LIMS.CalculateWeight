using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class CRANE_TRACK_INFO
    {
        public virtual int MSG_COUNTER { get; set; }
        public virtual DateTime? MSG_TIME { get; set; }
        public virtual DateTime? READ_TIME { get; set; }
        public virtual string MSG_STATUS { get; set; }
        public virtual string OP_DIV { get; set; }
        public virtual int? SM_PLAN_NO { get; set; }
        public virtual string HEAT_NO { get; set; }
        public virtual string LADLE_NO { get; set; }
        public virtual long? LADLE_AGE { get; set; }
        public virtual string LADLE_STATUS { get; set; }
        public virtual string PROD_MAKER { get; set; }
        public virtual int? GRASS_WT { get; set; }
        public virtual int? TARE_WT { get; set; }
        public virtual int? NET_WT { get; set; }
        public virtual string RUN_SIGNAL { get; set; }
        public virtual string START_TIME_EVENT { get; set; }
    }
}
