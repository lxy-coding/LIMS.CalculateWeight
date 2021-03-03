using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Model.CustomModel
{
    public class T_HEAT_SEND
    {
        public string ID { get; set; }

        public string PLAN_NUM { get; set; }

        public int PRO_LINE_NUM { get; set; }

        public string HEAT_NUM { get; set; }

        public string GRADE { get; set; }

        public string BALLIT_SIZE { get; set; }

        public int WEIGHT { get; set; }
        
        public string MIDDLE_NUM { get; set; }

        public string FIRST_USER { get; set; }

        public DateTime  FIRST_TIME { get; set; }

        public string LAST_USER { get; set; }

        public DateTime LAST_TIME { get; set; }
    }
}
