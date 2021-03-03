using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Common.CommonData
{
    public class ConstEnum
    {
        /// <summary>
        /// 吊运动作
        /// </summary>
        public sealed class Act_Type
        {
            /// <summary>
            /// 起吊 1
            /// </summary>
            public const int Up = 1;
            /// <summary>
            /// 放吊 3
            /// </summary>
            public const int Down = 3;
        }

        /// <summary>
        /// 区域类型
        /// </summary>
        public sealed class HL_Type
        {
            /// <summary>
            /// 存储区 1
            /// </summary>
            public const int Storage = 1;
            /// <summary>
            /// 辊道
            /// </summary>
            public const int Offline = 2;
            /// <summary>
            /// 过跨区 3
            /// </summary>
            public const int CrossTrain = 3;
            /// <summary>
            /// 汽车区 4
            /// </summary>
            public const int Car = 4;
            /// <summary>
            /// 火车区 5
            /// </summary>
            public const int Train = 5;
            /// <summary>
            /// 空白区 6
            /// </summary>
            public const int Blank = 6;
            /// <summary>
            /// 卸板台
            /// </summary>
            public const int UnloadingPlatform = 7;
            /// <summary>
            /// 垛板台
            /// </summary>
            public const int PalletizingPlatform = 8;
            /// <summary>
            /// 翻坯机
            /// </summary>
            public const int BilletTurner = 9;

        }
    }
}
