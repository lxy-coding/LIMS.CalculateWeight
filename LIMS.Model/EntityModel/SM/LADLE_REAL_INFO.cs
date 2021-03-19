using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class LADLE_REAL_INFO {
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
        /// 毛重，kg
        /// <summary>
        public virtual int? TOTAL_WEIGHT { get; set; }
        /// <summary>
        /// 炉次号
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 计划号
        /// <summary>
        public virtual string PLAN_NUM { get; set; }
        /// <summary>
        /// 钢种
        /// <summary>
        public virtual string STEEL_GRADE { get; set; }
        /// <summary>
        /// 负载标志，1空包，2重包
        /// <summary>
        public virtual short? ISLOAD { get; set; }
        /// <summary>
        /// 参照对象状态ID
        /// <summary>
        public virtual int? MAINTAIN_TYPE { get; set; }
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
        /// 跟踪逻辑处理： 烘烤区域 = 1,热修区域 = 2,转炉区域 = 3,精炼区域 = 4,连铸区域 = 5,运输区域 = 6,未知区域 = 0
        /// <summary>
        public virtual short? AREATYPE { get; set; }
        /// <summary>
        /// 跟踪逻辑处理：每次动作处理完成记录时间
        /// <summary>
        public virtual DateTime? HANDLETIME { get; set; }
        /// <summary>
        /// 1在线；2离线
        /// <summary>
        public virtual short? ISONLINE { get; set; }
        /// <summary>
        /// 可用状态，关联对象类型状态
        /// <summary>
        public virtual int? AVL_STATUS { get; set; }
        /// <summary>
        /// 占用状态，关联对象类型状态
        /// <summary>
        public virtual int? USED_STATUS { get; set; }
        /// <summary>
        /// 热力学状态，关联对象类型状态
        /// <summary>
        public virtual int? THERMAL_STATUS { get; set; }
    }
}
