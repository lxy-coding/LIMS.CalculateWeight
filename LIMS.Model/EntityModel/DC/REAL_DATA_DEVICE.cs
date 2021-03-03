using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {

[Serializable]
    
    public class REAL_DATA_DEVICE {
        /// <summary>
        /// 主键ID;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 表名称;
        /// <summary>
        public virtual string TABLE_NAME { get; set; }
        /// <summary>
        /// 主键字段名;
        /// <summary>
        public virtual string PRIMARY_KEY_FIELD_NAME { get; set; }
        /// <summary>
        /// 主键字段对应值;
        /// <summary>
        public virtual int? PRIMARY_KEY_ID { get; set; }
        /// <summary>
        /// 备用1;
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 备用2;
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 备用3;
        /// <summary>
        public virtual string FIELD3 { get; set; }
        /// <summary>
        /// 启用;
        /// <summary>
        public virtual short? ENABLE { get; set; }
        /// <summary>
        /// 备注;
        /// <summary>
        public virtual string RAMARK { get; set; }
        /// <summary>
        /// 表所属用户
        /// <summary>
        public virtual string TABLE_USERS { get; set; }
    }
}
