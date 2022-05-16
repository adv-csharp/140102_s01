using Session01.DataSource;
using Session01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01.Services
{
    internal class UserService
    {
        public void AddUser(User user)
        {
            InMemeoryDb.Users.Add(user);
        }

        public User GetByIndex(int index)
        {
            return InMemeoryDb.Users[index];
        }

        public void DeleteByIndex(int index)
        {
            InMemeoryDb.Users.RemoveAt(index);
        }

        public void UpdateUser(User user, int index)
        {
            InMemeoryDb.Users[index] = user;
        }

        //public List<User> GetAllUsers()
        //{
        //    return InMemeoryDb.Users;
        //}

        public int Length { get => InMemeoryDb.Users.Count;}

    }
}
