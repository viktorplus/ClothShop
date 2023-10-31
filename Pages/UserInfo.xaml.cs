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

namespace WpfApp6.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserInfo.xaml
    /// </summary>
    public partial class UserInfo : UserControl
    {
        Frame MainFrame;
        private User currentUser;

        public UserInfo(Frame mainFrame, User user)
        {
            InitializeComponent();
            MainFrame = mainFrame;
            currentUser = user; // Получаем текущего пользователя из параметров
            // Устанавливаем currentUser как контекст данных для страницы
            DataContext = currentUser;
        }

    }
}
