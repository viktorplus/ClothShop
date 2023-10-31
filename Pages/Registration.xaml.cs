﻿using System;
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
using WpfApp6.Pages;

namespace WpfApp6.Pages
{
    /// <summary>
    /// Логика взаимодействия для Registation.xaml
    /// </summary>
    public partial class Registation : UserControl
    {
        Frame MainFrame;

        public Registation(Frame mainframe)
        {
            InitializeComponent();
            this.MainFrame = mainframe;
        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;
            DateTime dateOfBirth = DateOfBirthPicker.SelectedDate ?? DateTime.MinValue;
            string address = AddressTextBox.Text;
            string phoneNumber = PhoneNumberTextBox.Text;

            User newUser = new User(firstName, lastName, email, password, dateOfBirth, address, phoneNumber);
            MainWindow.userList.AddUser(newUser);

            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            EmailTextBox.Clear();
            PasswordBox.Clear();
            DateOfBirthPicker.SelectedDate = null;
            AddressTextBox.Clear();
            PhoneNumberTextBox.Clear();

            if (MessageBox.Show("Registration Complete. Get Login.", "Confirmation", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                MainFrame.Content = new Login(MainFrame);
            }
            else
            {
                //NavigatorObject.Switch(new Catalog());
                MainFrame.Content = new MainList(MainFrame);
            }
        }
    }
}
