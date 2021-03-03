using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO.SI_DATA
{
    /// <summary>
    /// 铁水倒空信息Model
    /// </summary>
    public class AMA630
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
        /// 铁水罐号
        /// <summary>
        public string TPC_NO { get; set; }

        /// <summary>
        /// 铁次号
        /// <summary>
        public string IR_TAP_NO { get; set; }

        /// <summary>
        /// 炉批号
        /// <summary>
        public string ACT_TPC_NO { get; set; }

        /// <summary>
        /// 倒空状态，1倒空，2未倒空
        /// <summary>
        public short EMPTY_STATUS { get; set; }

        /// <summary>
        /// 限定重量，180t，毛重小于等于180认为倒空
        /// <summary>
        public double LIMIT_WEIGHT { get; set; }

        /// <summary>
        /// 毛重
        /// <summary>
        public double GROSS_WT { get; set; }

        /// <summary>
        /// 皮重
        /// <summary>
        public double TARE_WT { get; set; }

        /// <summary>
        /// 净重
        /// <summary>
        public double NET_WT { get; set; }

        /// <summary>
        /// 倒空时刻
        /// <summary>
        public DateTime? EMPTY_TIME { get; set; }

        /// <summary>
        /// 倒空后放到车架时刻
        /// <summary>
        public DateTime? ON_FRAME_TIME { get; set; }
    }
}
