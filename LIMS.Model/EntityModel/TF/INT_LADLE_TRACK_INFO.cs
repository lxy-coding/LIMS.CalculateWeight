using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class INT_LADLE_TRACK_INFO {
        /// <summary>
        /// 序号;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 钢包号;
        /// <summary>
        public virtual string LADLE_NUM { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 计划号;
        /// <summary>
        public virtual string PLAN_NUM { get; set; }
        /// <summary>
        /// 钢种;
        /// <summary>
        public virtual string STEEL_GRADE { get; set; }
        /// <summary>
        /// 钢液重量;
        /// <summary>
        public virtual double STEEL_WEIGHT { get; set; }
        /// <summary>
        /// 是否加盖;
        /// <summary>
        public virtual short IS_COVER { get; set; }
        /// <summary>
        /// 最新动作; 起吊or放吊
        /// <summary>
        public virtual short ACTION_SYMBOL { get; set; }
        /// <summary>
        /// 位置编号;
        /// <summary>
        public virtual string WST_NUM { get; set; }
        /// <summary>
        /// 时间戳; 格式YYYY-MM-DD HH24:MI:SS
        /// <summary>
        public virtual DateTime TIME_STAMP { get; set; }
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
