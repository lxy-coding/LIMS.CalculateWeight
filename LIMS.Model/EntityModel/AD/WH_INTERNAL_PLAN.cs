using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class WH_INTERNAL_PLAN {
        /// <summary>
        /// 计划序号
        /// <summary>
        public virtual string GUID { get; set; }
        /// <summary>
        /// 父作业计划序号
        /// <summary>
        public virtual string FATHER_PLAN_GUID { get; set; }
        /// <summary>
        /// 业务ID
        /// <summary>
        public virtual long? BUSI_ID { get; set; }
        /// <summary>
        /// 设备类型：1天车2台车
        /// <summary>
        public virtual short OBJ_TYPE { get; set; }
        /// <summary>
        /// 设备ID
        /// <summary>
        public virtual int? OBJ_ID { get; set; }
        /// <summary>
        /// 作业类型：1入库、2出库、3倒跨、4倒垛
        /// <summary>
        public virtual short JOB_TYPE { get; set; }
        /// <summary>
        /// 板坯序号
        /// <summary>
        public virtual int? SLAB_SN { get; set; }
        /// <summary>
        /// 物品名称：临时计划使用
        /// <summary>
        public virtual string THING_NAME { get; set; }
        /// <summary>
        /// 起始跨区ID
        /// <summary>
        public virtual int? START_SPA_ID { get; set; }
        /// <summary>
        /// 起始跨区名称
        /// <summary>
        public virtual string START_SPA_NAME { get; set; }
        /// <summary>
        /// 起始区域ID：默认0 区域ID
        /// <summary>
        public virtual int? START_AREA_ID { get; set; }
        /// <summary>
        /// 起始区域名称
        /// <summary>
        public virtual string START_AREA_NAME { get; set; }
        /// <summary>
        /// 起始货位ID
        /// <summary>
        public virtual int? START_POSITION_ID { get; set; }
        /// <summary>
        /// 起始位置名称
        /// <summary>
        public virtual string START_POSITION_NAME { get; set; }
        /// <summary>
        /// 起始行：默认0
        /// <summary>
        public virtual int? START_ROW { get; set; }
        /// <summary>
        /// 起始列：默认0
        /// <summary>
        public virtual int? START_COLUMN { get; set; }
        /// <summary>
        /// 起始层：默认0
        /// <summary>
        public virtual short? START_LAYER { get; set; }
        /// <summary>
        /// 起始X坐标：默认0
        /// <summary>
        public virtual int? START_X_COORD { get; set; }
        /// <summary>
        /// 起始Y坐标：默认0
        /// <summary>
        public virtual int? START_Y_COORD { get; set; }
        /// <summary>
        /// 起始Z坐标：默认0
        /// <summary>
        public virtual int? START_Z_COORD { get; set; }
        /// <summary>
        /// 目标跨区ID
        /// <summary>
        public virtual int? END_SPA_ID { get; set; }
        /// <summary>
        /// 目标跨区名称
        /// <summary>
        public virtual string END_SPA_NAME { get; set; }
        /// <summary>
        /// 目标区域ID
        /// <summary>
        public virtual int? END_AREA_ID { get; set; }
        /// <summary>
        /// 目标区域名称
        /// <summary>
        public virtual string END_AREA_NAME { get; set; }
        /// <summary>
        /// 目标货位ID
        /// <summary>
        public virtual int? END_POSITION_ID { get; set; }
        /// <summary>
        /// 目标货位名称
        /// <summary>
        public virtual string END_POSITION_NAME { get; set; }
        /// <summary>
        /// 目标行：默认0
        /// <summary>
        public virtual int? END_ROW { get; set; }
        /// <summary>
        /// 目标列：默认0
        /// <summary>
        public virtual int? END_COLUMN { get; set; }
        /// <summary>
        /// 目标层：默认0
        /// <summary>
        public virtual short? END_LAYER { get; set; }
        /// <summary>
        /// 目标X坐标
        /// <summary>
        public virtual int? END_X_COORD { get; set; }
        /// <summary>
        /// 目标Y坐标
        /// <summary>
        public virtual int? END_Y_COORD { get; set; }
        /// <summary>
        /// 目标Z坐标：默认0
        /// <summary>
        public virtual int? END_Z_COORD { get; set; }
        /// <summary>
        /// 创建时间
        /// <summary>
        public virtual DateTime? CREATE_TIME { get; set; }
        /// <summary>
        /// 计划来源：1web端  2PDA端   3临时手动录入  4计算分解  5其它
        ///20接口数据  
        /// <summary>
        public virtual short? PLAN_FROM { get; set; }
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
        /// 原始计划序号：区别于“父作业计划序号”，用于找到修改前的作业计划序号
        /// <summary>
        public virtual long? ORIGIN_PLAN_SN { get; set; }
        /// <summary>
        /// 计划是否执行中被修改：0为未修改，1为修改
        /// <summary>
        public virtual short? IS_EXECUTE_MODIFY { get; set; }
        /// <summary>
        /// 修改时间
        /// <summary>
        public virtual DateTime? UPDATE_TIME { get; set; }
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
    }
}
