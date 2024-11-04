using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace projekt_manager
{
    public partial class AlkalmazottAdatModosit : UserControl
    {
        int count, uCount, id;
        string felhNev, prev;
        string kepNeve = "nincs", kepHelye;
        bool chJelszo, chFelhNev;
        public AlkalmazottAdatModosit()
        {
            InitializeComponent();
        }


        void load()
        {
            listBox1.Items.Clear();
            var alkalmazottak = X.lekerdez("select felhNev,nev from workers");

            foreach (var a in alkalmazottak)
            {
                listBox1.Items.Add(a[0] + "/" + a[1]);
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string adat = listBox1.SelectedItem.ToString();
            felhNev = adat.Split('/')[0];
            id = X.getID("workers", felhNev);
            List<string[]> adatok = X.lekerdez($"select nev,jelszo,felhNev,szakkepesitese,kep from workers where felhNev like '{felhNev}'");

            foreach (var a in adatok)
            {
                textBox1.Text = a[0];
                textBox4.Text = X.Decrypt(a[1]);
                textBox3.Text = a[2];
                textBox2.Text = a[3];
                if (a[4].Equals("nincs"))
                {
                    MessageBox.Show("Az alkalmazottnak nincs profilkép beállítva!");
                    pictureBox1.Image = null;
                }
                else pictureBox1.Image = Image.FromFile(X.kepekPath + a[4]);
                jm1.Hide();
                jm2.Hide();
                chJelszo = false;
            }


        }

        private void watcher_Tick(object sender, EventArgs e)
        {
            X.parancs.CommandText = "select count(*) from workers";
            uCount = int.Parse(X.parancs.ExecuteScalar().ToString());
            if (count != uCount)
            {
                load();
                count = uCount;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            chFelhNev = true;

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Copy(kepHelye, Path.Combine(X.kepekPath, Path.GetFileName(kepHelye)), true);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            chJelszo = true;
            jm1.Show();
            jm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chJelszo == true && textBox4.Text.Trim() != string.Empty)
            {
                if (textBox1.Text.Trim() != string.Empty && textBox3.Text.Trim() != string.Empty && textBox2.Text.Trim() != string.Empty && textBox4.Text != string.Empty && textBox4.Text.Equals(jm2.Text))
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

                        load();
                    }
                }
                else MessageBox.Show("kitöltetlen érték!");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var alkalmazottak = X.lekerdez($"select felhNev,nev from workers where nev like '%{textBox5.Text}%'");

            foreach (var a in alkalmazottak)
            {
                listBox1.Items.Add(a[0] + "/" + a[1]);
            }
        }

        private void AlkalmazottAdatModosit_Load(object sender, EventArgs e)
        {
            load();
            X.parancs.CommandText = "select count(*) from workers";
            count = int.Parse(X.parancs.ExecuteScalar().ToString());
        }
    }
}
