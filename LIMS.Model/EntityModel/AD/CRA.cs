using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class CRA {
        /// <summary>
        /// 天车编号
        /// <summary>
        public virtual int CRA_ID { get; set; }
        /// <summary>
        /// 天车优先工作区域最大X，毫米
        /// <summary>
        public virtual int? FIR_MAX_X { get; set; }
        /// <summary>
        /// 天车优先工作区域最小X，毫米
        /// <summary>
        public virtual int? FIR_MIN_X { get; set; }
        /// <summary>
        /// 优先工作类型，
        ///CarryEmptHML = 1;//运载空铁水罐
        ///CarryHeavHML = 2;//运载重铁水罐
        ///CarryEmptSlot = 3;//运载空废钢斗
        ///CarryHeavSlot = 4;//运载重废钢斗
        ///CarryScrap = 5;//吊运废钢
        ///CarryEmptLadle = 6;//运载空钢包
        ///CarryHeavLadle = 7;//运载重钢包
        ///CarrySlab = 8;//运载板坯
        ///
        /// <summary>
        public virtual short? JOB_TYPE { get; set; }
        /// <summary>
        /// 大车载重包速度，单位mm/min
        /// <summary>
        public virtual int? BC_HEAVY_SPEED { get; set; }
        /// <summary>
        /// 大车载空包速度，单位mm/min
        /// <summary>
        public virtual int? BC_SLIGHT_SPEED { get; set; }
        /// <summary>
        /// 大车空载速度，单位mm/min
        /// <summary>
        public virtual int? BC_EMPTY_SPEED { get; set; }
        /// <summary>
        /// 小车载重包速度，单位mm/min
        /// <summary>
        public virtual int? SC_HEAVY_SPEED { get; set; }
        /// <summary>
        /// 小车载空包速度，单位mm/min
        /// <summary>
        public virtual int? SC_SLIGHT_SPEED { get; set; }
        /// <summary>
        /// 小车空载速度，单位mm/min
        /// <summary>
        public virtual int? SC_EMPTY_SPEED { get; set; }
        /// <summary>
        /// 重包起吊经验时长，单位min
        /// <summary>
        public virtual float? HEAVY_HOIST_DURAT { get; set; }
        /// <summary>
        /// 空包起吊经验时长，单位min
        /// <summary>
        public virtual float? EMPTY_HOIST_DURAT { get; set; }
        /// <summary>
        /// 重包放吊经验时长，单位min
        /// <summary>
        public virtual float? HEAVY_DROP_DURAT { get; set; }
        /// <summary>
        /// 空包放吊经验时长，单位min
        /// <summary>
        public virtual float? EMPTY_DROP_DURAT { get; set; }
        /// <summary>
        /// 1为X，2为Y
        /// <summary>
        public virtual short? DIRE { get; set; }
        /// <summary>
        /// 单位，豪米/分钟
        /// <summary>
        public virtual int? MAX_X_SPEED { get; set; }
        /// <summary>
        /// 单位，豪米/分钟
        /// <summary>
        public virtual int? MAX_Y_SPEED { get; set; }
    }
}
