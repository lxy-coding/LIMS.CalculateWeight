using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO
{
    /// <summary>
    /// 资源信息Dto
    /// </summary>
    public class ResourceInfoDto
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 名称;0;
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// 显示顺序;
        /// <summary>
        public virtual short? DISP_INDEX { get; set; }
        /// <summary>
        /// 父资源ID;
        /// <summary>
        public virtual int PAR_RESOURCE_ID { get; set; }
        /// <summary>
        /// 是否启用;
        /// <summary>
        public virtual short? ENABLE_FLAG { get; set; }
        /// <summary>
        /// 地址;
        /// <summary>
        public virtual string URL { get; set; }

        /// <summary>
        /// 图标;
        /// <summary>
        public virtual string ICON { get; set; }
    }
}
