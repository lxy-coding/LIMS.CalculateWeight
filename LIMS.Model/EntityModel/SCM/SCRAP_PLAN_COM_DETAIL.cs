using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class SCRAP_PLAN_COM_DETAIL {
        /// <summary>
        /// 主键;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 废钢料计划;
        /// <summary>
        public virtual string SCRAP_PLAN_COM_ID { get; set; }
        /// <summary>
        /// 接口ID;
        /// <summary>
        public virtual int? INTERFACE_ID { get; set; }
        /// <summary>
        /// 物料ID;
        /// <summary>
        public virtual int? MATERIAL_ID { get; set; }
        /// <summary>
        /// 物料重量kg;
        /// <summary>
        public virtual int? MATERIAL_WT { get; set; }
        /// <summary>
        /// 物料称量顺序;
        /// <summary>
        public virtual short? MATERIAL_SEQ { get; set; }
    }
}
