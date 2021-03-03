using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 连铸旋转信号
    /// </summary>
    [Serializable]
    public class CCM_TURRET
    {
        /// <summary>
        /// 序号，主键，自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 序号，外键，铸机属性表ID
        /// <summary>
        public virtual CCM_PROPERTY CCM_ID { get; set; }
        /// <summary>
        /// A臂浇铸
        /// <summary>
        public virtual short? ARMACASTPOS { get; set; }
        /// <summary>
        /// B臂浇铸
        /// <summary>
        public virtual short? ARMBCASTPOS { get; set; }
        /// <summary>
        /// 正在浇铸
        /// <summary>
        public virtual string CASTING_FALG { get; set; }
        /// <summary>
        /// 状态更新时间
        /// <summary>
        public virtual DateTime? UPDATE_TIME { get; set; }
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
