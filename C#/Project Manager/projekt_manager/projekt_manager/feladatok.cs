using System;
using System.Windows.Forms;

namespace projekt_manager
{
    public partial class feladatok : UserControl
    {
        int count, uCount, num;
        public feladatok(int a)
        {
            InitializeComponent();
            num = a;
            if (a == 1)
            {
                adminView();
                
            }
            if (a == 2)
            {
                bossView();
            }
        }

        private void feladatok_Load(object sender, EventArgs e)
        {
            X.parancs.CommandText = $@"select count(*) from tasks";
            count = int.Parse(X.parancs.ExecuteScalar().ToString());
        }


        void adminView()
        {
            int id = X.getID("admins", X.felhasznalo);
            string sql = $@"select megnevezes AS Megnevezés,tipus AS Típus,hatarido AS Hatáirdő,CASE
	                                  when surgos = 1 then 'igen'
	                                  ELSE 'nem'
                                      END AS Sürgős,workers.nev AS Alkalmazott,CASE
	                                  when allapot = 0 then 'folyamatban'
                                      when allapot = 1 then 'elkészült'
                                      ELSE 'még nem kezdte el'
                                      END AS Állapot
                                      From tasks
                                      Inner join workers on tasks.workerID = workers.id";

            dataGridView1.DataSource = X.tablacsinal(sql);




        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //összes
            if (num == 1)
            {
                string sql = $@"select megnevezes AS Megnevezés,tipus AS Típus,hatarido AS Hatáirdő,CASE
	                                  when surgos = 1 then 'igen'
	                                  ELSE 'nem'
                                      END AS Sürgős,workers.nev AS Alkalmazott,CASE
	                                  when allapot = 0 then 'folyamatban'
                                      when allapot = 1 then 'elkészült'
                                      ELSE 'még nem kezdte el'
                                      END AS Állapot
                                      From tasks
                                      Inner join workers on tasks.workerID = workers.id";

                dataGridView1.DataSource = X.tablacsinal(sql);
            }
            else
            {
                string sql = @"select megnevezes AS Megnevezés,tipus AS Típus,hatarido AS Hatáirdő,CASE
	                                  when allapot = 0 then 'folyamatban'
                                      when allapot = 1 then 'elkészült'
                                      ELSE 'még nem kezdte el'
                                      END AS Állapot,CASE
	                                  when surgos = 1 then 'igen'
	                                  ELSE 'nem'
                                      END AS Sürgős,workers.nev AS Alkalmazott,admins.nev AS Admin
                                      From tasks
                                      Inner join workers on tasks.workerID = workers.id
                                      Inner join admins on tasks.adminID = admins.id";
                dataGridView1.DataSource = X.tablacsinal(sql);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //folyamatban
            if (num == 1)
            {
                string sql = $@"select megnevezes AS Megnevezés,tipus AS Típus,hatarido AS Hatáirdő,CASE
	                                  when surgos = 1 then 'igen'
	                                  ELSE 'nem'
                                      END AS Sürgős,workers.nev AS Alkalmazott,CASE
	                                  when allapot = 0 then 'folyamatban'
                                      when allapot = 1 then 'elkészült'
                                      ELSE 'még nem kezdte el'
                                      END AS Állapot
                                      From tasks
                                      Inner join workers on tasks.workerID = workers.id where allapot = 0";

                dataGridView1.DataSource = X.tablacsinal(sql);
            }
            else
            {
                string sql = @"select megnevezes AS Megnevezés,tipus AS Típus,hatarido AS Hatáirdő,CASE
	                                  when allapot = 0 then 'folyamatban'
                                      when allapot = 1 then 'elkészült'
                                      ELSE 'még nem kezdte el'
                                      END AS Állapot,CASE
	                                  when surgos = 1 then 'igen'
	                                  ELSE 'nem'
                                      END AS Sürgős,workers.nev AS Alkalmazott ,workers.nev AS Alkalmazott,admins.nev AS Admin
                                      From tasks
                                      Inner join workers on tasks.workerID = workers.id
                                      Inner join admins on tasks.adminID = admins.id
                                      where allapot = 0";
                dataGridView1.DataSource = X.tablacsinal(sql);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //elkészült
            if (num == 1)
            {
                string sql = $@"select megnevezes AS Megnevezés,tipus AS Típus,hatarido AS Hatáirdő,CASE
	                                  when surgos = 1 then 'igen'
	                                  ELSE 'nem'
                                      END AS Sürgős,workers.nev AS Alkalmazott,CASE
	                                  when allapot = 0 then 'folyamatban'
                                      when allapot = 1 then 'elkészült'
                                      ELSE 'még nem kezdte el'
                                      END AS állapot
                                      From tasks
                                      Inner join workers on tasks.workerID = workers.id where allapot = 1";

                dataGridView1.DataSource = X.tablacsinal(sql);
            }
            else
            {
                string sql = @"select megnevezes AS Megnevezés,tipus AS Típus,hatarido AS Hatáirdő,CASE
	                                  when allapot = 0 then 'folyamatban'
                                      when allapot = 1 then 'elkészült'
                                      ELSE 'még nem kezdte el'
                                      END AS Állapot,CASE
	                                  when surgos = 1 then 'igen'
	                                  ELSE 'nem'
                                      END AS Sürgős
,workers.nev AS Alkalmazott,admins.nev AS Admin
                                      From tasks
                                      Inner join workers on tasks.workerID = workers.id
                                      Inner join admins on tasks.adminID = admins.id
                                      where allapot = 1";
                dataGridView1.DataSource = X.tablacsinal(sql);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //még nem
            if (num == 1)
            {
                string sql = $@"select megnevezes AS Megnevezés,tipus AS Típus,hatarido AS Hatáirdő,CASE
	                                  when surgos = 1 then 'igen'
	                                  ELSE 'nem'
                                      END AS Sürgős,workers.nev AS Alkalmazott,CASE
	                                  when allapot = 0 then 'folyamatban'
                                      when allapot = 1 then 'elkészült'
                                      ELSE 'még nem kezdte el'
                                      END AS Állapot
                                      From tasks
                                      Inner join workers on tasks.workerID = workers.id where allapot = -1";

                dataGridView1.DataSource = X.tablacsinal(sql);
            }
            else
            {
                string sql = @"select megnevezes AS Megnevezés,tipus AS Típus,hatarido AS Hatáirdő,CASE
	                                  when allapot = 0 then 'folyamatban'
                                      when allapot = 1 then 'elkészült'
                                      ELSE 'még nem kezdte el'
                                      END AS Állapot,CASE
	                                  when surgos = 1 then 'igen'
	                                  ELSE 'nem'
                                      END AS Sürgös,workers.nev AS Alkalmazott ,workers.nev AS Alkalmazott,admins.nev AS Admin
                                      From tasks
                                      Inner join workers on tasks.workerID = workers.id
                                      Inner join admins on tasks.adminID = admins.id
                                      where allapot = -1";
                dataGridView1.DataSource = X.tablacsinal(sql);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //sürgős
            if (num == 1)
            {
                string sql = $@"select megnevezes AS Megnevezés,tipus AS Típus,hatarido AS Hatáirdő,CASE
	                                  when surgos = 1 then 'igen'
	                                  ELSE 'nem'
                                      END AS Sürgös,workers.nev AS Alkalmazott,CASE
	                                  when allapot = 0 then 'folyamatban'
                                      when allapot = 1 then 'elkészült'
                                      ELSE 'még nem kezdte el'
                                      END AS Állapot
                                      From tasks
                                      Inner join workers on tasks.workerID = workers.id
                                      WHERE surgos = 1";

                dataGridView1.DataSource = X.tablacsinal(sql);
            }
            else
            {
                string sql = @"select megnevezes AS Megnevezés,tipus AS Típus,hatarido AS Hatáirdő,CASE
	                                  when allapot = 0 then 'folyamatban'
                                      when allapot = 1 then 'elkészült'
                                      ELSE 'még nem kezdte el'
                                      END AS Állapot,CASE
	                                  when surgos = 1 then 'igen'
	                                  ELSE 'nem'
                                      END AS Sürgös,workers.nev AS Alkalmazott ,workers.nev AS Alkalmazott,admins.nev AS Admin
                                      From tasks
                                      Inner join workers on tasks.workerID = workers.id
                                      Inner join admins on tasks.adminID = admins.id WHERE surgos = 1";

                dataGridView1.DataSource = X.tablacsinal(sql);
            }
        }

        private void watcher_Tick(object sender, EventArgs e)
        {
            X.parancs.CommandText = $@"select count(*) from tasks";
            uCount = int.Parse(X.parancs.ExecuteScalar().ToString());

            if (uCount != count)
            {

                if (num == 1)
                {
                    adminView();
                }
                if (num == 2)
                {
                    bossView();
                }
                count = uCount;
            }


        }

        void bossView()
        {
            string sql = @"select megnevezes AS Megnevezés,tipus AS Típus,hatarido AS Hatáirdő,CASE
	                                  when allapot = 0 then 'folyamatban'
                                      when allapot = 1 then 'elkészült'
                                      ELSE 'még nem kezdte el'
                                      END AS Állapot,CASE
	                                  when surgos = 1 then 'igen'
	                                  ELSE 'nem'
                                      END AS Sürgös,workers.nev AS Alkalmazott,admins.nev AS Admin
                                      From tasks
                                      Inner join workers on tasks.workerID = workers.id
                                      Inner join admins on tasks.adminID = admins.id";
            dataGridView1.DataSource = X.tablacsinal(sql);
        }

    }
}
