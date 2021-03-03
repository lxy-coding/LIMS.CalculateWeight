using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Model.CustomModel
{
    public class Scrap_Hang_Log
    {
        public string ID { get; set; }
        
        public int CRANE_ID { get; set; }

        public int SPA_ID { get; set; }

        public int POSITION_ID_UP { get; set; }

        public int CENTRE_X_UP { get; set; }

        public int CENTRE_Y_UP { get; set; }

        public int CENTRE_Z_UP { get; set; }

        public int PLC_ORDER_UP { get; set; }

        public int WEIGHT { get; set; }

        public DateTime HANG_TIME_UP { get; set; }

        public int SCRAP_BUCKET_ID { get; set; }

        public int DEAL_FLAG { get; set; }

        public int POSITION_ID_DOWN { get; set; }

        public int CENTRE_X_DOWN { get; set; }

        public int CENTRE_Y_DOWN { get; set; }

        public int CENTRE_Z_DOWN { get; set; }

        public int PLC_ORDER_DOWN { get; set; }

        public DateTime HANG_TIME_DOWN { get; set; }

        public int SCRAP_TYPE_ID { get; set; }
    }
}
