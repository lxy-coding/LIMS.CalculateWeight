using LIMS.CalculateWeight.Visitor;
using LIMS.Model.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.CalculateWeight
{
    public class VisitorProvider
    {
        public VisitorBase GetVisitor(CRANE_ACTION_RECORD_X record)
        {
            WST wst = WstManager.MatchWst((int)record.COORD_X, (int)record.COORD_Y);
            if (wst != null)
            {
                VisitorBase visitor= GetVisitor(wst.FIELD2);
                visitor.Wst = wst;
                return visitor;
            }
            else
            {
                return new UnknowVisitor();
            }
        }

        /// <summary>
        /// 类型：1转炉装入位；2转炉钢水吊包位；3精炼吊包位；4连铸吊包位；5混铁炉吊包位；6脱硫吊包位;7浇筑跨吊包位;8提凡炉半钢水吊包位;9VD炉吊位;10其他
        /// </summary>
        /// <param name="wstType"></param>
        /// <returns></returns>
        public VisitorBase GetVisitor(string wstType)
        {
            switch (wstType)
            {
                case "1":
                    return new BofChargeVisitor();
                case "2":
                    return new BofCraneVisitor();
                case "3":
                    return new RefineCraneVisitor();
                case "4":
                    return new CCMCraneVisitor();
                case "5":
                    return new MMCraneVisitor();
                case "6":
                    return new KRCraneVisitor();
                case "7":
                    return new OtherWstVisitor();
                case "8":
                    return new HalfBofChargeVisitor();
                case "9":
                    return new VDCraneVisitor();
                case "10":
                    return new OtherWstVisitor();
                default:
                    return new OtherWstVisitor();
            }
        }

        /// <summary>
        /// 工位管理者
        /// </summary>
        public WstManager WstManager { get; set; } = new WstManager();
    }
}
