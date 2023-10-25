using System;
using System.ComponentModel;

namespace WpfApp6.Domain
{
    public class User : INotifyPropertyChanged
    {
        private string _firstname;
        private string _lastname;
        private string _email;
        private string _password;
        private DateTime _dateofbirth;
        private string _address;
        private string _phonenumber;


        public User(string firstName, string lastName, string email, string password, DateTime dateOfBirth, string address, string phoneNumber)
        {
            _firstname = firstName;
            _lastname = lastName;
            _email = email;
            _password = password;
            _dateofbirth = dateOfBirth;
            _address = address;
            _phonenumber = phoneNumber;
        }
        public string FirstName
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }
        public string LastName
        {
            get { return _lastname; }
            set
            {
                _lastname = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public DateTime Dateofbirth
        {
            get { return _dateofbirth; }
            set
            {
                _dateofbirth = value;
                OnPropertyChanged(nameof(Dateofbirth));
            }
        }
        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

        public string Phonenumber
        {
            get { return _phonenumber; }
            set
            {
                _phonenumber = value;
                OnPropertyChanged(nameof(Phonenumber));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
