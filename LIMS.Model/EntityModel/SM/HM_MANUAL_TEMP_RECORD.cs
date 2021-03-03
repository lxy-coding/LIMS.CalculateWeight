using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class HM_MANUAL_TEMP_RECORD {
        /// <summary>
        /// 序号，主键; GUID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 炉批号
        /// <summary>
        public virtual string HEAT_BATCH_NO { get; set; }
        /// <summary>
        /// 铁包号
        /// <summary>
        public virtual string HML_NUM { get; set; }
        /// <summary>
        /// 测温值，摄氏度
        /// <summary>
        public virtual int? IRON_TEMP { get; set; }
        /// <summary>
        /// 测温时间
        /// <summary>
        public virtual DateTime IRON_TEMP_TIME { get; set; }
        /// <summary>
        /// 测温操作员
        /// <summary>
        public virtual int USER_ID { get; set; }
        /// <summary>
        /// 测温班组
        /// <summary>
        public virtual int TEAM_ID { get; set; }
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
