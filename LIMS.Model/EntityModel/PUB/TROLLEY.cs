    using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {

[Serializable]
    
    public class TROLLEY {
        public TROLLEY() { }
        /// <summary>
        /// 序号; 自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 台车编号;
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 对象类型ID;  
        /// <summary>
        public virtual int? OBJ_TYPE_ID { get; set; }
        /// <summary>
        /// 台车名称;
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// 跨ID集合; 使用；分割
        /// <summary>
        public virtual string SPA_ID_GATHER { get; set; }
        /// <summary>
        /// 区域ID集合; 使用；分割
        /// <summary>
        public virtual string AREA_ID_GATHER { get; set; }
        /// <summary>
        /// 货/工位ID集合; 使用；分割
        /// <summary>
        public virtual string POSITION_ID_GATHER { get; set; }
        /// <summary>
        /// 台车方向; 台车布局方向
        /// <summary>
        public virtual int? DIRECTION { get; set; }
        /// <summary>
        /// 台车行走最小值;
        /// <summary>
        public virtual int? WALK_MIN { get; set; }
        /// <summary>
        /// 台车行走最大值;
        /// <summary>
        public virtual int? WALK_MAX { get; set; }
        /// <summary>
        /// 描述; 台车基本描述
        /// <summary>
        public virtual string DESCRIPTION { get; set; }
        /// <summary>
        /// 鞍座编号集合; 鞍座工位集合
        /// <summary>
        public virtual string SADDLE_NUM_GATHER { get; set; }
        /// <summary>
        /// 台车载运基准重量;
        /// <summary>
        public virtual int? BASIC_LOAD_WEIGHT { get; set; }
        /// <summary>
        /// 轨道ID; 所属轨道编号ID
        /// <summary>
        public virtual int? RAIL_ID { get; set; }
        /// <summary>
        /// 预留字段1;存储台车类型，1炼钢过跨台车、2脱硫台车、3转炉台车、4精炼台车、5板坯过跨台车
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
        /// 对象ID
        /// <summary>
        public virtual int? OBJ_ID { get; set; }
        /// <summary>
        /// 存储台车类型
        /// <summary>
        public virtual short? TROLLEY_TYPE { get; set; }
        /// <summary>
        /// 台车速度最大值; X速度最大值，单位，m/s
        /// <summary>
        public virtual float? TRO_MAX_SPEED { get; set; }
        /// <summary>
        /// 零点
        /// <summary>
        public virtual int? ZERO { get; set; }
        /// <summary>
        /// 零点偏移
        /// <summary>
        public virtual int? ZERO_OOFSET { get; set; }
        /// <summary>
        /// 零点方向:1.上、2.下、3.左、4.右
        /// <summary>
        public virtual short? ZERO_DIRECTION { get; set; }
    }
}
