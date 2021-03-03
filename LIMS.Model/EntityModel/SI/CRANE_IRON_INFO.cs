using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class CRANE_IRON_INFO
    {
        public virtual long MSG_COUNTER { get; set; }
        public virtual DateTime? MSG_TIME { get; set; }
        public virtual DateTime? READ_TIME { get; set; }
        public virtual string MSG_STATUS { get; set; }
        public virtual string OP_DIV { get; set; }
        public virtual string GL_NO { get; set; }
        public virtual string PROC_NO { get; set; }
        public virtual string IRON_NO { get; set; }
        public virtual string IRON_LADLE_NO { get; set; }
        public virtual string HEAT_NO { get; set; }
        public virtual float? NET_WT { get; set; }
        public virtual short? IRON_TEMP { get; set; }
        public virtual string ANALYSIZE_TIME { get; set; }
        public virtual float? CF_C { get; set; }
        public virtual float? CF_SI { get; set; }
        public virtual float? CF_MN { get; set; }
        public virtual float? CF_P { get; set; }
        public virtual float? CF_S { get; set; }
        public virtual float? CF_TI { get; set; }
        public virtual float? CF_AS { get; set; }
        public virtual string MOLTENIRON_SOURCE { get; set; }
        public virtual string IRON_LOAD_START_TIME { get; set; }
        public virtual string IRON_LOAD_END_TIME { get; set; }
        /// <summary>
        /// 操作类型为D的，字段不能为空。被删除的数据ID
        /// <summary>
        public virtual long? DEL_ID { get; set; }
    }
}
