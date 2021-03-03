using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class SCRAP_PLAN {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 炉次计划号;
        /// <summary>
        public virtual string HEAT_PLAN_ID { get; set; }
        /// <summary>
        /// 废钢料计划状态;
        /// <summary>
        public virtual short? STATUS { get; set; }
        /// <summary>
        /// 异常结束信息;
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
        /// <summary>
        /// 废钢料计划号;
        /// <summary>
        public virtual string STEEL_PLAN_ID { get; set; }
        /// <summary>
        /// 计划重量;
        /// <summary>
        public virtual int? PALN_WEIGHT { get; set; }
        /// <summary>
        /// 废钢料计划类型;
        /// <summary>
        public virtual short? PLAN_TYPE { get; set; }
        /// <summary>
        /// 废钢料炉次号;
        /// <summary>
        public virtual string HEAT_NO { get; set; }
    }
}
