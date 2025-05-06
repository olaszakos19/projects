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

namespace Controls
{
    public partial class UserReservationList : UserControl
    {
        Reservation reservation = new();
        Parkinglot parkinglot = new();
        ReservationHandler reservationHandler = new();
        VehicleHandler vehicleHandler = new();
        ParkingHandler parkingHandler = new();
        User currentuser = new();
        private void fillListBox()
        {
            listBox1.Items.Clear();
        }

        private void fillCombo()
        {
            foreach(var p in parkingHandler.GettAllParkingLot()) 
            { 
                parkingLots.Items.Add(p);
            }
        }

        public UserReservationList(User user)
        {
            InitializeComponent();
            currentuser = user;
            fillCombo();
        }

        private void active_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void closed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Vehicle v) 
            {
                /*
                reservation = reservationHandler.GetReservationByLicenseplate(v.LicensePlate);
                DateTime start = reservation.StartDate;
                DateTime end = reservation.EndDate;

                double hourlyRate = parkinglot.HourlyRate;
                double hoursParked = (DateTime.Now - start).TotalHours; //amit eddig parkolt
                double totalParkingTime = (end - start).TotalHours; // amit összesen fog

                double totalCost = hoursParked * hourlyRate;

                startDate.Text = start.ToString();
                endDate.Text = end.ToString();
                hourRate.Text = hourlyRate.ToString();
                spotText.Text = reservation.SpotNumber.ToString();
                sum.Text = totalCost.ToString();
                */
            }

            if(listBox1.SelectedItem is Reservation r) 
            {
                DateTime start = r.StartDate;
                DateTime end = r.EndDate;
                startDate.Text = start.ToString();
                endDate.Text = end.ToString();
            }
        }

        private void parkingLots_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (parkingLots.SelectedItem is Parkinglot selectedParkinglot)
            {
                /*
                parkinglot = selectedParkinglot;
                listBox1.Items.Clear();
                foreach (var v in parkingHandler.GetVehiclesInLot(selectedParkinglot,currentuser)) 
                { 
                    listBox1.Items.Add(v);
                }
                */
                parkinglot = selectedParkinglot;
                listBox1.Items.Clear();
                foreach(var v in reservationHandler.GetReservationsByLotId(selectedParkinglot.Id).Where(r => r.isEnded() == false)) 
                { 
                    listBox1.Items.Add(v);
                }
            }
        }


        private void resetBtn_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            string res = reservationHandler.CloseREservationNow(reservation);
            MessageBox.Show(res);
        }
    }
}
