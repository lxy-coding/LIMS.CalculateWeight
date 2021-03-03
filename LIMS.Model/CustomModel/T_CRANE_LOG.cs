using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Model.CustomModel
{
    public class T_CRANE_LOG
    {
        public string ID { get; set; }

        public string CRANE_ID { get; set; }

        public string STEEL_NUM { get; set; }

        public string HEAT_NUM { get; set; }

        public int STEEL_COUNT { get; set; }

        public string UP_AREA_ID { get; set; }

        public string UP_AREA_NAME { get; set; }

        public string UP_LOCATION_ID { get; set; }

        public string UP_LOCATION_NAME { get; set; }

        public int UP_LAYER { get; set; }

        public int UP_X { get; set; }

        public int UP_Y { get; set; }

        public int UP_Z { get; set; }

        public DateTime UP_TIME { get; set; }

        public string DOWN_AREA_ID { get; set; }

        public string DOWN_AREA_NAME { get; set; }

        public string DOWN_LOCATION_ID { get; set; }

        public string DOWN_LOCATION_NAME { get; set; }

        public int DOWN_LAYER { get; set; }

        public int DOWN_X { get; set; }

        public int DOWN_Y { get; set; }

        public int DOWN_Z { get; set; }

        public DateTime DOWN_TIME { get; set; }

        public int DO_FLAG { get; set; }

        public int BUSINESS_TYPE { get; set; }

        public int UP_ORDER { get; set; }

        public int DOWN_ORDER { get; set; }

        public int WEIGHT { get; set; }

        public string CHECKER { get; set; }

        public string CLASS_ID { get; set; }

        public int SLAB_TYPE { get; set; }//铸坯类型：5为板坯，6为方坯

        public int UP_Z_ROTATE { get; set; }

        public int DOWN_Z_ROTATE { get; set; }
    }
}
