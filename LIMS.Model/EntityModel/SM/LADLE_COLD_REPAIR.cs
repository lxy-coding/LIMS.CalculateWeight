using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 冷修表
    /// </summary>
    [Serializable]
    public class LADLE_COLD_REPAIR
    {
        /// <summary>
        /// 序号;主键，GUID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 钢包号;
        /// <summary>
        public virtual string LADLE_NUM { get; set; }
        /// <summary>
        /// 冷修时间;
        /// <summary>
        public virtual DateTime? COLD_REPAIR_TIME { get; set; }
        /// <summary>
        /// 修包班组;
        /// <summary>
        public virtual string REPAIR_CLASS { get; set; }
        /// <summary>
        /// 耐材厂家;
        /// <summary>
        public virtual string REFRACTORY_MANU { get; set; }
        /// <summary>
        /// 新包上线日期;
        /// <summary>
        public virtual DateTime? NEW_LADLE_ONLINE_TIME { get; set; }
        /// <summary>
        /// 新包修砌日期;
        /// <summary>
        public virtual DateTime? NEW_LADLE_BUILD_TIME { get; set; }
        /// <summary>
        /// 层役;
        /// <summary>
        public virtual string LAYER_LIFE { get; set; }
        /// <summary>
        /// 上线日期;
        /// <summary>
        public virtual DateTime? ONLINE_TIME { get; set; }
        /// <summary>
        /// 下线日期;
        /// <summary>
        public virtual DateTime? DOWNLINE_TIME { get; set; }
        /// <summary>
        /// 甩包班组;
        /// <summary>
        public virtual string DOWNLINE_CLASS { get; set; }
        /// <summary>
        /// 使用寿命;
        /// <summary>
        public virtual int? LADLE_LIFE { get; set; }
        /// <summary>
        /// 累计寿命;
        /// <summary>
        public virtual int? ACCUMULATE_LIFE { get; set; }
        /// <summary>
        /// 新渣线厚度;
        /// <summary>
        public virtual int? NEW_SLAG_BRICK_THICK { get; set; }
        /// <summary>
        /// 上次渣线厚度;
        /// <summary>
        public virtual int? LAST_SLAG_BRICK_THICK { get; set; }
        /// <summary>
        /// 渣线残厚;
        /// <summary>
        public virtual int? SLAG_BRICK_THICKNESS { get; set; }
        /// <summary>
        /// 包壁残厚;
        /// <summary>
        public virtual int? WALL_THICKNESS { get; set; }
        /// <summary>
        /// 包底残厚;
        /// <summary>
        public virtual int? BOTTOM_THICKNESS { get; set; }
        /// <summary>
        /// 透气残厚;
        /// <summary>
        public virtual int? PUROUS_THICKNESS { get; set; }
        /// <summary>
        /// 是否结账;
        /// <summary>
        public virtual short? IS_ACCOUNT { get; set; }
        /// <summary>
        /// 钢包类型;
        /// <summary>
        public virtual int? LADLE_MATERIAL_TYPE { get; set; }
        /// <summary>
        /// 拆包备注;
        /// <summary>
        public virtual string UNPACK_REMARK { get; set; }
        /// <summary>
        /// 修砌备注;
        /// <summary>
        public virtual string REPAIR_REMARK { get; set; }
        /// <summary>
        /// 甩包原因;
        /// <summary>
        public virtual string DOWNLINE_REASON { get; set; }
        /// <summary>
        /// 预留字段1;
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2;
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3;
        /// <summary>
        public virtual string FIELD3 { get; set; }
        /// <summary>
        /// 容器ID
        /// <summary>
        public virtual int CONID { get; set; }
        /// <summary>
        /// 上线位置
        /// <summary>
        public virtual string ONLINE_POSIT { get; set; }
        /// <summary>
        /// 是否上线0未上线；1已上线
        /// <summary>
        public virtual short? IS_ONLINE { get; set; }
        /// <summary>
        /// 记录生成时间
        /// <summary>
        public virtual DateTime? TIME_TAMP { get; set; }
    }
}
