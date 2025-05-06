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

namespace Controls.AdminControls.ReserVation
{
    public partial class AdminReservationList : UserControl
    {
        ParkingHandler parkingHandler = new();
        ReservationHandler reserHandler = new();
        Reservation selectedR;
        public AdminReservationList()
        {
            InitializeComponent();
        }

        private void fillcombo()
        {
            foreach (var p in parkingHandler.GettAllParkingLot())
            {
                listBox1.Items.Add(p);
            }
        }

        private void fillVehicles(int lotId)
        {
            listBox2.Items.Clear();
            foreach (var r in reserHandler.GetReservationsByLotId(lotId).Where(r => r.isEnded() == false))
            {
                listBox2.Items.Add(r);
            }
        }


        private void AdminReservationList_Load(object sender, EventArgs e)
        {
            fillcombo();

        }

        public void LoadOccupancyPieChart(Parkinglot parkinglot, DateTime selectedDate)
        {



            int occupiedSpots = parkingHandler.GetOccupation(parkinglot, selectedDate);

            int freeSpots = parkinglot.Capacity - occupiedSpots;
            if (freeSpots < 0) { freeSpots = 0; }


            chartOccupancy.Series.Clear();
            chartOccupancy.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("PieArea");
            chartOccupancy.ChartAreas.Add(chartArea);

            Series series = new Series("Telítettség");
            series.ChartType = SeriesChartType.Pie;

            series.Points.AddXY("Foglalt", occupiedSpots);
            series.Points.AddXY("Szabad", freeSpots);

            chartOccupancy.Series.Add(series);

            series["PieLabelStyle"] = "Outside";
            series.IsValueShownAsLabel = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Parkinglot p)
            {
                lotNameTExt.Text = p.Name;
                LoadOccupancyPieChart(p, dateTimePicker1.Value);
                fillVehicles(p.Id);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBTn_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Parkinglot p)
            {
                LoadOccupancyPieChart(p, dateTimePicker1.Value);

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox2.SelectedItem is Reservation r) 
            {
                fromText.Text = r.StartDate.ToString();
                toText.Text = r.EndDate.ToString();
            }
        }
    }
}
