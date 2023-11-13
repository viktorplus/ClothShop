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
        public MainGoodsList(Frame MainFrame, List<Goods> goods, string? startSortBy = null)
        {
            this.MainFrame = MainFrame;
            InitializeComponent();
            CBGenderSelector.Items.Add("Male");
            CBGenderSelector.Items.Add("Female");
            CBGenderSelector.Items.Add("Both");
            if (startSortBy != null)
            {
                List<Goods> gds = MainWindow.goodsList.goods.FindAll(x => x.gender == startSortBy).GroupBy(x => x.ItemId).Select(g => g.First()).ToList();
                LVMain.ItemsSource = gds;
            }
            else
            {
                LVMain.ItemsSource = goods;
            }
        }
        private void LVMain_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Content = new GoodInfo(MainFrame);
        }

        private void LVMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainWindow.goodsList.selectedGud = LVMain.SelectedItem as Goods;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (CBGenderSelector.Text != "")
            {
                List<Goods> gds = MainWindow.goodsList.goods.FindAll(x => x.gender == CBGenderSelector.Text).GroupBy(x => x.ItemId).Select(g => g.First()).ToList();
                MainFrame.Content = new MainGoodsList(MainFrame, gds);
            }
        }
    }
}
