using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class ST_TRANS_ORDER_REC {
        /// <summary>
        /// 序号，GUID
        /// <summary>
        public virtual string GUID { get; set; }
        /// <summary>
        /// 点对点吊运计划编号
        /// <summary>
        public virtual string PLAN_NUM { get; set; }
        /// <summary>
        /// 点对点吊运父计划编号
        /// <summary>
        public virtual string FATHER_PLAN_NUM { get; set; }
        /// <summary>
        /// 运输设备大类：1为台车，2为天车
        /// <summary>
        public virtual short? TRANS_CLASS { get; set; }
        /// <summary>
        /// 对于台车：1为废钢车，2为过跨车，对于天车：1为电磁吊，2为废钢车，3为铁包车，4为钢包车
        /// <summary>
        public virtual short? TRANS_SUB_CLASS { get; set; }
        /// <summary>
        /// 指令编号
        /// <summary>
        public virtual string ORDER_NUM { get; set; }
        /// <summary>
        /// 优先级字段，越大越优先。空包为1，重包为2，临时计划为3
        /// <summary>
        public virtual short? PRIORITY_LEVEL { get; set; }
        /// <summary>
        /// 临时计划标志位，0为正常指令，1为临时计划指令
        /// <summary>
        public virtual short? TEMP_PLAN_FLAG { get; set; }
        /// <summary>
        /// 运输设备编号
        /// <summary>
        public virtual int? TRANS_ID { get; set; }
        /// <summary>
        /// 实际运输设备编号
        /// <summary>
        public virtual int? REAL_TRANS_ID { get; set; }
        /// <summary>
        /// 吊物编号
        /// <summary>
        public virtual int? HOIST_ID { get; set; }
        /// <summary>
        /// 重量，单位kg
        /// <summary>
        public virtual int? WEIGHT { get; set; }
        /// <summary>
        /// 起始跨编号
        /// <summary>
        public virtual int? START_SPA_ID { get; set; }
        /// <summary>
        /// 结束跨编号
        /// <summary>
        public virtual int? END_SPA_ID { get; set; }
        /// <summary>
        /// 工作类型：1运载空铁水罐，2运载重铁水罐，3运载空废钢斗，
        ///4运载重废钢斗，5吊运废钢，6运载空钢包，7运载重钢包
        /// <summary>
        public virtual short? WORK_TYPE { get; set; }
        /// <summary>
        /// 执行顺序：本指令在计划中需要执行的步骤对应的序号
        /// <summary>
        public virtual short? EXECUTE_SEQ { get; set; }
        /// <summary>
        /// 推荐顺序：本指令在计划某步骤中存在多套解决方案时的推荐顺序
        /// <summary>
        public virtual short? RECOMMEND_SEQ { get; set; }
        /// <summary>
        /// 起始工位编号
        /// <summary>
        public virtual string START_WST_ID { get; set; }
        /// <summary>
        /// 目标工位编号
        /// <summary>
        public virtual string END_WST_ID { get; set; }
        /// <summary>
        /// 移动开始时间
        /// <summary>
        public virtual DateTime? MOVE_START_TIME { get; set; }
        /// <summary>
        /// 移动结束时间
        /// <summary>
        public virtual DateTime? MOVE_END_TIME { get; set; }
        /// <summary>
        /// 占用开始时间
        /// <summary>
        public virtual DateTime? OCCUPY_START_TIME { get; set; }
        /// <summary>
        /// 占用结束时间
        /// <summary>
        public virtual DateTime? OCCUPY_END_TIME { get; set; }
        /// <summary>
        /// 截止时间：运输完成任务最后允许时间
        /// <summary>
        public virtual DateTime? END_TASK_TIME { get; set; }
        /// <summary>
        /// 指令下达时间
        /// <summary>
        public virtual DateTime? SET_TIME { get; set; }
        /// <summary>
        /// 提醒时间
        /// <summary>
        public virtual DateTime? REMIND_TIME { get; set; }
        /// <summary>
        /// 已读标志位
        /// <summary>
        public virtual short? R_FLAG { get; set; }
        /// <summary>
        /// 指令执行状态：1为计划；2为开始；3为完成；4为中断；5为不能吊运
        /// <summary>
        public virtual short? STATUS { get; set; }
        /// <summary>
        /// 指令状态变化，时间标签
        /// <summary>
        public virtual DateTime? TIME_STAMP { get; set; }
        /// <summary>
        /// 生成时间
        /// <summary>
        public virtual DateTime? GENER_TIME { get; set; }
        /// <summary>
        /// 综合评分：
        ///量化为分数，综合考虑选择评分和执行评分结果，
        ///选择评分系数为0.4，执行评分系数为0.6，
        ///综合评分=0.4*选择评分+0.6*执行评分
        ///选择评分：
        ///指令基数为100，打分系数根据调度员选择情况给出
        ///（最高为1最低为0，选第一位系数为1、第二位系数为0.8、
        ///第三位系数为0.5、没选中所给项系数为0），
        ///指令基数乘以打分系数得到选择评分。
        ///例：调度员选择第二位推荐结果，选择评分为80分。
        ///执行评分：
        ///指令基数为100，打分系数根据实际执行情况给出
        ///（最高为1最低为0，未延时：执行第一位系数为1、
        ///第二位系数为0.8、第三位系数为0.5、没选中所给项系数为0，
        ///第一阶段延时：执行第一位系数为0.8、
        ///第二位系数为0.64、第三位系数为0.4、没选中所给项系数为0，
        ///第二阶段延时：执行第一位系数为0.5、
        ///第二位系数为0.4、第三位系数为0.25、没选中所给项系数为0，
        ///无法执行系数为0），
        ///指令基数乘以打分系数得到选择评分。
        ///例：实际按照第一阶段延时执行第二位推荐结果，
        ///执行评分为64分。
        ///综合评分=80*0.4+64*0.6=70.4分
        ///
        /// <summary>
        public virtual float? GRADE { get; set; }
        /// <summary>
        /// 选中状态：0未选中,1默认选中,2人工选中
        /// <summary>
        public virtual short? SELECT_STATUS { get; set; }
        /// <summary>
        /// 执行状态：0未执行,1执行中,2执行失败,3执行成功,4放弃状态
        /// <summary>
        public virtual short? EXECUTE_STATUS { get; set; }
        /// <summary>
        /// 失败类型：1.天车故障,2.台车故障,3.吊物故障,4.吊具故障,5.垛板台故障,
        ///6.卸板台故障,7.临时计划打断
        ///
        /// <summary>
        public virtual short? FAIL_REASON { get; set; }
        /// <summary>
        /// 是否为最后指令：0为非，1为是
        /// <summary>
        public virtual short? IS_LAST_ORDER { get; set; }
        /// <summary>
        /// 预留字段1
        /// <summary>
        public virtual string FIELD1 { get; set; }
        /// <summary>
        /// 预留字段2
        /// <summary>
        public virtual string FIELD2 { get; set; }
        /// <summary>
        /// 预留字段3
        /// <summary>
        public virtual string FIELD3 { get; set; }
    }
}
