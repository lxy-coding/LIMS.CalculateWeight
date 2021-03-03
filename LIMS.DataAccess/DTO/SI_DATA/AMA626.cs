using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LIMS.DataAccess.DTO.SI_DATA
{
    /// <summary>
    /// 库位同步信息Model
    /// </summary>
    
    public class Ama626 {

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
        /// 库位类别
        /// </summary>
        public  string POS_TYPE { get; set; }
        /// <summary>
        /// 跨号-库区号
        /// </summary>
        public  string POS_YARD { get; set; }
        /// <summary>
        /// 区号
        /// </summary>
        public  string POS_AREA { get; set; }
        /// <summary>
        /// 列号
        /// </summary>
        public  string POS_COLUMN { get; set; }
        /// <summary>
        /// 行号
        /// </summary>
        public  string POS_ROW { get; set; }
        /// <summary>
        /// 层号
        /// </summary>
        public  string POS_LAYER { get; set; }
        /// <summary>
        /// 逻辑位置
        /// </summary>
        public  string POS_NO { get; set; }
        /// <summary>
        /// 库位属性
        /// </summary>
        public  string POS_REMARK { get; set; }
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
