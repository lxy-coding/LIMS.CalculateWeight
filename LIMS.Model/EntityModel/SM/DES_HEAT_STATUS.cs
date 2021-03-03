using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 脱硫炉次状态
    /// </summary>
    [Serializable]
    public class DES_HEAT_STATUS
    {
        /// <summary>
        /// 序号，主键，自增
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 序号，外键，脱硫站属性表ID
        /// <summary>
        public virtual int? DES_ID { get; set; }
        /// <summary>
        /// 计划号
        /// <summary>
        public virtual string PLAN_NUM { get; set; }
        /// <summary>
        /// 炉次号
        /// <summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 处理号
        /// <summary>
        public virtual string DEAL_NUM { get; set; }
        /// <summary>
        /// 参照铁包属性表编号
        /// <summary>
        public virtual string HML_NUM { get; set; }
        /// <summary>
        /// 状态信息表ID
        /// <summary>
        public virtual string HEAT_STATUS { get; set; }
        /// <summary>
        /// 钢种
        /// <summary>
        public virtual string STEEL_GRADE { get; set; }
        /// <summary>
        /// 工艺路径
        /// <summary>
        public virtual string HEAT_ROUTE { get; set; }
        /// <summary>
        /// 1为东侧，2为西侧，3为南侧，4为北侧
        /// <summary>
        public virtual short? SMELT_POSIT { get; set; }
        /// <summary>
        /// 铁水温度，单位：摄氏度
        /// <summary>
        public virtual short? HML_CTEMP { get; set; }
        /// <summary>
        /// 铁水成分
        /// <summary>
        public virtual string HML_COMP { get; set; }
        /// <summary>
        /// 冶炼开始时间
        /// <summary>
        public virtual DateTime? PROCESS_BEGIN { get; set; }
        /// <summary>
        /// 预计剩余时长
        /// <summary>
        public virtual short? REMAIN_DURAT { get; set; }
        /// <summary>
        /// 状态变化时间
        /// <summary>
        public virtual DateTime? TIME_STAMP { get; set; }
        /// <summary>
        /// 预留字段1
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3
        /// <summary>
        public virtual string FIELD3 { get; set; }
    }
}
