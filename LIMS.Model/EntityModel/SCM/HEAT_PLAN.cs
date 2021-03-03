using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class HEAT_PLAN {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 事件代码;
        /// <summary>
        public virtual short? EVENT_CODE { get; set; }
        /// <summary>
        /// 事件;
        /// <summary>
        public virtual DateTime? EVENT_TIME { get; set; }
        /// <summary>
        /// 计划状态;
        /// <summary>
        public virtual short? STATUS { get; set; }
        /// <summary>
        /// 浇次位置;
        /// <summary>
        public virtual int? POSITION_IN_LINE { get; set; }
        /// <summary>
        /// 计划炉号;
        /// <summary>
        public virtual int? PLAN_HEAT_ID { get; set; }
        /// <summary>
        /// 实际炉号;
        /// <summary>
        public virtual int? HEAT_ID { get; set; }
        /// <summary>
        /// 铁钢包号;
        /// <summary>
        public virtual int? EQUIP_ID { get; set; }
        /// <summary>
        /// 计划类型;
        /// <summary>
        public virtual short? PLAN_TYPE { get; set; }
        /// <summary>
        /// 钢/合金等级;
        /// <summary>
        public virtual string GRADE_ID { get; set; }
        /// <summary>
        /// 浇次号;
        /// <summary>
        public virtual string CASTSEQ_ID { get; set; }
        /// <summary>
        /// 目标炉次重量;
        /// <summary>
        public virtual int? WEIGHT_AIM { get; set; }
        /// <summary>
        /// 描述;
        /// <summary>
        public virtual string NOTE_TEXT { get; set; }
    }
}
