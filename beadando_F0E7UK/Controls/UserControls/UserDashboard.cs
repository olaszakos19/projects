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
using System.Windows.Forms.DataVisualization.Charting;

namespace Controls.UserControls
{
    public partial class UserDashboard : UserControl
    {
        User currentuser = new();
        ReservationHandler reservationHandler = new ReservationHandler();
        VehicleHandler vehicleHandler = new VehicleHandler();
        public UserDashboard(User user)
        {
            InitializeComponent();
            currentuser = user;
            InitializeChart();
        }


        private void InitializeChart()
        {
            DateTime from = startDate.Value.Date;
            DateTime to = endDate.Value.Date.Date;

            // Biztonság kedvéért: ha fordítva választotta ki a dátumokat
            if (from > to)
            {
                var temp = from;
                from = to;
                to = temp;
            }

            

            // Lekérjük a foglalásokat
            var reservations = reservationHandler.GetReservationByUserId(currentuser)
                .Where(r => r.StartDate <= to && r.EndDate >= from)
                .ToList();

            decimal ratePerHour = 500;

            // Napokra lebontva számoljuk a költségeket
            var costPerDay = new Dictionary<DateTime, decimal>();

            for (DateTime date = from; date <= to; date = date.AddDays(1))
            {
                costPerDay[date] = 0;
            }

            foreach (var reservation in reservations)
            {
                DateTime start = reservation.StartDate.Date;
                DateTime end = reservation.EndDate.Date;

                for (DateTime d = start; d <= end; d = d.AddDays(1))
                {
                    if (d >= from && d <= to)
                    {
                        // Az adott napra eső órák kiszámítása
                        DateTime dayStart = d;
                        DateTime dayEnd = d.AddDays(1);

                        DateTime resStart = reservation.StartDate > dayStart ? reservation.StartDate : dayStart;
                        DateTime resEnd = reservation.EndDate < dayEnd ? reservation.EndDate : dayEnd;

                        double hours = (resEnd - resStart).TotalHours;
                        decimal cost = (decimal)Math.Ceiling(hours) * ratePerHour;

                        costPerDay[d] += cost;
                    }
                }
            }

            // Chart kirajzolása
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new ChartArea("MainArea"));

            var series = new Series("Napi költségek")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.Date
            };

            foreach (var kvp in costPerDay.OrderBy(x => x.Key))
            {
                series.Points.AddXY(kvp.Key.ToString("yyyy-MM-dd"), kvp.Value);
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "Dátum";
            chart1.ChartAreas[0].AxisY.Title = "Költség (Ft)";
        }







        private void UserDashboard_Load(object sender, EventArgs e)
        {
            InitializeChart();
            
            int totalVehicle = vehicleHandler.GetVehiclesByUserId(currentuser.Id).Count();
            int totalReservation = reservationHandler.GetReservationByUserId(currentuser).Where(r => r.EndDate < DateTime.Now).Count();

            rCount.Text = totalReservation + " db";
            vCount.Text = totalVehicle + "db";



            

        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            InitializeChart();

        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            InitializeChart();

        }
    }
}
