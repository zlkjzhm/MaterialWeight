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

namespace MaterialWeight
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //定义一个列表集合,设置给listview的数据源
            List<WaterCollector> s = new List<WaterCollector>();
            for (int i = 0; i < 20; i++)
            {
                s.Add(new WaterCollector { BendingPlate = new BendingPlate { _typeName = i.ToString() } });
            }
            specificationslist.ItemsSource = s;
        }

        //private void specificationslist_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        //{
        //    //取当前选中的一行,此行数据你原来绑定的是什么类型还是什么类型
        //    WaterCollector hl = specificationslist.SelectedItem as WaterCollector;
        //    MessageBox.Show(hl.BendingPlate);
        //}

        private void testButton60(object sender, MouseButtonEventArgs e)
        {
            WaterCollector hl = specificationslist.SelectedItem as WaterCollector;
            MessageBox.Show(hl.PlateDensity.ToString());
        }

    }
}
//数据库