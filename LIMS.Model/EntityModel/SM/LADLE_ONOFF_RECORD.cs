using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class LADLE_ONOFF_RECORD
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
        /// 上下线状态，对象类型状态表ID
        /// </summary>
        public virtual int ONOFF_STATUS { get; set; }
        /// <summary>
        /// 总包龄
        /// </summary>
        public virtual short? TOTAL_LADLE_LIFE { get; set; }
        /// <summary>
        /// 本次包龄
        /// </summary>
        public virtual short? CURRENT_LADLE_LIFE { get; set; }
        /// <summary>
        /// 上下线类型：0新包录入、1热修下线、2热修上线
        /// </summary>
        public virtual int ONOFF_TYPE { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public virtual string REMARK { get; set; }
        /// <summary>
        /// 记录生成时间
        /// </summary>
        public virtual DateTime TIME_STAMP { get; set; }
        /// <summary>
        /// 预留字段1;
        /// </summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 上下线位置
        /// </summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3;
        /// </summary>
        public virtual string FIELD3 { get; set; }
    }
}
