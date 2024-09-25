using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace projekt_manager
{
    public partial class jelenlegiMunkatarsak : UserControl
    {

        List<string[]> ceoCollection = new List<string[]>();
        List<string[]> employeeCollection = new List<string[]>();
        List<string[]> adminCollection = new List<string[]>();
        public jelenlegiMunkatarsak()
        {
            InitializeComponent();

        }


        private void loadCEOCollection(string s)
        {
            if (ceoCollection.Count() > 0) { ceoCollection.Clear(); }
            foreach (string[] an in X.lekerdez(s))
            {
                ceoCollection.Add(an);
            }
        }
        private void loadEmployeeCollection(string s)
        {
            if (employeeCollection.Count() > 0) { employeeCollection.Clear(); }
            foreach (string[] an in X.lekerdez(s))
            {
                employeeCollection.Add(an);
            }
        }
        private void loadAdminCollection(string s)
        {
            if (adminCollection.Count() > 0) { adminCollection.Clear(); }
            foreach (string[] an in X.lekerdez(s))
            {
                adminCollection.Add(an);
            }
        }
        private void loadCEOList(List<string[]> li)
        {
            if (ceoList.Items.Count > 0) { ceoList.Items.Clear(); }
            string aLine;
            for (int i = 0; i < li.Count; i++)
            {
                aLine = "";
                aLine += $"{li[i][0]} - {li[i][1]}";
                ceoList.Items.Add(aLine);
            }
        }
        private void loadEmployeeList(List<string[]> li)
        {
            if (employeeList.Items.Count > 0) { employeeList.Items.Clear(); }
            string aLine;
            for (int i = 0; i < li.Count; i++)
            {
                aLine = "";
                aLine += $"{li[i][0]} - {li[i][3]}";
                employeeList.Items.Add(aLine);
            }
        }
        private void loadAdminList(List<string[]> li)
        {
            if (adminList.Items.Count > 0) { adminList.Items.Clear(); }
            string aLine;
            for (int i = 0; i < li.Count; i++)
            {
                aLine = "";
                aLine += $"{li[i][0]} - {li[i][2]}";
                adminList.Items.Add(aLine);
            }
        }
        private string getSelectedId(string s)
        {
            string[] t = s.Split(' ');
            return t[0];
        }
        private void provideDataForReport(List<string[]> li, int mode, string id)
        {
            bool loggedIn = false;

            if (mode < 1)
            {   
                foreach (string[] t in li)
                {
                    if (t[0].Equals(id)) { nameLabel.Text = $"{t[1]} (felhasználónév)"; professionLabel.Text = "-"; }
                    
                }
                isLoggedInLabel.ForeColor = Color.Gray;
                isLoggedInLabel.Text = "nincs adat";
            }
            else if (mode == 1)
            {  
                foreach (string[] t in li)
                {
                    if (t[0].Equals(id))
                    {
                        if (Int32.Parse(t[4]) == 1) { loggedIn = true; }
                        nameLabel.Text = $"{t[1]}";
                        professionLabel.Text = $"{t[2]}";
                        if (loggedIn) { isLoggedInLabel.ForeColor = Color.LimeGreen; isLoggedInLabel.Text = "bejelentkezve"; }
                        else { isLoggedInLabel.ForeColor = Color.Red; isLoggedInLabel.Text = "nincs bejelentkezve"; }
                    }
                }
            }
            else
            {   // admin, mode = 2
                foreach (string[] t in li)
                {
                    if (t[0].Equals(id))
                    {
                        if (Int32.Parse(t[3]) == 1) { loggedIn = true; }
                        nameLabel.Text = $"{t[1]}";
                        professionLabel.Text = $"{t[2]}";
                        if (loggedIn) { isLoggedInLabel.ForeColor = Color.LimeGreen; isLoggedInLabel.Text = "bejelentkezve"; }
                        else { isLoggedInLabel.ForeColor = Color.Red; isLoggedInLabel.Text = "nincs bejelentkezve"; }
                    }
                }
            }
            /* foreach (string[] t in li)
             {
                 if (t[0].Equals(s)) { ReadingSite.Text = t[2]; }
             }*/
        }


        private void jelenlegiMunkatarsak_Load(object sender, EventArgs e)
        {
            //SQL queries
            String ceoSQL = "SELECT ID, felhNev FROM boss;";
            String employeeSQL = "SELECT ID, nev, szakkepesitese, felhNev, bejelentkezve FROM workers;";
            String adminSQL = "SELECT ID, nev, felhNev, bejelentkezve FROM admins";

            //loading the lists with the data of sql queries
            loadCEOCollection(ceoSQL);
            loadEmployeeCollection(employeeSQL);
            loadAdminCollection(adminSQL);

            // loadin the listboxes
            loadCEOList(ceoCollection);
            loadEmployeeList(employeeCollection);
            loadAdminList(adminCollection);

        }


        private void ceoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            provideDataForReport(ceoCollection, 0, getSelectedId(ceoList.SelectedItem.ToString()));
        }

        private void employeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            provideDataForReport(employeeCollection, 1, getSelectedId(employeeList.SelectedItem.ToString()));
        }

        private void adminList_SelectedIndexChanged(object sender, EventArgs e)
        {
            provideDataForReport(adminCollection, 2, getSelectedId(adminList.SelectedItem.ToString()));
        }

        private void watcher_Tick(object sender, EventArgs e)
        {

        }

        private void avatarPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
