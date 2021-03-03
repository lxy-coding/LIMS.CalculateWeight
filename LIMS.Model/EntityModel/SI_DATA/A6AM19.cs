using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class A6AM19
    {
        /// <summary>
        /// 序号
        /// <summary>
        public virtual long MSG_COUNTER { get; set; }
        /// <summary>
        /// 消息时间
        /// <summary>
        public virtual DateTime? MSG_TIME { get; set; }
        /// <summary>
        /// 读取时间
        /// <summary>
        public virtual DateTime? READ_TIME { get; set; }
        /// <summary>
        /// 消息状态
        /// <summary>
        public virtual string MSG_STATUS { get; set; }
        /// <summary>
        /// 操作类型
        /// <summary>
        public virtual string OP_DIV { get; set; }
        /// <summary>
        /// 生产班次号
        /// <summary>
        public virtual string PROD_SHIFT_NO { get; set; }
        /// <summary>
        /// 生产班组
        /// <summary>
        public virtual string PROD_SHIFT_GROUP { get; set; }
        /// <summary>
        /// 工号
        /// <summary>
        public virtual string PROD_MAKER { get; set; }
        /// <summary>
        /// 车辆号
        /// <summary>
        public virtual string VEHICLE_NO { get; set; }
        /// <summary>
        /// 斗号
        /// <summary>
        public virtual string HOPPER_NO { get; set; }
        /// <summary>
        /// 计量委托单号
        /// <summary>
        public virtual string REFE_ID { get; set; }
        /// <summary>
        /// 净重
        /// <summary>
        public virtual string NET_WEIGHT { get; set; }
        /// <summary>
        /// 皮重
        /// <summary>
        public virtual string TARE { get; set; }
        /// <summary>
        /// 毛重
        /// <summary>
        public virtual string GROSS_WEIGHT { get; set; }
        /// <summary>
        /// 委托状态
        /// <summary>
        public virtual string REFE_STATUS { get; set; }
        /// <summary>
        /// 品名编码
        /// <summary>
        public virtual string PROD_ID { get; set; }
        /// <summary>
        /// 品名名称
        /// <summary>
        public virtual string PROD_CNAME { get; set; }
        /// <summary>
        /// 来源单位编码
        /// <summary>
        public virtual string SRC_DEPT_ID { get; set; }
        /// <summary>
        /// 来源单位名称
        /// <summary>
        public virtual string SRC_DEPT_NAME { get; set; }
        /// <summary>
        /// 来源库号编码
        /// <summary>
        public virtual string SRC_STOCK_ID { get; set; }
        /// <summary>
        /// 来源库号名称
        /// <summary>
        public virtual string SRC_STOCK_NAME { get; set; }
        /// <summary>
        /// 去向单位编码
        /// <summary>
        public virtual string DEST_DEPT_ID { get; set; }
        /// <summary>
        /// 去向单位名称
        /// <summary>
        public virtual string DEST_DEPT_NAME { get; set; }
        /// <summary>
        /// 去向库号编码
        /// <summary>
        public virtual string DEST_STOCK_ID { get; set; }
        /// <summary>
        /// 去向库号名称
        /// <summary>
        public virtual string DEST_STOCK_NAME { get; set; }
        /// <summary>
        /// 业务类型
        /// <summary>
        public virtual string BUSINESS_TYPE { get; set; }
        /// <summary>
        /// 委托类型
        /// <summary>
        public virtual string REFE_TYPE { get; set; }
        /// <summary>
        /// 委托创建时间
        /// <summary>
        public virtual string REFE_DATE { get; set; }
        /// <summary>
        /// 委托创建人姓名
        /// <summary>
        public virtual string REFE_CREATOR { get; set; }
        /// <summary>
        /// 条码号
        /// <summary>
        public virtual string BAR_CODE { get; set; }
        /// <summary>
        /// 普通生铁重量
        /// <summary>
        public virtual string MATWET1 { get; set; }
        /// <summary>
        /// 低镍生铁重量
        /// <summary>
        public virtual string MATWET2 { get; set; }
        /// <summary>
        /// 渣钢重量
        /// <summary>
        public virtual string MATWET3 { get; set; }
        /// <summary>
        /// 统料重量
        /// <summary>
        public virtual string MATWET4 { get; set; }
        /// <summary>
        /// 一类废钢重量
        /// <summary>
        public virtual string MATWET5 { get; set; }
        /// <summary>
        /// 二类废钢重量
        /// <summary>
        public virtual string MATWET6 { get; set; }
        /// <summary>
        /// 称重时间
        /// <summary>
        public virtual string GROSS_WEIGHT_TIME { get; set; }
    }
}
