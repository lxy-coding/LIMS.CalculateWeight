using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class HM_DISPATCH_RECORD
    {
        /// <summary>
        /// 序号，主键; GUID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 炉批号
        /// <summary>
        public virtual string HEAT_BATCH_NO { get; set; }
        /// <summary>
        /// 铁包号
        /// <summary>
        public virtual string HML_NUM { get; set; }
        /// <summary>
        /// 分流天车编号
        /// <summary>
        public virtual string CRA_NUM { get; set; }
        /// <summary>
        /// 去向转炉编号
        /// <summary>
        public virtual string BOF_NUM { get; set; }
        /// <summary>
        /// 入炉实际炉次号
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 分流时间
        /// <summary>
        public virtual DateTime DISPATCH_TIME { get; set; }
        /// <summary>
        /// 分流状态，是否入炉为准，0待执行，1已完成
        /// <summary>
        public virtual short DISPATCH_STATUS { get; set; }
        /// <summary>
        /// 出库状态，0未出库，1已出库
        /// <summary>
        public virtual short OUTPUT_STATUS { get; set; }
        /// <summary>
        /// 分流操作员
        /// <summary>
        public virtual int USER_ID { get; set; }
        /// <summary>
        /// 分流班组
        /// <summary>
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
        /// 是否发送转炉，0未发送，1已发送;
        /// <summary>
        public virtual string FIELD3 { get; set; }
        /// <summary>
        /// 钢种
        /// <summary>
        public virtual string GRADE { get; set; }
        /// <summary>
        /// 铁水温度
        /// <summary>
        public virtual short? HM_TEMP { get; set; }
        /// <summary>
        /// 是否铁运放吊，0未放吊，1已放吊
        /// <summary>
        public virtual short DROP_IN_IRONLINE { get; set; }
        /// <summary>
        /// 铁运放吊时间
        /// <summary>
        public virtual DateTime? DROP_IN_IRONLINE_TIME { get; set; }
        /// <summary>
        /// 铁运放吊位置
        /// <summary>
        public virtual string DROP_IN_IRONLINE_POSIT { get; set; }
        /// <summary>
        /// 铁运放吊动作记录
        /// <summary>
        public virtual string DROP_IN_IRONLINE_ID { get; set; }
        /// <summary>
        /// 是否发送至三级，0未发送，1已发送
        /// <summary>
        public virtual short SEND_TO_L3_FLAG { get; set; }
        /// <summary>
        /// 加料前重量，kg
        /// <summary>
        public virtual int? BEFORE_WEIGHT { get; set; }
        /// <summary>
        /// 加料后重量，kg
        /// <summary>
        public virtual int? AFTER_WEIGHT { get; set; }
        /// <summary>
        /// 净重，kg
        /// <summary>
        public virtual int? NET_WEIGHT { get; set; }
        /// <summary>
        /// 兑物前时间
        /// <summary>
        public virtual DateTime? CHARGE_START_TIME { get; set; }
        /// <summary>
        /// 兑物后时间
        /// <summary>
        public virtual DateTime? CHARGE_END_TIME { get; set; }

        /// <summary>
        /// 分流结束时间
        /// <summary>
        public virtual DateTime DISPATCH_END_TIME { get; set; }
    }
}
