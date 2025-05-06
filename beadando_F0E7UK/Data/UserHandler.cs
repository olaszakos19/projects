using Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UserHandler
    {
        public string AddUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            using var context = new DataContext();
            context.Users.Add(user);
            context.SaveChanges();
            return "User added succesfully";
        }

        public string RemoveUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            using var context = new DataContext();
            context.Users.Remove(user);
            context.SaveChanges();
            return "User deleted succesfully";
        }

        public  string UpdateUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            using var context = new DataContext();
            var cust = context.Users.FirstOrDefault(u => u.Id == user.Id);

            if (cust == null)
            {
                return "User not found";
            }

            cust.FirstName = user.FirstName;
            cust.LastName = user.LastName;
            cust.Email = user.Email;
            cust.Password = user.Password;

            context.SaveChanges();
            return "User updated succesfully";
        }

        public  List<User> GetOnlyUsers()
        {
            using var context = new DataContext();
            return context.Users.Where(u => u.isAdmin == false).ToList();
        }

        public List<User> GetAllUsers()
        {
            using var context = new DataContext();
            return context.Users.ToList();
        }

        public  User GetUserById(int id)
        {
            if (id == null)
            {
                throw new ArgumentException(nameof(id));
            }

            using var context = new DataContext();
            return context.Users.FirstOrDefault(c => c.Id == id);
        }


        /// <summary>
        /// Check creditentials if correct then true ,othwerise false
        /// </summary>
        public bool Login(User user)
        {
            using var context = new DataContext();

            var usr = context.Users.FirstOrDefault(u => u.Email == user.Email);

            if (usr == null)
            {
                return false; 
            }

            

            return usr.Password == user.Password;
        }



    }
}
