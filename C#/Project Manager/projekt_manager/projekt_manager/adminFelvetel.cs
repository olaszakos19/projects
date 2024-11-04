using System;
using System.Windows.Forms;

namespace projekt_manager
{
    public partial class adminFelvetel : UserControl
    {
        string nev, felhnev, jelszo;

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            felhnev = textBox4.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            jelszo = X.Encrypt(textBox2.Text);
        }

        private void adminFelvetel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (X.CheckfelhNev(felhnev) == true)
            {
                X.parancs.CommandText = "insert into admins (nev,jelszo,felhNev,bejelentkezve) values('" + nev + "','" + jelszo + "','" + felhnev + "',0)";
                X.parancs.ExecuteScalar();
                MessageBox.Show("Sikeres felvétel");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
            }
            else MessageBox.Show("ilyen felhasználónév már van!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nev = textBox1.Text;
        }

        public adminFelvetel()
        {
            InitializeComponent();
        }
    }
}
