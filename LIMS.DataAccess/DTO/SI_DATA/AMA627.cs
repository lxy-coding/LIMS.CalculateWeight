using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO.SI_DATA
{
    /// <summary>
    /// 废钢入厂实际信息Model
    /// </summary>
    public class AMA627
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
        public  string PROD_SHIFT_NO { get; set; }
        /// <summary>
        /// 生产班组
        /// </summary>
        public  string PROD_SHIFT_GROUP { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        public  string PROD_MAKER { get; set; }
        /// <summary>
        /// 车辆号
        /// </summary>
        public  string VEHICLE_NO { get; set; }
        /// <summary>
        /// 斗号
        /// </summary>
        public  string HOPPER_NO { get; set; }
        /// <summary>
        /// 计量委托单号
        /// </summary>
        public  string REFE_ID { get; set; }
    }
}
