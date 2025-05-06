using Models;
using Data;

namespace Controls
{
    public partial class Register : UserControl
    {
        UserHandler handler = new UserHandler();
        
        public Register()
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
            isAdmin = true,
            };

            
            handler.AddUser(user);
            
        }
    }
}
