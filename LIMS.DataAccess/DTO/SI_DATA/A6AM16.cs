using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LIMS.DataAccess.DTO.SI_DATA
{
    /// <summary>
    /// 钢坯出库信息Model
    /// </summary>
    
    public class A6AM16
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
        /// 出库计划号
        /// </summary>
        public  string OUTPUT_PLAN { get; set; }
        /// <summary>
        /// 物料号
        /// </summary>
        public  string MAT_NO { get; set; }
        /// <summary>
        /// 物料类别
        /// </summary>
        public  string MAT_TYPE { get; set; }
        /// <summary>
        /// 出库方式
        /// </summary>
        public  string OUT_TYPE { get; set; }
        /// <summary>
        /// 原位置
        /// </summary>
        public  string SOU_POS { get; set; }
        /// <summary>
        /// 目的位置
        /// </summary>
        public  string DES_POS { get; set; }
        /// <summary>
        /// 库区号
        /// </summary>
        public  string STOCK_NO { get; set; }
        /// <summary>
        /// 垛位号
        /// </summary>
        public  string STOCK_PLACE_NO { get; set; }
        /// <summary>
        /// 备用
        /// </summary>
        public  string BACKUP { get; set; }
    }
}
