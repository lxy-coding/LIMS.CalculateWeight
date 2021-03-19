using LIMS.Model.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.CalculateWeight
{
    /// <summary>
    /// 工位管理
    /// </summary>
    public class WstManager
    {
        /// <summary>
        /// 类型：1转炉装入位；2转炉钢水吊包位；3精炼吊包位；4连铸吊包位；5混铁炉吊包位；6脱硫吊包位;7浇筑跨吊包位;8提凡炉半钢水吊包位;9VD炉吊位;10其他
        /// </summary>
        public Dictionary<int,WST> DicWsts { get; set; }

        /// <summary>
        /// 匹配工位
        /// </summary>
        /// <param name="xCoord"></param>
        /// <param name="yCoord"></param>
        public bool MatchWst(int xCoord, int yCoord,WST wst)
        {
            if (Math.Abs(xCoord - (int)wst.CENTRE_X) < (wst.POSITION_LENGTH / 2) && Math.Abs(yCoord - (int)wst.CENTRE_Y) < (wst.WIDTH / 2))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 匹配工位
        /// </summary>
        /// <param name="xCoord"></param>
        /// <param name="yCoord"></param>
        /// <returns>工位类型--工位</returns>
        public WST MatchWst(int xCoord, int yCoord)
        {
            return null;
        }

    }
}
