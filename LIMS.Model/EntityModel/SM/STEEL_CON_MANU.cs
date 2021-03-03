using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class STEEL_CON_MANU {
        /// <summary>
        /// 序号，主键，自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 参照对象类型ID
        /// <summary>
        public virtual short CON_TYPE { get; set; }
        /// <summary>
        /// 部件名称
        /// <summary>
        public virtual string COMP_NAM { get; set; }
        /// <summary>
        /// 厂家名称
        /// <summary>
        public virtual string MANU_NAM { get; set; }
        /// <summary>
        /// 厂家负责人
        /// <summary>
        public virtual string MANU_DIRECTOR { get; set; }
        /// <summary>
        /// 厂家地址
        /// <summary>
        public virtual string MANU_ADDRESS { get; set; }
        /// <summary>
        /// 厂家联系方式
        /// <summary>
        public virtual string MANU_TEL { get; set; }
        /// <summary>
        /// 购入时间
        /// <summary>
        public virtual DateTime? PURCHASE_TIME { get; set; }
        /// <summary>
        /// 是否可用，0不可用，1可用
        /// <summary>
        public virtual short? IS_ENABLE { get; set; }
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
        public virtual string XML_DATA { get; set; }
    }
}
