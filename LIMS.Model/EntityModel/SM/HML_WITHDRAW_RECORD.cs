using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel{
[Serializable]
    
    public class HML_WITHDRAW_RECORD {
        /// <summary>
        /// 序号，主键; GUID
        /// </summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 表A6AM07中MSG_COUNTER
        /// </summary>
        public virtual string MSG_COUNTER { get; set; }
        /// <summary>
        /// 炉批号
        /// </summary>
        public virtual string HEAT_BATCH_NO { get; set; }
        /// <summary>
        /// 铁包号
        /// </summary>
        public virtual string HML_NUM { get; set; }
        /// <summary>
        /// 撤回时间
        /// </summary>
        public virtual DateTime TIME_STAMP { get; set; }
        /// <summary>
        /// 撤回操作员ID
        /// </summary>
        public virtual int USER_ID { get; set; }
        /// <summary>
        /// 撤回班组ID
        /// </summary>
        public virtual int TEAM_ID { get; set; }
        /// <summary>
        /// 预留字段1;
        /// </summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2;
        /// </summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3;
        /// </summary>
        public virtual string FIELD3 { get; set; }
    }
}
