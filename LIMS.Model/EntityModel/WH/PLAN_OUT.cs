using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class PLAN_OUT {
        public PLAN_OUT() { }
        /// <summary>
        /// GUID;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 坯料号;
        /// <summary>
        public virtual string STEEL_NUM { get; set; }
        /// <summary>
        /// 计划号;
        /// <summary>
        public virtual string PLAN_NUM { get; set; }
        /// <summary>
        /// 起始跨ID;
        /// <summary>
        public virtual int? START_SPA_ID { get; set; }
        /// <summary>
        /// 起始区域ID;
        /// <summary>
        public virtual int? START_AREA_ID { get; set; }
        /// <summary>
        /// 起始货位ID;
        /// <summary>
        public virtual int? START_POSITION_ID { get; set; }
        /// <summary>
        /// 起始层;
        /// <summary>
        public virtual short? START_LAYER { get; set; }
        /// <summary>
        /// 目标跨ID;
        /// <summary>
        public virtual int? END_SPA_ID { get; set; }
        /// <summary>
        /// 目标区域ID;
        /// <summary>
        public virtual int? END_AREA_ID { get; set; }
        /// <summary>
        /// 目标货位ID;
        /// <summary>
        public virtual int? END_POSITION_ID { get; set; }
        /// <summary>
        /// 车辆序号;
        /// <summary>
        public virtual int? CAR_NUM { get; set; }
        /// <summary>
        /// 出库类型;（1上线出库2车辆出库3直接出库4过跨出库）
        /// <summary>
        public virtual short? OUT_TYPE { get; set; }
        /// <summary>
        /// 出库时间;yyyy-mm-dd hh24:mi:ss
        /// <summary>
        public virtual DateTime? OUT_TIME { get; set; }
        /// <summary>
        /// 天车ID集合;
        /// <summary>
        public virtual string CRANE_ID_GATHER { get; set; }
        /// <summary>
        /// 计划状态; （0计划未发布；1计划未执行；2计划已完成；3计划已确认；9计划执行中）
        /// <summary>
        public virtual short? PLAN_STATUS { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 总支数;
        /// <summary>
        public virtual short? STEEL_COUNT { get; set; }
        /// <summary>
        /// 剩余支数;
        /// <summary>
        public virtual short? REMAIN_COUNT { get; set; }
        /// <summary>
        /// 创建用户NUM;
        /// <summary>
        public virtual string CREATE_USER_NUM { get; set; }
        /// <summary>
        /// 创建时间; yyyy-mm-dd hh24:mi:ss
        /// <summary>
        public virtual DateTime? CREATE_TIME { get; set; }
        /// <summary>
        /// 修改用户NUM;
        /// <summary>
        public virtual string UPDATE_USER_NUM { get; set; }
        /// <summary>
        /// 修改时间; yyyy-mm-dd hh24:mi:ss
        /// <summary>
        public virtual DateTime? UPDATE_TIME { get; set; }
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
