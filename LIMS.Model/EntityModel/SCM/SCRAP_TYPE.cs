using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {

[Serializable]
    
    public class SCRAP_TYPE {
        /// <summary>
        /// 序号;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 废钢名称;
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// 废钢编号;
        /// <summary>
        public virtual string CODE { get; set; }
        /// <summary>
        /// 废钢规格;
        /// <summary>
        public virtual string SPECIFICATION { get; set; }     
        /// <summary>
        /// 废钢大小类别;
        /// <summary>
        public virtual int? P_ID { get; set; }
        /// <summary>
        /// 描述;
        /// <summary>
        public virtual string DESCRIPTION { get; set; }
        /// <summary>
        /// 废钢等级
        /// <summary>
        public virtual short? SCRAP_LEVEL { get; set; }
        /// <summary>
        /// 废钢是否可用
        /// <summary>
        public virtual short? IS_USE { get; set; }
        /// <summary>
        /// 创建时间
        /// <summary>
        public virtual DateTime? CREATE_TIME { get; set; }
        /// <summary>
        /// 修改时间
        /// <summary>
        public virtual DateTime? UPDATE_TIME { get; set; }
    }
}
