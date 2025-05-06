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
    public partial class VehicleList : UserControl
    {
        User currentUser = new();
        Vehicle vehicle;
        VehicleHandler vehicleHandler = new();

        void fillListbox() 
        {
            listBox1.Items.Clear();
            foreach (var vehicle in vehicleHandler.GetVehiclesByUserId(currentUser.Id))
            {
                listBox1.Items.Add(vehicle);
            }
        }

        public VehicleList(User user)
        {
            InitializeComponent();
            currentUser = user;

            fillListbox();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Vehicle v)
            {
                v.LicensePlate = licensText.Text;
                v.Brand = brandText.Text;
                v.Type = typeText.Text;
                v.Color = colorText.Text;
                string res = vehicleHandler.UpdateVEhicle(v);
                MessageBox.Show(res);
            }
            fillListbox();
        }

        private void deleteBTn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Vehicle v)
            {
                string res = vehicleHandler.RemoveVehicle(v);
                MessageBox.Show(res);
            }
            fillListbox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Vehicle selectedVehicle)
            {
                licensText.Text = selectedVehicle.LicensePlate;
                brandText.Text = selectedVehicle.Brand;
                typeText.Text = selectedVehicle.Type;
                colorText.Text = selectedVehicle.Color;
            }
        }
    }
}
