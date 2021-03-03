using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel
{

    [Serializable]

    public class AMA620
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
        /// 连铸处理号
        /// <summary>
        public virtual string PROC_NO { get; set; }
        /// <summary>
        /// 设备号
        /// <summary>
        public virtual string DEV_CODE { get; set; }
        /// <summary>
        /// 炼钢计划号
        /// <summary>
        public virtual string SM_PLAN_NO { get; set; }
        /// <summary>
        /// 制造命令号
        /// <summary>
        public virtual string PONO { get; set; }
        /// <summary>
        /// 内部钢种
        /// <summary>
        public virtual string PREC_ST_NO { get; set; }
        /// <summary>
        /// 浇铸批号
        /// <summary>
        public virtual string CAST_LOT_NO { get; set; }
        /// <summary>
        /// cast_lot分割号
        /// <summary>
        public virtual string CAST_DIV_NO { get; set; }
        /// <summary>
        /// 炉号（熔炼号）
        /// <summary>
        public virtual string HEAT_NO { get; set; }
        /// <summary>
        /// 流号
        /// <summary>
        public virtual string STRAND_NO { get; set; }
        /// <summary>
        /// 流水号（铸坯切断次序号）
        /// <summary>
        public virtual string MAT_CUT_SEQ { get; set; }
        /// <summary>
        /// 材料号
        /// <summary>
        public virtual string MAT_NO { get; set; }
        /// <summary>
        /// 钢坯实物记号 
        /// <summary>
        public virtual string CUST_MAT_NO { get; set; }
        /// <summary>
        /// 计划钢坯号
        /// <summary>
        public virtual string PRE_MAT_NO { get; set; }
        /// <summary>
        /// 合同号
        /// <summary>
        public virtual string ORDER_NO { get; set; }
        /// <summary>
        /// 切断内部钢种
        /// <summary>
        public virtual string CUT_ST_NO { get; set; }
        /// <summary>
        /// 钢坯厚度
        /// <summary>
        public virtual string MAT_THICK { get; set; }
        /// <summary>
        /// 钢坯宽度
        /// <summary>
        public virtual string MAT_WIDTH { get; set; }
        /// <summary>
        /// 钢坯长度
        /// <summary>
        public virtual string MAT_LEN { get; set; }
        /// <summary>
        /// 钢坯重量
        /// <summary>
        public virtual string MAT_WT { get; set; }
        /// <summary>
        /// 计重方式
        /// <summary>
        public virtual string WT_MODE { get; set; }
        /// <summary>
        /// 钢坯计划去向
        /// <summary>
        public virtual string MAT_PLAN_DEST { get; set; }
        /// <summary>
        /// 调宽标记
        /// <summary>
        public virtual string ADJUST_WIDTH_MARK { get; set; }
        /// <summary>
        /// 板坯头部宽度
        /// <summary>
        public virtual string MAT_HEAD_WIDTH { get; set; }
        /// <summary>
        /// 板坯尾部宽度
        /// <summary>
        public virtual string MAT_TAIL_WIDTH { get; set; }
        /// <summary>
        /// 板坯宽度变化开始点
        /// <summary>
        public virtual string MAT_TAPPER_WIDTH_START { get; set; }
        /// <summary>
        /// 板坯宽度变化长度
        /// <summary>
        public virtual string MAT_TAPPER_WIDTH_LEN { get; set; }
        /// <summary>
        /// 板坯类型
        /// <summary>
        public virtual string MAT_TYPE { get; set; }
        /// <summary>
        /// 是否交接坯(交接部代码)
        /// <summary>
        public virtual string IF_TRANSFER { get; set; }
        /// <summary>
        /// 炉次交接点
        /// <summary>
        public virtual string PONO_CONNECT { get; set; }
        /// <summary>
        /// 交接部开始位置
        /// <summary>
        public virtual string CONNECT_START_POS { get; set; }
        /// <summary>
        /// 交接部终止位置
        /// <summary>
        public virtual string CONNECT_END_POS { get; set; }
        /// <summary>
        /// 钢坯位置代码
        /// <summary>
        public virtual string MAT_PLACE_CODE { get; set; }
        /// <summary>
        /// 钢坯切断时刻
        /// <summary>
        public virtual string MAT_CUT_TIME { get; set; }
        /// <summary>
        /// 切断位置
        /// <summary>
        public virtual string CUT_POS { get; set; }
        public virtual string FACTORY_DIV { get; set; }
        public virtual string RCF_CODE { get; set; }
        /// <summary>
        /// 下一块板坯预定切割完毕时间
        /// <summary>
        public virtual string NEXT_SLAB_CUT_TIME { get; set; }
        /// <summary>
        /// 钢坯质量判定标志
        /// <summary>
        public virtual string MAT_QUAL_FLG { get; set; }
        /// <summary>
        /// HCR标志
        /// <summary>
        public virtual string HOT_CHARGE_FLAG { get; set; }
        /// <summary>
        /// 热送标志
        /// <summary>
        public virtual string HOT_SEND_FLAG { get; set; }
        /// <summary>
        /// 热送可否标志
        /// <summary>
        public virtual string HOT_SEND_DECNDE { get; set; }
        /// <summary>
        /// 热送终止原因
        /// <summary>
        public virtual string HOT_SEND_STOP_CAUSE { get; set; }
        /// <summary>
        /// 品质异常代码
        /// <summary>
        public virtual string QUALITY_ABN_CODE { get; set; }
        /// <summary>
        /// 切头目标长度
        /// <summary>
        public virtual string CUT_TOP_TAR_LEN { get; set; }
        /// <summary>
        /// 切尾长度
        /// <summary>
        public virtual string CUT_TAIL_LEN { get; set; }
        /// <summary>
        /// 钢坯热送计划
        /// <summary>
        public virtual string MAT_HOT_SEND_PLAN { get; set; }
        /// <summary>
        /// 目标定尺
        /// <summary>
        public virtual string TAR_LEN { get; set; }
        /// <summary>
        /// 最大定尺
        /// <summary>
        public virtual string MAX_LEN { get; set; }
        /// <summary>
        /// 最小定尺
        /// <summary>
        public virtual string MIN_LEN { get; set; }
        /// <summary>
        /// 最终切割完标志
        /// <summary>
        public virtual string FIN_CUT_FLG { get; set; }
        /// <summary>
        /// 米单重
        /// <summary>
        public virtual string UNIT_METER_WEIGHT { get; set; }
        /// <summary>
        /// 钢坯去向标志
        /// <summary>
        public virtual string CUT_BG_LENGTH { get; set; }
        public virtual string CUT_ED_LENGTH { get; set; }
        public virtual string JJQ_YMBD_1 { get; set; }
        public virtual string JJQ_YMBD_2 { get; set; }
        public virtual string JJQ_YMBD_3 { get; set; }
        public virtual string ZJB_YMBD_BG1 { get; set; }
        public virtual string ZJB_YMBD_ED1 { get; set; }
        public virtual string ZJB_YMBD_BG2 { get; set; }
        public virtual string ZJB_YMBD_ED2 { get; set; }
        public virtual string ZJB_YMBD_BG3 { get; set; }
        public virtual string ZJB_YMBD_ED3 { get; set; }
        public virtual string LSYC_BG1 { get; set; }
        public virtual string LSYC_ED1 { get; set; }
        public virtual string LSYC_BG2 { get; set; }
        public virtual string LSYC_ED2 { get; set; }
        public virtual string LSYC_BG3 { get; set; }
        public virtual string LSYC_ED3 { get; set; }
        public virtual string LSYC_CAUSE { get; set; }
        public virtual string IF_AUTO { get; set; }
        public virtual string SDKZ_BG { get; set; }
        public virtual string SDKZ_ED { get; set; }
        public virtual string GSN_BG1 { get; set; }
        public virtual string GSN_ED1 { get; set; }
        public virtual string GSN_BG2 { get; set; }
        public virtual string GSN_ED2 { get; set; }
        public virtual string CKJZ_REASON { get; set; }
        /// <summary>
        /// 钢坯去向标志
        /// <summary>
        public virtual string DEST_FLAG { get; set; }
        /// <summary>
        /// 全程工序途径代码
        /// <summary>
        public virtual string PROCESS_PATH { get; set; }
    }
}
