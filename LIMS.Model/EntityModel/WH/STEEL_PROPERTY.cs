using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class STEEL_PROPERTY
    {
        /// <summary>
        /// GUID;
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 坯料号;
        /// <summary>
        public virtual string STEEL_NUM { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 宽度;
        /// <summary>
        public virtual short? WIDTH { get; set; }
        /// <summary>
        /// 长度;
        /// <summary>
        public virtual int? STEEL_LENGTH { get; set; }
        /// <summary>
        /// 厚度;
        /// <summary>
        public virtual short? THICK { get; set; }
        /// <summary>
        /// 重量;
        /// <summary>
        public virtual int? WEIGTH { get; set; }
        /// <summary>
        /// 钢种;
        /// <summary>
        public virtual string GRADE { get; set; }
        /// <summary>
        /// 规格;
        /// <summary>
        public virtual string S_SIZE { get; set; }
        /// <summary>
        /// 等级;
        /// <summary>
        public virtual string S_LEVEL { get; set; }
        /// <summary>
        /// 描述;
        /// <summary>
        public virtual string DESCRIPTION { get; set; }
        /// <summary>
        /// 是否为外购坯;
        /// <summary>
        public virtual short? IS_BUY { get; set; }
        /// <summary>
        /// 订单号;
        /// <summary>
        public virtual string ORDER_NO { get; set; }
        /// <summary>
        /// 创建时间; yyyy-mm-dd hh24:mi:ss
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
