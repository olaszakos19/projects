using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls.AdminControls
{
    public partial class AdminDashboard : UserControl
    {
        ParkingHandler parkingHandler = new();
        UserHandler userHandler = new();
        VehicleHandler vehicleHandler = new();
        ReservationHandler reservationHandler = new();
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            int pCount = parkingHandler.GettAllParkingLot().Count;
            int uCount = userHandler.GetOnlyUsers().Count;
            int vCount = vehicleHandler.GetAllVehicle().Count;

            userCount.Text = uCount+" db";
            parkingCount.Text = pCount + " db";
            totalVhicle.Text = vCount+" db";

            //int rCount = reservationHandler.
        }
    }
}
