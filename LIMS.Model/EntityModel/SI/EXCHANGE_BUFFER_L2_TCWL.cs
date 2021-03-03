using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class EXCHANGE_BUFFER_L2_TCWL
    {
        /// <summary>
        /// ID
        /// <summary>
        public virtual long MSG_COUNTER { get; set; }
        /// <summary>
        /// 消息插入时间
        /// <summary>
        public virtual DateTime? MSG_TIME { get; set; }
        /// <summary>
        /// 读取时间
        /// <summary>
        public virtual DateTime? READ_TIME { get; set; }
        /// <summary>
        /// 处理标志：0未处理，1已处理
        /// <summary>
        public virtual string MSG_STATUS { get; set; }
        /// <summary>
        /// 表单
        /// <summary>
        public virtual string TABLE_NAME { get; set; }
        /// <summary>
        /// 数据ID
        /// <summary>
        public virtual long? DATA_ID { get; set; }
        /// <summary>
        /// 插入资源
        /// <summary>
        public virtual string INSERT_SOURCE { get; set; }
        /// <summary>
        /// 二级处理标志位：0未处理，1已处理
        /// <summary>
        public virtual string LEVEL2_MSG_STATUS { get; set; }
        /// <summary>
        /// 二级更新数据
        /// <summary>
        public virtual DateTime? LEVEL2_UPDATE_TIME { get; set; }
        /// <summary>
        /// 三级处理标志位：0未处理，1已处理
        /// <summary>
        public virtual string LEVEL3_MSG_STATUS { get; set; }
        /// <summary>
        /// 三级更新数据
        /// <summary>
        public virtual DateTime? LEVEL3_UPDATE_TIME { get; set; }
    }
}
