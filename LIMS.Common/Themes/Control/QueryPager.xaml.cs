using System;
using System.Collections.Generic;
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
    /// QueryPager.xaml 的交互逻辑
    /// </summary>
    public partial class QueryPager : UserControl
    {
        public QueryPager()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 执行查询事件,参数1：跳过的条数  参数2：查询的条数
        /// </summary>
        public event Action<int, int> ExecuteQuery;

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
            DependencyProperty.Register("CurrentPage", typeof(int), typeof(QueryPager), new PropertyMetadata(0));

        /// <summary>
        /// 总条数
        /// </summary>
        public int TotalCount
        {
            get { return (int)GetValue(TotalCountProperty); }
            set { SetValue(TotalCountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TotalCount.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TotalCountProperty =
            DependencyProperty.Register("TotalCount", typeof(int), typeof(QueryPager), new PropertyMetadata(0, TotalCountChanged));

        private static void TotalCountChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            QueryPager u = d as QueryPager;
            int count = (int)e.NewValue;
            u.TotalPage = count % u.CountPerPage == 0 ? count / u.CountPerPage : count / u.CountPerPage + 1;
            if(u.TotalPage>0)
            {
                u.CurrentPage = 1;
                u.ExecuteQuery?.Invoke(u.CountPerPage * (u.CurrentPage - 1), u.CountPerPage);
            }
            else
            {
                u.CurrentPage = 0;
                u.ExecuteQuery?.Invoke(0, u.CountPerPage);
            }
        }


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
            DependencyProperty.Register("TotalPage", typeof(int), typeof(QueryPager), new PropertyMetadata(0));

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
            DependencyProperty.Register("CountPerPage", typeof(int), typeof(QueryPager), new PropertyMetadata(10));

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
                ExecuteQuery?.Invoke(CountPerPage* (CurrentPage-1), CountPerPage);
            }
        }
        /// <summary>
        /// 前一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousPageButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                ExecuteQuery?.Invoke(CountPerPage * (CurrentPage - 1), CountPerPage);
            }
        }
        /// <summary>
        /// 后一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextPageButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentPage < TotalPage)
            {
                CurrentPage++;
                ExecuteQuery?.Invoke(CountPerPage * (CurrentPage - 1), CountPerPage);
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
                CurrentPage = TotalPage;
                ExecuteQuery?.Invoke(CountPerPage * (CurrentPage - 1), CountPerPage);
            }
        }
    }
}
