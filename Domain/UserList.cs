using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.Domain
{
    public class UserList
    {
        private List<User> users;

        public UserList()
        {
            users = new List<User>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void RemoveUser(User user)
        {
            users.Remove(user);
        }

        public List<User> GetAllUsers()
        {
            return users;
        }
    }
}
