using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projekt_manager
{
    public partial class feladataim : UserControl
    {
        string feladat;
        int id, feladatId, count, nCount, tipus, surg;
        List<int> ids = new List<int>();
        public feladataim()
        {
            InitializeComponent();
        }

        private void feladataim_Load(object sender, EventArgs e)
        {
            ids.Clear();
            id = X.getID("workers", X.felhasznalo);
            var sql = X.lekerdez($"select id,megnevezes from tasks where workerID = {id} and not allapot = 1");
            foreach (var t in sql)
            {
                ids.Add(int.Parse(t[0]));
                listBox1.Items.Add(t[1]);
            }

            X.parancs.CommandText = $"select count(*) from tasks where workerID = {id} and not allapot = 1";
            count = int.Parse(X.parancs.ExecuteScalar().ToString());

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            X.parancs.CommandText = $"select megnevezes from tasks where workerID = {id}";
            X.eredm = X.parancs.ExecuteReader();
            using (MySqlDataReader reader = X.eredm)
            {
                while (reader.Read())
                {
                    listBox1.Items.Add(reader.GetString(0));
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            X.parancs.CommandText = $"select megnevezes from tasks where surgos = 1 and workerID = {id} ";
            X.eredm = X.parancs.ExecuteReader();
            using (MySqlDataReader reader = X.eredm)
            {
                while (reader.Read())
                {
                    listBox1.Items.Add(reader.GetString(0));
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            X.parancs.CommandText = "select megnevezes from tasks where";
            X.eredm = X.parancs.ExecuteReader();
            using (MySqlDataReader reader = X.eredm)
            {
                while (reader.Read())
                {
                    listBox1.Items.Add(reader.GetString(0));
                }
            }
        }

        private void watcher_Tick(object sender, EventArgs e)
        {
            X.parancs.CommandText = $"select count(*) from tasks where workerID = {id} and not allapot = 1";
            nCount = int.Parse(X.parancs.ExecuteScalar().ToString());

            if (nCount != count)
            {
                ids.Clear();
                listBox1.Items.Clear();
                count = nCount;
                var sql = X.lekerdez($"select id,megnevezes from tasks where workerID = {id} and not allapot = 1");
                foreach (var t in sql)
                {
                    ids.Add(int.Parse(t[0]));
                    listBox1.Items.Add(t[1]);
                }
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                feladatId = ids[listBox1.SelectedIndex];
                List<string[]> adatok = X.lekerdez($"select * from tasks where id = {feladatId}");
                // megnevezés típus hatarido leiras surgos allapot 
                //      1       2      3        4      5       6
                foreach (string[] t in adatok)
                {
                    fNev.Text = t[1];
                    fTipus.Text = t[2];
                    hIdo.Text = t[3];
                    lIras.Text = t[4];
                    surg = int.Parse(t[5]);
                    tipus = int.Parse(t[6]);

                }
                if (tipus == 0) button2.Hide();
                if (surg == 0) sGos.Text = "Nem";
                else sGos.Text = "Igen";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            X.parancs.CommandText = $"update tasks set allapot = 1 where  ID = {feladatId} and workerID = {id} ";
            X.parancs.ExecuteScalar();

            ids.Clear();
            id = X.getID("workers", X.felhasznalo);
            listBox1.Items.Clear();
            fNev.Text = "-";
            hIdo.Text = "-";
            fTipus.Text = "-";
            lIras.Text = "";
            fNev.Text = "-";
            sGos.Text = "-";
            button2.Show();
            var sql = X.lekerdez($"select id,megnevezes from tasks where workerID = {id} and not allapot = 1");
            foreach (var t in sql)
            {
                ids.Add(int.Parse(t[0]));
                listBox1.Items.Add(t[1]);
            }

            X.parancs.CommandText = $"select count(*) from tasks where workerID = {id} and not allapot = 1";
            count = int.Parse(X.parancs.ExecuteScalar().ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            X.parancs.CommandText = $"update tasks set allapot = 0 where  ID = {feladatId} and workerID = {id} ";
            X.parancs.ExecuteScalar();
            ids.Clear();
            id = X.getID("workers", X.felhasznalo);
            listBox1.Items.Clear();
            button2.Hide();
            var sql = X.lekerdez($"select id,megnevezes from tasks where workerID = {id} and not allapot = 1");
            foreach (var t in sql)
            {
                ids.Add(int.Parse(t[0]));
                listBox1.Items.Add(t[1]);
            }

            X.parancs.CommandText = $"select count(*) from tasks where workerID = {id} and not allapot = 1";
            count = int.Parse(X.parancs.ExecuteScalar().ToString());

        }
    }
}
