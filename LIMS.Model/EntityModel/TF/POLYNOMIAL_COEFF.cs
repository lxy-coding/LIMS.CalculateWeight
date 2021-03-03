using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel{

[Serializable]
    
    public class POLYNOMIAL_COEFF {
        /// <summary>
        /// 序号; 自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 材料编号
        /// <summary>
        public virtual string MATERIAL_NUM { get; set; }
        /// <summary>
        /// 材料属性
        /// <summary>
        public virtual string PROPERTY { get; set; }
        /// <summary>
        /// 0次项系数
        /// <summary>
        public virtual string POWER0 { get; set; }
        /// <summary>
        /// 1次项系数
        /// <summary>
        public virtual string POWER1 { get; set; }
        /// <summary>
        /// 2次项系数
        /// <summary>
        public virtual string POWER2 { get; set; }
        /// <summary>
        /// 3次项系数
        /// <summary>
        public virtual string POWER3 { get; set; }
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
