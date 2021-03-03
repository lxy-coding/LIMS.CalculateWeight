using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class RESOURCE_INFO {
        public RESOURCE_INFO() { }
        /// <summary>
        /// 序号;1;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 编码;0;
        /// <summary>
        public virtual string NUM { get; set; }
        /// <summary>
        /// 名称;0;
        /// <summary>
        public virtual string NAME { get; set; }
        /// <summary>
        /// 选中状态;
        /// <summary>
        public virtual string SELECTED { get; set; }
        /// <summary>
        /// 父资源编号;
        /// <summary>
        public virtual string PAR_RESOURCE_NUM { get; set; }
        /// <summary>
        /// 显示顺序;
        /// <summary>
        public virtual short? DISP_INDEX { get; set; }
        /// <summary>
        /// 父资源ID;
        /// <summary>
        public virtual RESOURCE_INFO PAR_RESOURCE_ID { get; set; }
        /// <summary>
        /// 地址;
        /// <summary>
        public virtual string URL { get; set; }
        /// <summary>
        /// 层级;
        /// <summary>
        public virtual short? LEVELS { get; set; }
        /// <summary>
        /// 图标;
        /// <summary>
        public virtual string ICON { get; set; }
        /// <summary>
        /// 是否启用;
        /// <summary>
        public virtual short? ENABLE_FLAG { get; set; }
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
        /// 传入参数;
        /// <summary>
        public virtual string AFFERENTPARAMETER { get; set; }
        /// <summary>
        /// 资源类型；（1 pc；2 web)
        /// <summary>
        public virtual short? RESOURCE_TYPE { get; set; }
    }
}
