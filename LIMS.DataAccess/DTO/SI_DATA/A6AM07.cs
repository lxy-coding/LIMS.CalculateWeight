using System.Collections.Generic;
using System.Text;
using System;
using Castle.ActiveRecord;


namespace LIMS.Model.EntityModel {
    
    
    [ActiveRecord()]
    public class A6am07 : ActiveRecordValidationBase<A6am07> {
        
        [Property(Column="MSG_COUNTER", Length=22, NotNull=true)]
        public virtual long MsgCounter { get; set; }
        
        [Property(Column="MSG_TIME", Length=7)]
        public virtual System.DateTime MsgTime { get; set; }
        
        [Property(Column="READ_TIME", Length=7)]
        public virtual System.DateTime ReadTime { get; set; }
        
        [Property(Column="MSG_STATUS", Length=8)]
        public virtual string MsgStatus { get; set; }
        
        [Property(Column="OP_DIV", Length=12)]
        public virtual string OpDiv { get; set; }
        
        /// <summary>
        /// 高炉号
        /// <summary>
        [Property(Column="GL_NO", Length=20)]
        public virtual string GlNo { get; set; }
        
        /// <summary>
        /// 铁次号
        /// <summary>
        [Property(Column="IRON_NO", Length=50)]
        public virtual string IronNo { get; set; }
        
        /// <summary>
        /// 铁水罐号
        /// <summary>
        [Property(Column="IRON_LADLE_NO", Length=30)]
        public virtual string IronLadleNo { get; set; }
        
        /// <summary>
        /// 铁水包保龄
        /// <summary>
        [Property(Column="IRON_LADLE_LIFE", Length=20)]
        public virtual string IronLadleLife { get; set; }
        
        /// <summary>
        /// 车号
        /// <summary>
        [Property(Column="VEHICLE_NO", Length=50)]
        public virtual string VehicleNo { get; set; }
        
        /// <summary>
        /// 毛重
        /// <summary>
        [Property(Column="GROSS_WT", Length=24)]
        public virtual string GrossWt { get; set; }
        
        /// <summary>
        /// 皮重
        /// <summary>
        [Property(Column="TARE_WT", Length=24)]
        public virtual string TareWt { get; set; }
        
        /// <summary>
        /// 净重
        /// <summary>
        [Property(Column="NET_WT", Length=24)]
        public virtual string NetWt { get; set; }
        
        /// <summary>
        /// 磅站
        /// <summary>
        [Property(Column="WEIGH_SITE", Length=50)]
        public virtual string WeighSite { get; set; }
        
        /// <summary>
        /// 重磅过磅时间
        /// <summary>
        [Property(Column="PONDER_TIME", Length=38)]
        public virtual string PonderTime { get; set; }
        
        /// <summary>
        /// 空磅过磅时间
        /// <summary>
        [Property(Column="EMPTY_TIME", Length=38)]
        public virtual string EmptyTime { get; set; }
        
        /// <summary>
        /// 铁水温度
        /// <summary>
        [Property(Column="IRON_TEMP", Length=18)]
        public virtual string IronTemp { get; set; }
        
        /// <summary>
        /// 铁水测温时刻
        /// <summary>
        [Property(Column="IRON_TEMP_TIME", Length=38)]
        public virtual string IronTempTime { get; set; }
        
        /// <summary>
        /// 出铁开始时刻
        /// <summary>
        [Property(Column="TAP_START_TIME", Length=38)]
        public virtual string TapStartTime { get; set; }
        
        /// <summary>
        /// 出铁结束时刻
        /// <summary>
        [Property(Column="TAP_END_TIME", Length=38)]
        public virtual string TapEndTime { get; set; }
        
        /// <summary>
        /// 发料时刻
        /// <summary>
        [Property(Column="ISSUE_TIME", Length=38)]
        public virtual string IssueTime { get; set; }
        
        /// <summary>
        /// 炉批号
        /// <summary>
        [Property(Column="HEAT_BATCH_NO", Length=50)]
        public virtual string HeatBatchNo { get; set; }
    }
}
