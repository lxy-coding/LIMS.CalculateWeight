using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{
    /// <summary>
    /// 语音提示
    /// </summary>
    [Serializable]
    public class DEVICE_VOICE_HINT
    {
        /// <summary>
        /// 序号;
        /// <summary>
        public virtual int ID { get; set; }
        /// <summary>
        /// 天车ID;
        /// <summary>
        public virtual int? CRA_ID { get; set; }
        /// <summary>
        /// 语音类型;
        /// <summary>
        public virtual short? VOICE_TYPE { get; set; }
        /// <summary>
        /// 语音内容;
        /// <summary>
        public virtual string VOICE_CONTENT { get; set; }
        /// <summary>
        /// 播放次数;
        /// <summary>
        public virtual short? PLAY_COUNT { get; set; }
        /// <summary>
        /// 优先级;
        /// <summary>
        public virtual short? PRIORITY { get; set; }
        /// <summary>
        /// 是否播放;
        /// <summary>
        public virtual short? IS_PLAY { get; set; }
        /// <summary>
        /// 数值范围;
        /// <summary>
        public virtual string VALUE_RANGE { get; set; }
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
