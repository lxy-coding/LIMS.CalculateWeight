using System.Collections.Generic;
using System.Text;
using System;

namespace LIMS.DataAccess.DTO
{

    [Serializable]

    public class BilletCoolingBedModel
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
        /// 连铸机编号
        /// <summary>
        public virtual string PLANT_NO { get; set; }
        /// <summary>
        /// 冷床位置
        /// <summary>
        public virtual string POSIT { get; set; }
        /// <summary>
        /// 外侧第1支钢坯号
        /// <summary>
        public virtual string EXTERNAL1_BILLET_NO { get; set; }
        /// <summary>
        /// 外侧第1支炉次号
        /// <summary>
        public virtual string EXTERNAL1_HEAT_NO { get; set; }
        /// <summary>
        /// 外侧第1支流号
        /// <summary>
        public virtual short? EXTERNAL1_STRAND_NO { get; set; }
        /// <summary>
        /// 外侧第2支钢坯号
        /// <summary>
        public virtual string EXTERNAL2_BILLET_NO { get; set; }
        /// <summary>
        /// 外侧第2支炉次号
        /// <summary>
        public virtual string EXTERNAL2_HEAT_NO { get; set; }
        /// <summary>
        /// 外侧第2支流号
        /// <summary>
        public virtual short? EXTERNAL2_STRAND_NO { get; set; }
        /// <summary>
        /// 外侧第3支钢坯号
        /// <summary>
        public virtual string EXTERNAL3_BILLET_NO { get; set; }
        /// <summary>
        /// 外侧第3支炉次号
        /// <summary>
        public virtual string EXTERNAL3_HEAT_NO { get; set; }
        /// <summary>
        /// 外侧第3支流号
        /// <summary>
        public virtual short? EXTERNAL3_STRAND_NO { get; set; }
        /// <summary>
        /// 外侧第4支钢坯号
        /// <summary>
        public virtual string EXTERNAL4_BILLET_NO { get; set; }
        /// <summary>
        /// 外侧第4支炉次号
        /// <summary>
        public virtual string EXTERNAL4_HEAT_NO { get; set; }
        /// <summary>
        /// 外侧第4支流号
        /// <summary>
        public virtual short? EXTERNAL4_STRAND_NO { get; set; }
        /// <summary>
        /// 外侧第5支钢坯号
        /// <summary>
        public virtual string EXTERNAL5_BILLET_NO { get; set; }
        /// <summary>
        /// 外侧第5支炉次号
        /// <summary>
        public virtual string EXTERNAL5_HEAT_NO { get; set; }
        /// <summary>
        /// 外侧第5支流号
        /// <summary>
        public virtual short? EXTERNAL5_STRAND_NO { get; set; }
        /// <summary>
        /// 外侧第6支钢坯号
        /// <summary>
        public virtual string EXTERNAL6_BILLET_NO { get; set; }
        /// <summary>
        /// 外侧第6支炉次号
        /// <summary>
        public virtual string EXTERNAL6_HEAT_NO { get; set; }
        /// <summary>
        /// 外侧第6支流号
        /// <summary>
        public virtual short? EXTERNAL6_STRAND_NO { get; set; }
        /// <summary>
        /// 外侧第7支钢坯号
        /// <summary>
        public virtual string EXTERNAL7_BILLET_NO { get; set; }
        /// <summary>
        /// 外侧第7支炉次号
        /// <summary>
        public virtual string EXTERNAL7_HEAT_NO { get; set; }
        /// <summary>
        /// 外侧第7支流号
        /// <summary>
        public virtual short? EXTERNAL7_STRAND_NO { get; set; }
        /// <summary>
        /// 数据产生时间
        /// <summary>
        public virtual DateTime? TIME_STAMP { get; set; }
    }
}
