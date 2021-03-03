using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {

[Serializable]
    
    public class LMS_MATERIAL_INFO {
        /// <summary>
        /// 序号; 自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 结构层编号;
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 结构层名称;
        /// <summary>
        public virtual string NAM { get; set; }
        /// <summary>
        /// 密度;
        /// <summary>
        public virtual float? DENSITY { get; set; }
        /// <summary>
        /// 比热;
        /// <summary>
        public virtual float? SPECIFIC_HEAT { get; set; }
        /// <summary>
        /// 导热系数;
        /// <summary>
        public virtual double? CONDUCTIVITY { get; set; }
        /// <summary>
        /// 固相线;
        /// <summary>
        public virtual short? TEMPS { get; set; }
        /// <summary>
        /// 液相线;
        /// <summary>
        public virtual short? TEMPL { get; set; }
        /// <summary>
        /// 表面发射率;
        /// <summary>
        public virtual float? EMISSIVITY { get; set; }
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
