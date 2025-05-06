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
using Microsoft.IdentityModel.Tokens;
using Models;

namespace Controls
{
    public partial class AddReservation : UserControl
    {
        VehicleHandler vehicleHandler = new();
        ReservationHandler reservationHandler = new();
        ParkingHandler parkingHandler = new();
        User currentUser = new();
        Vehicle selectedVehilce;
        Reservation newReservation = new();
        string licenseplate = "";
        int lotID = 0;

        public AddReservation(User user)
        {
            InitializeComponent();
            currentUser = user;
            foreach (var p in parkingHandler.GettAllParkingLot())
            {
                parkingBox.Items.Add(p);
            }

            foreach (var v in vehicleHandler.GetVehiclesByUserId(currentUser.Id))
            {
                myCarBox.Items.Add(v);
            }

            

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            
            if (parkingBox.SelectedItem is Parkinglot p)
            {

                newReservation.StartDate = startDate.Value;
                newReservation.EndDate = endDate.Value;
                newReservation.LicensePlate = selectedVehilce.LicensePlate;
                newReservation.SpotNumber = (int)spotsBox.SelectedItem;
                newReservation.LotId = lotID;
                
                   
               

                if ((newReservation.EndDate - newReservation.StartDate).TotalHours > 3) 
                { 
                    MessageBox.Show("Figyelem: 3 óránál hosszabb parkolás!");  
                }
                    

                string res = reservationHandler.AddReservation(newReservation);
                MessageBox.Show(res);
            }
            

        }

        private void AddReservation_Load(object sender, EventArgs e)
        {

        }

        private void parkingBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (parkingBox.SelectedItem is Parkinglot p)
            {
                spotsBox.Items.Clear();
                lotID = p.Id;
                postalText.Text = p.PostalCode;
                cityText.Text = p.Town;
                addressText.Text = p.Addres;
                rateText.Text = p.HourlyRate + "/Hour";

                for(int i = 0; i < p.Capacity; i++) 
                { 
                    spotsBox.Items.Add((int)i+1);
                }

            }
        }

        private void myCarBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (myCarBox.SelectedItem is Vehicle v)
            {
                licenseplate = v.LicensePlate;
                licenseText.Text = v.LicensePlate;
                selectedVehilce = v;
            }
        }

        private void cityText_Click(object sender, EventArgs e)
        {

        }
    }
}
