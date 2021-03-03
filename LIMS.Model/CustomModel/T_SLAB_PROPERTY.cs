using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Model.CustomModel
{
    public class T_SLAB_PROPERTY
    {
        public string P_ID { get; set; }

        public string T_SLAB_POSIT_ID { get; set; }

        public int HEAD_WIDTH { get; set; }

        public int TAIL_WIDTH { get; set; }

        public int THICK { get; set; }

        public int LENGTH { get; set; }

        public int WEIGHT { get; set; }

        public string GRADE { get; set; }

        public string ORDER_NO { get; set; }

        public DateTime ORDER_TIME { get; set; }

        public string HEAT_NUM { get; set; }

        public DateTime MELT_TIME { get; set; }

        public int BLOCK_FLAG { get; set; }

        public string BLOCK_REASON { get; set; }

        public string QUAL_CODE { get; set; }

        public int IN_STORAGE_STATE { get; set; }

        public string CAR_UNLOAD_PLAN { get; set; }

        public DateTime RECORD_CREATE_TIME { get; set; }

        public int IN_STORAGE_TYPE { get; set; }

        public string CHECK_RESULT { get; set; }

        public DateTime CHECK_TIME { get; set; }

        public string OFF_LOCATION { get; set; }

        public string SLAB_DESC { get; set; }

        public DateTime CUT_TIME { get; set; }

        public int FAULT_NUM { get; set; }

        public string SLAB_SOURCE { get; set; }

        public string SLAB_DEST { get; set; }

        public int UPDATE_FLAG { get; set; }

        public string SLAB_SIZE { get; set; }

        public string SLAB_LEVEL { get; set; }

        public string NUM { get; set; }
    }
}
