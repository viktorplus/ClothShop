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

        UserList userList;
        GoodsList list;
        //ShowGood? showGood = null;
        public Catalog()
        {
            userList = new UserList();
            list = new GoodsList();
            list.AddGud(new Goods(1, @"https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSzxBQ-k5CztX5ZIW9oMuEJUeduLMz87oDEpsFPG3a2M5ZOHnW6A0q2pIp3S0iz2xUeql4yyXewo51NPZz52i4wL9IRwLgwREE50VDH6IsM&usqp=CAE", "Skirt", "Super cute skirt", "Black", "XL", 4, 100.99f, DateTime.Now));
            list.AddGud(new Goods(1, @"https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSzxBQ-k5CztX5ZIW9oMuEJUeduLMz87oDEpsFPG3a2M5ZOHnW6A0q2pIp3S0iz2xUeql4yyXewo51NPZz52i4wL9IRwLgwREE50VDH6IsM&usqp=CAE", "Skirt", "Super cute skirt", "Black", "XL", 4, 100.99f, DateTime.Now));
            list.AddGud(new Goods(1, @"https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSzxBQ-k5CztX5ZIW9oMuEJUeduLMz87oDEpsFPG3a2M5ZOHnW6A0q2pIp3S0iz2xUeql4yyXewo51NPZz52i4wL9IRwLgwREE50VDH6IsM&usqp=CAE", "Skirt", "Super cute skirt", "Black", "XL", 4, 100.99f, DateTime.Now));
            list.AddGud(new Goods(1, @"https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSzxBQ-k5CztX5ZIW9oMuEJUeduLMz87oDEpsFPG3a2M5ZOHnW6A0q2pIp3S0iz2xUeql4yyXewo51NPZz52i4wL9IRwLgwREE50VDH6IsM&usqp=CAE", "Skirt", "Super cute skirt", "Black", "XL", 4, 100.99f, DateTime.Now));
            list.AddGud(new Goods(1, @"https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSzxBQ-k5CztX5ZIW9oMuEJUeduLMz87oDEpsFPG3a2M5ZOHnW6A0q2pIp3S0iz2xUeql4yyXewo51NPZz52i4wL9IRwLgwREE50VDH6IsM&usqp=CAE", "Skirt", "Super cute skirt", "Black", "XL", 4, 100.99f, DateTime.Now));
            list.AddGud(new Goods(1, @"https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSzxBQ-k5CztX5ZIW9oMuEJUeduLMz87oDEpsFPG3a2M5ZOHnW6A0q2pIp3S0iz2xUeql4yyXewo51NPZz52i4wL9IRwLgwREE50VDH6IsM&usqp=CAE", "Skirt", "Super cute skirt", "Black", "XL", 4, 100.99f, DateTime.Now));
            list.AddGud(new Goods(1, @"https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSzxBQ-k5CztX5ZIW9oMuEJUeduLMz87oDEpsFPG3a2M5ZOHnW6A0q2pIp3S0iz2xUeql4yyXewo51NPZz52i4wL9IRwLgwREE50VDH6IsM&usqp=CAE", "Skirt", "Super cute skirt", "Black", "XL", 4, 100.99f, DateTime.Now));
            list.AddGud(new Goods(1, @"https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSzxBQ-k5CztX5ZIW9oMuEJUeduLMz87oDEpsFPG3a2M5ZOHnW6A0q2pIp3S0iz2xUeql4yyXewo51NPZz52i4wL9IRwLgwREE50VDH6IsM&usqp=CAE", "Skirt", "Super cute skirt", "Black", "XL", 4, 100.99f, DateTime.Now));
            list.AddGud(new Goods(1, @"https://content.rozetka.com.ua/goods/images/big/355902578.jpg", "Skirt", "Super cute skirt", "Black", "XL", 4, 99.99f, DateTime.Now));
            list.AddGud(new Goods(1, @"https://content.rozetka.com.ua/goods/images/big/355902578.jpg", "Skirt", "Super cute skirt", "Black", "XL", 4, 99.99f, DateTime.Now));
            list.AddGud(new Goods(1, @"https://content.rozetka.com.ua/goods/images/big/355902578.jpg", "Skirt", "Super cute skirt", "Black", "XL", 4, 99.99f, DateTime.Now));
            list.AddGud(new Goods(1, @"https://content.rozetka.com.ua/goods/images/big/355902578.jpg", "Skirt", "Super cute skirt", "Black", "XL", 4, 99.99f, DateTime.Now));
            list.AddGud(new Goods(1, @"https://content.rozetka.com.ua/goods/images/big/355902578.jpg", "Skirt", "Super cute skirt", "Black", "XL", 4, 99.99f, DateTime.Now));
            InitializeComponent();
            LVMain.ItemsSource = list.goods;
        }


        private void LVMain_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //if (showGood != null && showGood.selectedGud != null) { showGood.Hide(); showGood.Show(); }
        }

        private void LVMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var sel = LVMain.SelectedItem;
            //try
            //{
            //    if (showGood != null) showGood.Close();
            //    showGood = new ShowGood(sel as Goods);
            //}
            //catch
            //{
            //    showGood = null;
            //    MessageBox.Show("Error with selection!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            //}
        }

        private void Cart_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new Cart());
        }

        private void Catalog_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new Catalog());
        }

        private void Checkout_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new Checkout());
        }

        private void GoodInfo_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new GoodInfo());
        }

        private void UserInfo_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new UserInfo());
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new Login());
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new Registation());
        }

        private void StartPage_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new Catalog());
        }
    }

}
