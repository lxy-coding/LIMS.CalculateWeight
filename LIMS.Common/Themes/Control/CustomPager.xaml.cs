using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LIMS.Common.Themes.Control
{
    /// <summary>
    /// CustomPager.xaml 的交互逻辑
    /// </summary>
    public partial class CustomPager : UserControl
    {
        public CustomPager()
        {
            InitializeComponent();

        }

        private static void CopyDataRow(DataRow row,DataRow newRow)
        {
            foreach (DataColumn item in row.Table.Columns)
            {
                newRow[item.ColumnName] = row[item.ColumnName];
            }
        }

        #region 属性

        /// <summary>
        /// 原始数据源
        /// </summary>
        public object OriginalDataSource
        {
            get { return (object)GetValue(OriginalDataSourceProperty); }
            set { SetValue(OriginalDataSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OriginalDataSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OriginalDataSourceProperty =
            DependencyProperty.Register("OriginalDataSource", typeof(object), typeof(CustomPager), new PropertyMetadata(null, OriginalDataSourceChanged));


        private static void OriginalDataSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CustomPager pager = d as CustomPager;
            if (pager != null && e.NewValue != null)
            {
                if (e.NewValue is DataTable)
                {
                    DataTable dt = e.NewValue as DataTable;
                    pager.TotalPage = dt.Rows.Count % pager.CountPerPage == 0 ? dt.Rows.Count / pager.CountPerPage : dt.Rows.Count / pager.CountPerPage + 1;
                    pager.CurrentPage = 1;
                    DataRow[] rows = dt.Rows.Cast<DataRow>().Where(r => dt.Rows.IndexOf(r) >= (pager.CurrentPage - 1) * pager.CountPerPage &&
                          dt.Rows.IndexOf(r) < pager.CurrentPage * pager.CountPerPage).ToArray();
                    DataTable newDt = dt.Clone();
                    DataColumn column = new DataColumn();
                    column.ColumnName = "SerialNum";
                    newDt.Columns.Add(column);
                    foreach (DataRow row in rows)
                    {
                        DataRow newRow = newDt.NewRow();
                        CopyDataRow(row, newRow);
                        newRow["SerialNum"] = dt.Rows.IndexOf(row) + 1;
                        newDt.Rows.Add(newRow);
                    }
                    pager.PageDataSource = newDt.DefaultView;
                }
                else if (e.NewValue is ICollection)
                {
                    var lst = ((ICollection)e.NewValue).Cast<dynamic>();
                    pager.TotalPage = lst.Count() % pager.CountPerPage == 0 ? lst.Count() / pager.CountPerPage : lst.Count() / pager.CountPerPage + 1;
                    pager.CurrentPage = 1;
                    pager.PageDataSource = lst.Skip((pager.CurrentPage - 1) * pager.CountPerPage).Take(pager.CountPerPage);
                }
            }
        }


        /// <summary>
        /// 分页后的数据源
        /// </summary>
        public object PageDataSource
        {
            get { return (object)GetValue(PageDataSourceProperty); }
            set { SetValue(PageDataSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PageDataSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PageDataSourceProperty =
            DependencyProperty.Register("PageDataSource", typeof(object), typeof(CustomPager), new PropertyMetadata(null));



        /// <summary>
        /// 当前页码
        /// </summary>
        public int CurrentPage
        {
            get { return (int)GetValue(CurrentPageProperty); }
            set { SetValue(CurrentPageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentPage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register("CurrentPage", typeof(int), typeof(CustomPager), new PropertyMetadata(0));


        /// <summary>
        /// 总页码
        /// </summary>
        public int TotalPage
        {
            get { return (int)GetValue(TotalPageProperty); }
            set { SetValue(TotalPageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TotalPage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TotalPageProperty =
            DependencyProperty.Register("TotalPage", typeof(int), typeof(CustomPager), new PropertyMetadata(0));



        /// <summary>
        /// 每页显示条数
        /// </summary>
        public int CountPerPage
        {
            get { return (int)GetValue(CountPerPageProperty); }
            set { SetValue(CountPerPageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CountPerPage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CountPerPageProperty =
            DependencyProperty.Register("CountPerPage", typeof(int), typeof(CustomPager), new PropertyMetadata(3));


        #endregion

        #region 事件处理

        private void GetPageDataSource()
        {
            if (OriginalDataSource is DataTable)
            {
                DataTable dt = OriginalDataSource as DataTable;
                DataRow[] rows = dt.Rows.Cast<DataRow>().Where(r => dt.Rows.IndexOf(r) >= (CurrentPage - 1) * CountPerPage &&
                              dt.Rows.IndexOf(r) < CurrentPage * CountPerPage).ToArray();
                DataTable newDt = dt.Clone();
                DataColumn column = new DataColumn();
                column.ColumnName = "SerialNum";
                newDt.Columns.Add(column);
                foreach (DataRow row in rows)
                {
                    DataRow newRow = newDt.NewRow();
                    CopyDataRow(row, newRow);
                    newRow["SerialNum"] = dt.Rows.IndexOf(row)+1;
                    newDt.Rows.Add(newRow);
                }
                PageDataSource = newDt.DefaultView;
            }
            else if (OriginalDataSource is IList)
            {
                var lst = ((ICollection)OriginalDataSource).Cast<dynamic>();
                PageDataSource = lst.Skip((CurrentPage - 1) * CountPerPage).Take(CountPerPage);
            }
        }
        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstPageButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage = 1;
                GetPageDataSource();
            }
        }
        /// <summary>
        /// 前一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousPageButton_Click(object sender, RoutedEventArgs e)
        {
            if(CurrentPage>1)
            {
                CurrentPage--;
                GetPageDataSource();
            }
        }
        /// <summary>
        /// 后一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextPageButton_Click(object sender, RoutedEventArgs e)
        {
            if(CurrentPage<TotalPage)
            {
                CurrentPage++;
                GetPageDataSource();
            }
        }
        /// <summary>
        /// 尾页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LastPageButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentPage < TotalPage)
            {
                CurrentPage= TotalPage;
                GetPageDataSource();
            }
        }
        #endregion
    }
}
