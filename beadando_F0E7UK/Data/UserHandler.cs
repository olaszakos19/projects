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
        private readonly DataContext _context;

        public UserHandler(DataContext context)
        {
            _context = context;
        }

        public UserHandler()
        {
            _context = new DataContext();
        }

        public string AddUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }


            _context.Users.Add(user);
            _context.SaveChanges();
            return "User added succesfully";
        }

        public string RemoveUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

          
            _context.Users.Remove(user);
            _context.SaveChanges();
            return "User deleted succesfully";
        }

        public string UpdateUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            
            var cust = _context.Users.FirstOrDefault(u => u.Id == user.Id);

            if (cust == null)
            {
                return "User not found";
            }

            cust.FirstName = user.FirstName;
            cust.LastName = user.LastName;
            cust.Email = user.Email;
            cust.Password = user.Password;

            _context.SaveChanges();
            return "User updated succesfully";
        }

        public List<User> GetOnlyUsers()
        {
         
            return _context.Users.Where(u => u.isAdmin == false).ToList();
        }

        public List<User> GetAllUsers()
        {
           
            return _context.Users.ToList();
        }

        public User GetUserById(int id)
        {
            if (id == null)
            {
                throw new ArgumentException(nameof(id));
            }

            
            return _context.Users.FirstOrDefault(c => c.Id == id);
        }


        /// <summary>
        /// Check creditentials if correct then true ,othwerise false
        /// </summary>
        public bool Login(User user)
        {
        

            var usr = _context.Users.FirstOrDefault(u => u.Email == user.Email);

            if (usr == null)
            {
                return false;
            }



            return usr.Password == user.Password;
        }



    }
}
