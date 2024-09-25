using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projekt_manager
{
    public partial class AdminAdatModosit : UserControl
    {
        int count, uCount, id;
        bool chJelszo, chFelhNev;
        string felhNev;
        public AdminAdatModosit()
        {
            InitializeComponent();
        }


        void load()
        {
            listBox1.Items.Clear();
            var adminok = X.lekerdez("select nev,felhNev from admins");

            foreach (var a in adminok)
            {

                listBox1.Items.Add(a[0] + "/" + a[1]);

            }
        }

        private void watcher_Tick(object sender, EventArgs e)
        {
            X.parancs.CommandText = "select count(*) from admins";
            uCount = int.Parse(X.parancs.ExecuteScalar().ToString());
            if (count != uCount)
            {
                load();
                count = uCount;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string adat = listBox1.SelectedItem.ToString();
                felhNev = adat.Split('/')[1];
                id = X.getID("admins", felhNev);

                List<string[]> adatok = X.lekerdez($"select * from admins where felhNev like '{felhNev}'");

                foreach (var s in adatok)
                {
                    textBox1.Text = s[1];
                    textBox4.Text = s[3];
                    textBox2.Text = X.Decrypt(s[2]);
                    jm1.Hide();
                    jm2.Hide();
                    chFelhNev = false;
                    chJelszo = false;

                }
            }



        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            chFelhNev = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (chJelszo == true)
            {
                if (textBox1.Text.Trim() != string.Empty && textBox2.Text.Trim() != string.Empty && textBox4.Text.Trim() != string.Empty)
                {
                    if (textBox2.Text.Equals(jm2.Text))
                    {
                        if (chFelhNev == true)
                        {
                            if (X.CheckfelhNev(textBox4.Text) == true)
                            {
                                X.parancs.CommandText = $"update admins set nev = '{textBox1.Text}' ,felhNev = '{textBox4.Text}' ,jelszo = '{X.Encrypt(textBox2.Text)}' where id = {id} ";
                                X.parancs.ExecuteNonQuery();

                                MessageBox.Show("Sikeres módosíttás");
                                X.updateEverything(felhNev, textBox4.Text);
                                textBox1.Text = "";
                                textBox2.Text = "";
                                textBox4.Text = "";
                                felhNev = "";
                                chJelszo = false;
                                jm1.Hide();
                                jm2.Hide();
                                load();
                            }
                            else
                            {
                                MessageBox.Show("Felhasználónév már foglalt");
                            }
                        }

                        else
                        {
                            X.parancs.CommandText = $"update admins set nev = '{textBox1.Text}' ,felhNev = '{textBox4.Text}' ,jelszo = '{X.Encrypt(textBox2.Text)}' where id = {id} ";
                            X.parancs.ExecuteNonQuery();

                            MessageBox.Show("Sikeres módosíttás");
                            X.updateEverything(felhNev, textBox4.Text);
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox4.Text = "";
                            felhNev = "";
                            chJelszo = false;
                            jm1.Hide();
                            jm2.Hide();
                            load();
                        }
                    }
                    else MessageBox.Show("Nem egyeznek a jelszavak!");

                }
                else MessageBox.Show("Kitöltetlen érték!");
            }
            else
            {
                if (textBox1.Text.Trim() != string.Empty && textBox2.Text.Trim() != string.Empty && textBox4.Text.Trim() != string.Empty)
                {
                    if (chFelhNev == true)
                    {
                        if (X.CheckfelhNev(textBox4.Text) == true)
                        {
                            X.parancs.CommandText = $"update admins set nev = '{textBox1.Text}' ,felhNev = '{textBox4.Text}' ,jelszo = '{X.Encrypt(textBox2.Text)}' where id = {id} ";
                            X.parancs.ExecuteNonQuery();

                            MessageBox.Show("Sikeres módosíttás");
                            X.updateEverything(felhNev, textBox4.Text);
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox4.Text = "";
                            felhNev = "";
                            chJelszo = false;
                            jm1.Hide();
                            jm2.Hide();
                            load();
                        }
                        else
                        {
                            MessageBox.Show("Felhasználónév már foglalt");
                        }
                    }
                    else
                    {
                        X.parancs.CommandText = $"update admins set nev = '{textBox1.Text}' ,felhNev = '{textBox4.Text}' ,jelszo = '{X.Encrypt(textBox2.Text)}' where id = {id} ";
                        X.parancs.ExecuteNonQuery();

                        MessageBox.Show("Sikeres módosíttás");
                        X.updateEverything(felhNev, textBox4.Text);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox4.Text = "";
                        felhNev = "";
                        chJelszo = false;
                        jm1.Hide();
                        jm2.Hide();
                        load();
                    }
                }
                else MessageBox.Show("Kitöltetlen érték!");
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            chJelszo = true;
            jm1.Show();
            jm2.Show();
        }

        private void adatModosit_Load(object sender, EventArgs e)
        {
            load();
            X.parancs.CommandText = "select count(*) from admins";
            count = int.Parse(X.parancs.ExecuteScalar().ToString());
            jm1.Hide();
            jm2.Hide();
        }
    }
}
