using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class PLAN_POSIT
    {
        /// <summary>
        /// GUID;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 计划ID;
        /// <summary>
        public virtual string PLA_ID { get; set; }
        /// <summary>
        /// 计划号;
        /// <summary>
        public virtual string PARENT_ID { get; set; }
        /// <summary>
        /// 区域ID;
        /// <summary>
        public virtual int? AREA_ID { get; set; }
        /// <summary>
        /// 货位ID;
        /// <summary>
        public virtual int? POSITION_ID { get; set; }
        /// <summary>
        /// 层;
        /// <summary>
        public virtual short? LAYER { get; set; }
        /// <summary>
        /// 根数
        /// <summary>
        public virtual short? STEEL_COUNT { get; set; }
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
