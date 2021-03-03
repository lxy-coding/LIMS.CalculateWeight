using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class HML_OUTPUT_RECORD {
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
        /// 车架号
        /// <summary>
        public virtual string VERHICLE_NUM { get; set; }
        /// <summary>
        /// 出厂位置
        /// <summary>
        public virtual string INPUT_WST { get; set; }
        /// <summary>
        /// 出库操作员
        /// <summary>
        public virtual int USER_ID { get; set; }
        /// <summary>
        /// 出库班组
        /// <summary>
        public virtual int TEAM_ID { get; set; }
        /// <summary>
        /// 出库时间
        /// <summary>
        public virtual DateTime OUTPUT_TIME { get; set; }
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
