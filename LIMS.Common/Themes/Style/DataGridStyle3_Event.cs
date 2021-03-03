using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LIMS.Common.Themes.Style
{
    public partial class DataGridStyle3_Event: ResourceDictionary
    {
        /// <summary>
        /// 设置行序号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datagrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header= e.Row.GetIndex() + 1;
        }

        private void Row_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridRow row = sender as DataGridRow;
            row.Header = row.GetIndex() + 1;
        }
    }
}
