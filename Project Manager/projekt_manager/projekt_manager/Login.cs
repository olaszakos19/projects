using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace projekt_manager
{
    public partial class Login : Form
    {
        string felhnev = "", jelszo = "";
        public string loggedFelhNev { get; set; }

        public Login()
        {
            InitializeComponent();
            //this.BackColor = Color.FromArgb(11, 99, 116);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.Aquamarine,
                                                                       Color.Aqua,
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
        private void Login_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }


        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;


            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);


            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(57, 128, 227), 65f);


            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            felhnev = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            jelszo = textBox2.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            if (checkBox1.Checked == false)
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
        X DM = new X("project_manager", "root", "123456");
        private void Create_database()
        {
            X DMC = new X();
            String[] stb = File.ReadAllLines("db.sql");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < stb.Length; i++) { sb.AppendLine(stb[i]); }
            DMC.SQL_run(sb.ToString());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int count = DM.SQL_run("select FIELD, VALUE from comm limit 100;");

            if (DM.info.Length > 0)
            {

                if (DM.info.Contains("Unknown database"))
                {

                    Create_database();
                }
            }


            textBox2.UseSystemPasswordChar = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (X.visibility == true) { this.Visible = true; }
            else { this.Visible = false; textBox1.Text = ""; textBox2.Text = ""; }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                X.parancs.CommandText = @"select admins.felhNev,admins.jelszo 
            from admins
            where felhNev like '" + felhnev + "' and jelszo like '" + X.Encrypt(jelszo) + "'";

                MySqlDataAdapter adapter = new MySqlDataAdapter(X.parancs);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                if (dt.Rows.Count <= 0)
                {
                    X.parancs.CommandText = @"select workers.felhNev,workers.jelszo 
                    from workers
                    where felhNev like '" + felhnev + "' and jelszo like '" + X.Encrypt(jelszo) + "'";

                    MySqlDataAdapter adapter2 = new MySqlDataAdapter(X.parancs);

                    DataTable dt2 = new DataTable();

                    adapter2.Fill(dt2);
                    if (dt2.Rows.Count <= 0)
                    {
                        X.parancs.CommandText = @"select felhNev,jelszo 
                    from boss
                    where felhNev like '" + felhnev + "' and jelszo like '" + X.Encrypt(jelszo) + "'";

                        MySqlDataAdapter adapter3 = new MySqlDataAdapter(X.parancs);

                        DataTable dt3 = new DataTable();

                        adapter3.Fill(dt3);
                        if (dt3.Rows.Count <= 0)
                        {
                            MessageBox.Show("hibás felhasználónév vagy jelszó");
                        }
                        else
                        {
                            loggedFelhNev = felhnev;
                            X.login(felhnev);
                        }
                    }
                    else
                    {
                        loggedFelhNev = felhnev;
                        X.login(felhnev, "workers", 0);
                    }
                }
                else
                {
                    loggedFelhNev = felhnev;
                    X.login(felhnev, "admins", 1);
                }
            }
           
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (felhnev.Trim().Length > 0 && jelszo.Trim().Length > 0)
            {
                X.parancs.CommandText = @"select admins.felhNev,admins.jelszo 
            from admins
            where felhNev like '" + felhnev + "' and jelszo like '" + X.Encrypt(jelszo) + "'";

                MySqlDataAdapter adapter = new MySqlDataAdapter(X.parancs);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                if (dt.Rows.Count <= 0)
                {
                    X.parancs.CommandText = @"select workers.felhNev,workers.jelszo 
                    from workers
                    where felhNev like '" + felhnev + "' and jelszo like '" + X.Encrypt(jelszo) + "'";

                    MySqlDataAdapter adapter2 = new MySqlDataAdapter(X.parancs);

                    DataTable dt2 = new DataTable();

                    adapter2.Fill(dt2);
                    if (dt2.Rows.Count <= 0)
                    {
                        X.parancs.CommandText = @"select felhNev,jelszo 
                    from boss
                    where felhNev like '" + felhnev + "' and jelszo like '" + X.Encrypt(jelszo) + "'";

                        MySqlDataAdapter adapter3 = new MySqlDataAdapter(X.parancs);

                        DataTable dt3 = new DataTable();

                        adapter3.Fill(dt3);
                        if (dt3.Rows.Count <= 0)
                        {
                            MessageBox.Show("hibás felhasználónév vagy jelszó");
                        }
                        else
                        {
                            X.login(felhnev);
                        }
                    }
                    else
                    {
                        X.login(felhnev, "workers", 0);
                    }
                }
                else
                {
                    X.login(felhnev, "admins", 1);
                }
            }
            else MessageBox.Show("Kitöltetlen érték!");


        }


    }
}

