using Controls;
using Data;
using Models;

namespace beadando_F0E7UK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Login login = new Login();
            Register register = new Register();
            int x = (panel1.Width - login.Width) / 2;
            int y = (panel1.Height - login.Height) / 2;
            login.Location = new Point(x, y);
            login.Location = new Point(x, y);
            login.LoginSuccessful += Login_LoginSuccessful;
            panel1.Controls.Add(login);
            
            /*
             Ide kellene majd egy automata admin generálás
             */

        }

        private void Login_LoginSuccessful(object sender, User user)
        {
            
            if (user.isAdmin == true)
            {
                AdminMenu adminMenu = new AdminMenu(user);
                adminMenu.Show();
            }
            else 
            {
                Menu menu = new Menu(user);
                menu.Show();
            }

            //this.Hide();
        }
    }
}
