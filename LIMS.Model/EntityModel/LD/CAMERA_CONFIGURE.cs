using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 相机配置
    /// </summary>
    [Serializable]
    public class CAMERA_CONFIGURE
    {
        /// <summary>
        /// 序号
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 设备IP
        /// <summary>
        public virtual string DEVICEIP { get; set; }
        /// <summary>
        /// 设备端口
        /// <summary>
        public virtual string DEVICEPORT { get; set; }
        /// <summary>
        /// 用户名称
        /// <summary>
        public virtual string USERNAME { get; set; }
        /// <summary>
        /// 用户密码
        /// <summary>
        public virtual string PASSWORD { get; set; }
        /// <summary>
        /// 位置
        /// <summary>
        public virtual string POSITION { get; set; }
        /// <summary>
        /// 备用字段1
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 备用字段2
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 备用字段3
        /// <summary>
        public virtual string FIELD3 { get; set; }
    }
}
