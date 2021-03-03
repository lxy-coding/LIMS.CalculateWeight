using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LIMS.DataAccess.DTO.SI_DATA
{
    /// <summary>
    /// 物料异动信息Model
    /// </summary>
    public class Ama624
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
        /// 生产班次号
        /// </summary>
        public string PROD_SHIFT_NO { get; set; }
        /// <summary>
        /// 生产班组号
        /// </summary>
        public string PROD_SHIFT_GROUP { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        public string PROD_MAKER { get; set; }
        /// <summary>
        /// 物料类别
        /// </summary>
        public string MAT_TYPE { get; set; }
        /// <summary>
        /// 物料异动类别
        /// </summary>
        public string MOVE_TYPE { get; set; }
        /// <summary>
        /// 物料号
        /// </summary>
        public string MAT_NO { get; set; }
        /// <summary>
        /// 原位置
        /// </summary>
        public string SOU_POS { get; set; }
        /// <summary>
        /// 目的位置
        /// </summary>
        public string DES_POS { get; set; }
        /// <summary>
        /// 入/出库计划号
        /// </summary>
        public string INOUTPUT_PLAN { get; set; }
        /// <summary>
        /// 库区号
        /// </summary>
        public string STOCK_NO { get; set; }
        /// <summary>
        /// 垛位号
        /// </summary>
        public string STOCK_PLACE_NO { get; set; }
        /// <summary>
        /// 层号
        /// </summary>
        public string LAYER_NO { get; set; }
        /// <summary>
        /// 顺序号
        /// </summary>
        public string SEQ_NO { get; set; }
        /// <summary>
        /// 装车状态
        /// </summary>
        public string CHARGED_STATUS { get; set; }
        /// <summary>
        /// 计划执行状态
        /// </summary>
        public string PLAN_FLAG { get; set; }
        /// <summary>
        /// 备用
        /// </summary>
        public string BACKUP { get; set; }
    }
}
