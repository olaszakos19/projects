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

namespace AdminControls.Vehicles
{

    public partial class AdminAddCar : UserControl
    {
        VehicleHandler vehicleHandler = new();
        UserHandler userHandler = new();
        public AdminAddCar()
        {
            InitializeComponent();
        }

        private void fillcombo()
        {
            foreach (var u in userHandler.GetOnlyUsers())
            {
                comboBox1.Items.Add(u);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is User u)
            {
                Vehicle vehicle = new Vehicle()
                {
                    LicensePlate = licenseBox.Text,
                    Brand = brandBox.Text,
                    Type = typeBox.Text,
                    Color = colorBox.Text,
                    UserId = u.Id
                };
                string res = vehicleHandler.AddVehicle(vehicle);
                MessageBox.Show(res);
            }

        }

        private void licenseBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
