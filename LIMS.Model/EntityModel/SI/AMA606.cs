using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class AMA606
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
        public virtual string RUN_SIGNAL { get; set; }
        public virtual string START_TIME_EVENT { get; set; }
        public virtual string LADLE_NO { get; set; }
        /// <summary>
        /// 创建时间
        /// <summary>
        public virtual DateTime? CREATE_TIME { get; set; }
    }
}
