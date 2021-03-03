using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO
{

    /// <summary>
    ///倒跨视图
    /// </summary>
    public class V_SPA_PLAN
    {
        public string P_ID { get; set; }
        public string S_SIZE { get; set; }
        public string WEIGTH { get; set; }
        public string GRADE { get; set; }
        public string PLANO { get; set; }
        public string HEAT_NUM { get; set; }
        public string LAST_NUM { get; set; }
        public string COUNT { get; set; }
        public string SLAB_NUM { get; set; }
        public string CRA_NUM { get; set; }
        public string CREATE_TIME { get; set; }
        public string PLAN_STATUS { get; set; }
        public string USER_NUM { get; set; }
        public string OUT_TYPE { get; set; }
        public string CRA_NAM { get; set; }
        public string IN_TYPE { get; set; }
        public string UPUSER_NUM { get; set; }
        public string HP_ID { get; set; }
        public string HP_NAME { get; set; }
        public string HL_ID { get; set; }
        public string HL_NAME { get; set; }
        public string ENDHP_ID { get; set; }
        public string ENDHP_NAME { get; set; }
        public string ENDHL_ID { get; set; }
        public string ENDHL_NAME { get; set; }
        public string END_TIME { get; set; }
        public string START_LAYER { get; set; }
        public string ATTR { get; set; }
        public string HC_ID { get; set; }
        public string HC_NAME { get; set; }
        public string ENDHC_ID { get; set; }
        public string ENDHC_NAME { get; set; }
        public string HELPCRA_NUM { get; set; }//目标天车
        public string ENDCRA_NAM { get; set; }
    }
}
