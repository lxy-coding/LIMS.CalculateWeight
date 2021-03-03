using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 容器调度计划
    /// </summary>[Serializable]

    public class D_CON_DISPATCH_RESULT
    {
        /// <summary>
        /// 序号，主键; GUID
        /// </summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 制造命令号
        /// </summary>
        public virtual string PONO { get; set; }
        /// <summary>
        /// 炉次号
        /// </summary>
        public virtual string HEAT_NUM { get; set; }
        /// <summary>
        /// 炉批号
        /// </summary>
        public virtual string HEAT_BATCH_NO { get; set; }
        /// <summary>
        /// 计量委托单号
        /// </summary>
        public virtual string REFE_ID { get; set; }
        /// <summary>
        /// 容器编号
        /// </summary>
        public virtual string CON_NUM { get; set; }
        /// <summary>
        /// 容器类型，参照对象类型表ID
        /// </summary>
        public virtual int CON_TYPE { get; set; }
        /// <summary>
        /// 执行状态，1计划，2执行，3结束
        /// </summary>
        public virtual short PLAN_STATUS { get; set; }
        /// <summary>
        /// 起始位置
        /// </summary>
        public virtual short? START_POSIT { get; set; }
        /// <summary>
        /// 起始时间
        /// </summary>
        public virtual DateTime? START_TIME { get; set; }
        /// <summary>
        /// 结束位置
        /// </summary>
        public virtual short? END_POSIT { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public virtual DateTime? END_TIME { get; set; }
        /// <summary>
        /// 数据生成时间
        /// </summary>
        public virtual DateTime? TIME_STAMP { get; set; }
        /// <summary>
        /// 备用字段1
        /// </summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 备用字段2
        /// </summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 备用字段3
        /// </summary>
        public virtual string FIELD3 { get; set; }
    }
}
