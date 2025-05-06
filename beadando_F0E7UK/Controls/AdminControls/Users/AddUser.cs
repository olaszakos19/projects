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

namespace AdminControls.Users
{
    public partial class AddUser : UserControl
    {
        UserHandler handler = new UserHandler();
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                Email = emmailText.Text,
                Password = passwordText.Text,
                isAdmin = isadmin.Checked,
            };


            string res = handler.AddUser(user);
            MessageBox.Show(res);
        }
    }
}
