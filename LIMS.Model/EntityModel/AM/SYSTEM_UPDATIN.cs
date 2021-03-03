using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 系统更新
    /// </summary>
    [Serializable]
    public class SYSTEM_UPDATIN
    {
        /// <summary>
        /// GUID;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 版本号;
        /// <summary>
        public virtual string VERSION_NUM { get; set; }
        /// <summary>
        /// 内容;
        /// <summary>
        public virtual string VERSION_CONTENT { get; set; }
        /// <summary>
        /// 区域更新DLL
        /// <summary>
        public virtual string AREA_UPDATIN_DLL { get; set; }
        /// <summary>
        /// 文件地址;
        /// <summary>
        public virtual string FILE_ADDRESS { get; set; }
        /// <summary>
        /// 服务器IP
        /// <summary>
        public virtual string SERVICE_IP { get; set; }
        /// <summary>
        /// 读取标识(1：全部更新；2：区域更新);
        /// <summary>
        public virtual short? IS_READ { get; set; }
        /// <summary>
        /// 创建时间;
        /// <summary>
        public virtual DateTime? CREATE_TIME { get; set; }
        /// <summary>
        /// 预留字段1;
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2;
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3;
        /// <summary>
        public virtual string FIELD3 { get; set; }
    }
}
