using System;
using System.Text;
using System.Collections.Generic;


namespace LIMS.Model.EntityModel {
[Serializable]
    
    public class WH_STACKER_ORDER_REC {
        /// <summary>
        /// 指令序号
        /// <summary>
        public virtual string GUID { get; set; }
        /// <summary>
        /// 计划序号
        /// <summary>
        public virtual string PLAN_GUID { get; set; }
        /// <summary>
        /// 推荐垛板台ID：货位ID
        /// <summary>
        public virtual int? POSITION_ID { get; set; }
        /// <summary>
        /// 跨ID
        /// <summary>
        public virtual int? SPA_ID { get; set; }
        /// <summary>
        /// 板坯号
        /// <summary>
        public virtual string SLAB_NUM { get; set; }
        /// <summary>
        /// 生成时间
        /// <summary>
        public virtual DateTime? CREATE_TIME { get; set; }
        /// <summary>
        /// 推荐顺序：本指令在计划某步骤中存在多套解决方案时的推荐顺序
        /// <summary>
        public virtual short? RECOMMEND_SEQ { get; set; }
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
        public virtual float? SCORE { get; set; }
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
