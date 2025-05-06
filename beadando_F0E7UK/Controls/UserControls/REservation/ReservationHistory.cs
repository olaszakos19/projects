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

namespace Controls.UserControls.REservation
{
    public partial class ReservationHistory : UserControl
    {
        ReservationHandler reservationHandler = new ReservationHandler();
        ParkingHandler parkingHandler = new ParkingHandler();
        User currentUser = new();

        public ReservationHistory(User user)
        {
            InitializeComponent();
            currentUser = user;
            dataGridView1.Columns.Add("startDate", "Kezdés");
            dataGridView1.Columns.Add("endDate", "Befejezés");
            dataGridView1.Columns.Add("parking", "Parkoló");
            dataGridView1.Columns.Add("plate", "Rendszám");

        }
        private void fillDatagrid()
        {
            dataGridView1.Rows.Clear();

            ReservationHandler reservationHandler = new ReservationHandler();
            var reservations = reservationHandler.GetReservationByUserId(currentUser).Where(r => r.isEnded() == true);
            
            foreach (var res in reservations)
            {
                dataGridView1.Rows.Add(
                    res.StartDate.ToString("yyyy-MM-dd HH:mm"),
                    res.EndDate.ToString("yyyy-MM-dd HH:mm"),
                    parkingHandler.GettAllParkingLot().First(p => p.Id == res.LotId),
                    res.LicensePlate
                );
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (parkingBox.SelectedItem is Parkinglot p)
            {

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (vehcleBox.SelectedItem is Vehicle v)
            {
                dataGridView1.Rows.Clear();

                ReservationHandler reservationHandler = new ReservationHandler();
                var reservations = reservationHandler.GetReservationByUserId(currentUser).Where(r => r.isEnded() == true).Where(rv => rv.LicensePlate.Equals(v.LicensePlate));

                foreach (var res in reservations)
                {
                    dataGridView1.Rows.Add(
                        res.StartDate.ToString("yyyy-MM-dd HH:mm"),
                        res.EndDate.ToString("yyyy-MM-dd HH:mm"),
                        parkingHandler.GettAllParkingLot().Where(p => p.Id == res.Id).First().Name,
                        res.LicensePlate
                    );
                }
            }
            */
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ReservationHistory_Load(object sender, EventArgs e)
        {
            fillDatagrid();
        }
    }
}
