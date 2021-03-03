using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LIMS.DataAccess.DTO.SI_DATA
{
    /// <summary>
    /// 请求库图同步信息Model
    /// </summary>

    public class A6AM18
    {
        /// <summary>
        /// 序号
        /// <summary>
        public long MSG_COUNTER { get; set; }
        public DateTime? MSG_TIME { get; set; }

        public DateTime? READ_TIME { get; set; }

        public string MSG_STATUS { get; set; }

        /// <summary>
        /// 操作类型，I:Insert;U:Update;D:Delete 
        /// <summary>
        public string OP_DIV { get; set; }
        /// <summary>
        /// 请求物料类型
        /// </summary>
        public  string REQ_MAT_TYPE { get; set; }
        /// <summary>
        /// 请求同步类别
        /// </summary>
        public  string REQ_TYPE { get; set; }
        /// <summary>
        /// 请求位置
        /// </summary>
        public  string REQ_POS { get; set; }
        /// <summary>
        /// 备用
        /// </summary>
        public  string BACKUP { get; set; }
    }
}
