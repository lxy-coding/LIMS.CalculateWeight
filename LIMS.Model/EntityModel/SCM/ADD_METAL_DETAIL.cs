using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class ADD_METAL_DETAIL {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 炉前加贵金属ID;
        /// <summary>
        public virtual string ADD_METAL_ID { get; set; }
        /// <summary>
        /// 贵金属种类;
        /// <summary>
        public virtual int? METAL_TYPE_ID { get; set; }
        /// <summary>
        /// 计划重量;
        /// <summary>
        public virtual int? PLAN_WEIGHT { get; set; }
        /// <summary>
        /// 实际重量;
        /// <summary>
        public virtual int? REAL_WEIGHT { get; set; }
        /// <summary>
        /// 创建人;
        /// <summary>
        public virtual string FIRST_USER { get; set; }
        /// <summary>
        /// 创建时间;
        /// <summary>
        public virtual DateTime? FIRST_TIME { get; set; }
        /// <summary>
        /// 修改人;
        /// <summary>
        public virtual string LAST_USER { get; set; }
        /// <summary>
        /// 修改时间;
        /// <summary>
        public virtual DateTime? LAST_TIME { get; set; }
        /// <summary>
        /// 主表ID;
        /// <summary>
        public virtual string MASTERID { get; set; }

    }
}
