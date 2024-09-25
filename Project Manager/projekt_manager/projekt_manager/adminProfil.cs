using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projekt_manager
{
    public partial class adminProfil : UserControl
    {
        string felhNev;
        string prev = X.felhasznalo;
        int id = X.getID("admins", X.felhasznalo), num;
        bool chJelszo, chFelhNev;
        public adminProfil(string s)
        {
            InitializeComponent();
            felhNev = s;

        }

        void load()
        {
            textBox2.UseSystemPasswordChar = true;
            jm2.UseSystemPasswordChar = true;
            List<string[]> adatok = X.lekerdez($"select nev,felhNev,jelszo from admins where felhNev like '{felhNev}'");
            foreach (string[] t in adatok)
            {
                textBox1.Text = t[0];
                textBox4.Text = t[1];
                textBox2.Text = X.Decrypt(t[2]);
                jm1.Hide();
                jm2.Hide();
                chJelszo = false;
                chFelhNev = false;
            }
        }

        private void adminProfil_Load(object sender, EventArgs e)
        {
            load();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (chJelszo == true)
            {
                if (textBox1.Text.Trim() != string.Empty && textBox2.Text.Trim() != string.Empty)
                {
                    if (jm2.Text.Equals(textBox2.Text))
                    {
                        if (chFelhNev == true)
                        {
                            if (X.CheckfelhNev(textBox4.Text) == true)
                            {
                                prev = X.felhasznalo;
                                X.parancs.CommandText = $"update admins set nev = '{textBox1.Text}' ,felhNev = '{textBox4.Text}' ,jelszo = '{X.Encrypt(textBox2.Text)}' where id = {id} ";
                                X.parancs.ExecuteNonQuery();
                                X.felhasznalo = textBox4.Text;
                                MessageBox.Show("Sikeres módosíttás");
                                X.updateEverything(prev, X.felhasznalo);
                            }
                            else
                            {
                                MessageBox.Show("Ilyen felhasználónév már van!");
                            }
                        }

                        else
                        {
                            prev = X.felhasznalo;
                            X.parancs.CommandText = $"update admins set nev = '{textBox1.Text}' ,felhNev = '{textBox4.Text}' ,jelszo = '{X.Encrypt(textBox2.Text)}' where id = {id} ";
                            X.parancs.ExecuteNonQuery();
                            X.felhasznalo = textBox4.Text;
                            MessageBox.Show("Sikeres módosíttás");
                            X.updateEverything(prev, X.felhasznalo);
                        }

                    }
                    else MessageBox.Show("Hibás jelszó!");

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

                            prev = X.felhasznalo;
                            X.parancs.CommandText = $"update admins set nev = '{textBox1.Text}' ,felhNev = '{textBox4.Text}' ,jelszo = '{X.Encrypt(textBox2.Text)}' where id = {id} ";
                            X.parancs.ExecuteNonQuery();
                            X.felhasznalo = textBox4.Text;
                            MessageBox.Show("Sikeres módosíttás");
                            X.updateEverything(prev, X.felhasznalo);
                        }
                        else
                        {
                            MessageBox.Show("Ilyen felhasználónév már van!");
                        }
                    }
                    else
                    {
                        prev = X.felhasznalo;
                        X.parancs.CommandText = $"update admins set nev = '{textBox1.Text}' ,felhNev = '{textBox4.Text}' ,jelszo = '{X.Encrypt(textBox2.Text)}' where id = {id} ";
                        X.parancs.ExecuteNonQuery();
                        X.felhasznalo = textBox4.Text;
                        MessageBox.Show("Sikeres módosíttás");
                    }
                }
                else MessageBox.Show("Kitöltetlen érték!");
            }

            load();
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            chFelhNev = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            jm1.Show();
            jm2.Show();
            chJelszo = true;
        }


    }
}
