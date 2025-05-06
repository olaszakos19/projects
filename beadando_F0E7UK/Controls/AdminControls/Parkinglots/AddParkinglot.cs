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

namespace AdminControls.Parkinglots
{
    public partial class AddParkinglot : UserControl
    {
        ParkingHandler handler = new ParkingHandler();   
        public AddParkinglot()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Models.Parkinglot parkinglot = new Parkinglot 
            { 
                Name = nameText.Text,
                PostalCode = postalCodeText.Text,
                Town = cityText.Text,
                Addres = adressText.Text,
                Capacity = (int)capacityCount.Value,
                HourlyRate = (int)hourlyRate.Value,
            };

            string res = handler.AddParkinglot(parkinglot);
            MessageBox.Show(res);

        }
    }
}
