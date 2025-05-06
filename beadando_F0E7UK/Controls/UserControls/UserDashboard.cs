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
        ParkingHandler parkingHandler = new ParkingHandler();
        public UserDashboard(User user)
        {
            InitializeComponent();
            currentuser = user;
            endDate.MinDate = startDate.Value;
        }


        private void InitializeChart()
        {
            DateTime from = startDate.Value.Date;
            DateTime to = endDate.Value.Date;


            var reservations = reservationHandler.GetReservationByUserId(currentuser)
                .Where(r => r.EndDate.Date >= from && r.StartDate.Date <= to)
                .ToList();

            var costPerDay = new Dictionary<DateTime, decimal>();


            for (DateTime date = from; date <= to; date = date.AddDays(1))
            {
                costPerDay[date] = 0;
            }

            foreach (var reservation in reservations)
            {
                DateTime start = reservation.StartDate.Date;
                DateTime end = reservation.EndDate.Date;


                Parkinglot parkinglot = parkingHandler.GettAllParkingLot().Where(p => p.Id == reservation.LotId).First();

                decimal ratePerHour = parkinglot.HourlyRate;

                for (DateTime d = start; d <= end; d = d.AddDays(1))
                {
                    if (d >= from && d <= to)
                    {
                        DateTime dayStart = d;
                        DateTime dayEnd = d.AddDays(1);

                        DateTime resStart = reservation.StartDate > dayStart ? reservation.StartDate : dayStart;
                        DateTime resEnd = reservation.EndDate < dayEnd ? reservation.EndDate : dayEnd;

                        double hours = (resEnd - resStart).TotalHours;
                        if (hours < 0) hours = 0;

                        decimal cost = (decimal)Math.Ceiling(hours) * ratePerHour;
                        costPerDay[d] += cost;
                    }
                }
            }

       
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new ChartArea("MainArea"));

            var series = new Series("Napi költségek")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.DateTime,
                IsValueShownAsLabel = true
            };

            foreach (var kvp in costPerDay.OrderBy(x => x.Key))
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }

            chart1.Series.Add(series);

            var area = chart1.ChartAreas[0];
            area.AxisX.IntervalType = DateTimeIntervalType.Days;
            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Format = "yyyy-MM-dd";
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisX.Title = "Dátum";
            area.AxisY.Title = "Költség (Ft)";
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
