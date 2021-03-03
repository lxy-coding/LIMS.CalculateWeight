using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 用户权限视图
    /// </summary>
    [Serializable]
    public class V_SELECTAUTHORITY
    {
        /// <summary>
        /// 资源ID
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 资源名称
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// 用户编号
        /// <summary>
        public virtual string USER_NUM { get; set; }
        /// <summary>
        /// 父资源ID
        /// <summary>
        public virtual string PAR_RESOURCE_ID { get; set; }

    }
}
