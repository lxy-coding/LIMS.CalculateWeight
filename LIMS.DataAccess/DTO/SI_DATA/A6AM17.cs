using System.Collections.Generic;
using System.Text;
using System;
using Castle.ActiveRecord;


namespace LIMS.Model.EntityModel {
    
    
    [ActiveRecord()]
    public class A6am17 : ActiveRecordValidationBase<A6am17> {
        
        [Property(Column="MSG_COUNTER", Length=22, NotNull=true)]
        public virtual long MsgCounter { get; set; }
        
        [Property(Column="MSG_TIME", Length=7, NotNull=true)]
        public virtual System.DateTime MsgTime { get; set; }
        
        [Property(Column="READ_TIME", Length=7)]
        public virtual System.DateTime ReadTime { get; set; }
        
        [Property(Column="MSG_STATUS", Length=8, NotNull=true)]
        public virtual string MsgStatus { get; set; }
        
        [Property(Column="OP_DIV", Length=12)]
        public virtual string OpDiv { get; set; }
        
        [Property(Column="INPUT_PLAN", Length=50)]
        public virtual string InputPlan { get; set; }
        
        [Property(Column="MAT_NO", Length=50)]
        public virtual string MatNo { get; set; }
        
        [Property(Column="MAT_TYPE", Length=30)]
        public virtual string MatType { get; set; }
        
        [Property(Column="IN_TYPE", Length=30)]
        public virtual string InType { get; set; }
        
        [Property(Column="SOU_POS", Length=30)]
        public virtual string SouPos { get; set; }
        
        [Property(Column="DES_POS", Length=30)]
        public virtual string DesPos { get; set; }
        
        [Property(Column="BACKUP", Length=210)]
        public virtual string Backup { get; set; }
    }
}
