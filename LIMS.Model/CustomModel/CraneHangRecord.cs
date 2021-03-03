using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Model.CustomModel
{
    public class CraneHangRecord
    {
        public string STEEL_NUM { get; set; }

        public string HEAT_NUM { get; set; }

        public string CRA_NUM { get; set; }

        public string UP_AREA { get; set; }

        public string UP_POSITION { get; set; }

        public string UP_LAYER { get; set; }

        public string UP_X { get; set; }

        public string UP_Y { get; set; }

        public string UP_TIME { get; set; }

        public string DOWN_AREA { get; set; }

        public string DOWN_POSITION { get; set; }

        public string DOWN_LAYER { get; set; }

        public string DOWN_X { get; set; }

        public string DOWN_Y { get; set; }

        public string DOWN_TIME { get; set; }

        public string DEAL_FLAG { get; set; }
    }
}
