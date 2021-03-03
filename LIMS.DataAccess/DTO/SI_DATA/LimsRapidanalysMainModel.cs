using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.DataAccess.DTO
{

    [Serializable]

    public class LimsRapidanalysMainModel
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
        /// 主键ID
        /// <summary>
        public virtual decimal? ID { get; set; }
        /// <summary>
        /// 委托单号
        /// <summary>
        public virtual string SAMPLE_ID { get; set; }
        /// <summary>
        /// 取样分类
        /// <summary>
        public virtual string SAMPLE_SPEC { get; set; }
        /// <summary>
        /// 取样时刻
        /// <summary>
        public virtual DateTime? SAMPLE_TAKEN_TIME { get; set; }
        /// <summary>
        /// 取样位置描述
        /// <summary>
        public virtual string SAMPLE_MS { get; set; }
        /// <summary>
        /// 钢种编码
        /// <summary>
        public virtual string STEEL_CODE { get; set; }
        /// <summary>
        /// 检验结束时间
        /// <summary>
        public virtual DateTime? ANALYSIS_END_TIME { get; set; }
        /// <summary>
        /// 熔炼号
        /// <summary>
        public virtual string HEAT_NO { get; set; }
        /// <summary>
        /// 制造命令号
        /// <summary>
        public virtual string PONO { get; set; }
        /// <summary>
        /// 炼钢气体试样区分
        /// <summary>
        public virtual string ST_SAMPLE_DIV { get; set; }
        /// <summary>
        /// 铁次号
        /// <summary>
        public virtual string IRON_NO { get; set; }
        /// <summary>
        /// 代表成份试样标识
        /// <summary>
        public virtual short? REP_SAMPLE_FLAG { get; set; }
        /// <summary>
        /// 取样次数
        /// <summary>
        public virtual string SAMPLE_OF_TIMES { get; set; }
        /// <summary>
        /// 包号
        /// <summary>
        public virtual string LADLEID { get; set; }
        /// <summary>
        /// 内部委托单号
        /// <summary>
        public virtual string ORDER_IN_CODE { get; set; }
        /// <summary>
        /// 委托类别
        /// <summary>
        public virtual string ORDER_TYPE_CODE { get; set; }
        /// <summary>
        /// 取样类别代码
        /// <summary>
        public virtual string SAMP_SITE_CODE { get; set; }
        /// <summary>
        /// 品名类别代码
        /// <summary>
        public virtual string MAT_TYPE_CODE { get; set; }
        /// <summary>
        /// 品名代码
        /// <summary>
        public virtual string MAT_CODE { get; set; }
        /// <summary>
        /// 试样状态
        /// <summary>
        public virtual string SAMPLE_STATE { get; set; }
        /// <summary>
        /// 流程实例ID
        /// <summary>
        public virtual decimal? PROCESSINSTID { get; set; }
        /// <summary>
        /// 委托类型
        /// <summary>
        public virtual string COM_TYPE { get; set; }
        /// <summary>
        /// 委托人
        /// <summary>
        public virtual string COM_PERSON { get; set; }
        /// <summary>
        /// 接收时间
        /// <summary>
        public virtual DateTime? ACCEPT_TIME { get; set; }
        /// <summary>
        /// 委托时间
        /// <summary>
        public virtual DateTime? ENTR_TIME { get; set; }
        /// <summary>
        /// 委托单位名称
        /// <summary>
        public virtual string ENTR_DEP_NAME { get; set; }
        /// <summary>
        /// 炉次号(高炉号)
        /// <summary>
        public virtual string HEAT_ID { get; set; }
        /// <summary>
        /// 牌号/外部牌号
        /// <summary>
        public virtual string STEEL_GRADE_ID { get; set; }
        /// <summary>
        /// 内部牌号
        /// <summary>
        public virtual string INNER_STG_ID { get; set; }
        /// <summary>
        /// 取样位置编码
        /// <summary>
        public virtual string SAMPLE_PLACE { get; set; }
        /// <summary>
        /// 取样顺序号
        /// <summary>
        public virtual string SAMPLE_NUMBER { get; set; }
        /// <summary>
        /// 检测开始时刻
        /// <summary>
        public virtual DateTime? SAMPLE_START_TIME { get; set; }
        /// <summary>
        /// 检测结束时刻
        /// <summary>
        public virtual DateTime? SAMPLE_RELEASE_TIME { get; set; }
        /// <summary>
        /// 脱硫处理号
        /// <summary>
        public virtual string DESUL_TREATMENT_ID { get; set; }
        /// <summary>
        /// 制样设备编号
        /// <summary>
        public virtual string PREP_EQU_ID { get; set; }
        /// <summary>
        /// 分析设备编号
        /// <summary>
        public virtual string ANALYZER_ID { get; set; }
        /// <summary>
        /// 1=night shift（夜班）2=day shift（白班）
        /// <summary>
        public virtual string CLASS_ID { get; set; }
        /// <summary>
        /// 分组ID
        /// <summary>
        public virtual string GROUP_ID { get; set; }
        public virtual string OPERATOR_ID { get; set; }
        /// <summary>
        /// 样品类型
        /// <summary>
        public virtual string SAMPLE_TYPE { get; set; }
        /// <summary>
        /// 创建时间
        /// <summary>
        public virtual DateTime? CREATE_DATE { get; set; }
        /// <summary>
        /// 创建人
        /// <summary>
        public virtual string CREATE_USER { get; set; }
        /// <summary>
        /// 更新时间
        /// <summary>
        public virtual DateTime? UPDATE_DATE { get; set; }
        /// <summary>
        /// 更新人
        /// <summary>
        public virtual string UPDATE_USER { get; set; }
        /// <summary>
        /// 工序
        /// <summary>
        public virtual string YL_TEC_ROUTE { get; set; }
        /// <summary>
        /// 状态
        /// <summary>
        public virtual string STATE { get; set; }
        /// <summary>
        /// 设备号
        /// <summary>
        public virtual string DEVICES { get; set; }
        /// <summary>
        /// 要求完成时间(检验周期)
        /// <summary>
        public virtual DateTime? REQ_DATE { get; set; }
        /// <summary>
        /// 检验标准
        /// <summary>
        public virtual string INSPECTION_STANDARD { get; set; }
        /// <summary>
        /// 检验标准名称
        /// <summary>
        public virtual string INSPECTIONG_STANDARD_NAME { get; set; }
        /// <summary>
        /// 检验结果
        /// <summary>
        public virtual string TEST_RESULT { get; set; }
        /// <summary>
        /// 留样状态
        /// <summary>
        public virtual string STATE_WAIT { get; set; }
        /// <summary>
        /// 坏样标记
        /// <summary>
        public virtual short? BAD_SAMPLE { get; set; }
        /// <summary>
        /// 数据状态（正常，异常）小块分系统
        /// <summary>
        public virtual string TQ_STATE { get; set; }
        /// <summary>
        /// 置废原因
        /// <summary>
        public virtual string ABOLISH_REASON { get; set; }
        /// <summary>
        /// 接样人
        /// <summary>
        public virtual string SAMPLE_HOLDER { get; set; }
        /// <summary>
        /// 接样时刻
        /// <summary>
        public virtual DateTime? SAMPLING_TIME { get; set; }
        /// <summary>
        /// 分析方法
        /// <summary>
        public virtual string ANALYSIS_METHOD { get; set; }
        /// <summary>
        /// 反馈时刻
        /// <summary>
        public virtual string FEEDBACK_LIMIT { get; set; }
        /// <summary>
        /// 实验方法
        /// <summary>
        public virtual string TEST_METHOD { get; set; }
        /// <summary>
        /// 委托接收人
        /// <summary>
        public virtual string ACCEPT_PERSON { get; set; }
        /// <summary>
        /// 炉批号
        /// <summary>
        public virtual string ACT_TPC_NO { get; set; }
        /// <summary>
        /// 铁水罐号
        /// <summary>
        public virtual string TPC_NO { get; set; }
        /// <summary>
        /// 上传人
        /// <summary>
        public virtual string UP_PERSON { get; set; }
        /// <summary>
        /// 上传时间
        /// <summary>
        public virtual DateTime? UP_DATE { get; set; }
        /// <summary>
        /// 板坯号
        /// <summary>
        public virtual string SLAB_NO { get; set; }
        /// <summary>
        /// 钢水检验结果状态
        /// <summary>
        public virtual string STATE_AAA601 { get; set; }
        /// <summary>
        /// 钢渣检验结果状态
        /// <summary>
        public virtual string STATE_AAA602 { get; set; }
        /// <summary>
        /// 铁水检验结果状态
        /// <summary>
        public virtual string STATE_AAA603 { get; set; }
        /// <summary>
        /// 钢坯割（锭）样检验结果状态
        /// <summary>
        public virtual string STATE_AAA604 { get; set; }
        /// <summary>
        /// 钢水检验结果操作标识
        /// <summary>
        public virtual string OP_FLAG_AAA601 { get; set; }
        /// <summary>
        /// 钢渣检验结果操作标识
        /// <summary>
        public virtual string OP_FLAG_AAA602 { get; set; }
        /// <summary>
        /// 铁水检验结果操作标识
        /// <summary>
        public virtual string OP_FLAG_AAA603 { get; set; }
        /// <summary>
        /// 钢坯割（锭）样检验结果操作标识
        /// <summary>
        public virtual string OP_FLAG_AAA604 { get; set; }
        /// <summary>
        /// 小块分数据上传时间
        /// <summary>
        public virtual DateTime? SMALL_UP_TIME { get; set; }
        /// <summary>
        /// 小块分系统进样时间
        /// <summary>
        public virtual DateTime? SMALL_SAMPLE_TIME { get; set; }
        /// <summary>
        /// 小块分制样
        /// <summary>
        public virtual DateTime? SMALL_PREPSTART_TIME { get; set; }
        /// <summary>
        /// 开始时间
        /// <summary>
        public virtual DateTime? SMALL_PREPEND_TIME { get; set; }
        /// <summary>
        /// 小块分制样结束时间
        /// <summary>
        public virtual string SMALL_PREP_TIME { get; set; }
        /// <summary>
        /// 小块分制样时长
        /// <summary>
        public virtual string SMALL_ANA_TIME { get; set; }
        /// <summary>
        /// 车站
        /// <summary>
        public virtual string SMALL_STATION_ID { get; set; }
        /// <summary>
        /// 审核人
        /// <summary>
        public virtual string SMALL_AUDITOR { get; set; }
        /// <summary>
        /// 名称
        /// <summary>
        public virtual string SMALL_ANAPROG_NAME { get; set; }
    }
}
