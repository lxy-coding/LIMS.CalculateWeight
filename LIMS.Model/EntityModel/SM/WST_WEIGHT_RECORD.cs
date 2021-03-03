using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class WST_WEIGHT_RECORD {
        /// <summary>
        /// ID,GUID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 设备
        /// <summary>
        public virtual string DEVICE { get; set; }
        /// <summary>
        /// 设备类型、1转炉，2精炼，3连铸
        /// <summary>
        public virtual short? DEVICE_TYPE { get; set; }
        /// <summary>
        /// 入天车
        /// <summary>
        public virtual string ENTER_CRA { get; set; }
        /// <summary>
        /// 入工位
        /// <summary>
        public virtual string ENTER_WST { get; set; }
        /// <summary>
        /// 入时间
        /// <summary>
        public virtual DateTime? ENTER_TIME { get; set; }
        /// <summary>
        /// 入物重
        /// <summary>
        public virtual int? ENTER_WEIGHT { get; set; }
        /// <summary>
        /// 出天车
        /// <summary>
        public virtual string EXIT_CRA { get; set; }
        /// <summary>
        /// 出工位
        /// <summary>
        public virtual string EXIT_WST { get; set; }
        /// <summary>
        /// 出时间
        /// <summary>
        public virtual DateTime? EXTI_TIME { get; set; }
        /// <summary>
        /// 出物重
        /// <summary>
        public virtual int? EXTI_WEIGHT { get; set; }
        /// <summary>
        /// 炉次号
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 类型、1废钢，2铁水，3钢水
        /// <summary>
        public virtual short? TYPE { get; set; }
        /// <summary>
        /// 单号、废钢计量委托单号，铁水炉次号
        /// <summary>
        public virtual string ODD { get; set; }
        /// <summary>
        /// 是否处理标志、0未处理，1已处理
        /// <summary>
        public virtual short? FLAG { get; set; }
        /// <summary>
        /// 创建时间
        /// <summary>
        public virtual DateTime CREAT_TIME { get; set; }
        /// <summary>
        /// 备用1
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 备用2
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 备用3
        /// <summary>
        public virtual string FIELD3 { get; set; }
        /// <summary>
        /// 包号
        /// <summary>
        public virtual string CON_NUM { get; set; }
        /// <summary>
        /// 净重
        /// <summary>
        public virtual int? NET_WEIGHT { get; set; }
        /// <summary>
        /// 是否匹配到分流
        /// <summary>
        public virtual short? IS_MATCH { get; set; }
    }
}
