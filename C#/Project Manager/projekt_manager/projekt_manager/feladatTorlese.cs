using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projekt_manager
{
    public partial class feladatTorlese : UserControl
    {
        int count, newCount;
        public feladatTorlese(int a)
        {
            InitializeComponent();
        }

        private void loadListbox()
        {
            if (listBox1.Items.Count != 0)
            {
                listBox1.Items.Clear();
            }
            else { }

            List<string[]> listaFeltölt = X.lekerdez(@"select id,megnevezes from tasks");
            string id = "";
            string nev = "";
            for (int i = 0; i < listaFeltölt.Count; i++)
            {
                id = listaFeltölt[i][0];
                nev = listaFeltölt[i][1];
                listBox1.Items.Add(listItemString(id, nev));
            }
        }

        private int getIdFromListBox(string a)
        {
            string[] t = a.Split(' ');
            int result = Int32.Parse(t[0]);



            return result;
        }
        private string listItemString(string a, string b)
        {
            string s = "";
            s += a + " - " + b;
            return s;
        }

        private void feladatTorlese_Load(object sender, EventArgs e)
        {
            loadListbox();


            /* int id = X.getID("workers", X.felhasznalo);
             var sql = X.lekerdez("select id,megnevezes from tasks where workerID = " + id + " and not allapot = 1");
             foreach (var t in sql)
             {
                 listBox1.Items.Add(t[0] + t[1]);
             }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {


                String sql = "DELETE FROM tasks WHERE ";

                int id = getIdFromListBox(listBox1.SelectedItem.ToString());

                sql += $"ID = {id}";

                X.vegrehajt(sql);

                MessageBox.Show("sikeres törlés!");
                loadListbox();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {
                int id = getIdFromListBox(listBox1.SelectedItem.ToString());
                
                List<string[]> ScreenDataCollection = X.lekerdez($"SELECT t.megnevezes, t.tipus, t.hatarido, w.nev, a.nev, t.leiras FROM tasks t INNER JOIN workers w ON w.ID = t.workerID INNER JOIN admins a ON a.ID = t.adminID WHERE t.id = {id};");
                if (ScreenDataCollection.Count != 1) { }
                else
                {
                    fNev.Text = ScreenDataCollection[0][0];
                    fTipus.Text = ScreenDataCollection[0][1];
                    hIdo.Text = ScreenDataCollection[0][2];
                    label1.Text = ScreenDataCollection[0][3];
                    label4.Text = ScreenDataCollection[0][4];
                    lIras.Text = ScreenDataCollection[0][5];
                }
            }

        }

        private void watcher_Tick(object sender, EventArgs e)
        {

        }
    }
}
