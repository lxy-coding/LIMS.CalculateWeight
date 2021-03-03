using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class WH_SLAB_REAL_INFO {
        /// <summary>
        /// GUID;
        /// <summary>
        public virtual string ID { get; set; }
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
        /// 货位ID;
        /// <summary>
        public virtual int? POSITION_ID { get; set; }
        /// <summary>
        /// 中心坐标X;
        /// <summary>
        public virtual int? CENTRE_X { get; set; }
        /// <summary>
        /// 中心坐标Y;
        /// <summary>
        public virtual int? CENTRE_Y { get; set; }
        /// <summary>
        /// 中心坐标Z;
        /// <summary>
        public virtual int? CENTRE_Z { get; set; }
        public virtual DateTime? UPDATE_TIME { get; set; }
        /// <summary>
        /// 区域ID
        /// <summary>
        public virtual int? AREA_ID { get; set; }
        /// <summary>
        /// 跨ID
        /// <summary>
        public virtual int? SPA_ID { get; set; }
        /// <summary>
        /// 层
        /// <summary>
        public virtual short? LAYER { get; set; }
    }
}
