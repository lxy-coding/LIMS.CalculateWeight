using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO
{
    /// <summary>
    /// 用户信息Dto
    /// 段勇明 Add 2020-05-19
    /// </summary>
    public class UserInfoDto
    {
        /// <summary>
        /// ID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 用户账号
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 用户名字
        /// <summary>
        public virtual string USER_NAM { get; set; }
        /// <summary>
        /// 用户状态
        /// <summary>
        public virtual string USER_ENABLE { get; set; }

        /// <summary>
        /// 是否在职
        /// </summary>
        public virtual string IN_JOB { get; set; }
        /// <summary>
        /// 班组名称
        /// <summary>
        public virtual string CLASS_NAME { get; set; }
        /// <summary>
        /// 班组负责人
        /// <summary>
        public virtual string TEAM_LEADER { get; set; }
        /// <summary>
        /// 班组类型
        /// <summary>
        public virtual string TEAM_TYPE { get; set; }
        /// <summary>
        /// 角色名称
        /// <summary>
        public virtual string ROLE_NAM { get; set; }
        /// <summary>
        /// 角色状态
        /// <summary>
        public virtual string ROLE_ENABLE { get; set; }
    }
}
