using System;
using System.Windows;
using WpfApp6.Domain;

namespace WpfApp6
{
    public partial class Registration : Window
    {
        private UserList userList;
        public Registration(UserList userList)
        {
            InitializeComponent();

            this.userList = userList;
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
            userList.AddUser(newUser);

            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            EmailTextBox.Clear();
            PasswordBox.Clear();
            DateOfBirthPicker.SelectedDate = null;
            AddressTextBox.Clear();
            PhoneNumberTextBox.Clear();
        }
    }
}
