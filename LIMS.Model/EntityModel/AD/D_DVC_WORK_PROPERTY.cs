using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class D_DVC_WORK_PROPERTY {
        /// <summary>
        /// 序号，主键; 自增
        /// </summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 设备编号
        /// </summary>
        public virtual string DVC_NUM { get; set; }
        /// <summary>
        /// 设备名称
        /// </summary>
        public virtual string DVC_NAM { get; set; }
        /// <summary>
        /// 设备类型，参照对象类型表ID
        /// </summary>
        public virtual int DVC_TYPE { get; set; }
        /// <summary>
        /// 所在跨ID
        /// </summary>
        public virtual int SPA_ID { get; set; }
        /// <summary>
        /// 工作标准时长，min
        /// </summary>
        public virtual short AVE_DEAL_DURAT { get; set; }
        /// <summary>
        /// 工作时长上限，min
        /// </summary>
        public virtual short? UP_DEAL_DURAT { get; set; }
        /// <summary>
        /// 工作时长下限，min
        /// </summary>
        public virtual short? DOWN_DEAL_DURAT { get; set; }
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
