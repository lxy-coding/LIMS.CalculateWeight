using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class LADLE_TURNOVER_RECORD
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
        public virtual int? MAINTAIN_TYPE { get; set; }
        /// <summary>
        /// 总包龄
        /// </summary>
        public virtual short? TOTAL_LADLE_LIFE { get; set; }
        /// <summary>
        /// 本次包龄
        /// </summary>
        public virtual short? CURRENT_LADLE_LIFE { get; set; }
        /// <summary>
        /// 当前冷修过钢量，吨
        /// </summary>
        public virtual int? CURRENT_WEIGHT { get; set; }
        /// <summary>
        /// 历史累计过钢量，吨
        /// </summary>
        public virtual int? ACCUMULATE_WEIGHT { get; set; }
        /// <summary>
        /// 炉次号
        /// </summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 分配转炉号
        /// </summary>
        public virtual string DISPATCH_BOF_NUM { get; set; }
        /// <summary>
        /// 配包时刻
        /// </summary>
        public virtual DateTime? MATCH_HEAT_TIME { get; set; }
        /// <summary>
        /// 离开热修位
        /// </summary>
        public virtual string LEAVE_TILTER_NUM { get; set; }
        /// <summary>
        /// 离开热修位时刻
        /// </summary>
        public virtual DateTime? LEAVE_TILTER_TIME { get; set; }
        /// <summary>
        /// 实际转炉号
        /// </summary>
        public virtual string REAL_BOF_NUM { get; set; }
        /// <summary>
        /// 转炉包盖
        /// </summary>
        public virtual string COVER_IN_BOF { get; set; }
        /// <summary>
        /// 到达转炉时刻
        /// </summary>
        public virtual DateTime? ARRIVE_BOF_TIME { get; set; }
        /// <summary>
        /// 出钢开始时刻
        /// </summary>
        public virtual DateTime? BOF_TAP_START_TIME { get; set; }
        /// <summary>
        /// 出钢结束时刻
        /// </summary>
        public virtual DateTime? BOF_TAP_END_TIME { get; set; }
        /// <summary>
        /// 氩站
        /// </summary>
        public virtual string AR_NUM { get; set; }
        /// <summary>
        /// 吹氩开始时刻
        /// </summary>
        public virtual DateTime? AR_START_TIME { get; set; }
        /// <summary>
        /// 吹氩结束时刻
        /// </summary>
        public virtual DateTime? AR_END_TIME { get; set; }
        /// <summary>
        /// 离开转炉时刻
        /// </summary>
        public virtual DateTime? LEAVE_BOF_TIME { get; set; }
        /// <summary>
        /// LF炉
        /// </summary>
        public virtual string LF_NUM { get; set; }
        /// <summary>
        /// LF炉包盖
        /// </summary>
        public virtual string COVER_IN_LF { get; set; }
        /// <summary>
        /// 到达精炼时刻
        /// </summary>
        public virtual DateTime? ARRIVE_LF_TIME { get; set; }
        /// <summary>
        /// 精炼开始时刻
        /// </summary>
        public virtual DateTime? REFINE_START_TIME { get; set; }
        /// <summary>
        /// 精炼结束时刻
        /// </summary>
        public virtual DateTime? REFINE_END_TIME { get; set; }
        /// <summary>
        /// 离开精炼时刻
        /// </summary>
        public virtual DateTime? LEAVE_LF_TIME { get; set; }
        /// <summary>
        /// RH炉
        /// </summary>
        public virtual string RH_NUM { get; set; }
        /// <summary>
        /// RH炉包盖
        /// </summary>
        public virtual string COVER_IN_RH { get; set; }
        /// <summary>
        /// 到达RH时刻
        /// </summary>
        public virtual DateTime? ARRIVE_RH_TIME { get; set; }
        /// <summary>
        /// 真空开始时刻
        /// </summary>
        public virtual DateTime? VACUUM_START_TIME { get; set; }
        /// <summary>
        /// 真空结束时刻
        /// </summary>
        public virtual DateTime? VACUUM_END_TIME { get; set; }
        /// <summary>
        /// 离开RH时刻
        /// </summary>
        public virtual DateTime? LEAVE_RH_TIME { get; set; }
        /// <summary>
        /// 连铸机
        /// </summary>
        public virtual string CCM_NUM { get; set; }
        /// <summary>
        /// 到达连铸时刻
        /// </summary>
        public virtual DateTime? ARRIVE_CCM_TIME { get; set; }
        /// <summary>
        /// 连铸开浇时刻
        /// </summary>
        public virtual DateTime? CAST_START_TIME { get; set; }
        /// <summary>
        /// 浇铸结束时刻
        /// </summary>
        public virtual DateTime? CAST_END_TIME { get; set; }
        /// <summary>
        /// 离开连铸时刻
        /// </summary>
        public virtual DateTime? LEAVE_CCM_TIME { get; set; }
        /// <summary>
        /// 倒渣位
        /// </summary>
        public virtual string SLAG_DUMP_STATION { get; set; }
        /// <summary>
        /// 倒渣开始时刻
        /// </summary>
        public virtual DateTime? DUMP_START_TIME { get; set; }
        /// <summary>
        /// 倒渣结束时刻
        /// </summary>
        public virtual DateTime? DUMP_END_TIME { get; set; }
        /// <summary>
        /// 返回热修位
        /// </summary>
        public virtual string ARRIVE_TILTER_NUM { get; set; }
        /// <summary>
        /// 返回热修位时刻
        /// </summary>
        public virtual DateTime? ARRIVE_TILTER_TIME { get; set; }
        /// <summary>
        /// 流程结束标志，0未结束，1结束
        /// </summary>
        public virtual short PROCESS_SYMBOL { get; set; }
        /// <summary>
        /// 记录生成时间，热修配包时生成
        /// </summary>
        public virtual DateTime TIME_STAMP { get; set; }
        /// <summary>
        /// 是否删除;0:未;1:已
        /// </summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 计划号;
        /// </summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3;
        /// </summary>
        public virtual string FIELD3 { get; set; }
        /// <summary>
        /// 钢种名称
        /// </summary>
        public virtual string STEEL_GRADE { get; set; }
    }
}
