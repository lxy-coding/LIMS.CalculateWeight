using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class D_CRA_TEMPORARY_USE {
        /// <summary>
        /// 序号，主键; GUID
        /// </summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 计划用车
        /// </summary>
        public virtual string CRA_NUM { get; set; }
        /// <summary>
        /// 天车类型，1废钢，2铁水，3钢包
        /// </summary>
        public virtual short CRA_TYPE { get; set; }
        /// <summary>
        /// 起始时间
        /// </summary>
        public virtual DateTime START_TIME { get; set; }
        /// <summary>
        /// 计划时长，min
        /// </summary>
        public virtual short OCCUPY_DURATION { get; set; }
        /// <summary>
        /// 用车事由
        /// </summary>
        public virtual string USING_REASON { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public virtual string REMARK { get; set; }
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
