using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 用户与相机关系
    /// </summary>
    [Serializable]
    public class REL_USER_CAMERA
    {
        /// <summary>
        /// ID
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 用户ID
        /// <summary>
        public virtual int? USERID { get; set; }
        /// <summary>
        /// 工位1;工位2;工位3。最多填入三个相机
        /// <summary>
        public virtual string CAMERA_WST { get; set; }
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
