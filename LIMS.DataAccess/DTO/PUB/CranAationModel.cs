using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO
{
    ///曾马建 2020-05-25
    /// <summary>
    /// 天车动作记录Model
    /// </summary>
    public class CranAationModel
    {       
        public string CRA_NAME { get; set; }//天车名称

        public int COORD_X { get; set; }//X坐标
        public int COORD_Y { get; set; }//Y坐标
        public int COORD_Z { get; set; }//Z坐标
        public int WEIGHT { get; set; }//重量
        public string POSITION { get; set; }//位置
        public int ACTION_SYMBOL { get; set; }//动作标志
        public string PLAN_NUM { get; set; }//计划号
        public string HEAT_NUM { get; set; }//炉次号
        public string HOIST_NUM { get; set; }//负载包号
        public DateTime? OPERATION_TIME{get ;set;}//动作生成时间

    }
}
