using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class A6AM07
    {
        public virtual long MSG_COUNTER { get; set; }
        public virtual DateTime? MSG_TIME { get; set; }
        public virtual DateTime? READ_TIME { get; set; }
        public virtual string MSG_STATUS { get; set; }
        public virtual string OP_DIV { get; set; }
        public virtual string GL_NO { get; set; }
        public virtual string IRON_NO { get; set; }
        public virtual string IRON_LADLE_NO { get; set; }
        public virtual string IRON_LADLE_LIFE { get; set; }
        public virtual string VEHICLE_NO { get; set; }
        public virtual string GROSS_WT { get; set; }
        public virtual string TARE_WT { get; set; }
        public virtual string NET_WT { get; set; }
        public virtual string WEIGH_SITE { get; set; }
        public virtual string PONDER_TIME { get; set; }
        public virtual string EMPTY_TIME { get; set; }
        public virtual string IRON_TEMP { get; set; }
        public virtual string IRON_TEMP_TIME { get; set; }
        public virtual string TAP_START_TIME { get; set; }
        public virtual string TAP_END_TIME { get; set; }
        public virtual string ISSUE_TIME { get; set; }

        /// <summary>
        /// Â¯ÅúºÅ
        /// </summary>
        public virtual string HEAT_BATCH_NO { get; set; }
    }
}
