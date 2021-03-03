using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class LADLE_READY_RECORD
    {
        /// <summary>
        /// 序号，主键; GUID
        /// </summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 冷修号
        /// </summary>
        public virtual string COOL_REPAIR_NUM { get; set; }
        /// <summary>
        /// 热修号
        /// </summary>
        public virtual string HOT_REPAIR_NUM { get; set; }
        /// <summary>
        /// 钢包号
        /// </summary>
        public virtual string LADLE_NUM { get; set; }
        /// <summary>
        /// 钢包类型，1方坯用包，2板坯用包
        /// </summary>
        public virtual int LADLE_TYPE { get; set; }
        /// <summary>
        /// 修包类型，对象类型状态表ID
        /// </summary>
        public virtual int MAINTAIN_TYPE { get; set; }
        /// <summary>
        /// 总包龄
        /// </summary>
        public virtual short? TOTAL_LADLE_LIFE { get; set; }
        /// <summary>
        /// 本次包龄
        /// </summary>
        public virtual short? CURRENT_LADLE_LIFE { get; set; }
        /// <summary>
        /// 机构号
        /// </summary>
        public virtual string STRUCT_NUM { get; set; }
        /// <summary>
        /// 钢包接管时刻
        /// </summary>
        public virtual DateTime LADLE_TAKEOVER_TIME { get; set; }
        /// <summary>
        /// 钢包接管人员，人员表ID
        /// </summary>
        public virtual int TAKEOVER_USER_ID { get; set; }
        /// <summary>
        /// 钢包准备备注
        /// </summary>
        public virtual string READY_REMARK { get; set; }
        /// <summary>
        /// 装包完成时刻
        /// </summary>
        public virtual DateTime READY_TIME { get; set; }
        /// <summary>
        /// 数据记录操作员，人员表ID
        /// </summary>
        public virtual int USER_ID { get; set; }
        /// <summary>
        /// 装包班组，班组表ID
        /// </summary>
        public virtual int TEAM_ID { get; set; }
        /// <summary>
        /// 是否删除;0：否，2：是
        /// </summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 操作类型;1:手动，2：自动
        /// </summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3;
        /// </summary>
        public virtual string FIELD3 { get; set; }
    }
}
