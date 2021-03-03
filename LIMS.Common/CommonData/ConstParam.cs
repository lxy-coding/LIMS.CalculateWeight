using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Common.CommonData
{
    public class ConstParam
    {
        //单根重量
        private static double perWeight = 1.5;
        public static double PerWeight
        {
            get
            {
                return perWeight;
            }
            set
            {
                perWeight = value;
            }
        }
    }
}
