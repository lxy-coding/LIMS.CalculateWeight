using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LIMS.Common.Themes
{
    public class CustomResource
    {
        /// <summary>
        /// 标题样式
        /// </summary>
        public static ComponentResourceKey HeaderStyle
        {
            get { return new ComponentResourceKey(typeof(CustomResource), "HeaderStyle"); }
        }
        /// <summary>
        /// 按钮样式
        /// </summary>
        public static ComponentResourceKey ButtonStyle
        {
            get { return new ComponentResourceKey(typeof(CustomResource), "ButtonStyle"); }
        }
        /// <summary>
        /// 按钮样式1
        /// </summary>
        public static ComponentResourceKey ButtonStyle1
        {
            get { return new ComponentResourceKey(typeof(CustomResource), "ButtonStyle1"); }
        }
        /// <summary>
        /// 按钮 [关闭] 样式
        /// </summary>
        public static ComponentResourceKey ButtonCloseStyle
        {
            get { return new ComponentResourceKey(typeof(CustomResource), "ButtonCloseStyle"); }
        }
        /// <summary>
        /// 列表框样式
        /// </summary>
        public static ComponentResourceKey DataGridStyle
        {
            get { return new ComponentResourceKey(typeof(CustomResource), "DataGridStyle"); }
        }
        /// <summary>
        /// 列表框样式1
        /// </summary>
        public static ComponentResourceKey DataGridStyle1
        {
            get { return new ComponentResourceKey(typeof(CustomResource), "DataGridStyle1"); }
        }
        /// <summary>
        /// 列表框样式2
        /// </summary>
        public static ComponentResourceKey DataGridStyle2
        {
            get { return new ComponentResourceKey(typeof(CustomResource), "DataGridStyle2"); }
        }
        /// <summary>
        /// 文本框样式
        /// </summary>
        public static ComponentResourceKey TextBoxStyle
        {
            get { return new ComponentResourceKey(typeof(CustomResource), "TextBoxStyle"); }
        }
        /// <summary>
        /// 设备名称样式
        /// </summary>
        public static ComponentResourceKey DvcNameStyle
        {
            get { return new ComponentResourceKey(typeof(CustomResource), "DvcNameStyle"); }
        }
        /// <summary>
        /// 设备状态样式
        /// </summary>
        public static ComponentResourceKey DvcStateStyle
        {
            get { return new ComponentResourceKey(typeof(CustomResource), "DvcStateStyle"); }
        }
        /// <summary>
        /// 包号样式
        /// </summary>
        public static ComponentResourceKey LadleNumStyle
        {
            get { return new ComponentResourceKey(typeof(CustomResource), "LadleNumStyle"); }
        }
        /// <summary>
        /// 日期控件样式
        /// </summary>
        public static ComponentResourceKey DatePickerStyle
        {
            get { return new ComponentResourceKey(typeof(CustomResource), "DatePickerStyle"); }
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComponentResourceKey ButtonTemplate
        {
            get { return new ComponentResourceKey(typeof(CustomResource), "ButtonTemplate"); }
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComponentResourceKey DataGridStyle3
        {
            get { return new ComponentResourceKey(typeof(CustomResource), "DataGridStyle3"); }
        }

    }
}
