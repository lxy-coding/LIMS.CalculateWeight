using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO.SI_DATA
{
    /// <summary>
    /// 库图同步信息Model
    /// </summary>
    public class Ama625  {

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
        /// 物料类别
        /// </summary>
        public  string MAT_TYPE { get; set; }
        /// <summary>
        /// 同步类别
        /// </summary>
        public  string OP_TYPE { get; set; }
        /// <summary>
        /// 物料号
        /// </summary>
        public  string MAT_NO { get; set; }
        /// <summary>
        /// 物料位置
        /// </summary>
        public  string MAT_POS { get; set; }
        /// <summary>
        /// 库区号
        /// </summary>
        public  string STOCK_NO { get; set; }
        /// <summary>
        /// 垛位号
        /// </summary>
        public  string STOCK_PLACE_NO { get; set; }
        /// <summary>
        /// 层号
        /// </summary>
        public  string LAYER_NO { get; set; }
        /// <summary>
        /// 备用
        /// </summary>
        public  string BACKUP { get; set; }
    }
}
