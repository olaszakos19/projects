using Controls;
using Microsoft.VisualBasic.ApplicationServices;
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
using User = Models.User;
using Microsoft.VisualBasic.Logging;
using AdminControls;
using AdminControls.Parkinglots;
using Controls.AdminControls.ReserVation;
using Controls.AdminControls;
using Controls.AdminControls.Vehicles;
using AdminControls.Vehicles;
using AdminControls.Users;


namespace beadando_F0E7UK
{
    public partial class AdminMenu : Form
    {
        User currentUser = new();
        public AdminMenu(User user)
        {
            InitializeComponent();
            currentUser = user;

        }

        public void LoadControl(UserControl control)
        {
            panel1.Controls.Clear();
            int x = (panel1.Width - control.Width) / 2;
            int y = (panel1.Height - control.Height) / 2;
            control.Location = new Point(x, y);
            control.Location = new Point(x, y);
            panel1.Controls.Add(control);
        }

        private void újFelvételeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            LoadControl(addUser);
        }

        private void jelenlegiekMegtekintéseToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            UserList userList = new UserList();
            LoadControl(userList);
        }

        private void profilomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(currentUser);
            LoadControl(profile);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AdminAddCar adminAddCar = new AdminAddCar();
            LoadControl(adminAddCar);
        }

        private void újHozzáaádsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddParkinglot addParkinglot = new AddParkinglot();
            LoadControl(addParkinglot);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AdminCarList adminCarList = new AdminCarList();
            LoadControl(adminCarList);
        }

        private void jelenlegiekMegtekintéseToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ParkinglotList parkinglotList = new ParkinglotList();
            LoadControl(parkinglotList);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            AdminReservationList reservationList = new AdminReservationList();
            LoadControl(reservationList);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            AdminAddReservation addReservation = new AdminAddReservation();
            LoadControl(addReservation);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }



        private void bevételMegtekintéseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RevenuePage revenuePage = new RevenuePage();
            LoadControl(revenuePage);
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            LoadControl(dashboard);
        }

        private void kitiltásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanVehiclePage banVehicle = new BanVehiclePage();
            LoadControl(banVehicle);
        }
    }
}
