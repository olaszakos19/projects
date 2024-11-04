using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projekt_manager
{
    public partial class uzeneteim : UserControl
    {

        int uzenetId, count, nCount;
        List<int> ids = new List<int>();
        public uzeneteim()
        {
            InitializeComponent();

        }

        void load()
        {
            ids.Clear();
            listBox1.Items.Clear();

            var sql = X.lekerdez($@"select ID,cim,
                                    case 
                                    when    megtekintett = 0 then 'olvasatlan'                                          
                                    ELSE 'megtekintett'
                                    end as asd
                                    from messages where cimzett like '{X.felhasznalo}'");
            foreach (var t in sql)
            {
                ids.Add(int.Parse(t[0]));
                listBox1.Items.Add($"Üzenet címe:{t[1]} ,{t[2]}");
            }
        }

        private void uzeneteim_Load(object sender, EventArgs e)
        {


            load();
            X.parancs.CommandText = $"select count(*) from messages where cimzett like '{X.felhasznalo}'";
            count = int.Parse(X.parancs.ExecuteScalar().ToString());

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {

                uzenetId = ids[listBox1.SelectedIndex];
                fAdo.Text = "";
                tArgy.Text = "";
                uZenet.Text = "";
                string sql = $"select ID,felado,cim,leiras from messages where ID = {uzenetId}";
                List<string[]> adatok = X.lekerdez(sql);
                foreach (string[] t in adatok)
                {
                    fAdo.Text = X.getNev(t[1]);
                    tArgy.Text = t[2];
                    uZenet.Text = t[3];
                }
                X.parancs.CommandText = $"update messages set megtekintett = 1 where id = {uzenetId}";
                X.parancs.ExecuteNonQuery();
                load();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            load();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            clear();
            var sql = X.lekerdez($@"select ID,cim,
                                    case 
                                    when    megtekintett = 0 then 'olvasatlan'                                          
                                    ELSE 'megtekintett'
                                    end as asd
                                    from messages where cimzett like '{X.felhasznalo}' and megtekintett = 1");
            foreach (var t in sql)
            {
                listBox1.Items.Add(t[0] + "/" + t[1] + "-" + t[2]);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (uzenetId != 0)
            {
                X.parancs.CommandText = $"delete from messages where ID = {uzenetId}";
                X.parancs.ExecuteNonQuery();
                fAdo.Text = "";
                tArgy.Text = "";
                uZenet.Text = "";
                MessageBox.Show("Üzenet törölve");
            }
            else MessageBox.Show("Nem választott ki üzenetet");
        }

        void clear()
        {
            listBox1.Items.Clear();
            fAdo.Text = "";
            tArgy.Text = "";
            uZenet.Text = "";

        }

        private void watcher_Tick(object sender, EventArgs e)
        {
            X.parancs.CommandText = $"select count(*) from messages where cimzett like '{X.felhasznalo}'";
            nCount = int.Parse(X.parancs.ExecuteScalar().ToString());


            if (nCount != count)
            {
                load();
                count = nCount;
            }


        }
    }
}
