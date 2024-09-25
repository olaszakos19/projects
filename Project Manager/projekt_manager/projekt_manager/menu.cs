using System;
using System.Drawing;
using System.Windows.Forms;

namespace projekt_manager
{
    public partial class menu : Form
    {
        int num, ujCountM, countM, countT, ujCountT, id;

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        public menu(int a)
        {
            InitializeComponent();
            X.parancs.CommandText = $"select count(*) from messages where cimzett like '{X.felhasznalo}' ";
            countM = Convert.ToInt32(X.parancs.ExecuteScalar().ToString());
            if (a == 0)
            {
                id = X.getID("workers", X.felhasznalo);
                X.parancs.CommandText = $"select count(*) from tasks where workerID = {id} ";
                countT = Convert.ToInt32(X.parancs.ExecuteScalar().ToString());
                countT = int.Parse(X.parancs.ExecuteScalar().ToString());
                num = 0;
                flowLayoutPanel1.Controls.Clear();
                dolgozoiFelulet dolgozo = new dolgozoiFelulet();
                flowLayoutPanel1.Controls.Add(dolgozo);
            }

            if (a == 1)
            {
                num = 1;
                flowLayoutPanel1.Controls.Clear();
                adminfelulet admin = new adminfelulet();
                flowLayoutPanel1.Controls.Add(admin);
            }
            if (a == 2)
            {
                num = 2;
                flowLayoutPanel1.Controls.Clear();
                bossFelulet boss = new bossFelulet();
                flowLayoutPanel1.Controls.Add(boss);
            }

        }


        private void menu_Load(object sender, EventArgs e)
        {
            
        }

        private void menu_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime datum = DateTime.Now;
            date.Text = datum.ToString("yyy.MMMM.dd");
            udv.Text = datum.ToString("dddd");
            ora.Text = datum.ToString("HH:mm");
            if (X.close == true) this.Dispose();
        }

        private void watcher_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                X.parancs.CommandText = $"select count(*) from messages where cimzett like '{X.felhasznalo}' ";
                ujCountM = Convert.ToInt32(X.parancs.ExecuteScalar().ToString());
                X.parancs.CommandText = $"select count(*) from tasks where workerID = {id} ";
                ujCountT = Convert.ToInt32(X.parancs.ExecuteScalar().ToString());



                if (ujCountM > countM)
                {
                    watcher.Enabled = false;
                    notifyIcon1.Text = "Új üzenete érkezett!";
                    notifyIcon1.BalloonTipText = "Új üzenete érkezett";
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.ShowBalloonTip(1000);

                    countM = ujCountM;

                    watcher.Enabled = true;
                }
                if (ujCountT > countT)
                {
                    watcher.Enabled = false;
                    notifyIcon1.Text = "Új feladatot írtak ki önnek!";
                    notifyIcon1.BalloonTipText = "Új feladatot írtak ki önnek";
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.ShowBalloonTip(1000);
                    countT = ujCountT;
                    watcher.Enabled = true;
                }

                if (ujCountT < countT)
                {
                    watcher.Enabled = false;
                    notifyIcon1.Text = "Feladatot tötöltek!!";
                    notifyIcon1.BalloonTipText = "Feladatot tötöltek!";
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.ShowBalloonTip(1000);
                    countT = ujCountT;
                    watcher.Enabled = true;
                }
            }

            if (num == 1)
            {
                X.parancs.CommandText = $"select count(*) from messages where cimzett like '{X.felhasznalo}' ";
                ujCountM = Convert.ToInt32(X.parancs.ExecuteScalar().ToString());

                if (ujCountM > countM)
                {
                    watcher.Enabled = false;
                    notifyIcon1.Text = "Új üzenete érkezett!";
                    notifyIcon1.BalloonTipText = "Új üzenete érkezett!";
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.ShowBalloonTip(1000);
                    countM = ujCountM;
                    watcher.Enabled = true;
                }
            }

            if (num == 2)
            {
                X.parancs.CommandText = $"select count(*) from messages where cimzett like '{X.felhasznalo}' ";
                ujCountM = Convert.ToInt32(X.parancs.ExecuteScalar().ToString());

                if (ujCountM > countM)
                {
                    watcher.Enabled = false;
                    notifyIcon1.Text = "Új üzenete érkezett!";
                    notifyIcon1.BalloonTipText = "Új üzenete érkezett!";
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.ShowBalloonTip(1000);
                    countM = ujCountM;
                    watcher.Enabled = true;
                }
            }
        }
    }
}
