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
using WpfApp6.Domain;
using WpfApp6.Navigator;


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
            this.MainFrame = MainFrame;
            InitializeComponent();
            LVMain.ItemsSource = MainWindow.goodList.DistinctGoods();
        }
        private void LVMain_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Content = new GoodInfo();
        }

        private void LVMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainWindow.goodList.selectedGud = LVMain.SelectedItem as Goods;
        }
    }
}
