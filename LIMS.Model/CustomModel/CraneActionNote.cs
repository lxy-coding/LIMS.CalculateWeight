using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Model.CustomModel
{
    /// <summary>
    /// 原先版本定义类（新定数据库后为T_CRANE_LOG）
    /// </summary>
    public class CraneActionNote
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 天车号
        /// </summary>
        public int HCR_ID { get; set; }

        /// <summary>
        /// 跨ID
        /// </summary>
        public int HC_ID { get; set; }

        /// <summary>
        /// X坐标
        /// </summary>
        public int S_X { get; set; }

        /// <summary>
        /// Y坐标
        /// </summary>
        public int S_Y { get; set; }

        /// <summary>
        /// Z坐标
        /// </summary>
        public int S_Z { get; set; }

        /// <summary>
        /// 动作类型，1起吊3放吊
        /// </summary>
        public int ACT_TYPE { get; set; }

        /// <summary>
        /// 动作发生时间
        /// </summary>
        public DateTime ACT_TIME { get; set; }

        /// <summary>
        /// PLC缓存序号
        /// </summary>
        public int PLC_ACHCE { get; set; }

        /// <summary>
        /// 起吊重量
        /// </summary>
        public int GOODS_WEIGHT { get; set; }

        /// <summary>
        /// 吊物数量
        /// </summary>
        public int GOODS_NUM { get; set; }

        /// <summary>
        /// 处理标志位 0未处理1已处理2处理失败
        /// </summary>
        public int DEAL_FLAG { get; set; }

        /// <summary>
        /// Z轴旋转值
        /// </summary>
        public int Z_ROTATE { get; set; }
    }
}
