using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 铁水来源信息Model
    /// </summary>
    public class CRANE_IRON_INFO
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
        /// GL_NO	高炉炉号
        /// </summary>
        public string GL_NO { get; set; }
        /// <summary>
        /// 脱硫处理号
        /// </summary>
        public string PROC_NO { get; set; }
        /// <summary>
        /// 铁次号
        /// </summary>
        public string IRON_NO { get; set; }
        /// <summary>
        /// 铁水罐号
        /// </summary>
        public string IRON_LADLE_NO { get; set; }
        /// <summary>
        /// 熔炼号
        /// </summary>
        public string HEAT_NO { get; set; }
        /// <summary>
        /// 铁水重量
        /// </summary>
        public float NET_WT { get; set; }
        /// <summary>
        /// 铁水温度
        /// </summary>
        public short IRON_TEMP { get; set; }
        /// <summary>
        /// 分析时间
        /// </summary>
        public DateTime? ANALYSIZE_TIME { get; set; }
        /// <summary>
        /// 铁水成分C
        /// </summary>
        public float CF_C { get; set; }
        /// <summary>
        /// 铁水成分SI
        /// </summary>
        public float CF_SI { get; set; }
        /// <summary>
        /// 铁水成分MN
        /// </summary>
        public float CF_MN { get; set; }
        /// <summary>
        /// 铁水成分P
        /// </summary>
        public float CF_P { get; set; }
        /// <summary>
        /// 铁水成分S
        /// </summary>
        public float CF_S { get; set; }
        /// <summary>
        /// 铁水成分Ti
        /// </summary>
        public float CF_TI { get; set; }
        /// <summary>
        /// 铁水成分As
        /// </summary>
        public float CF_AS { get; set; }
        /// <summary>
        /// 铁水来源
        /// </summary>
        public string MOLTENIRON_SOURCE { get; set; }
        /// <summary>
        /// 铁水加入开始时刻
        /// </summary>
        public DateTime? IRON_LOAD_START_TIME { get; set; }
        /// <summary>
        /// 铁水加入完成时刻
        /// </summary>
        public DateTime? IRON_LOAD_END_TIME { get; set; }
        /// <summary>
        /// 炉批号
        /// </summary>
        public string HEAT_BATCH_NO { get; set; }
        /// <summary>
        /// 设备采集净重
        /// </summary>
        public float SCALE_WGT { get; set; }
    }
}
