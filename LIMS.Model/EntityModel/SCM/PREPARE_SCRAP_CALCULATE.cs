using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class PREPARE_SCRAP_CALCULATE {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 废钢料计划;
        /// <summary>
        public virtual string LOAD_SCRAP_PLAN_ID { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string HEAT_NUMBER { get; set; }
        /// <summary>
        /// 废钢斗;
        /// <summary>
        public virtual int? SCRAP_BUCKET_ID { get; set; }
        /// <summary>
        /// 状态;
        /// <summary>
        public virtual short? STATUS { get; set; }
        /// <summary>
        /// 异常结束信息;
        /// <summary>
        public virtual string UNUSUAL_DESCRIPTION { get; set; }
        /// <summary>
        /// 计划总重量;
        /// <summary>
        public virtual int? PLAN_SUM_WEIGHT { get; set; }
        /// <summary>
        /// 实际总重量;
        /// <summary>
        public virtual int? REAL_SUM_WEIGHT { get; set; }
        /// <summary>
        /// 人工确认总重量;
        /// <summary>
        public virtual int? CONFIRM_SUM_WEIGHT { get; set; }
        /// <summary>
        /// 描述;
        /// <summary>
        public virtual string DESCRIPTION { get; set; }
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
