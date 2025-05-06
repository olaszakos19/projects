using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Models;

namespace AdminControls
{
    public partial class UserList : UserControl
    {
        UserHandler handler = new();
        VehicleHandler vehicleHandler = new VehicleHandler();
        
        public UserList()
        {
            InitializeComponent();
        }

        private void fillListbox() 
        {
            listBox1.Items.Clear();
            var users = handler.GetOnlyUsers();

            foreach (var user in users)
            {

                listBox1.Items.Add(user);
            }
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            fillListbox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is User selectedUser)
            {
                firstNameText.Text = selectedUser.FirstName;
                lastNameText.Text = selectedUser.LastName;
                emailText.Text = selectedUser.Email;
                passwordText.Text = selectedUser.Password;
                
                listBox2.Items.Clear();
                foreach(var vehichle in vehicleHandler.GetVehiclesByUserId(selectedUser.Id)) 
                { 
                listBox2.Items.Add(vehichle);
                }

            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is User selectedUser)
            {
                selectedUser.FirstName = firstNameText.Text;
                selectedUser.LastName = lastNameText.Text;
                emailText.Text = selectedUser.Email;
                passwordText.Text = selectedUser.Password;
                handler.UpdateUser(selectedUser);
            }
            fillListbox();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem is User selectedUser)
            {
                handler.RemoveUser(selectedUser);
            }
            fillListbox();

        }
    }
}
