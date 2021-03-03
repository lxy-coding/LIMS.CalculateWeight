using LIMS.Model.CustomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Common.CommonData
{
    //天车动作记录集合
    public static class CraneActionRecords
    {
        /// <summary>
        /// 吊出
        /// </summary>
        private static List<CraneActionRecord> _lstCraneActionRecord;
        public static List<CraneActionRecord> lstCraneActionRecord
        {
            get
            {
                if (_lstCraneActionRecord == null)
                {
                    _lstCraneActionRecord = new List<CraneActionRecord>();
                }
                return _lstCraneActionRecord;
            }
            
        }

        /// <summary>
        /// 吊入
        /// </summary>
        private static List<CraneActionRecord> _lstInCraneActionRecord;
        public static List<CraneActionRecord> lstInCraneActionRecord
        {
            get
            {
                if (_lstInCraneActionRecord == null)
                {
                    _lstInCraneActionRecord = new List<CraneActionRecord>();
                }
                return _lstInCraneActionRecord;
            }

        }
    }

}
