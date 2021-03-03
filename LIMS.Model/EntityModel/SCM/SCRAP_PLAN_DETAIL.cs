using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class SCRAP_PLAN_DETAIL {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 废钢料计划;
        /// <summary>
        public virtual string SCRAP_PLAN_ID { get; set; }
        /// <summary>
        /// 废钢种类;
        /// <summary>
        public virtual int? SCRAP_TYPE_ID { get; set; }
        /// <summary>
        /// 废钢斗号;
        /// <summary>
        public virtual int? SCRAP_BUCKET_ID { get; set; }
        /// <summary>
        /// 计划配入量;
        /// <summary>
        public virtual int? PLAN_MATCH_WEIGHT { get; set; }
        /// <summary>
        /// 计划配入时间;
        /// <summary>
        public virtual DateTime? PLAN_MATCH_TIME { get; set; }
        /// <summary>
        /// 实际配入时间;
        /// <summary>
        public virtual DateTime? REAL_MATCH_TIME { get; set; }
        /// <summary>
        /// 计划装入量;
        /// <summary>
        public virtual int? PLAN_LOAD_WEIGHT { get; set; }
        /// <summary>
        /// 计划装入时间;
        /// <summary>
        public virtual DateTime? PLAN_LOAD_TIME { get; set; }
        /// <summary>
        /// 实际装入时间;
        /// <summary>
        public virtual DateTime? REAL_LOAD_TIME { get; set; }
        /// <summary>
        /// 废钢装载位置;
        /// <summary>
        public virtual short? LOAD_BUCKET_LOCATION { get; set; }
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
    }
}
