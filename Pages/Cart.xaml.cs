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
    /// Логика взаимодействия для Cart.xaml
    /// </summary>
    public partial class Cart : UserControl
    {
        Frame mainFrame;
        public Cart(Frame mainFrame)
        {
            InitializeComponent();
            if (MainWindow.CurrentUser != null)
            {
                LVCart.ItemsSource = MainWindow.CurrentUser.cart.goods;
                float sum = 0;
                foreach (var item in MainWindow.CurrentUser.cart.goods)
                {
                    sum += item.price;
                }
                LCost.Content = Math.Round(sum, 2) + " $";
            }

            this.mainFrame = mainFrame;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.CurrentUser != null)
            {
                MainWindow.CurrentUser.cart.goods.Clear();
                mainFrame.Content = new Cart(mainFrame);
            }
        }
    }
}
