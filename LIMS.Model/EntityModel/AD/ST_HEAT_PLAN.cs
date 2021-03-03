using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class ST_HEAT_PLAN {
        public ST_HEAT_PLAN() { }
        /// <summary>
        /// 序号，GUID
        /// <summary>
        public virtual string GUID { get; set; }
        /// <summary>
        /// 计划状态：1为计划；2为开始；3为结束；4为中断；5为阻塞
        /// <summary>
        public virtual short? STATUS { get; set; }
        /// <summary>
        /// 事件标志：1为新增；2为修改；3为删除
        /// <summary>
        public virtual short? EVENT_FLAG { get; set; }
        /// <summary>
        /// 浇次号
        /// <summary>
        public virtual decimal? CASTING_NUM { get; set; }
        /// <summary>
        /// 浇次位置
        /// <summary>
        public virtual short? POSIT_IN_CAST { get; set; }
        /// <summary>
        /// 计划号
        /// <summary>
        public virtual string PLAN_NUM { get; set; }
        /// <summary>
        /// 实际炉次号
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 钢包号
        /// <summary>
        public virtual string LADLE_NUM { get; set; }
        /// <summary>
        /// 通过工位ID和-串联，具体热修位、转炉接钢位、1#精炼处理位、
        ///2#精炼处理位、3#精炼处理位、4#精炼处理位、连铸处理位、
        ///渣罐位、热修位（下线位）
        /// <summary>
        public virtual string LADLE_ROUTE { get; set; }
        /// <summary>
        /// 通过时间和-串联，钢包工艺路径计划开始时间
        /// <summary>
        public virtual string LADLE_ROUTE_S_TIME { get; set; }
        /// <summary>
        /// 通过时间和-串联，钢包工艺路径计划结束时间
        /// <summary>
        public virtual string LADLE_ROUTE_E_TIME { get; set; }
        /// <summary>
        /// 铁包号
        /// <summary>
        public virtual string HML_NUM { get; set; }
        /// <summary>
        /// 通过工位ID和-串联，具体铁水线罐架号、脱磷站处理位、脱磷转炉装入位、
        ///脱磷转炉吊装位、脱磷转炉接钢位、脱磷转炉吊装位、
        ///脱碳转炉装入位、铁水线罐架号
        /// <summary>
        public virtual string HM_ROUTE { get; set; }
        /// <summary>
        /// 废钢斗编号
        /// <summary>
        public virtual string SLOT_NUM { get; set; }
        /// <summary>
        /// 通过工位ID和-串联，具体废钢间、转炉、废钢斗暂存区或废钢台车
        /// <summary>
        public virtual string SLOT_ROUTE { get; set; }
        /// <summary>
        /// 钢种
        /// <summary>
        public virtual string GRADE { get; set; }
        /// <summary>
        /// 工艺路径
        /// <summary>
        public virtual string H_ROUTE { get; set; }
        /// <summary>
        /// 设备数：工艺路径对应设备数
        /// <summary>
        public virtual short? FACILITY_QUAN { get; set; }
        /// <summary>
        /// 兑铁计划开始时间
        /// <summary>
        public virtual DateTime? POUR_START_TIME { get; set; }
        /// <summary>
        /// 兑铁计划结束时间
        /// <summary>
        public virtual DateTime? POUR_END_TIME { get; set; }
        /// <summary>
        /// 铁水预处理计划开始时间
        /// <summary>
        public virtual DateTime? PRE_START_TIME { get; set; }
        /// <summary>
        /// 铁水预处理计划结束时间
        /// <summary>
        public virtual DateTime? PRE_END_TIME { get; set; }
        /// <summary>
        /// 转炉计划开始时间
        /// <summary>
        public virtual DateTime? BOF_START_TIME { get; set; }
        /// <summary>
        /// 转炉计划结束时间
        /// <summary>
        public virtual DateTime? BOF_END_TIME { get; set; }
        /// <summary>
        /// LF精炼计划开始时间
        /// <summary>
        public virtual DateTime? LF_START_TIME { get; set; }
        /// <summary>
        /// LF精炼计划结束时间
        /// <summary>
        public virtual DateTime? LF_END_TIME { get; set; }
        /// <summary>
        /// RH精炼计划开始时间
        /// <summary>
        public virtual DateTime? RH_START_TIME { get; set; }
        /// <summary>
        /// RH精炼计划结束时间
        /// <summary>
        public virtual DateTime? RH_END_TIME { get; set; }
        /// <summary>
        /// 连铸计划开始时间
        /// <summary>
        public virtual DateTime? CC_START_TIME { get; set; }
        /// <summary>
        /// 连铸计划结束时间
        /// <summary>
        public virtual DateTime? CC_END_TIME { get; set; }
        /// <summary>
        /// 计划状态变化，时间标签
        /// <summary>
        public virtual DateTime? TIME_STATMP { get; set; }
        /// <summary>
        /// 生成时间
        /// <summary>
        public virtual DateTime? GENER_TIME { get; set; }
        /// <summary>
        /// 修改时间
        /// <summary>
        public virtual DateTime? MODIFY_TIME { get; set; }
        /// <summary>
        /// 执行顺序：本计划在上层计划分解后需要执行的步骤对应的序号
        /// <summary>
        public virtual short? EXECUTE_SEQ { get; set; }
        /// <summary>
        /// 是否为最后计划：0为非，1为是
        /// <summary>
        public virtual short? IS_LAST_PLAN { get; set; }
        /// <summary>
        /// 预留字段1
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3
        /// <summary>
        public virtual string FIELD3 { get; set; }
        /// <summary>
        /// 计划配废钢开始时间
        /// <summary>
        public virtual DateTime? MATCH_SCRAP_START { get; set; }
        /// <summary>
        /// 计划配废钢结束时间
        /// <summary>
        public virtual DateTime? MATCH_SCRAP_END { get; set; }
        /// <summary>
        /// 计划装废钢开始时间
        /// <summary>
        public virtual DateTime? CHARGE_SCRAP_START { get; set; }
        /// <summary>
        /// 计划装废钢结束时间
        /// <summary>
        public virtual DateTime? CHARGE_SCRAP_END { get; set; }
        /// <summary>
        /// 空废钢斗计划返回时间
        /// <summary>
        public virtual DateTime? SLOT_BACK { get; set; }
        /// <summary>
        /// 通过时间和-串联，钢包工艺路径计划开始时间
        /// <summary>
        public virtual string HM_ROUTE_S_TIME { get; set; }
        /// <summary>
        /// 通过时间和-串联，钢包工艺路径计划结束时间
        /// <summary>
        public virtual string HM_ROUTE_E_TIME { get; set; }
        /// <summary>
        /// 通过时间和-串联，废钢斗工艺路径计划开始时间
        /// <summary>
        public virtual string SLOT_ROUTE_S_TIME { get; set; }
        /// <summary>
        /// 通过时间和-串联，废钢斗工艺路径计划结束时间
        /// <summary>
        public virtual string SLOT_ROUTE_E_TIME { get; set; }
        /// <summary>
        /// 默认为0，人工修改1，校验流程读取2，计算流程重算3
        /// <summary>
        public virtual short? MODIFY_STATUS { get; set; }
    }
}
