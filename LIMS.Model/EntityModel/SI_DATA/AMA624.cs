using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class AMA624 {
        public virtual long MSG_COUNTER { get; set; }
        public virtual DateTime? MSG_TIME { get; set; }
        public virtual DateTime? READ_TIME { get; set; }
        public virtual string MSG_STATUS { get; set; }
        public virtual string OP_DIV { get; set; }
        public virtual string PROD_SHIFT_NO { get; set; }
        public virtual string PROD_SHIFT_GROUP { get; set; }
        public virtual string PROD_MAKER { get; set; }
        public virtual string MAT_TYPE { get; set; }
        public virtual string MOVE_TYPE { get; set; }
        public virtual string MAT_NO { get; set; }
        public virtual string SOU_POS { get; set; }
        public virtual string DES_POS { get; set; }
        public virtual string INOUTPUT_PLAN { get; set; }
        public virtual string STOCK_NO { get; set; }
        public virtual string STOCK_PLACE_NO { get; set; }
        public virtual string LAYER_NO { get; set; }
        public virtual string SEQ_NO { get; set; }
        public virtual string CHARGED_STATUS { get; set; }
        public virtual string PLAN_FLAG { get; set; }
        public virtual string BACKUP { get; set; }
    }
}
