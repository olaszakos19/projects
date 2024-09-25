using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace projekt_manager
{
    public partial class alkalmazottProfil : UserControl
    {
        int id = X.getID("workers", X.felhasznalo);
        string prev = "";
        bool chJelszo, chFelhNev;
        string kepNeve = "nincs", kepHelye;
        public alkalmazottProfil()
        {
            InitializeComponent();

        }


        void load()
        {
            List<string[]> adatok = X.lekerdez($"select nev,felhNev,jelszo,szakkepesitese,kep from workers where felhNev like '{X.felhasznalo}'");
            foreach (string[] t in adatok)
            {
                textBox1.Text = t[0];
                textBox3.Text = t[1];
                textBox4.Text = X.Decrypt(t[2]);
                jm2.Text = "";
                textBox2.Text = t[3];
                if (t[4].Equals("nincs"))
                {
                    MessageBox.Show("Önnek nincs profilkép beállíitva");
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(@"Kepek\" + t[4]);
                }

                jm1.Hide();
                jm2.Hide();
                chJelszo = false;
                chFelhNev = false;
            }
        }

        private void alkalmazottProfil_Load(object sender, EventArgs e)
        {
            load();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            chJelszo = true;
            jm1.Show();
            jm2.Show();
        }

        private void jm2_TextChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (chJelszo == true)
            {
                if (textBox1.Text.Trim() != string.Empty && textBox3.Text.Trim() != string.Empty && textBox2.Text.Trim() != string.Empty && textBox4.Text.Trim() != string.Empty && textBox4.Text.Equals(jm2.Text))
                {
                    if (chFelhNev == true)
                    {
                        if (X.CheckfelhNev(textBox3.Text) == true)
                        {
                            prev = X.felhasznalo;
                            X.parancs.CommandText = $"update workers set nev = '{textBox1.Text}', jelszo = '{X.Encrypt(textBox4.Text)}', szakkepesitese = '{textBox2.Text}', kep = '{kepNeve}' ,felhNev = '{textBox3.Text}' where id = {id}";
                            X.parancs.ExecuteNonQuery();
                            MessageBox.Show("Sikeres módósíttás!");
                            X.updateEverything(prev, textBox3.Text);
                            X.felhasznalo = textBox3.Text;
                            load();
                        }
                        else MessageBox.Show("Ez a felhasználónév már foglalt");
                    }
                    else
                    {
                        prev = X.felhasznalo;
                        X.parancs.CommandText = $"update workers set nev = '{textBox1.Text}', jelszo = '{X.Encrypt(textBox4.Text)}', szakkepesitese = '{textBox2.Text}', kep = '{kepNeve}' ,felhNev = '{textBox3.Text}' where id = {id}";
                        X.parancs.ExecuteNonQuery();
                        MessageBox.Show("Sikeres módósíttás!");
                        X.updateEverything(prev, textBox3.Text);
                        X.felhasznalo = textBox3.Text;
                        load();
                    }
                }
                else MessageBox.Show("kitöltetlen érték!");
            }
            else
            {
                if (textBox1.Text.Trim() != string.Empty && textBox3.Text.Trim() != string.Empty && textBox2.Text.Trim() != string.Empty && textBox4.Text.Trim() != string.Empty)
                {
                    if (chFelhNev == true)
                    {
                        if (X.CheckfelhNev(textBox3.Text) == true)
                        {
                            prev = X.felhasznalo;
                            X.parancs.CommandText = $"update workers set nev = '{textBox1.Text}', jelszo = '{X.Encrypt(textBox4.Text)}', szakkepesitese = '{textBox2.Text}', kep = '{kepNeve}' ,felhNev = '{textBox3.Text}' where id = {id}";
                            X.parancs.ExecuteNonQuery();
                            MessageBox.Show("Sikeres módósíttás!");
                            X.updateEverything(prev, textBox3.Text);
                            X.felhasznalo = textBox3.Text;
                            load();
                        }
                        else MessageBox.Show("Ez a felhasználónév már foglalt");
                    }
                    else
                    {
                        prev = X.felhasznalo;
                        X.parancs.CommandText = $"update workers set nev = '{textBox1.Text}', jelszo = '{X.Encrypt(textBox4.Text)}', szakkepesitese = '{textBox2.Text}', kep = '{kepNeve}' ,felhNev = '{textBox3.Text}' where id = {id}";
                        X.parancs.ExecuteNonQuery();
                        MessageBox.Show("Sikeres módósíttás!");
                        X.updateEverything(prev, textBox3.Text);
                        X.felhasznalo = textBox3.Text;
                        load();
                    }
                }
                else MessageBox.Show("kitöltetlen érték!");
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            chFelhNev = true;
        }
    }
}
