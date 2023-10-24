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

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserList userList;
        GoodsList list;
        ShowGood? showGood = null;
        public MainWindow()
        {

            userList = new UserList();
            list = new GoodsList();
            list.AddGud(new Goods(1,@"https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSzxBQ-k5CztX5ZIW9oMuEJUeduLMz87oDEpsFPG3a2M5ZOHnW6A0q2pIp3S0iz2xUeql4yyXewo51NPZz52i4wL9IRwLgwREE50VDH6IsM&usqp=CAE", "Skirt", "Super cute skirt", "Black", "XL", 4, 100.99f, DateTime.Now));
            list.AddGud(new Goods(1,@"https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSzxBQ-k5CztX5ZIW9oMuEJUeduLMz87oDEpsFPG3a2M5ZOHnW6A0q2pIp3S0iz2xUeql4yyXewo51NPZz52i4wL9IRwLgwREE50VDH6IsM&usqp=CAE", "Skirt", "Super cute skirt", "Black", "XL", 4, 100.99f, DateTime.Now));
            list.AddGud(new Goods(1,@"https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSzxBQ-k5CztX5ZIW9oMuEJUeduLMz87oDEpsFPG3a2M5ZOHnW6A0q2pIp3S0iz2xUeql4yyXewo51NPZz52i4wL9IRwLgwREE50VDH6IsM&usqp=CAE", "Skirt", "Super cute skirt", "Black", "XL", 4, 100.99f, DateTime.Now));
            list.AddGud(new Goods(1,@"https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSzxBQ-k5CztX5ZIW9oMuEJUeduLMz87oDEpsFPG3a2M5ZOHnW6A0q2pIp3S0iz2xUeql4yyXewo51NPZz52i4wL9IRwLgwREE50VDH6IsM&usqp=CAE", "Skirt", "Super cute skirt", "Black", "XL", 4, 100.99f, DateTime.Now));
            list.AddGud(new Goods(1,@"https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSzxBQ-k5CztX5ZIW9oMuEJUeduLMz87oDEpsFPG3a2M5ZOHnW6A0q2pIp3S0iz2xUeql4yyXewo51NPZz52i4wL9IRwLgwREE50VDH6IsM&usqp=CAE", "Skirt", "Super cute skirt", "Black", "XL", 4, 100.99f, DateTime.Now));
            list.AddGud(new Goods(1,@"https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSzxBQ-k5CztX5ZIW9oMuEJUeduLMz87oDEpsFPG3a2M5ZOHnW6A0q2pIp3S0iz2xUeql4yyXewo51NPZz52i4wL9IRwLgwREE50VDH6IsM&usqp=CAE", "Skirt", "Super cute skirt", "Black", "XL", 4, 100.99f, DateTime.Now));
            list.AddGud(new Goods(1,@"https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSzxBQ-k5CztX5ZIW9oMuEJUeduLMz87oDEpsFPG3a2M5ZOHnW6A0q2pIp3S0iz2xUeql4yyXewo51NPZz52i4wL9IRwLgwREE50VDH6IsM&usqp=CAE", "Skirt", "Super cute skirt", "Black", "XL", 4, 100.99f, DateTime.Now));
            list.AddGud(new Goods(1,@"https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSzxBQ-k5CztX5ZIW9oMuEJUeduLMz87oDEpsFPG3a2M5ZOHnW6A0q2pIp3S0iz2xUeql4yyXewo51NPZz52i4wL9IRwLgwREE50VDH6IsM&usqp=CAE", "Skirt", "Super cute skirt", "Black", "XL", 4, 100.99f, DateTime.Now));
            list.AddGud(new Goods(1, @"https://content.rozetka.com.ua/goods/images/big/355902578.jpg", "Skirt", "Super cute skirt", "Black", "XL", 4, 99.99f, DateTime.Now));
            list.AddGud(new Goods(1, @"https://content.rozetka.com.ua/goods/images/big/355902578.jpg", "Skirt", "Super cute skirt", "Black", "XL", 4, 99.99f, DateTime.Now));
            list.AddGud(new Goods(1, @"https://content.rozetka.com.ua/goods/images/big/355902578.jpg", "Skirt", "Super cute skirt", "Black", "XL", 4, 99.99f, DateTime.Now));
            list.AddGud(new Goods(1, @"https://content.rozetka.com.ua/goods/images/big/355902578.jpg", "Skirt", "Super cute skirt", "Black", "XL", 4, 99.99f, DateTime.Now));
            list.AddGud(new Goods(1, @"https://content.rozetka.com.ua/goods/images/big/355902578.jpg", "Skirt", "Super cute skirt", "Black", "XL", 4, 99.99f, DateTime.Now));
            InitializeComponent();
            LVMain.ItemsSource = list.goods;
        }

        private void Registere_Click(object sender, RoutedEventArgs e)
        {
            Registration registrationPage = new Registration(userList); 
            NavigationFrame.Navigate(registrationPage);
        }



        private void LVMain_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (showGood != null && showGood.selectedGud != null) { showGood.Hide(); showGood.Show(); }
        }

        private void LVMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var sel = LVMain.SelectedItem;
            try
            {
                if(showGood!=null) showGood.Close();
                showGood = new ShowGood(sel as Goods);
            }
            catch
            {
                showGood = null;
                MessageBox.Show("Error with selection!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
