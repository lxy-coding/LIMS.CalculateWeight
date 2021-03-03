using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Model.CustomModel
{
    //天车动作记录
    public class CraneActionRecord
    {
        public string ID { get; set; }

        public int T_OBJECT_INFO_ID { get; set; }//记录天车

        public int X_COORD { get; set; }

        public int Y_COORD { get; set; }

        public int LITTLT_HOOK_Y { get; set; }

        public int Z_COORD { get; set; }

        public int LITTLE_HOOK_Z { get; set; }

        public int Z_ROTATE { get; set; }

        public int LITTLE_Z_ROTATE { get; set; }

        public double WEIGHT { get; set; }

        public int LITTLE_HOOK_WEIGHT { get; set; }

        public int ACTION_SYMBOL { get; set; }

        public string POSIT { get; set; }

        public string PLAN_NUM { get; set; }

        public string HEAT_NUM { get; set; }

        public string HOIST_NUM { get; set; }

        public int HOIST_TYPE { get; set; }

        public DateTime OPERATION_TIME { get; set; }

        public DateTime ACCEPT_TIME { get; set; }

        public DateTime DEAL_TIME { get; set; }

        public int DEAL_SYMBOL { get; set; }

        public int IS_TEMP { get; set; }

        public int CACHE_NUM { get; set; }

        public int HANGE_QUAN { get; set; }

        public int OVER_LOAD { get; set; }

        public int LOAD_SYMBOL { get; set; }

        public int TEMP_TASK { get; set; }

        public int IS_CHECKED { get; set; }

        public int CALIBRATE_WEIGHT { get; set; }

        public bool FLAG_INOUT { get; set; }

        public string OBJECT_AREA_ID { get; set; }//记录起放吊区域
    }
}
