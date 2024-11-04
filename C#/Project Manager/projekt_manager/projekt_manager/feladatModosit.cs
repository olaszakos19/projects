using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projekt_manager
{
    public partial class feladatModosit : UserControl
    {
        public feladatModosit(int a)
        {
            InitializeComponent();
        }


        private string listItemString(string a, string b)
        {
            string s = "";
            s += a + " - " + b;
            return s;
        }

        private void loadEmployees()
        {
            List<string[]> employees = X.lekerdez("SELECT nev FROM workers;");
            foreach (var n in employees)
            {
                foreach (string s in n)
                {
                    comboBox1.Items.Add(s);
                }
            }
        }
        private int getIdFromListBox(string a)
        {
            string[] t = a.Split(' ');
            int result = Int32.Parse(t[0]);



            return result;
        }
        private void feladatModosit_Load(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                listBox1.Items.Clear();
            }
            else
            {


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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadEmployees();
            int id = getIdFromListBox(listBox1.SelectedItem.ToString());
            //textBox1.Text = Convert.ToString(id);
            List<string[]> ScreenDataCollection = X.lekerdez($"SELECT t.tipus, t.hatarido, w.nev, t.leiras FROM tasks t INNER JOIN workers w ON w.ID = t.workerID WHERE t.id = {id};");
            if (ScreenDataCollection.Count != 1) { }
            else
            {
                textBox1.Text = ScreenDataCollection[0][0];
                dateTimePicker1.Value = DateTime.Parse(ScreenDataCollection[0][1]);
                comboBox1.SelectedIndex = comboBox1.FindString(ScreenDataCollection[0][2]);
                lIras.Text = ScreenDataCollection[0][3];
            }
        }

        private void watcher_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql = "";

            int id = getIdFromListBox(listBox1.SelectedItem.ToString());
            string tipus = textBox1.Text;
            string hatarido = Convert.ToString(dateTimePicker1.Value);
            string leiras = lIras.Text;

            sql += $"UPDATE tasks SET tipus = '{tipus}', hatarido = '{hatarido}', leiras = '{leiras}' WHERE id = {id};";

            X.vegrehajt(sql);

            MessageBox.Show("sikeres feladat módosítás!");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mmm";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
        }
    }
}
