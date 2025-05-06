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

namespace AdminControls.Parkinglots
{

    public partial class ParkinglotList : UserControl
    {
        BannedHandler bannedHandler = new();
        ParkingHandler parkingHandler = new ParkingHandler();
        Models.Parkinglot parkinglot = new();
        Banned banned = new();
        void fillListbox()
        {
            listBox1.Items.Clear();
            foreach (var p in parkingHandler.GettAllParkingLot())
            {
                listBox1.Items.Add(p);
            }
        }

        public ParkinglotList()
        {
            InitializeComponent();
            fillListbox();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem is Models.Parkinglot p) 
            { 
                p.Name = lotName.Text;
                p.Town = cityText.Text;
                p.Addres = addressText.Text;
                p.PostalCode = postalText.Text;
                p.Capacity = (int)cap.Value;
                p.HourlyRate = (int)rate.Value;

                string res = parkingHandler.UpdateParkinglot(p);
                MessageBox.Show(res);
                fillListbox();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Models.Parkinglot p)
            {
                top5.Items.Clear();
                //bannedList.Items.Clear();
                lotName.Text = p.Name;
                postalText.Text = p.PostalCode;
                cityText.Text = p.Town;
                addressText.Text = p.Addres;
                cap.Value = p.Capacity;
                rate.Value = p.HourlyRate;
                occupationText.Text = parkingHandler.GetOccupation(p,null)+"/"+p.Capacity;
               
                foreach(var t in parkingHandler.Top5(p)) 
                { 
                top5.Items.Add(t);
                }

                foreach(var b in bannedHandler.BannedVehiclesInLot(p)) 
                {
                    bannedList.Items.Add(b);
                }

            }
        }

        private void unbanBtn_Click(object sender, EventArgs e)
        {
            if (bannedList.SelectedItem is Banned b)
            {
                string result = bannedHandler.UnBanVehicle(b);
                MessageBox.Show(result);


                bannedList.Items.Remove(b);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Models.Parkinglot p)
            {
                string res = parkingHandler.RemoveParkinglot(p);
                MessageBox.Show(res);
                fillListbox();
            }
        }

        private void bannedList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
