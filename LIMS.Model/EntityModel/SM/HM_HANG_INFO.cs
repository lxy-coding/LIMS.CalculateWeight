using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class HM_HANG_INFO
    {
        /// <summary>
        /// 主键ID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 炉批号
        /// <summary>
        public virtual string HEAT_BATCH_NO { get; set; }
        /// <summary>
        /// 铁包编号
        /// <summary>
        public virtual string HML_NUM { get; set; }
        /// <summary>
        /// 当前状态，1入厂，2加料，3倒跨，4出厂
        /// <summary>
        public virtual short? STATE { get; set; }
        /// <summary>
        /// 是否去了转炉加料，0未加料，1已加料
        /// <summary>
        public virtual short? IS_ADD { get; set; }
        /// <summary>
        /// 转炉加料时间
        /// <summary>
        public virtual DateTime? BOF_ADD_TIME { get; set; }
        /// <summary>
        /// 是否出厂，0未出厂，1已出厂
        /// <summary>
        public virtual short? IS_OUT { get; set; }
        /// <summary>
        /// 出厂时间
        /// </summary>
        public virtual DateTime? OUT_TIME { get; set; }
        /// <summary>
        /// 创建时间，入厂时创建
        /// <summary>
        public virtual DateTime? CREATE_TIME { get; set; }
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
