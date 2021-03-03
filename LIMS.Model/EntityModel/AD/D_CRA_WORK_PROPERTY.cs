using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class D_CRA_WORK_PROPERTY {
        /// <summary>
        /// 序号，主键; 自增
        /// </summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 天车编号
        /// </summary>
        public virtual string CRA_NUM { get; set; }
        /// <summary>
        /// 天车名称
        /// </summary>
        public virtual string CRA_NAM { get; set; }
        /// <summary>
        /// 天车类型，1废钢，2铁水，3钢包
        /// </summary>
        public virtual short CRA_TYPE { get; set; }
        /// <summary>
        /// 所在跨ID
        /// </summary>
        public virtual int SPA_ID { get; set; }
        /// <summary>
        /// 起吊标准时长，min
        /// </summary>
        public virtual short AVE_HOIST_DURAT { get; set; }
        /// <summary>
        /// 起吊时长上限，min
        /// </summary>
        public virtual short? UP_HOIST_DURAT { get; set; }
        /// <summary>
        /// 起吊时长下限，min
        /// </summary>
        public virtual short? DOWN_HOIST_DURAT { get; set; }
        /// <summary>
        /// 放吊标准时长，min
        /// </summary>
        public virtual short AVE_DROP_DURAT { get; set; }
        /// <summary>
        /// 放吊时长上限，min
        /// </summary>
        public virtual short? UP_DROP_DURAT { get; set; }
        /// <summary>
        /// 放吊时长下限，min
        /// </summary>
        public virtual short? DOWN_DROP_DURAT { get; set; }
        /// <summary>
        /// X平均速度，m/min
        /// </summary>
        public virtual short AVE_X_SPEED { get; set; }
        /// <summary>
        /// X速度上限，m/min
        /// </summary>
        public virtual short? UP_X_SPEED { get; set; }
        /// <summary>
        /// X速度下限，m/min
        /// </summary>
        public virtual short? DOWN_X_SPEED { get; set; }
        /// <summary>
        /// X位移上限，m
        /// </summary>
        public virtual short? UP_X_DISPLACEMENT { get; set; }
        /// <summary>
        /// X位移下限，m
        /// </summary>
        public virtual short? DOWN_X_DISPLACEMENT { get; set; }
        /// <summary>
        /// 标准载荷，kg
        /// </summary>
        public virtual int? AVE_LOAD { get; set; }
        /// <summary>
        /// 最大载荷，kg
        /// </summary>
        public virtual int? MAX_LOAD { get; set; }
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
