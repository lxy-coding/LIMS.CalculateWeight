using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class A6AM07
    {
        /// <summary>
        /// 序号
        /// <summary>
        public virtual long MSG_COUNTER { get; set; }
        /// <summary>
        /// 消息时间
        /// <summary>
        public virtual DateTime? MSG_TIME { get; set; }
        /// <summary>
        /// 读取时间
        /// <summary>
        public virtual DateTime? READ_TIME { get; set; }
        /// <summary>
        /// 消息状态
        /// <summary>
        public virtual string MSG_STATUS { get; set; }
        /// <summary>
        /// 操作类型
        /// <summary>
        public virtual string OP_DIV { get; set; }
        /// <summary>
        /// 高炉号
        /// <summary>
        public virtual string GL_NO { get; set; }
        /// <summary>
        /// 铁次号
        /// <summary>
        public virtual string IRON_NO { get; set; }
        /// <summary>
        /// 铁水罐号
        /// <summary>
        public virtual string IRON_LADLE_NO { get; set; }
        /// <summary>
        /// 铁水包保龄
        /// <summary>
        public virtual string IRON_LADLE_LIFE { get; set; }
        /// <summary>
        /// 车号
        /// <summary>
        public virtual string VEHICLE_NO { get; set; }
        /// <summary>
        /// 毛重
        /// <summary>
        public virtual string GROSS_WT { get; set; }
        /// <summary>
        /// 皮重
        /// <summary>
        public virtual string TARE_WT { get; set; }
        /// <summary>
        /// 净重
        /// <summary>
        public virtual string NET_WT { get; set; }
        /// <summary>
        /// 磅站
        /// <summary>
        public virtual string WEIGH_SITE { get; set; }
        /// <summary>
        /// 重磅过磅时间
        /// <summary>
        public virtual string PONDER_TIME { get; set; }
        /// <summary>
        /// 空磅过磅时间
        /// <summary>
        public virtual string EMPTY_TIME { get; set; }
        /// <summary>
        /// 铁水温度
        /// <summary>
        public virtual string IRON_TEMP { get; set; }
        /// <summary>
        /// 铁水测温时刻
        /// <summary>
        public virtual string IRON_TEMP_TIME { get; set; }
        /// <summary>
        /// 出铁开始时刻
        /// <summary>
        public virtual string TAP_START_TIME { get; set; }
        /// <summary>
        /// 出铁结束时刻
        /// <summary>
        public virtual string TAP_END_TIME { get; set; }
        /// <summary>
        /// 发料时刻
        /// <summary>
        public virtual string ISSUE_TIME { get; set; }
        /// <summary>
        /// 炉批号
        /// <summary>
        public virtual string HEAT_BATCH_NO { get; set; }
    }
}
