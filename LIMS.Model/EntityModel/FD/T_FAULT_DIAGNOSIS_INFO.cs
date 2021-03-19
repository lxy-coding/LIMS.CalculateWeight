using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]
    public class T_FAULT_DIAGNOSIS_INFO
    {
        public virtual string ID { get; set; }
        public virtual string FAULT_CODE { get; set; }
        public virtual string FAULT_DESCRIBE { get; set; }
        public virtual DateTime? FAULT_START_TIME { get; set; }
        public virtual DateTime? FAULT_END_TIME { get; set; }
        public virtual short? FAULT_FLAG { get; set; }
        public virtual string CREATE_TIME { get; set; }
        public virtual string PROCESS_NAME { get; set; }
        public virtual DateTime? PROCESS_TIME { get; set; }
    }
}
