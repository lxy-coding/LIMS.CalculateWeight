using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class LADLE_COVER_PROPERTY {
        /// <summary>
        /// 序号，主键; 自增
        /// </summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 包盖号
        /// </summary>
        public virtual string COVER_NUM { get; set; }
        /// <summary>
        /// 包盖名称
        /// </summary>
        public virtual string COVER_NAM { get; set; }
        /// <summary>
        /// 皮重，kg
        /// </summary>
        public virtual int? TARE_WEIGHT { get; set; }
        /// <summary>
        /// 是否启用;0未启用，1启用
        /// </summary>
        public virtual short? IS_ENABLE { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public virtual string REMARK { get; set; }
        /// <summary>
        /// 记录生成时间
        /// </summary>
        public virtual DateTime TIME_STAMP { get; set; }
        /// <summary>
        /// 预留字段1;
        /// </summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2;
        /// </summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3;
        /// </summary>
        public virtual string FIELD3 { get; set; }
    }
}
