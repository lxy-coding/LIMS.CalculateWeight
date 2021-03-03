using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class AMA630 {
        public virtual long MSG_COUNTER { get; set; }
        public virtual DateTime? MSG_TIME { get; set; }
        public virtual DateTime? READ_TIME { get; set; }
        public virtual string MSG_STATUS { get; set; }
        /// <summary>
        /// 操作类型，I:Insert;U:Update;D:Delete 
        /// </summary>
        public virtual string OP_DIV { get; set; }
        /// <summary>
        /// 铁水罐号
        /// </summary>
        public virtual string TPC_NO { get; set; }
        /// <summary>
        /// 铁次号
        /// </summary>
        public virtual string IR_TAP_NO { get; set; }
        /// <summary>
        /// 炉批号
        /// </summary>
        public virtual string ACT_TPC_NO { get; set; }
        /// <summary>
        /// 倒空状态，1倒空，2未倒空
        /// </summary>
        public virtual string EMPTY_STATUS { get; set; }
        /// <summary>
        /// 限定重量，180t，毛重小于等于180认为倒空
        /// </summary>
        public virtual string LIMIT_WEIGHT { get; set; }
        /// <summary>
        /// 毛重
        /// </summary>
        public virtual string GROSS_WT { get; set; }
        /// <summary>
        /// 皮重
        /// </summary>
        public virtual string TARE_WT { get; set; }
        /// <summary>
        /// 净重
        /// </summary>
        public virtual string NET_WT { get; set; }
        /// <summary>
        /// 倒空时刻
        /// </summary>
        public virtual string EMPTY_TIME { get; set; }
        /// <summary>
        /// 倒空后放到车架时刻
        /// </summary>
        public virtual string ON_FRAME_TIME { get; set; }
    }
}
