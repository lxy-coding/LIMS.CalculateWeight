using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class USER_LOAD_RECORD {
        /// <summary>
        /// 主键，GUID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 用户信息表ID
        /// <summary>
        public virtual int? USER_ID { get; set; }
        /// <summary>
        /// 登录状态，0退出，1登录
        /// <summary>
        public virtual short? LOAD_STATUS { get; set; }
        /// <summary>
        /// IP地址
        /// <summary>
        public virtual string LOAD_IP { get; set; }
        /// <summary>
        /// MAC地址
        /// <summary>
        public virtual string LOAD_MAC { get; set; }
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
    }
}
