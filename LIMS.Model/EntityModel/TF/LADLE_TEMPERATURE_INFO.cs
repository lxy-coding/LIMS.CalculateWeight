using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class LADLE_TEMPERATURE_INFO {
        /// <summary>
        /// 序号; 主键，自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 对象表ID;
        /// <summary>
        public virtual int? OBJ_ID { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 净重;
        /// <summary>
        public virtual int? NET_WEIGHT { get; set; }
        /// <summary>
        /// 工作层厚度;
        /// <summary>
        public virtual int? LAYER_THICK { get; set; }
        /// <summary>
        /// 包底外部温度;  ℃
        /// <summary>
        public virtual short? BOTTOM_EX_TEMP { get; set; }
        /// <summary>
        /// 包底内部温度; ℃
        /// <summary>
        public virtual short? BOTTOM_IN_TEMP { get; set; }
        /// <summary>
        /// 包壁外部温度; ℃
        /// <summary>
        public virtual short? WALL_EX_TEMP { get; set; }
        /// <summary>
        /// 包壁内部温度; ℃
        /// <summary>
        public virtual short? WALL_IN_TEMP { get; set; }
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
