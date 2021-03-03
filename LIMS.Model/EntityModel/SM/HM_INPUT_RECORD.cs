using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class HM_INPUT_RECORD
    {
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
        /// 入库位置
        /// <summary>
        public virtual string INPUT_WST { get; set; }
        /// <summary>
        /// 入库时间
        /// <summary>
        public virtual DateTime INPUT_STAMP { get; set; }
        /// <summary>
        /// 确定分流,0否，1是
        /// <summary>
        public virtual short IS_DISPATCH { get; set; }
        /// <summary>
        /// 去向脱硫,脱硫站编号
        /// <summary>
        public virtual string TO_DES { get; set; }
        /// <summary>
        /// 入库操作员
        /// <summary>
        public virtual int USER_ID { get; set; }
        /// <summary>
        /// 入库班组
        /// <summary>
        public virtual int TEAM_ID { get; set; }
        /// <summary>
        /// 铁水净重
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
