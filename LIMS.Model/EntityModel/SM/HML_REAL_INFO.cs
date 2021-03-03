using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class HML_REAL_INFO {
        /// <summary>
        /// 序号，主键，自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 序号，外键，容器属性表ID
        /// <summary>
        public virtual CON_PROPERTY CON_ID { get; set; }
        /// <summary>
        /// 位置
        /// <summary>
        public virtual string POSIT { get; set; }
        /// <summary>
        /// 相机识别位置
        /// <summary>
        public virtual string DISTINGUISH_POSIT { get; set; }
        /// <summary>
        /// X坐标，mm
        /// <summary>
        public virtual int? COORD_X { get; set; }
        /// <summary>
        /// Y坐标，mm
        /// <summary>
        public virtual int? COORD_Y { get; set; }
        /// <summary>
        /// Z坐标，mm
        /// <summary>
        public virtual int? COORD_Z { get; set; }
        /// <summary>
        /// 空包重量，kg
        /// <summary>
        public virtual int? WEIGHT { get; set; }
        /// <summary>
        /// 炉次号
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 计划号
        /// <summary>
        public virtual string PLAN_NUM { get; set; }
        /// <summary>
        /// 铁次号
        /// <summary>
        public virtual string IRON_NUM { get; set; }
        /// <summary>
        /// 铁水温度
        /// <summary>
        public virtual short? HM_TEMPERATURE { get; set; }
        /// <summary>
        /// 铁水成分
        /// <summary>
        public virtual string HM_COMPNENT { get; set; }
        /// <summary>
        /// 负载标志，1空包，2重包
        /// <summary>
        public virtual short? ISLOAD { get; set; }
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
    }
}
