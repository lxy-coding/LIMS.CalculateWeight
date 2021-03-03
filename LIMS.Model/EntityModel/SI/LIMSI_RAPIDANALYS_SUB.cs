using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class LIMSI_RAPIDANALYS_SUB
    {
        public virtual long MSG_COUNTER { get; set; }
        public virtual DateTime? MSG_TIME { get; set; }
        public virtual DateTime? READ_TIME { get; set; }
        public virtual string MSG_STATUS { get; set; }
        public virtual string OP_DIV { get; set; }
        public virtual decimal? ID { get; set; }
        public virtual decimal? MID { get; set; }
        public virtual string SAMPLE_ID { get; set; }
        public virtual string ANALYSE_ITEM_CODE { get; set; }
        public virtual string ANALYSE_ITEM_NAME { get; set; }
        public virtual double? YVALUE { get; set; }
        public virtual DateTime? FINISH_DATE { get; set; }
        public virtual string ITEM_TYPE { get; set; }
        public virtual short? VALUE_TYPE { get; set; }
        public virtual double? STAND_RANGE_HV { get; set; }
        public virtual double? STAND_RANGE_LV { get; set; }
        public virtual string HV_COMPARE { get; set; }
        public virtual string LV_COMPARE { get; set; }
        public virtual string METHOD_CODE { get; set; }
        public virtual string METHOD_NAME { get; set; }
        public virtual string SUB_TASK_ID { get; set; }
    }
}
