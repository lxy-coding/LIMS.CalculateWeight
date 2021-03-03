using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 用户界面名称
    /// </summary>
    [Serializable]

    public class UINAME
    {
        /// <summary>
        /// 序号;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 名称;
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// 系统名称;
        /// <summary>
        public virtual string SYSTEMNAME { get; set; }
        /// <summary>
        /// 公司;
        /// <summary>
        public virtual string COMPANY { get; set; }
        /// <summary>
        /// 图标路径;
        /// <summary>
        public virtual string ICON { get; set; }
        /// <summary>
        /// 版本;
        /// <summary>
        public virtual string EDITION { get; set; }
        /// <summary>
        /// 是否启用;
        /// <summary>
        public virtual short? ENABLE_FLAG { get; set; }
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
