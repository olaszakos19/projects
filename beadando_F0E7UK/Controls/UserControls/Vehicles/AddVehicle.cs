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

namespace Controls.UserControls.Vehicles
{
    
    public partial class AddVehicle : UserControl
    {
        VehicleHandler vehicleHandler = new VehicleHandler();
        Vehicle vehicle = new();
        int userId = 0;
        public AddVehicle(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vehicle.LicensePlate = licenseBox.Text;
            vehicle.Brand = brandBox.Text;
            vehicle.Type = typeBox.Text;
            vehicle.Color = colorBox.Text;
            vehicle.UserId = userId;
            string res = vehicleHandler.AddVehicle(vehicle);
            MessageBox.Show(res);
            
            
        }
    }
}
