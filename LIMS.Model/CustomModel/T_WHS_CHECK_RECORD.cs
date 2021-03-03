using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Model.CustomModel
{
    /// <summary>
    /// 核库记录
    /// </summary>
    public class T_WHS_CHECK_RECORD
    {
        public string ID { get; set; }

        public string T_SLAB_POSIT_ID { get; set; }

        public string HEAT_NUM { get; set; }

        public string POSIT_NUM { get; set; }

        public int  LAYERS { get; set; }

        public DateTime CHECK_TIME { get; set; }

        public int CHECK_TYPE { get; set; }

        public string USER_NUM { get; set; }

        public string REMARK { get; set; }
    }
}
