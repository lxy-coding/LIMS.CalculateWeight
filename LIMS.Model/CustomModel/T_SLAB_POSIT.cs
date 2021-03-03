using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Model.CustomModel
{
    public class T_SLAB_POSIT
    {
        public string ID { get; set; }

        public string T_SLAB_PROPERTY_ID { get; set; }

        public string SLAB_NUM { get; set; }

        public string OUTSOURCING_NUM { get; set; }

        public string POSIT_NUM { get; set; }

        public int LAYER { get; set; }

        public int NUM_CHECK { get; set; }

        public int STATUS { get; set; }

        public DateTime TIME_STAMP { get; set; }

        public DateTime CREATE_TIME { get; set; }

        public DateTime IN_TIME { get; set; }

        public string REMARK { get; set; }

        public int X_COORD { get; set; }

        public int Y_COORD { get; set; }

        public int Z_COORD { get; set; }

        public int SLAB_ROW { get; set; }

        public int SLAB_COLUMN { get; set; }

        public string HEAT_NUM { get; set; }

        public int BILLET_NUM { get; set; }

        public int Z_ROTATE { get; set; }
    }
}
