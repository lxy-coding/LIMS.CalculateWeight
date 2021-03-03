using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class AMA626 {
        public virtual long MSG_COUNTER { get; set; }
        public virtual DateTime? MSG_TIME { get; set; }
        public virtual DateTime? READ_TIME { get; set; }
        public virtual string MSG_STATUS { get; set; }
        public virtual string OP_DIV { get; set; }
        public virtual string POS_TYPE { get; set; }
        public virtual string POS_YARD { get; set; }
        public virtual string POS_AREA { get; set; }
        public virtual string POS_COLUMN { get; set; }
        public virtual string POS_ROW { get; set; }
        public virtual string POS_LAYER { get; set; }
        public virtual string POS_NO { get; set; }
        public virtual string POS_REMARK { get; set; }
        public virtual string STOCK_NO { get; set; }
        public virtual string STOCK_PLACE_NO { get; set; }
        public virtual string LAYER_NO { get; set; }
        public virtual string BACKUP { get; set; }
    }
}
