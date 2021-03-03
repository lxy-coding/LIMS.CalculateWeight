using System.Collections.Generic;
using System.Text;
using System;
using Castle.ActiveRecord;


namespace LIMS.Model.EntityModel {
    
    
    [ActiveRecord()]
    public class A6am19 : ActiveRecordValidationBase<A6am19> {
        
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
        
        [Property(Column="PROD_SHIFT_NO", Length=12)]
        public virtual string ProdShiftNo { get; set; }
        
        [Property(Column="PROD_SHIFT_GROUP", Length=12)]
        public virtual string ProdShiftGroup { get; set; }
        
        [Property(Column="PROD_MAKER", Length=26)]
        public virtual string ProdMaker { get; set; }
        
        [Property(Column="VEHICLE_NO", Length=30)]
        public virtual string VehicleNo { get; set; }
        
        [Property(Column="HOPPER_NO", Length=30)]
        public virtual string HopperNo { get; set; }
        
        [Property(Column="REFE_ID", Length=38)]
        public virtual string RefeId { get; set; }
        
        [Property(Column="NET_WEIGHT", Length=24)]
        public virtual string NetWeight { get; set; }
        
        [Property(Column="TARE", Length=24)]
        public virtual string Tare { get; set; }
        
        [Property(Column="GROSS_WEIGHT", Length=24)]
        public virtual string GrossWeight { get; set; }
        
        [Property(Column="REFE_STATUS", Length=12)]
        public virtual string RefeStatus { get; set; }
        
        [Property(Column="PROD_ID", Length=30)]
        public virtual string ProdId { get; set; }
        
        [Property(Column="PROD_CNAME", Length=70)]
        public virtual string ProdCname { get; set; }
        
        [Property(Column="SRC_DEPT_ID", Length=30)]
        public virtual string SrcDeptId { get; set; }
        
        [Property(Column="SRC_DEPT_NAME", Length=70)]
        public virtual string SrcDeptName { get; set; }
        
        [Property(Column="SRC_STOCK_ID", Length=30)]
        public virtual string SrcStockId { get; set; }
        
        [Property(Column="SRC_STOCK_NAME", Length=70)]
        public virtual string SrcStockName { get; set; }
        
        [Property(Column="DEST_DEPT_ID", Length=30)]
        public virtual string DestDeptId { get; set; }
        
        [Property(Column="DEST_DEPT_NAME", Length=70)]
        public virtual string DestDeptName { get; set; }
        
        [Property(Column="DEST_STOCK_ID", Length=30)]
        public virtual string DestStockId { get; set; }
        
        [Property(Column="DEST_STOCK_NAME", Length=70)]
        public virtual string DestStockName { get; set; }
        
        [Property(Column="BUSINESS_TYPE", Length=12)]
        public virtual string BusinessType { get; set; }
        
        [Property(Column="REFE_TYPE", Length=12)]
        public virtual string RefeType { get; set; }
        
        [Property(Column="REFE_DATE", Length=38)]
        public virtual string RefeDate { get; set; }
        
        [Property(Column="REFE_CREATOR", Length=30)]
        public virtual string RefeCreator { get; set; }
        
        [Property(Column="BAR_CODE", Length=34)]
        public virtual string BarCode { get; set; }
        
        [Property(Column="MATWET1", Length=24)]
        public virtual string Matwet1 { get; set; }
        
        [Property(Column="MATWET2", Length=24)]
        public virtual string Matwet2 { get; set; }
        
        [Property(Column="MATWET3", Length=24)]
        public virtual string Matwet3 { get; set; }
        
        [Property(Column="MATWET4", Length=24)]
        public virtual string Matwet4 { get; set; }
        
        [Property(Column="MATWET5", Length=24)]
        public virtual string Matwet5 { get; set; }
        
        [Property(Column="MATWET6", Length=24)]
        public virtual string Matwet6 { get; set; }
        
        [Property(Column="GROSS_WEIGHT_TIME", Length=38)]
        public virtual string GrossWeightTime { get; set; }
    }
}
