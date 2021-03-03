using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel{

[Serializable]
    
    public class SIMULATION_RESULT {
        /// <summary>
        /// GUID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 钢包号;
        /// <summary>
        public virtual string LADLE_NUM { get; set; }
        /// <summary>
        /// 炉次号;
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 位置;
        /// <summary>
        public virtual string POSIT { get; set; }
        /// <summary>
        /// 钢液温度,K
        /// <summary>
        public virtual short? STEEL_TEMP { get; set; }
        /// <summary>
        /// 记录生成时间
        /// <summary>
        public virtual DateTime? TIME_STAMP { get; set; }
        /// <summary>
        /// 预留字段1
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3
        /// <summary>
        public virtual string FIELD3 { get; set; }
        /// <summary>
        /// 包底外壳温度分布
        /// <summary>
        public virtual string BOTTOM_SHELL_DIST { get; set; }
        /// <summary>
        /// 包壁外壳温度分布
        /// <summary>
        public virtual string WALL_SHELL_DIST { get; set; }
        /// <summary>
        /// 包底永久层温度分布
        /// <summary>
        public virtual string BOTTOM_PERMANENT_DIST { get; set; }
        /// <summary>
        /// 包底工作层温度分布
        /// <summary>
        public virtual string BOTTOM_WORK_DIST { get; set; }
        /// <summary>
        /// 包壁保温层温度分布
        /// <summary>
        public virtual string WALL_INSULATE_DIST { get; set; }
        /// <summary>
        /// 包壁永久层温度分布
        /// <summary>
        public virtual string WALL_PERMANENT_DIST { get; set; }
        /// <summary>
        /// 包壁工作层温度分布
        /// <summary>
        public virtual string WALL_WORK_DIST { get; set; }
    }
}
