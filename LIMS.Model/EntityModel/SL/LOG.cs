using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    /// <summary>
    /// 系统日志
    /// </summary>
    [Serializable]

    public class LOG
    {
        public virtual string GUID { get; set; }
        public virtual short? LOG_TYPE { get; set; }
        public virtual string LOG_CONTENT { get; set; }
        public virtual DateTime? CREATE_TIME { get; set; }
    }
}
