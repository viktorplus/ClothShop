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

namespace WpfApp6.Pages
{
    /// <summary>
    /// Interaction logic for MainList.xaml
    /// </summary>
    public partial class MainGoodsList : UserControl
    {
        Frame MainFrame;
        public MainGoodsList(Frame MainFrame)
        {
            InitializeComponent();
            LVMain.ItemsSource = MainWindow.goodsList.goods;
            this.MainFrame = MainFrame;
        }
        private void LVMain_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void LVMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
