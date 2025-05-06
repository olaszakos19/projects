using Controls;
using Controls.UserControls;
using Controls.UserControls.REservation;
using Controls.UserControls.Vehicles;
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

namespace beadando_F0E7UK
{
    public partial class Menu : Form
    {
        User currentUser = new();
        public Menu(User user)
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

        private void parkolásToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void addNewVehicle_Click(object sender, EventArgs e)
        {

            AddVehicle addCar = new AddVehicle(currentUser.Id);
            LoadControl(addCar);
        }

        private void ViewVehicles_Click(object sender, EventArgs e)
        {
            VehicleList vehicleList = new VehicleList(currentUser);
            LoadControl(vehicleList);
        }

        private void MyProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(currentUser);
            LoadControl(profile);
        }

        private void newReservationStart_Click(object sender, EventArgs e)
        {
            AddReservation addReservation = new AddReservation(currentUser);
            LoadControl(addReservation);
        }

        private void showMyReservations_Click(object sender, EventArgs e)
        {
            UserReservationList reservationList = new UserReservationList(currentUser);
            LoadControl(reservationList);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void parkolásiElőzményekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservationHistory reservationHistory = new ReservationHistory(currentUser);
            LoadControl(reservationHistory);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            UserDashboard dashboard = new UserDashboard(currentUser);
            LoadControl(dashboard);
        }
    }
}
