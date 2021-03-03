using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class AMA607
    {
        public virtual long MSG_COUNTER { get; set; }
        public virtual DateTime MSG_TIME { get; set; }
        public virtual DateTime? READ_TIME { get; set; }
        public virtual string MSG_STATUS { get; set; }
        public virtual string OP_DIV { get; set; }
        public virtual string PROC_NO { get; set; }
        public virtual string DEV_CODE { get; set; }
        public virtual string SM_PLAN_NO { get; set; }
        public virtual string PONO { get; set; }
        public virtual string HEAT_NO { get; set; }
        public virtual string TEMP_VAL { get; set; }
        public virtual string MEASURE_TIME { get; set; }
    }
}
