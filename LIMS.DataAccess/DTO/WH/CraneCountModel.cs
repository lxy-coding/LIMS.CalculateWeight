using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.DataAccess.DTO { 

    ///曾马建 2020-05-28
    /// <summary>
    /// 天车工--量
    /// </summary>
    public class CraneCountModel
    {
        public string carName { get; set; }//天车工作量
        public int? inStock { get; set; }//入库
        public int? outStock { get; set; }//出库
        public int? invertedSpan { get; set; }//倒跨
        public int? invertedStack { get; set; }//倒垛
        public int? total { get; set; }//合计
    }
}
