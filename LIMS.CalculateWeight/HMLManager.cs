using LIMS.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.CalculateWeight
{
    public class HMLManager
    {
        public string MatchLadle(string pos)
        {
            string con = null;

            var hml = CalculateWeightService.Instance.Get_HML_REAL_INFO(pos);

            if (hml != null)
            {
                con = hml.CON_ID.DISPLAYNAME;
                hml.POSIT = null;
                CalculateWeightService.Instance.Update_HML_REAL_INFO(hml);
            }
            return con;
        }

        public string MatchLadle(string pos, string newPos)
        {
            string con = null;

            var hml = CalculateWeightService.Instance.Get_HML_REAL_INFO(pos);

            if (hml != null)
            {
                con = hml.CON_ID.DISPLAYNAME;
                hml.POSIT = newPos;
                CalculateWeightService.Instance.Update_HML_REAL_INFO(hml);
            }
            return con;
        }
    }
}
