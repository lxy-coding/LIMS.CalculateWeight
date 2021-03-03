using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class MAIN_SCRAP {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 事件代码;
        /// <summary>
        public virtual string EVENT_CODE { get; set; }
        /// <summary>
        /// 事件时间;
        /// <summary>
        public virtual string EVENT_TIME { get; set; }
        /// <summary>
        /// 物料编码;
        /// <summary>
        public virtual string MAT_ID { get; set; }
        /// <summary>
        /// 物料名;
        /// <summary>
        public virtual string PRODUCT_CODE { get; set; }
        /// <summary>
        /// 物料描述;
        /// <summary>
        public virtual string DESCRIPTION { get; set; }
        /// <summary>
        /// 化学成分元素个数;
        /// <summary>
        public virtual string ELEM_COUNT { get; set; }
        /// <summary>
        /// 化学成分;
        /// <summary>
        public virtual string ELEM { get; set; }
        /// <summary>
        /// 保留参数个数;
        /// <summary>
        public virtual string PARAM_COUNT { get; set; }
    }
}
