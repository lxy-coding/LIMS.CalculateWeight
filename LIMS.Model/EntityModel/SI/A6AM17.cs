using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class A6AM17
    {
        public virtual long MSG_COUNTER { get; set; }
        public virtual DateTime MSG_TIME { get; set; }
        public virtual DateTime? READ_TIME { get; set; }
        public virtual string MSG_STATUS { get; set; }
        public virtual string OP_DIV { get; set; }
        public virtual string INPUT_PLAN { get; set; }
        public virtual string MAT_NO { get; set; }
        public virtual string MAT_TYPE { get; set; }
        public virtual string IN_TYPE { get; set; }
        public virtual string SOU_POS { get; set; }
        public virtual string DES_POS { get; set; }
        public virtual string BACKUP { get; set; }
    }
}
