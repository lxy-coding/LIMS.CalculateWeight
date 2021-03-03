using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class SLAG_LADLE_WORK_RECORD {
        /// <summary>
        /// 序号，主键; GUID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 渣罐号
        /// <summary>
        public virtual string SLAG_LADLE_NUM { get; set; }
        /// <summary>
        /// 进出标志，1进，2出
        /// <summary>
        public virtual short ENTER_SYMBOL { get; set; }
        /// <summary>
        /// 进出位置，工位编号
        /// <summary>
        public virtual string POSIT { get; set; }
        /// <summary>
        /// 天车编号
        /// <summary>
        public virtual string CRANE_NUM { get; set; }
        /// <summary>
        /// 渣罐毛重，kg
        /// <summary>
        public virtual int? WEIGHT { get; set; }
        /// <summary>
        /// 备注
        /// <summary>
        public virtual string REMARK { get; set; }
        /// <summary>
        /// 记录生成时间
        /// <summary>
        public virtual DateTime TIME_STAMP { get; set; }
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
    }
}
