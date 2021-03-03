using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class CHECK_OPERATOR {
        /// <summary>
        /// 主键ID
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 底层类编号集合，多个用 ; 连接
        /// <summary>
        public virtual string BOTTOM_ID_GATHER { get; set; }
        /// <summary>
        /// 类名
        /// <summary>
        public virtual string CLASS_NAME { get; set; }
        /// <summary>
        /// 中文名称
        /// <summary>
        public virtual string CHI_NAME { get; set; }
        /// <summary>
        /// 数据库连接名
        /// <summary>
        public virtual string DB_CONNECT_NAME { get; set; }
        /// <summary>
        /// 注释
        /// <summary>
        public virtual string ANNOTATION { get; set; }
        /// <summary>
        /// 是否启用：0为非，1为是
        /// <summary>
        public virtual short? IS_ENABLE { get; set; }
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
