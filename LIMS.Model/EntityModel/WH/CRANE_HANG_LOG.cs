using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class CRANE_HANG_LOG {
        /// <summary>
        /// GUID;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 货位基础_序号;
        /// <summary>
        public virtual POSITION POS_ID { get; set; }
        /// <summary>
        /// 天车ID;
        /// <summary>
        public virtual int? CRA_ID { get; set; }
        /// <summary>
        /// 坯料号
        /// <summary>
        public virtual string STEEL_NUM { get; set; }
        /// <summary>
        /// 炉次号; 
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 支数; 
        /// <summary>
        public virtual short? STEEL_COUNT { get; set; }
        /// <summary>
        /// 起吊区域ID;
        /// <summary>
        public virtual int? UP_AREA_ID { get; set; }
        /// <summary>
        /// 起吊货位ID;
        /// <summary>
        public virtual int? UP_POSITION_ID { get; set; }
        /// <summary>
        /// 起吊层;
        /// <summary>
        public virtual short? UP_LAYER { get; set; }
        /// <summary>
        /// 起吊位置坐标X;
        /// <summary>
        public virtual int? UP_X { get; set; }
        /// <summary>
        /// 起吊位置坐标Y;
        /// <summary>
        public virtual int? UP_Y { get; set; }
        /// <summary>
        /// 起吊位置坐标Z;
        /// <summary>
        public virtual int? UP_Z { get; set; }
        /// <summary>
        /// 起吊旋转值;
        /// <summary>
        public virtual short? UP_ROTATE { get; set; }
        /// <summary>
        /// 起吊时间; yyyy-mm-dd hh24:mi:ss
        /// <summary>
        public virtual DateTime? UP_TIME { get; set; }
        /// <summary>
        /// 起吊序号;
        /// <summary>
        public virtual int? UP_ORDER { get; set; }
        /// <summary>
        /// 放吊区域ID;
        /// <summary>
        public virtual int? DOWN_AREA_ID { get; set; }
        /// <summary>
        /// 放吊货位ID;
        /// <summary>
        public virtual int? DOWN_POSITION_ID { get; set; }
        /// <summary>
        /// 放吊层;
        /// <summary>
        public virtual short? DOWN_LAYER { get; set; }
        /// <summary>
        /// 放吊位置坐标X;
        /// <summary>
        public virtual int? DOWN_X { get; set; }
        /// <summary>
        /// 放吊位置坐标Y;
        /// <summary>
        public virtual int? DOWN_Y { get; set; }
        /// <summary>
        /// 放吊位置坐标Z;
        /// <summary>
        public virtual int? DOWN_Z { get; set; }
        /// <summary>
        /// 放吊旋转值;
        /// <summary>
        public virtual short? DOWN_ROTATE { get; set; }
        /// <summary>
        /// 放吊时间; yyyy-mm-dd hh24:mi:ss
        /// <summary>
        public virtual DateTime? DOWN_TIME { get; set; }
        /// <summary>
        /// 放吊序号;
        /// <summary>
        public virtual int? DOWN_ORDER { get; set; }
        /// <summary>
        /// 处理标志;（0为未处理，1为已处理）
        /// <summary>
        public virtual short? DO_FLAG { get; set; }
        /// <summary>
        /// 业务类型;（1为入库，2为出库，3为倒跨，4为倒垛，0为未知）
        /// <summary>
        public virtual short? BUSINESS_TYPE { get; set; }
        /// <summary>
        /// 钢的重量;
        /// <summary>
        public virtual int? STEEL_WEIGHT { get; set; }
        /// <summary>
        /// 铸坯分类;（1为板坯2为方坯）
        /// <summary>
        public virtual short? STEEL_CATEGORY { get; set; }
        /// <summary>
        /// 用户编号;
        /// <summary>
        public virtual string USER_NUM { get; set; }
        /// <summary>
        /// 班组ID;
        /// <summary>
        public virtual int? CLASS_ID { get; set; }
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
        /// 起吊层序号(方坯专用)
        /// <summary>
        public virtual short? UP_LAYER_ORDER { get; set; }
        /// <summary>
        /// 放吊层序号(方坯专用)
        /// <summary>
        public virtual short? DOWN_LAYER_ORDER { get; set; }
    }
}
