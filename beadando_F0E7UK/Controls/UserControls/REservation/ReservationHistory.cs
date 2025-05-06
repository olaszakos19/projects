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
        VehicleHandler vehicleHandler = new();
        ReservationHandler reservationHandler = new ReservationHandler();
        ParkingHandler parkingHandler = new ParkingHandler();
        User currentUser = new();
        private List<Reservation> allReservations = new();

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

            allReservations = reservationHandler
                .GetReservationByUserId(currentUser)
                .Where(r => r.isEnded())
                .ToList();

            ApplyFilters();
        }

        private void ApplyFilters()
        {
            dataGridView1.Rows.Clear();
            var filtered = allReservations.AsEnumerable();

            // Parkoló szűrés
            if (parkingBox.SelectedItem is Parkinglot selectedLot)
            {
                filtered = filtered.Where(r => r.LotId == selectedLot.Id);
            }

            // Rendszám szűrés
            if (vehcleBox.SelectedItem is string selectedPlate && !string.IsNullOrWhiteSpace(selectedPlate))
            {
                filtered = filtered.Where(r => r.LicensePlate == selectedPlate);
            }

            // Dátum szűrés (pl. startDate után)
            if (datePick.Checked)
            {
                DateTime selectedDate = datePick.Value.Date;
                filtered = filtered.Where(r => r.StartDate.Date >= selectedDate);
            }

            // Grid feltöltése
            foreach (var res in filtered)
            {
                var lot = parkingHandler.GettAllParkingLot().FirstOrDefault(p => p.Id == res.LotId);
                dataGridView1.Rows.Add(
                    res.StartDate.ToString("yyyy-MM-dd HH:mm"),
                    res.EndDate.ToString("yyyy-MM-dd HH:mm"),
                    lot?.Name ?? "Ismeretlen",
                    res.LicensePlate
                );
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ReservationHistory_Load(object sender, EventArgs e)
        {
            fillDatagrid();
            foreach (var v in vehicleHandler.GetVehiclesByUserId(currentUser.Id))
            {
                vehcleBox.Items.Add(v.LicensePlate);
            }

            foreach (var p in parkingHandler.GettAllParkingLot())
            {
                parkingBox.Items.Add(p);
            }
        }
    }
}
