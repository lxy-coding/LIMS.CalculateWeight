using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class METAL_TYPE {
        /// <summary>
        /// 序号;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 贵金属名称;
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// 贵金属编号;
        /// <summary>
        public virtual string CODE { get; set; }
        /// <summary>
        /// 描述;
        /// <summary>
        public virtual string DESCRIPTION { get; set; }
        /// <summary>
        /// PID;
        /// <summary>
        public virtual int? P_ID { get; set; }  //
        /// <summary>
        /// SPECIFICATION;
        /// <summary>
        public virtual string SPECIFICATION { get; set; } 
    }
}
