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
    public partial class Profile : UserControl
    {
        UserHandler handler = new UserHandler();
        User User;
        public Profile(User user)
        {
            InitializeComponent();
            User = user;
            firstNameText.Text = user.FirstName;
            lastNameText.Text = user.LastName;
            emmailText.Text = user.Email; ;
            passwordText.Text = user.Password;
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            User.FirstName = firstNameText.Text;
            User.LastName = lastNameText.Text;
            User.Email = emmailText.Text;
            User.Password = passwordText.Text;
            handler.UpdateUser(User);
        }
    }
}
