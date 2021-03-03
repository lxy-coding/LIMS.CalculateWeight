using System.Collections.Generic;
using System.Text;
using System;
using Castle.ActiveRecord;


namespace LIMS.Model.EntityModel {
    
    
    [ActiveRecord()]
    public class CcmRotationInterface : ActiveRecordValidationBase<CcmRotationInterface> {
        
        [Property(Column="MSG_COUNTER", Length=22, NotNull=true)]
        public virtual long MsgCounter { get; set; }
        
        [Property(Column="MSG_TIME", Length=7)]
        public virtual System.DateTime MsgTime { get; set; }
        
        [Property(Column="READ_TIME", Length=7)]
        public virtual System.DateTime ReadTime { get; set; }
        
        [Property(Column="MSG_STATUS", Length=8)]
        public virtual string MsgStatus { get; set; }
        
        [Property(Column="OP_DIV", Length=2)]
        public virtual string OpDiv { get; set; }
        
        [Property(Column="PLANT_NO", Length=10)]
        public virtual string PlantNo { get; set; }
        
        [Property(Column="ARMA_CAST", Length=2)]
        public virtual string ArmaCast { get; set; }
        
        [Property(Column="ARMB_CAST", Length=2)]
        public virtual string ArmbCast { get; set; }
        
        [Property(Column="CASTING_FLAG", Length=2)]
        public virtual string CastingFlag { get; set; }
        
        [Property(Column="TIME_STAMP", Length=28)]
        public virtual string TimeStamp { get; set; }
        
        [Property(Column="FIELD1", Length=40)]
        public virtual string Field1 { get; set; }
        
        [Property(Column="FIELD2", Length=40)]
        public virtual string Field2 { get; set; }
        
        [Property(Column="FIELD3", Length=40)]
        public virtual string Field3 { get; set; }
    }
}
