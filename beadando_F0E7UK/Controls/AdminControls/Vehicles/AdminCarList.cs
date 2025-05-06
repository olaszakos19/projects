using Data;
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

namespace AdminControls.Vehicles
{
    public partial class AdminCarList : UserControl
    {
        VehicleHandler vehicleHandler = new();
        UserHandler userHandler = new();
        public AdminCarList()
        {
            InitializeComponent();



        }

        private void fillCombo()
        {
            ownerBox.Items.Clear();
            foreach (var u in userHandler.GetOnlyUsers())
            {
                ownerBox.Items.Add(u);
            }
        }

        private void fillListBox() 
        { 
            listBox1.Items.Clear();
            foreach(var v in vehicleHandler.GetAllVehicle()) 
            { 
            listBox1.Items.Add(v);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem is Vehicle v) 
            { 
                v.Owner = ownerBox.SelectedItem as User;
                v.LicensePlate = licensText.Text;
                v.Brand = brandText.Text;
                v.Type = typeText.Text;
                v.Color = colorText.Text;

                string res = vehicleHandler.UpdateVEhicle(v);
                MessageBox.Show(res);
                fillListBox();

            }
        }

        private void deleteBTn_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Vehicle v)
            {
                licensText.Text = v.LicensePlate;
                brandText.Text = v.Brand;
                typeText.Text = v.Type;
                colorText.Text = v.Color;
                ownerBox.SelectedItem = v.Owner;
            }
        }

        private void AdminCarList_Load(object sender, EventArgs e)
        {
            fillCombo();
            fillListBox();
        }
    }
}
