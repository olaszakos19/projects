using Data;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Controls
{
    public partial class Login : UserControl
    {
        public event EventHandler<User> LoginSuccessful;
        UserHandler handler = new UserHandler();

        public Login()
        {
            InitializeComponent();
            EnsureAdminExists();
        }

        private void EnsureAdminExists()
        {


            bool hasAdmin = handler.GetAllUsers().Where(u => u.isAdmin == true).Any();

            if (!hasAdmin)
            {
                // Létrehozunk egy alapértelmezett admint
                var admin = new User
                {
                    FirstName = "Admin",
                    LastName = "Admin",
                    Email = "admin@admin.com",
                    Password = "admin123", // Fontos: ez csak példa!
                    isAdmin = true
                };

                handler.AddUser(admin);

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = emailText.Text;
            string password = pswdText.Text;

            User user = handler.GetAllUsers().Where(u => u.Email == email).First();

            bool loginSuccess = handler.Login(user);

            if (loginSuccess)
            {
                MessageBox.Show("Sikeres bejelentkezés!");
                LoginSuccessful?.Invoke(this, user);
            }
            else
            {
                MessageBox.Show("Hibás email vagy jelszó!");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
