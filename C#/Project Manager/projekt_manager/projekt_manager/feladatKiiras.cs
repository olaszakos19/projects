using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace projekt_manager
{
    public partial class feladatKiiras : UserControl
    {
        string tipus, feladatLeirasa, felhNev, nev, feladatNeve = "";
        int surgos, dolgozoId = -1, adminId = -1, count, nCount;
        string feladatHatarideje;


        public feladatKiiras()
        {
            InitializeComponent();
        }

        private void feladatKiiras_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            var sql = X.lekerdez("SELECT nev,felhNev from workers");
            foreach (var t in sql)
            {
                listBox1.Items.Add(t[0] + "-" + t[1]);
            }

            X.parancs.CommandText = "select szakkepesitese from workers";
            X.eredm = X.parancs.ExecuteReader();
            using (MySqlDataReader reader = X.eredm)
            {
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString(0));
                }
            }

            feladatHatarideje = DateTime.Today.ToString("yyy/MM/dd");



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            tipus = textBox2.Text;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {

                label10.Text = "";
                felhNev = listBox1.SelectedItem.ToString().Split('-')[1];
                nev = listBox1.SelectedItem.ToString().Split('-')[0];
                dolgozoId = X.getID("workers", felhNev);
                X.parancs.CommandText = $"SELECT COUNT(*) FROM tasks WHERE workerID = {dolgozoId} and allapot < 1";
                int fSzam = int.Parse(X.parancs.ExecuteScalar().ToString());
                var szKepesites = X.lekerdez("select szakkepesitese from workers where felhNev like '" + felhNev + "'");
                foreach (var s in szKepesites)
                {
                    label10.Text += s[0];
                }
                label7.Text = nev;
                label8.Text = fSzam + "db";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tipus != "")
            {
                X.parancs.CommandText = "select nev from workers";
                X.eredm = X.parancs.ExecuteReader();
                while (X.eredm.Read())
                {
                    listBox1.Items.Add(X.eredm.GetString(0));
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mmm";
            dateTimePicker1.Value = DateTime.Today;
            feladatHatarideje = dateTimePicker1.Value.ToString("HH:mm");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Value = DateTime.Today;
            feladatHatarideje = dateTimePicker1.Value.ToString("yyy/MM/dd");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            X.parancs.CommandText = "select count(*) from workers";
            nCount = int.Parse(X.parancs.ExecuteScalar().ToString());

            if (nCount != count)
            {
                listBox1.Items.Clear();
                comboBox1.Items.Clear();
                var sql = X.lekerdez("SELECT nev,felhNev from workers");
                foreach (var t in sql)
                {
                    listBox1.Items.Add(t[0] + "-" + t[1]);
                }

                X.parancs.CommandText = "select szakkepesitese from workers";
                X.eredm = X.parancs.ExecuteReader();
                using (MySqlDataReader reader = X.eredm)
                {
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader.GetString(0));
                    }
                }
                count = nCount;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var s = X.lekerdez("select nev from workers where szakkepesitese like '" + comboBox1.SelectedItem.ToString() + "'");
            foreach (var t in s)
            {
                listBox1.Items.Add(t[0]);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                feladatHatarideje = dateTimePicker1.Value.ToString("HH:mm");
            }
            if (radioButton1.Checked == true) feladatHatarideje = dateTimePicker1.Value.ToString("yyy/MM/dd");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            feladatNeve = textBox1.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                surgos = 1;
            }
            if (checkBox1.Checked == false)
            {
                surgos = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string s in richTextBox1.Lines)
            {
                feladatLeirasa += s + "\n";
            }
            adminId = X.getID("admins", X.felhasznalo);

            if (feladatNeve.Trim() != string.Empty && tipus.Trim() != string.Empty && dolgozoId != -1 && feladatLeirasa.Trim() != string.Empty)
            {
                X.parancs.CommandText = @"insert into tasks(megnevezes,tipus,hatarido,leiras,surgos,allapot,adminID,workerID) values('" + feladatNeve + "','" + tipus + "','" + feladatHatarideje + "','" + feladatLeirasa + "','" + surgos + "','-1','" + adminId + "','" + dolgozoId + "')";
                X.parancs.ExecuteScalar();
                MessageBox.Show("sikeres feladat rögzíttés!");
                textBox1.Text = "";
                textBox2.Text = "";
                checkBox1.Checked = false;
                richTextBox1.Text = "";
            }
            else MessageBox.Show("Kitöltetlen érték!");
        }
    }
}
