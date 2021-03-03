using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class BASE_PHYS_PROP {
        /// <summary>
        /// ID
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 属性名
        /// <summary>
        public virtual string PROPERTY_NAME { get; set; }
        /// <summary>
        /// 属性类型：1为int，2为double，3为float，4为string，5为date
        /// <summary>
        public virtual short? PROPERTY_TYPE { get; set; }
        /// <summary>
        /// 属性值
        /// <summary>
        public virtual string PROPERTY_VALUE { get; set; }
        /// <summary>
        /// 备注
        /// <summary>
        public virtual string REMARK { get; set; }
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
