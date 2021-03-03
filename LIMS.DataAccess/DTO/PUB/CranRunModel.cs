using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO
{
    public class CranRunModel
    {
        public string CRA_NAME { get; set; }//天车名称

        public int COORD_X { get; set; }//X坐标
        public int COORD_Y { get; set; }//Y坐标
        public int COORD_Z { get; set; }//Z坐标

        public int LITTLE_HOOK_Y { get; set; }//y副坐标
        public int LITTLE_HOOK_Z { get; set; }//Z副坐标
        public int WEIGHT { get; set; }//重量

        public DateTime? CREATE_TIME { get; set; }//创建时间
    }
}
