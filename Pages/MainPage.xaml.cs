using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
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
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : UserControl
    {
        public Catalog()
        {
            InitializeComponent();

            MainFrame.Content = new MainList(MainFrame);
        }

        private void Cart_Click(object sender, RoutedEventArgs e)
        {

            if (MainFrame.Content.GetType() != typeof(Cart))
            {
                MainFrame.Content = new Cart();
            }
        }

        private void Catalog_Click(object sender, RoutedEventArgs e)
        {
            if(MainFrame.Content.GetType()!=typeof(MainList))
            {
                MainFrame.Content = new MainList(MainFrame);
            }
        }

        private void Checkout_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.Content.GetType() != typeof(Checkout))
            {
                MainFrame.Content = new Checkout();
            }
        }

        private void GoodInfo_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.Content.GetType() != typeof(GoodInfo))
            {
                MainFrame.Content = new GoodInfo();
            }
        }

        private void UserInfo_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.Content.GetType() != typeof(UserInfo))
            {
                MainFrame.Content = new UserInfo();
            }
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.Content.GetType() != typeof(Login))
            {
                MainFrame.Content = new Login();
            }
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.Content.GetType() != typeof(Registation))
            {
                MainFrame.Content = new Registation(MainFrame);
            }
        }

        private void StartPage_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.Content.GetType() != typeof(StartPage))
            {
                MainFrame.Content = new StartPage();
            }
        }
    }

}
