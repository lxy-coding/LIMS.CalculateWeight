using LIMS.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.CalculateWeight
{
    public class LadleManager
    {
        public string MatchLadle(string pos)
        {
            string con = null;

            var ladle = CalculateWeightService.Instance.Get_LADLE_REAL_INFO(pos);

            if (ladle != null)
            {
                con = ladle.CON_ID.DISPLAYNAME;
                ladle.POSIT = null;
                CalculateWeightService.Instance.Update_LADLE_REAL_INFO(ladle);
            }
            return con;
        }

        public string MatchLadle(string pos,string newPos)
        {
            string con = null;

            var ladle = CalculateWeightService.Instance.Get_LADLE_REAL_INFO(pos);

            if (ladle != null)
            {
                con = ladle.CON_ID.DISPLAYNAME;
                ladle.POSIT = newPos;
                CalculateWeightService.Instance.Update_LADLE_REAL_INFO(ladle);
            }
            return con;
        }
    }
}
