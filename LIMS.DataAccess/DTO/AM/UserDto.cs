using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO
{
    /// <summary>
    /// 用户Dto
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        public string Names { get; set; }
    }
}
