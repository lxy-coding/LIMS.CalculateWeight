using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class VEHICLE_REAL_INFO {
        /// <summary>
        /// 序号;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 车辆属性_序号;
        /// <summary>
        public virtual VEHICLE VEH_ID { get; set; }
        /// <summary>
        /// 货位ID;
        /// <summary>
        public virtual int? POSITION_ID { get; set; }
        /// <summary>
        /// 重量; 单位kg
        /// <summary>
        public virtual int? WEIGHT { get; set; }
        /// <summary>
        /// 坯料号集合; 使用；隔开
        /// <summary>
        public virtual string STEEL_CODE_GATHER { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 总支数;
        /// <summary>
        public virtual short? STEEL_COUNT { get; set; }
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
        /// 车辆状态（1入库；2出库）
        /// <summary>
        public virtual short? VEH_STATUS { get; set; }
        /// <summary>
        /// 载物类型（1板坯；2方坯；3钢卷；4线卷；5棒材；9其他）
        /// <summary>
        public virtual short? LOAD_TYPE { get; set; }
    }
}
