using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace projekt_manager
{
    public partial class dolgozoFelvetele : UserControl
    {
        string nev, felhNev, jeslzo, szakkepesittes = "";

        string kepNeve = "nincs", kepHelye;
        public dolgozoFelvetele()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text.Trim() != string.Empty && textBox4.Text.Trim() != string.Empty && textBox2.Text.Trim() != string.Empty && textBox3.Text.Trim() != string.Empty)
            {
                if (X.CheckfelhNev(felhNev) == true)
                {
                    X.parancs.CommandText = "insert into workers (nev,jelszo,szakkepesitese,kep,felhNev,bejelentkezve) values('" + nev + "','" + X.Encrypt(jeslzo) + "','" + szakkepesittes + "','" + kepNeve + "','" + felhNev + "',0)";
                    X.parancs.ExecuteScalar();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox3.Text = "";
                    pictureBox1.Image = null;
                    MessageBox.Show("sikeres felvétel");

                }
                else MessageBox.Show("ilyen felhasználónév már van!");
            }
            else MessageBox.Show("Kitöltetlen érték!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nev = textBox1.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            felhNev = textBox4.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //interneten talált kód
            //https://stackoverflow.com/questions/4526926/get-name-of-picture
            //https://www.c-sharpcorner.com/UploadFile/mirfan00/uploaddisplay-image-in-picture-box-using-C-Sharp/ kép betöltése
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;*.png)|*.jpg; *.jpeg; *.gif; *.bmp;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                kepHelye = openFileDialog.FileName;
                string imagePath = openFileDialog.FileName.ToString();
                string imagepath = imagePath.ToString();
                imagepath = imagepath.Substring(imagepath.LastIndexOf("\\"));
                imagepath = imagepath.Remove(0, 1);
                kepNeve = imagepath;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Copy(kepHelye, Path.Combine(X.kepekPath, Path.GetFileName(kepHelye)), true);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != string.Empty && textBox4.Text.Trim() != string.Empty && textBox2.Text.Trim() != string.Empty && textBox3.Text.Trim() != string.Empty)
            {
                if (X.CheckfelhNev(felhNev) == true)
                {
                    X.parancs.CommandText = "insert into workers (nev,jelszo,szakkepesitese,kep,felhNev,bejelentkezve) values('" + nev + "','" + X.Encrypt(jeslzo) + "','" + szakkepesittes + "','" + kepNeve + "','" + felhNev + "',0)";
                    X.parancs.ExecuteScalar();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox3.Text = "";
                    pictureBox1.Image = null;
                    MessageBox.Show("sikeres felvétel");

                }
                else MessageBox.Show("ilyen felhasználónév már van!");
            }
            else MessageBox.Show("Kitöltetlen érték!");
        }

        private void dolgozoFelvetele_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            jeslzo = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            szakkepesittes = textBox3.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
