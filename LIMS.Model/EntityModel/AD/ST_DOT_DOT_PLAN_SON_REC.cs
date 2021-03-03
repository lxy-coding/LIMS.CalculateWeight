using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class ST_DOT_DOT_PLAN_SON_REC {
        /// <summary>
        /// 主键，GUID
        /// <summary>
        public virtual string GUID { get; set; }
        /// <summary>
        /// 外键，点对点吊运计划原表ID
        /// <summary>
        public virtual string FARTHER_ID { get; set; }
        /// <summary>
        /// 不可再分单段点对点吊运计划编号
        /// <summary>
        public virtual string SINGLE_DOT_PLAN_NUM { get; set; }
        /// <summary>
        /// 计划运输设备编号
        /// <summary>
        public virtual string PLAN_TRANS_ID { get; set; }
        /// <summary>
        /// 容器编号
        /// <summary>
        public virtual string CON_ID { get; set; }
        /// <summary>
        /// 容器重量，单位kg
        /// <summary>
        public virtual int? CON_WEIGHT { get; set; }
        /// <summary>
        /// 工作类型：1运载空铁水罐，2运载重铁水罐，3运载空废钢斗，
        ///4运载重废钢斗，5吊运废钢，6运载空钢包，7运载重钢包
        /// <summary>
        public virtual short? WORK_TYPE { get; set; }
        /// <summary>
        /// 起始跨编号
        /// <summary>
        public virtual int? START_SPA_ID { get; set; }
        /// <summary>
        /// 结束跨编号
        /// <summary>
        public virtual int? END_SPA_ID { get; set; }
        /// <summary>
        /// 起始工位编号
        /// <summary>
        public virtual string START_WST_ID { get; set; }
        /// <summary>
        /// 目标工位编号
        /// <summary>
        public virtual string END_WST_ID { get; set; }
        /// <summary>
        /// 开始时间
        /// <summary>
        public virtual DateTime? START_TIME { get; set; }
        /// <summary>
        /// 结束时间
        /// <summary>
        public virtual DateTime? END_TIME { get; set; }
        /// <summary>
        /// 计划状态：1为计划；2为开始；3为结束；4为中断；5为阻塞
        /// <summary>
        public virtual short? STATUS { get; set; }
        /// <summary>
        /// 事件标志：1为新增；2为修改；3为删除
        /// <summary>
        public virtual short? EVENT_FLAG { get; set; }
        /// <summary>
        /// 计划状态变化，时间标签
        /// <summary>
        public virtual DateTime? TIME_STAMP { get; set; }
        /// <summary>
        /// 生成时间
        /// <summary>
        public virtual DateTime? GENER_TIME { get; set; }
        /// <summary>
        /// 修改时间
        /// <summary>
        public virtual DateTime? MODIFY_TIME { get; set; }
        /// <summary>
        /// 计划来源
        /// <summary>
        public virtual short? PLAN_ORGIN { get; set; }
        /// <summary>
        /// 计划失败原因
        /// <summary>
        public virtual string FAILURE_REASON { get; set; }
        /// <summary>
        /// 执行顺序：本计划在上层计划分解后需要执行的步骤对应的序号
        /// <summary>
        public virtual short? EXECUTE_SEQ { get; set; }
        /// <summary>
        /// 执行评分：推荐指令与天车实际执行指令对比所得分数，
        ///先根据计划分成的指令段数，将总分100分平均分到每段得到
        ///段分数基数，每段指令根据执行情况给出打分系数
        ///（最高为1最低为0，未延时：执行第一位系数为1、
        ///第二位系数为0.8、第三位系数为0.5、没执行推荐项系数为0，
        ///第一阶段延时：执行第一位系数为0.8、
        ///第二位系数为0.64、第三位系数为0.4、没执行推荐项系数为0，
        ///第二阶段延时：执行第一位系数为0.5、
        ///第二位系数为0.4、第三位系数为0.25、没执行推荐项系数为0，
        ///无法执行系数为0），每段分别统计
        ///本段得分，本段分数基数乘以系数，最后累加所有分段得分即为
        ///总分，总分最大值为100分，最低值为0分。
        ///例：某计划分解成3段指令，则每段指令分数基数为33.33，
        ///若第一段指令被按时执行第一项推荐结果，第二段被第一阶段延时
        ///执行第二项推荐结果，第三段被第二阶段延时执行第一项推荐结果，
        ///则三段分别得分为：33.33分、21.33分、16.67分，累加得总分71.3分。
        /// <summary>
        public virtual float? EXECUTE_SCORE { get; set; }
        /// <summary>
        /// 选择执行评分：天车实际执行指令与调度人员选择相对比所得分数，
        ///先根据计划分成的指令段数，将总分100分平均分到每段指得到
        ///段分数基数，每段指令根据选择和执行情况给出打分系数
        ///（最高为1最低为0，未延时：执行和选择相同系数为1、
        ///不同则系数为0，第一阶段延时：执行和选择相同系数为0.8、
        ///不同则系数为0，第二阶段延时：执行和选择相同系数为0.5、
        ///不同则系数为0，无法执行系数为0），
        ///每段分别统计本段得分，本段分数基数乘以系数，
        ///最后累加所有分段得分即为总分，总分最大值为100分，最小值为0分。
        ///例：某计划分解成3段指令，则每段指令分数基数为33.33，
        ///若第一段指令按照被调度员选择结果按时执行，
        ///第二段未按照调度员选择结果第一阶段延时执行，
        ///第三段按照调度员选择结果第二阶段延时执行，
        ///则三段分别得分为：33.33分、0分、16.67分，累加得总分50分。
        /// <summary>
        public virtual float? SELECT_EXECUTE_SCORE { get; set; }
        /// <summary>
        /// 选择评分：推荐指令与调度人员选择相对比所得分数，
        ///先根据计划分成的指令段数，将总分100分平均分到每段得到
        ///段分数基数，每段指令根据选择情况给出打分系数
        ///（最高为1最低为0，选第一位系数为1、第二位系数为0.8、
        ///第三位系数为0.5、没选中所给项系数为0），每段分别统计
        ///本段得分，本段分数基数乘以系数，最后累加所有分段得分即为
        ///总分，总分最大值为100分，最低值为0分。
        ///例：某计划分解成3段指令，则每段指令分数基数为33.33，
        ///若第一段指令被调度员选择第一项推荐结果，第二段被调度员
        ///选择第二项推荐结果，第三段被调度员选择第一项推荐结果，
        ///则三段分别得分为：33.33分、26.67分、33.33分，累加得总分93.3分。
        ///
        /// <summary>
        public virtual float? SELECT_SCORE { get; set; }
        /// <summary>
        /// 计划是否作废：0为未作废，1为作废
        /// <summary>
        public virtual short? IS_PLAN_CANCEL { get; set; }
        /// <summary>
        /// 计划是否执行中被修改：0为未修改，1为修改
        /// <summary>
        public virtual short? IS_EXECUTE_MODIFY { get; set; }
        /// <summary>
        /// 是否为最后计划：0为非，1为是
        /// <summary>
        public virtual short? IS_LAST_PLAN { get; set; }
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
        /// <summary>
        /// 默认为0，人工修改1，校验流程读取2，计算流程重算3
        /// <summary>
        public virtual short? MODIFY_STATUS { get; set; }
    }
}
