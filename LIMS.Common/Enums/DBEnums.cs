using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Common.Enums
{
    /// <summary>
    /// 区域交通方向
    /// </summary>
    public enum AreaDirection
    {
        /// <summary>
        /// X方向 1
        /// </summary>
        XDirectoin = 1,
        /// <summary>
        /// Y方向 2
        /// </summary>
        YDirection = 2
    }

    /// <summary>
    /// 区域类型
    /// </summary>
    public enum AreaType
    {
        /// <summary>
        /// 跨区或未定义区域
        /// </summary>
        SPA = 0,
        /// <summary>
        /// 板坯存储区 
        /// </summary>
        Slab_Storage = 1,
        /// <summary>
        /// 板坯下线区 
        /// </summary>
        Slab_Offline = 2,
        /// <summary>
        /// 板坯过跨区 
        /// </summary>
        Slab_CrossSPA = 3,
        /// <summary>
        /// 板坯汽车区 
        /// </summary>
        Slab_Car = 4,
        /// <summary>
        /// 板坯切割区 
        /// </summary>
        Slab_Cut = 5,
        /// <summary>
        /// 板坯废品区 
        /// </summary>
        Slab_Waste = 11,

        /// <summary>
        /// 方坯存储区 
        /// </summary>
        Billet_Storage = 6,
        /// <summary>
        /// 方坯下线区 
        /// </summary>
        Billet_Offline = 7,
        /// <summary>
        /// 方坯过跨区 
        /// </summary>
        Billet_CrossSPA = 8,
        /// <summary>
        /// 方坯汽车区 
        /// </summary>
        Billet_Car = 9,
        /// <summary>
        /// 方坯切割区 
        /// </summary>
        Billet_Cut = 10,
        /// <summary>
        /// 方坯废品区 
        /// </summary>
        Billet_Waste = 12
    }

    /// <summary>
    /// 天车类型
    /// </summary>
    public enum CraneType
    {
        ScrapSteelCrane = 1,

    }
}

