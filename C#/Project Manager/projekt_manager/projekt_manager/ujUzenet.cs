using System;
using System.Windows.Forms;

namespace projekt_manager
{
    public partial class ujUzenet : UserControl
    {
        string cimzett = "", targy = "", uzenet = "", kuldesDatum;
        int cAlk, cAd, ucAlk, ucAd;
        public ujUzenet(int num)
        {
            InitializeComponent();
            if (num == 1)
            {
                radioButton3.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            cimzett = "";
            comboBox1.Items.Clear();
            comboBox1.Visible = true;
            var s = X.lekerdez("select nev,felhNev from admins where felhNev not like '" + X.felhasznalo + "'");
            foreach (var t in s)
            {
                comboBox1.Items.Add(t[0] + "-" + t[1]);
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Visible = false;
            X.parancs.CommandText = "select felhNev from boss";
            cimzett = X.parancs.ExecuteScalar().ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            cimzett = "";
            comboBox1.Items.Clear();
            comboBox1.Visible = true;
            var s = X.lekerdez("select nev,felhNev from workers where felhNev not like '" + X.felhasznalo + "'");
            foreach (var t in s)
            {
                comboBox1.Items.Add(t[0] + "-" + t[1]);
            }

        }

        private void watcher_Tick(object sender, EventArgs e)
        {
            X.parancs.CommandText = "select count(*) from workers where felhNev not like '" + X.felhasznalo + "'";
            ucAlk = int.Parse(X.parancs.ExecuteScalar().ToString());

            X.parancs.CommandText = "select count(*)from admins where felhNev not like '" + X.felhasznalo + "'";
            ucAd = int.Parse(X.parancs.ExecuteScalar().ToString());

            if (ucAlk != cAlk)
            {
                comboBox1.Items.Clear();
                cAlk = ucAlk;
                var s = X.lekerdez("select nev,felhNev from workers where felhNev not like '" + X.felhasznalo + "'");
                foreach (var t in s)
                {
                    comboBox1.Items.Add(t[0] + "-" + t[1]);
                }



            }
            if (ucAd != cAd)
            {
                comboBox1.Items.Clear();
                cAd = ucAd;
                var s = X.lekerdez("select nev,felhNev from admins where felhNev not like '" + X.felhasznalo + "'");
                foreach (var t in s)
                {
                    comboBox1.Items.Add(t[0] + "-" + t[1]);
                }

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cimzett = comboBox1.SelectedItem.ToString().Split('-')[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (string s in richTextBox1.Lines)
            {
                uzenet += s + "\n";

            }

            if (targy.Trim() != string.Empty && cimzett != string.Empty && uzenet.Trim() != string.Empty)
            {
                kuldesDatum = DateTime.Today.ToString("yyy-MM-dd");


                X.parancs.CommandText = $"insert into messages values(null,'{X.felhasznalo}','{cimzett}','{targy}','{uzenet}','{kuldesDatum}',0)";
                X.parancs.ExecuteScalar();
                MessageBox.Show("Üzenet elküldve");
                textBox1.Text = "";
                richTextBox1.Text = "";
                comboBox1.Items.Clear();
                comboBox1.Text = "Válassza ki kinek akarja küldeni!";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
            else MessageBox.Show("Kitöltetlen érték!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            targy = textBox1.Text;
        }

        private void ujUzenet_Load(object sender, EventArgs e)
        {
            X.parancs.CommandText = "select count(*) from workers where";


            X.parancs.CommandText = "select count(*) from admins where";


        }
    }
}
