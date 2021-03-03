using System.Collections.Generic;
using System.Text;
using System;
using Castle.ActiveRecord;


namespace LIMS.Model.EntityModel {
    
    
    [ActiveRecord()]
    public class A6am08 : ActiveRecordValidationBase<A6am08> {
        
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
        /// 分析时间
        /// <summary>
        [Property(Column="ANALYSIZE_TIME", Length=38)]
        public virtual string AnalysizeTime { get; set; }
        
        [Property(Column="CF_C", Length=26)]
        public virtual string CfC { get; set; }
        
        [Property(Column="CF_SI", Length=26)]
        public virtual string CfSi { get; set; }
        
        [Property(Column="CF_MN", Length=26)]
        public virtual string CfMn { get; set; }
        
        [Property(Column="CF_P", Length=26)]
        public virtual string CfP { get; set; }
        
        [Property(Column="CF_S", Length=26)]
        public virtual string CfS { get; set; }
        
        [Property(Column="CF_TI", Length=26)]
        public virtual string CfTi { get; set; }
        
        [Property(Column="CF_AS", Length=26)]
        public virtual string CfAs { get; set; }
        
        /// <summary>
        /// 炉批号
        /// <summary>
        [Property(Column="HEAT_BATCH_NO", Length=50)]
        public virtual string HeatBatchNo { get; set; }
    }
}
