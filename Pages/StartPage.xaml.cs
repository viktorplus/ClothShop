﻿using System;
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
using WpfApp6.Navigator;

namespace WpfApp6.Pages
{
    /// <summary>
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : UserControl
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void BMale(object sender, RoutedEventArgs e)
        {

            NavigatorObject.Switch(new Catalog("Male"));
        }

        private void BBoth(object sender, RoutedEventArgs e)
        {

            NavigatorObject.Switch(new Catalog("Both"));
        }

        private void BFemale(object sender, RoutedEventArgs e)
        {

            NavigatorObject.Switch(new Catalog("Female"));
        }
    }
}
