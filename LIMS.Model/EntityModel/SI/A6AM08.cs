using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class A6AM08
    {
        public virtual long MSG_COUNTER { get; set; }
        public virtual DateTime? MSG_TIME { get; set; }
        public virtual DateTime? READ_TIME { get; set; }
        public virtual string MSG_STATUS { get; set; }
        public virtual string OP_DIV { get; set; }
        public virtual string GL_NO { get; set; }
        public virtual string IRON_NO { get; set; }
        public virtual string IRON_LADLE_NO { get; set; }
        public virtual string ANALYSIZE_TIME { get; set; }
        public virtual string CF_C { get; set; }
        public virtual string CF_SI { get; set; }
        public virtual string CF_MN { get; set; }
        public virtual string CF_P { get; set; }
        public virtual string CF_S { get; set; }
        public virtual string CF_TI { get; set; }
        public virtual string CF_AS { get; set; }

        /// <summary>
        /// Â¯ÅúºÅ
        /// </summary>
        public virtual string HEAT_BATCH_NO { get; set; }
    }
}
