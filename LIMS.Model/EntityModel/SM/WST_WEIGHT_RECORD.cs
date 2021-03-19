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
        /// 设备类型、1转炉，2精炼，3连铸，4VD炉
        /// <summary>
        public virtual short? DEVICE_TYPE { get; set; }
        /// <summary>
        /// 天车号
        /// <summary>
        public virtual string CRA { get; set; }
        /// <summary>
        /// 工位
        /// <summary>
        public virtual string WST { get; set; }
        /// <summary>
        /// 开始时间
        /// <summary>
        public virtual DateTime? START_TIME { get; set; }
        /// <summary>
        /// 毛重
        /// <summary>
        public virtual int? GROSS_WEIGHT { get; set; }     
        /// <summary>
        /// 结束时间
        /// <summary>
        public virtual DateTime? END_TIME { get; set; }
        /// <summary>
        /// 皮重
        /// <summary>
        public virtual int? TARE_WEIGHT { get; set; }
        /// <summary>
        /// 炉次号
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 类型、1废钢，2铁水，3半钢水，4钢水
        /// <summary>
        public virtual short? TYPE { get; set; }       
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
        /// 动作类型:1、兑物 2、到站 3、离站
        /// <summary>
        public virtual int? IO_TYPE { get; set; }

    }
}
