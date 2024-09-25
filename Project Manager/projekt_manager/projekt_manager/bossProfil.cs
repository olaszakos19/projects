using System;
using System.Windows.Forms;

namespace projekt_manager
{
    public partial class bossProfil : UserControl
    {
        string felh, jelszo;
        bool felhChanged, jelszoChanged;

        public bossProfil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (felhChanged == true && jelszoChanged == false) // Csak felhasználónév
            {
                if (felh.Length > 0)
                {
                    X.parancs.CommandText = $"update boss set felhNev = '{felh}'";
                    X.parancs.ExecuteScalar();
                    MessageBox.Show("Felhasználónév megváltoztatva!");
                }
                else { MessageBox.Show("A felhasználónév nem lehet üres!"); }
            }
            if (felhChanged == false && jelszoChanged == true && jelszo.Length != 0) // Csak jelszó
            {
                if (jelszo.Equals(textBox3.Text))
                {
                    X.parancs.CommandText = $"update boss set jelszo = '{X.Encrypt(jelszo)}'";
                    X.parancs.ExecuteScalar();
                    MessageBox.Show("A jelszó megváltozott!");
                }
                else { MessageBox.Show("A két beírt jelszó nem egyezik!."); }
            }
            if (felhChanged == true && jelszoChanged == true && jelszo.Length != 0) // Felhasználónév és jelszó is
            {
                if (jelszo.Equals(textBox3.Text))
                {
                    X.parancs.CommandText = $"update boss set felhNev = '{felh}', jelszo = '{X.Encrypt(jelszo)}'";
                    X.parancs.ExecuteScalar();
                    MessageBox.Show("A jelszó és a felhasználónév megváltozott!.");
                }
                else { MessageBox.Show("A két beírt jelszó nem egyezik!."); }

            }
            if (felhChanged == false && jelszoChanged == false) // A 'boss' sem a felhasználónevét sem a jelszavát nem változtatta meg.
            {
                MessageBox.Show("Nem változtatott semmit!");

            }
        }

        private void bossProfil_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            felhChanged = true;
            felh = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            jelszoChanged = true;
            jelszo = textBox2.Text;
        }
    }
}
