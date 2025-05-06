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
using System.Xml.Linq;

namespace Controls.AdminControls.ReserVation
{
    public partial class RevenuePage : UserControl
    {
        ReservationHandler reservationHandler = new();
        ParkingHandler parkingHandler = new();
        public RevenuePage()
        {
            InitializeComponent();
            fillcombobox();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Parkoló neve és hónap";
            dataGridView1.Columns[1].Name = "Autók száma";
            dataGridView1.Columns[2].Name = "Összköltség (Ft)";


        }

        public void fillcombobox()
        {
            foreach (var p in parkingHandler.GettAllParkingLot())
            {
                comboBox1.Items.Add(p);
            }
        }

        private void fillDatagrid(Parkinglot p,DateTime d)
        {

            dataGridView1.Rows.Clear();

            var reservations = reservationHandler.GetReservationsByLotId(p.Id).Where(r => r.StartDate.Year == d.Year && r.StartDate.Month == d.Month);

            var groupedByMonth = reservations
                .GroupBy(r => new { Year = r.StartDate.Year, Month = r.StartDate.Month })
                .OrderBy(g => g.Key.Year).ThenBy(g => g.Key.Month);

            foreach (var group in groupedByMonth)
            {
                int totalVehicles = group.Count();
                double totalCost = 0;

                foreach (var res in group)
                {
                    if (res.EndDate != null)
                    {
                        double hours = (res.EndDate - res.StartDate).TotalHours;
                        totalCost += hours * p.HourlyRate;
                    }
                    else
                    {
                        double hours = (DateTime.Now - res.StartDate).TotalHours;
                        totalCost += hours * p.HourlyRate;
                    }
                }

                string monthName = new DateTime(group.Key.Year, group.Key.Month, 1).ToString("yyyy MMMM");

                dataGridView1.Rows.Add($"{p.Name} - {monthName}", totalVehicles, totalCost.ToString("F2") + " Ft");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Parkinglot p)
            {
                fillDatagrid(p,monthBox.Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is not Parkinglot selectedParkinglot)
            {
                MessageBox.Show("Kérlek válassz ki egy parkolót a listából!");
                return;
            }



            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";
            openFileDialog.Title = "Válassz egy fájlt a bevétel mentéséhez";
            openFileDialog.CheckFileExists = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;


                    reservationHandler.ExportRevenue(filePath, monthBox.Value.Month);

                    MessageBox.Show("Bevétel sikeresen exportálva!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba történt az exportálás során: {ex.Message}");
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Parkinglot p)
            {
                fillDatagrid(p, monthBox.Value);
            }
        }
    }
}
