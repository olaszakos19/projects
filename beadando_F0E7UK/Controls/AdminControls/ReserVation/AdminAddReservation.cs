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

namespace Controls.AdminControls.ReserVation
{
    public partial class AdminAddReservation : UserControl
    {
        ReservationHandler reservationHandler = new();
        VehicleHandler vehicleHandler = new();
        Reservation reservation = new();
        ParkingHandler parkingHandler = new();
        UserHandler userHandler = new();
        int lotID = 0;
        User selectedUser = new();
        string licenseplate = "";
        public AdminAddReservation()
        {
            InitializeComponent();
            
            fillParkingBox();
            fillUsercombo();

        }

        public void fillUsercombo()
        {
            foreach (User u in userHandler.GetOnlyUsers()) 
            { 
                userBox.Items.Add(u);
            }
        }

        public void fillParkingBox() 
        { 
            foreach(Parkinglot p in parkingHandler.GettAllParkingLot()) 
            { 
                parkingBox.Items.Add(p);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userBox.SelectedItem is User u)
            {
                selectedUser = u;
                foreach(var v in vehicleHandler.GetVehiclesByUserId(selectedUser.Id)) 
                { 
                    vehicleBox.Items.Add(v);
                }
            }
        }

        private void spotsBox_SelectedIndexChanged(object sender, EventArgs e)
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

                for (int i = 0; i < p.Capacity; i++)
                {
                    spotsBox.Items.Add((int)i + 1);
                }

            }
        }

        private void myCarBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(vehicleBox.SelectedItem is Vehicle v) 
            { 
                licenseplate = v.LicensePlate;
                licenseText.Text = licenseplate;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            
            if (parkingBox.SelectedItem is Parkinglot p)
            {
                Reservation r = new Reservation
                {
                    StartDate = startDate.Value,
                    EndDate = endDate.Value,
                    //Licenseplate = licenseplate,
                    SpotNumber = (int)spotsBox.SelectedItem,
                    LotId = lotID,


                };

                if ((r.EndDate - r.StartDate).TotalHours > 3)
                {
                    MessageBox.Show("Figyelem: 3 óránál hosszabb parkolás!");
                }


                string res = reservationHandler.AddReservation(r);
                MessageBox.Show(res);
            }
            
        }

        private void AddReservation_Load(object sender, EventArgs e)
        {

        }
    }
}
