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

namespace Controls.AdminControls.Vehicles
{
    public partial class BanVehiclePage : UserControl
    {
        ParkingHandler parkingHandler = new();
        BannedHandler bannedHandler = new();
        VehicleHandler vehicleHandler = new();

        public BanVehiclePage()
        {
            InitializeComponent();
        }

        private void fillComboBox()
        {
            foreach (var p in parkingHandler.GettAllParkingLot())
            {
                parkingBox.Items.Add(p);
            }
        }

        private void fillListBox()
        {
            foreach(var v in vehicleHandler.GetAllVehicle()) 
            { 
                vehicleBox.Items.Add(v);
            }
        }

        private void BanHammer_Click(object sender, EventArgs e)
        {
            if (vehicleBox.SelectedItem is Vehicle v && parkingBox.SelectedItem is Parkinglot p)
            {
                Banned b = new Banned()
                {
                    vehicle = v,
                    Reason = reasonBox.Text, 
                    parkinglot = p,
                };
                string res = bannedHandler.BanVehicle(b);
                MessageBox.Show(res);
            }
        }

        private void vehicleBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BanVehiclePage_Load(object sender, EventArgs e)
        {
            fillComboBox();
            fillListBox();
        }
    }
}
