using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 钢包烘烤记录,烘烤开始、暂停、结束均生成一条记录
    /// </summary>    [Serializable]
    public class LADLE_REHEAT_RECORD
    {
        /// <summary>
        /// 序号，主键; GUID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 冷修号
        /// <summary>
        public virtual string COOL_REPAIR_NUM { get; set; }
        /// <summary>
        /// 热修号
        /// </summary>
        public virtual string HOT_REPAIR_NUM { get; set; }
        /// <summary>
        /// 烘烤号，按规则生成
        /// </summary>
        public virtual string REHEAT_NUM { get; set; }
        /// <summary>
        /// 烤包器号
        /// </summary>
        public virtual string BURNER_NUM { get; set; }
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
        /// 烘烤状态，对象类型状态表ID
        /// </summary>
        public virtual int REHEAT_STATUS { get; set; }
        /// <summary>
        /// 总包龄
        /// <summary>
        public virtual short? TOTAL_LADLE_LIFE { get; set; }
        /// <summary>
        /// 本次包龄
        /// <summary>
        public virtual short? CURRENT_LADLE_LIFE { get; set; }
        /// <summary>
        /// 烘烤标志（开始、暂停、结束），对象类型状态表ID
        /// </summary>
        public virtual int REHEAT_SYMBOL { get; set; }
        /// <summary>
        /// 烘烤时长(小时)
        /// <summary>
        public virtual int? REHEAT_DURATION { get; set; }
        /// <summary>
        /// 煤气压力，Kp
        /// <summary>
        public virtual int? GAS_PRESSURE { get; set; }
        /// <summary>
        /// 煤气流量，m3/h
        /// <summary>
        public virtual int? GAS_FLUX { get; set; }
        /// <summary>
        /// 钢包烘烤备注
        /// <summary>
        public virtual string REHEAT_REMARK { get; set; }
        /// <summary>
        /// 记录生成时刻
        /// </summary>
        public virtual DateTime TIME_STAMP { get; set; }
        /// <summary>
        /// 数据记录操作员
        /// <summary>
        public virtual int USER_ID { get; set; }
        /// <summary>
        /// 烘烤班组
        /// </summary>
        public virtual int TEAM_ID { get; set; }
        /// <summary>
        /// 预留字段1;
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2;
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3;
        /// <summary>
        public virtual string FIELD3 { get; set; }
    }
}
