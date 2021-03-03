using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class A6AM19
    {
        public virtual long MSG_COUNTER { get; set; }
        public virtual DateTime? MSG_TIME { get; set; }
        public virtual DateTime? READ_TIME { get; set; }
        public virtual string MSG_STATUS { get; set; }
        public virtual string OP_DIV { get; set; }
        public virtual string PROD_SHIFT_NO { get; set; }
        public virtual string PROD_SHIFT_GROUP { get; set; }
        public virtual string PROD_MAKER { get; set; }
        public virtual string VEHICLE_NO { get; set; }
        public virtual string HOPPER_NO { get; set; }
        public virtual string REFE_ID { get; set; }
        public virtual string NET_WEIGHT { get; set; }
        public virtual string TARE { get; set; }
        public virtual string GROSS_WEIGHT { get; set; }
        public virtual string REFE_STATUS { get; set; }
        public virtual string PROD_ID { get; set; }
        public virtual string PROD_CNAME { get; set; }
        public virtual string SRC_DEPT_ID { get; set; }
        public virtual string SRC_DEPT_NAME { get; set; }
        public virtual string SRC_STOCK_ID { get; set; }
        public virtual string SRC_STOCK_NAME { get; set; }
        public virtual string DEST_DEPT_ID { get; set; }
        public virtual string DEST_DEPT_NAME { get; set; }
        public virtual string DEST_STOCK_ID { get; set; }
        public virtual string DEST_STOCK_NAME { get; set; }
        public virtual string BUSINESS_TYPE { get; set; }
        public virtual string REFE_TYPE { get; set; }
        public virtual string REFE_DATE { get; set; }
        public virtual string REFE_CREATOR { get; set; }
        public virtual string BAR_CODE { get; set; }
        public virtual string MATWET1 { get; set; }
        public virtual string MATWET2 { get; set; }
        public virtual string MATWET3 { get; set; }
        public virtual string MATWET4 { get; set; }
        public virtual string MATWET5 { get; set; }
        public virtual string MATWET6 { get; set; }
    }
}
