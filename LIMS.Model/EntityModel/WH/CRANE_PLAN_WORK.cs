using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class CRANE_PLAN_WORK {
        /// <summary>
        /// GUID;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 计划ID;
        /// <summary>
        public virtual string PLA_ID { get; set; }
        /// <summary>
        /// 作业计划类型; (1入库；2出库；3到跨；4倒垛)
        /// <summary>
        public virtual short? PLAN_WORK_TYPE { get; set; }
        /// <summary>
        /// 天车ID;
        /// <summary>
        public virtual int? CRA_ID { get; set; }
        /// <summary>
        /// 车辆ID;
        /// <summary>
        public virtual int? VEHICLE_ID { get; set; }
        /// <summary>
        /// 坯料号;
        /// <summary>
        public virtual string STEEL_NUM { get; set; }
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
        /// 计划来源; 1接口，2WEB，3PDA，4其他，5.PC端
        /// <summary>
        public virtual short? PLAN_FROM { get; set; }
        /// <summary>
        /// 读取标志; 0未读1已读
        /// <summary>
        public virtual short? READ_FLAG { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string HEAT_CODE { get; set; }
        /// <summary>
        /// 总支数;
        /// <summary>
        public virtual short? STEEL_COUNT { get; set; }
        /// <summary>
        /// 剩余支数;
        /// <summary>
        public virtual short? REMAIN_COUNT { get; set; }
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
        /// <summary>
        /// 创建时间
        /// <summary>
        public virtual DateTime? CREATE_TIME { get; set; }
    }
}
