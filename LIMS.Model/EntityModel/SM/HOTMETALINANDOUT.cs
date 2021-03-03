using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 铁水出入库情况
    /// </summary>
    [Serializable]
    public class HOTMETALINANDOUT
    {
        /// <summary>
        /// ID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 铁运线（对象ID）
        /// <summary>
        public virtual int? IRONLINE { get; set; }
        /// <summary>
        /// 铁包号
        /// <summary>
        public virtual string IRONCONNUM { get; set; }
        /// <summary>
        /// 经办人
        /// <summary>
        public virtual string HANDLEUSER { get; set; }
        /// <summary>
        /// 工位
        /// <summary>
        public virtual string WSTNUM { get; set; }
        /// <summary>
        /// 类型
        /// <summary>
        public virtual short? IRONTYPE { get; set; }
        /// <summary>
        /// 时间
        /// <summary>
        public virtual DateTime? RECORDINGTIME { get; set; }
        /// <summary>
        /// 状态（1入库；2出库）
        /// <summary>
        public virtual short? ISSTATE { get; set; }
        /// <summary>
        /// 入库时间
        /// <summary>
        public virtual DateTime? ENTERTIME { get; set; }
        /// <summary>
        /// 出库时间
        /// <summary>
        public virtual DateTime? OUTTIME { get; set; }
        /// <summary>
        /// 铁次号
        /// <summary>
        public virtual string IRONTIMESNUM { get; set; }
        /// <summary>
        /// 备注
        /// <summary>
        public virtual string REMARKS { get; set; }
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
