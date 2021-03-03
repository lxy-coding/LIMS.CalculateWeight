using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class USER_OPERATION_RECORD {
        /// <summary>
        /// 主键，GUID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 用户登录记录表ID
        /// <summary>
        public virtual string USER_LOAD_ID { get; set; }
        /// <summary>
        /// 操作类型
        /// <summary>
        public virtual short? OPERATE_TYPE { get; set; }
        /// <summary>
        /// 记录生成时间
        /// <summary>
        public virtual DateTime? TIME_STAMP { get; set; }
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
        /// 操作内容
        /// <summary>
        public virtual string OPERATE_CONTENT { get; set; }
    }
}
