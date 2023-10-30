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
    /// Логика взаимодействия для GoodInfo.xaml
    /// </summary>
    public partial class GoodInfo : UserControl
    {
        public GoodInfo()
        {
            InitializeComponent();
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(MainWindow.goodList.selectedGud?.photo ?? @"https://t4.ftcdn.net/jpg/04/20/44/43/360_F_420444334_ZYBSR9hxn92eruuPj9kHqObfQmxFMmlm.jpg");
            image.EndInit();
            Image myImage = new Image();
            myImage.Source = image;
            SPTitle.Children.Add(myImage);
        }
    }
}
