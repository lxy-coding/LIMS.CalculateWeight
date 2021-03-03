using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class D_CRA_STATUS_RECORD {
        /// <summary>
        /// 序号，主键; GUID
        /// </summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 天车编号
        /// </summary>
        public virtual string CRA_NUM { get; set; }
        /// <summary>
        /// 在线状态(一级状态)，0离线，1在线
        /// </summary>
        public virtual short IS_NOLINE { get; set; }
        /// <summary>
        /// 占用状态(二级状态)，0占用，1未占用
        /// </summary>
        public virtual short IS_OCCUPY { get; set; }
        /// <summary>
        /// 数据生成时间
        /// </summary>
        public virtual DateTime? TIME_STAMP { get; set; }
        /// <summary>
        /// 备用字段1
        /// </summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 备用字段2
        /// </summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 备用字段3
        /// </summary>
        public virtual string FIELD3 { get; set; }
    }
}
