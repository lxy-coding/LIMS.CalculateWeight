using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class D_TRO_WORK_PROPERTY {
        /// <summary>
        /// 序号，主键; 自增
        /// </summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 台车编号
        /// </summary>
        public virtual string TRO_NUM { get; set; }
        /// <summary>
        /// 台车名称
        /// </summary>
        public virtual string TRO_NAM { get; set; }
        /// <summary>
        /// 台车类型，1炼钢过跨台车、2脱硫台车、3转炉台车、4精炼台车、5板坯过跨台车
        /// </summary>
        public virtual short TRO_TYPE { get; set; }
        /// <summary>
        /// 跨ID集合
        /// </summary>
        public virtual string SPA_ID_COLLECTION { get; set; }
        /// <summary>
        /// 平均速度，m/min
        /// </summary>
        public virtual short AVE_X_SPEED { get; set; }
        /// <summary>
        /// 速度上限，m/min
        /// </summary>
        public virtual short? UP_X_SPEED { get; set; }
        /// <summary>
        /// 速度下限，m/min
        /// </summary>
        public virtual short? DOWN_X_SPEED { get; set; }
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
