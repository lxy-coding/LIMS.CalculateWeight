using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO
{
    public class BakingInNewBagsDto
    {
        #region LADLE_REAL_INFO
        /// <summary>
        /// 序号，外键，容器属性表ID
        /// <summary>
        public virtual int CON_ID { get; set; }
        #endregion

        #region CON_PROPERTY
        /// <summary>
        /// 编号;
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 名称;
        /// <summary>
        public virtual string NAME { get; set; }
        #endregion

        #region LADLE_ASSEMBLE_RECORD

        /// <summary>
        /// 砌筑完成时刻
        /// <summary>
        public virtual DateTime ASSEMBLE_TIME { get; set; }

        #endregion

        #region LADLE_REHEAT_REAL

        /// <summary>
        /// 序号，主键;自增
        /// <summary>
        public virtual int ID { get; set; }
        /// </summary>
        /// 烤包器号
        /// </summary>
        public virtual string BURNER_NUM { get; set; }
        /// <summary>
        /// 冷修号
        /// </summary>
        public virtual string COOL_REPAIR_NUM { get; set; }
        /// <summary>
        /// 热修号
        /// </summary>
        public virtual string HOT_REPAIR_NUM { get; set; }
        /// <summary>
        /// 烘烤号，按规则生成
        /// </summary>
        public virtual string REHEAT_NUM { get; set; }
        /// <summary>
        /// 钢包号
        /// </summary>
        public virtual string LADLE_NUM { get; set; }
        /// <summary>
        /// 钢包类型，1方坯用包，2板坯用包
        /// </summary>
        public virtual int LADLE_TYPE { get; set; }
        /// <summary>
        /// 修包类型，对象类型状态表ID
        /// </summary>
        public virtual int MAINTAIN_TYPE { get; set; }
        /// <summary>
        /// 总包龄
        /// </summary>
        public virtual short? TOTAL_LADLE_LIFE { get; set; }
        /// <summary>
        /// 本次包龄
        /// <summary>
        public virtual short? CURRENT_LADLE_LIFE { get; set; }
        /// <summary>
        /// 烘烤状态，对象类型状态表ID
        /// <summary>
        public virtual int REHEAT_STATUS { get; set; }
        /// <summary>
        /// 烘烤标志（开始、暂停、结束），对象类型状态表ID
        /// <summary>
        public virtual int REHEAT_SYMBOL { get; set; }
        /// <summary>
        /// 烘烤开始时刻
        /// <summary>
        public virtual DateTime REHEAT_START_TIME { get; set; }
        /// <summary>
        /// 烘烤总时长
        /// <summary>
        public virtual int? REHEAT_DURATION { get; set; }
        /// <summary>
        /// 小火时长
        /// <summary>
        public virtual int? SOFT_DURATION { get; set; }
        /// <summary>
        /// 中火时长
        /// <summary>
        public virtual int? MEDIUM_DURATION { get; set; }
        /// <summary>
        /// 大火时长
        /// <summary>
        public virtual int? RAG_DURATION { get; set; }
        /// <summary>
        /// 煤气压力
        /// <summary>
        public virtual int GAS_PRESSURE { get; set; }
        /// <summary>
        /// 煤气流量
        /// <summary>
        public virtual int GAS_FLUX { get; set; }
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
        /// 备注
        /// </summary>
        public virtual string REMARK { get; set; }
        #endregion
    }
}
