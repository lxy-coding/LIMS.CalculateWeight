using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO
{
    ///曾马建 2020-05-25
    /// <summary>
    ///未完成作业计划查询 
    /// </summary>
    public class SABL_CRA_WORK_Model
    {
       
        public string OBJ_NUM { get; set; }//天车号
        public string SLAB_NUM { get; set; }//板坯
        public string HEAT_NUM { get; set; }//炉次
        public string GRADE { get; set; }//钢种
        public string SLAB_SIZE { get; set; }//规格
        public string WEIGHT { get; set; }//重量
        public string PLAN_TYPE { get; set; }//类型
        public DateTime CREATE_TIME { get; set; }//时间
        public string START_AREA_NUM { get; set; }//开始区域
        public string START_WST_NUM { get; set; }//开始货位       
        public string START_LAYER { get; set; }//开始层次

        public string END_AREA_NUM { get; set; }//结束区域
        public string END_WST_NUM { get; set; }//结束货位
        public string END_LAYER { get; set; }//结束层次
        
    }
}
