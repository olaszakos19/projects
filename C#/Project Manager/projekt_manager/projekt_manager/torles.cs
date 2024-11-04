using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projekt_manager
{
    public partial class torles : UserControl
    {
        string tabla, felhNev = "";
        int count, ujCount = 0;
        bool nezet;
        public torles(int a)
        {
            InitializeComponent();
            if (a == 1)
            {
                tabla = "admins";
                d1.Visible = false;
                d2.Visible = false;
                szk.Visible = false;
                listBox2.Visible = false;
                nezet = true;
            }
            if (a == 2)
            {
                tabla = "workers";
                nezet = false;
            }
        }

        private void listBoxBetölt()
        {
            var sql = X.lekerdez("SELECT nev,felhNev from " + tabla + "");
            foreach (var t in sql)
            {
                listBox1.Items.Add(t[0] + "-" + t[1]);
            }
        }

        private void torles_Load(object sender, EventArgs e)
        {
            listBoxBetölt();
        }

        private void watcher_Tick(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                felhNev = listBox1.SelectedItem.ToString().Split('-')[1];
                if (nezet == false)
                {
                    List<string[]> adatok = X.lekerdez("select * from " + tabla + " where felhNev like '" + felhNev + "'");
                    int id = X.getID(tabla, felhNev);
                    List<string[]> feladatok = X.lekerdez($"select megnevezes from tasks where  workerID = {id}");
                    foreach (string[] t in adatok)
                    {
                        n.Text = t[1];
                        fn.Text = t[5];
                        szk.Text = t[3];
                        foreach (string[] t2 in feladatok)
                        {
                            listBox2.Items.Add(t2[0]);
                        }

                    }
                }
                else
                {
                    List<string[]> adatok = X.lekerdez("select * from " + tabla + " where felhNev like '" + felhNev + "'");
                    int id = X.getID(tabla, felhNev);
                    foreach (string[] t in adatok)
                    {
                        n.Text = t[1];
                        fn.Text = t[3];


                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (nezet == true)
            {
                X.torlesAdmin(felhNev);
                listBox1.Items.Clear();
                listBoxBetölt();
            }
            else
            {
                X.torlesAlkalmazott(felhNev);
                listBox1.Items.Clear();
                listBoxBetölt();
            }
        }
    }
}
