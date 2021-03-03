using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    /// <summary>
    /// 废钢运转
    /// </summary>    [Serializable]
    public class SLOT_MANAGEMENT_INFO
    {
        /// <summary>
        /// 主键;GUID
        /// <summary>
        public virtual string ID { get; set; }
        /// <summary>
        /// 废钢斗号
        /// <summary>
        public virtual string SLOT_NUM { get; set; }
        /// <summary>
        /// 入库卡车号
        /// <summary>
        public virtual string ENTER_CAR_NUM { get; set; }
        /// <summary>
        /// 计量委托单号
        /// <summary>
        public virtual string REFE_ID { get; set; }
        /// <summary>
        /// 皮重
        /// <summary>
        public virtual int? GRASS_WT { get; set; }
        /// <summary>
        /// 毛重
        /// <summary>
        public virtual int? TARE_WT { get; set; }
        /// <summary>
        /// 净重
        /// <summary>
        public virtual int? NET_WT { get; set; }
        /// <summary>
        /// 废钢配比
        /// <summary>
        public virtual string SCRAP_MAT { get; set; }
        /// <summary>
        /// 来源单位名称
        /// <summary>
        public virtual string SRC_DEPT_NAME { get; set; }
        /// <summary>
        /// 来源库号名称
        /// <summary>
        public virtual string SRC_STOCK_NAME { get; set; }
        /// <summary>
        /// 去向库号名称
        /// <summary>
        public virtual string DEST_DEPT_NAME { get; set; }
        /// <summary>
        /// 条码号
        /// <summary>
        public virtual string BAR_CODE { get; set; }
        /// <summary>
        /// 入库天车号
        /// <summary>
        public virtual string ENTER_CRANE_NUM { get; set; }
        /// <summary>
        /// 入库时间
        /// <summary>
        public virtual DateTime? ENTER_TIME { get; set; }
        /// <summary>
        /// 是否落地:0否，1是
        /// <summary>
        public virtual short? IS_PUT { get; set; }
        /// <summary>
        /// 入库跨
        /// <summary>
        public virtual string ENTER_SPA { get; set; }
        /// <summary>
        /// 入库班组
        /// <summary>
        public virtual string ENTER_TEAM { get; set; }
        /// <summary>
        /// 入库班别
        /// <summary>
        public virtual string ENTER_SHIFT { get; set; }
        /// <summary>
        /// 入库操作员
        /// <summary>
        public virtual string ENTER_USER { get; set; }
        /// <summary>
        /// 出库天车号
        /// <summary>
        public virtual string ADD_CRANE_NUM { get; set; }
        /// <summary>
        /// 转炉号
        /// <summary>
        public virtual string DEV_CODE { get; set; }
        /// <summary>
        /// 炉次号
        /// <summary>
        public virtual string HEAT_NO { get; set; }
        /// <summary>
        /// 挂斗时间
        /// <summary>
        public virtual DateTime? ADD_CRANE_UP_TIME { get; set; }
        /// <summary>
        /// 入炉前重量
        /// <summary>
        public virtual int? ADD_BEFORE_WT { get; set; }
        /// <summary>
        /// 入炉后重量
        /// <summary>
        public virtual int? ADD_AFTER_WT { get; set; }
        /// <summary>
        /// 入炉净重
        /// <summary>
        public virtual int? ADD_NET_WT { get; set; }
        /// <summary>
        /// 出库班组
        /// <summary>
        public virtual string ADD_TEAM { get; set; }
        /// <summary>
        /// 出库班别
        /// <summary>
        public virtual string ADD_SHIFT { get; set; }
        /// <summary>
        /// 出库操作员
        /// <summary>
        public virtual string ADD_USER { get; set; }
        /// <summary>
        /// 出厂卡车
        /// <summary>
        public virtual string OUT_CAR_NUM { get; set; }
        /// <summary>
        /// 出厂天车
        /// <summary>
        public virtual string OUT_CRANE_NUM { get; set; }
        /// <summary>
        /// 出厂时间
        /// <summary>
        public virtual DateTime? OUT_TIME { get; set; }
        /// <summary>
        /// 出厂班组
        /// <summary>
        public virtual string OUT_TEAM { get; set; }
        /// <summary>
        /// 出库班别
        /// <summary>
        public virtual string OUT_SHIFT { get; set; }
        /// <summary>
        /// 出库操作员
        /// <summary>
        public virtual string OUT_USER { get; set; }
        /// <summary>
        /// 倒跨次数
        /// <summary>
        public virtual string POUR_SPA_COUNT { get; set; }
        /// <summary>
        /// 倒跨路径1
        /// <summary>
        public virtual string POUR_SPA_POSIT1 { get; set; }
        /// <summary>
        /// 倒跨时间1
        /// <summary>
        public virtual DateTime? POUR_SPA_TIME1 { get; set; }
        /// <summary>
        /// 倒跨班组1
        /// <summary>
        public virtual string POUR_TEAM1 { get; set; }
        /// <summary>
        /// 倒跨班别1
        /// <summary>
        public virtual string POUR_SHIFT1 { get; set; }
        /// <summary>
        /// 倒跨操作员1
        /// <summary>
        public virtual string POUR_USER1 { get; set; }
        /// <summary>
        /// 倒跨路径2
        /// <summary>
        public virtual string POUR_SPA_POSIT2 { get; set; }
        /// <summary>
        /// 倒跨时间2
        /// <summary>
        public virtual DateTime? POUR_SPA_TIME2 { get; set; }
        /// <summary>
        /// 倒跨班组2
        /// <summary>
        public virtual string POUR_TEAM2 { get; set; }
        /// <summary>
        /// 倒跨班别2
        /// <summary>
        public virtual string POUR_SHIFT2 { get; set; }
        /// <summary>
        /// 倒跨操作员2
        /// <summary>
        public virtual string POUR_USER2 { get; set; }
        /// <summary>
        /// 倒跨路径3
        /// <summary>
        public virtual string POUR_SPA_POSIT3 { get; set; }
        /// <summary>
        /// 倒跨时间3
        /// <summary>
        public virtual DateTime? POUR_SPA_TIME3 { get; set; }
        /// <summary>
        /// 倒跨班组3
        /// <summary>
        public virtual string POUR_TEAM3 { get; set; }
        /// <summary>
        /// 倒跨班别3
        /// <summary>
        public virtual string POUR_SHIFT3 { get; set; }
        /// <summary>
        /// 倒跨操作员3
        /// <summary>
        public virtual string POUR_USER3 { get; set; }
        /// <summary>
        /// 自动入库;是否自动入库，0否，1是
        /// <summary>
        public virtual short? IS_AUTO_IN { get; set; }
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
        /// 状态：1、已入厂；2、已出库；3、已出厂
        /// <summary>
        public virtual short? IS_STATE { get; set; }
    }
}
