using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 工位重量状态记录
    /// </summary>
    [Serializable]

    public class WST_WEIGHT_STATUS_RECORD
    {
        /// <summary>
        /// 序号;GUID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 对象表ID;
        /// <summary>
        public virtual int? OBJ_ID { get; set; }
        /// <summary>
        /// 位置;
        /// <summary>
        public virtual string POSIT { get; set; }
        /// <summary>
        /// 放吊标志;0未放吊，1放吊
        /// <summary>
        public virtual short? DROP_STATUS { get; set; }
        /// <summary>
        /// 放吊天车编号;
        /// <summary>
        public virtual string DROP_CRA_NUM { get; set; }
        /// <summary>
        /// 放吊时间;
        /// <summary>
        public virtual DateTime? DROP_TIME { get; set; }
        /// <summary>
        /// 放吊重量;kg
        /// <summary>
        public virtual int? DROP_WEIGHT { get; set; }
        /// <summary>
        /// 起吊标志;0未起吊，1起吊
        /// <summary>
        public virtual short? HOIST_STATUS { get; set; }
        /// <summary>
        /// 起吊天车编号;
        /// <summary>
        public virtual string HOIST_CRA_NUM { get; set; }
        /// <summary>
        /// 起吊时间;
        /// <summary>
        public virtual DateTime? HOIST_TIME { get; set; }
        /// <summary>
        /// 起吊重量;kg
        /// <summary>
        public virtual int? HOIST_WEIGHT { get; set; }
        /// <summary>
        /// 兑物标志;0未兑物，1兑物
        /// <summary>
        public virtual short? POUR_STATUS { get; set; }
        /// <summary>
        /// 兑物天车编号;
        /// <summary>
        public virtual string POUR_CRA_NUM { get; set; }
        /// <summary>
        /// 兑物前时间;
        /// <summary>
        public virtual DateTime? POUR_ARRIVE_TIME { get; set; }
        /// <summary>
        /// 兑物前重量;kg
        /// <summary>
        public virtual int? BEFORE_POUR_WEIGHT { get; set; }
        /// <summary>
        /// 兑物后时间;
        /// <summary>
        public virtual DateTime? POUR_LEAVE_TIME { get; set; }
        /// <summary>
        /// 兑物后重量;kg
        /// <summary>
        public virtual int? AFTER_POUR_WEIGHT { get; set; }
        /// <summary>
        /// 连铸放吊标志;0连铸位放吊，1连铸放吊
        /// <summary>
        public virtual short? CASTING_STATUS { get; set; }
        /// <summary>
        /// 连铸放吊天车编号;
        /// <summary>
        public virtual string CASTING_CRA_NUM { get; set; }
        /// <summary>
        /// 连铸放吊时间;
        /// <summary>
        public virtual DateTime? CASTING_DROP_TIME { get; set; }
        /// <summary>
        /// 临时天车编号;
        /// <summary>
        public virtual string TEMP_CRA_NUM { get; set; }
        /// <summary>
        /// 临时重量;kg
        /// <summary>
        public virtual int? TEMP_WEIGHT { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 吊物编号;
        /// <summary>
        public virtual string CONT_NUM { get; set; }
        /// <summary>
        /// 除渣阈值;kg
        /// <summary>
        public virtual int? DISLODGE_SLAG_WEIGHT { get; set; }
        /// <summary>
        /// 最大载重;kg
        /// <summary>
        public virtual int? MAX_WEIGHT { get; set; }
        /// <summary>
        /// 最小载重;kg
        /// <summary>
        public virtual int? MIN_WEIGHT { get; set; }
        /// <summary>
        /// 读取标志;0未读，1已读
        /// <summary>
        public virtual short? FLAG { get; set; }
        /// <summary>
        /// 发送标志;0未发送，1已发送
        /// <summary>
        public virtual short? IS_SEND { get; set; }
        /// <summary>
        /// 创建时间;
        /// <summary>
        public virtual DateTime? CREATE_TIME { get; set; }
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
