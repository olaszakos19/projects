using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace projekt_manager
{
    public partial class bossFelulet : UserControl
    {

        public bossFelulet()
        {
            InitializeComponent();
        }


        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.Yellow,
                                                                       Color.DarkOrange,
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }


        private void újFelvételToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            adminFelvetel adminFelvetel = new adminFelvetel();
            flowLayoutPanel1.Controls.Add(adminFelvetel);
        }

        private void adminTörléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            torles torles = new torles(1);
            flowLayoutPanel1.Controls.Add(torles);
        }

        private void újFelvételToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            dolgozoFelvetele dolgozoFelvetele = new dolgozoFelvetele();
            flowLayoutPanel1.Controls.Add(dolgozoFelvetele);
        }
        private void alkalmazottTörléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            torles torles = new torles(2);
            flowLayoutPanel1.Controls.Add(torles);
        }

        private void jelenlegiFeladatokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            feladatok feladatok = new feladatok(2);
            flowLayoutPanel1.Controls.Add(feladatok);
        }

        private void profilomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            bossProfil boss = new bossProfil();
            flowLayoutPanel1.Controls.Add(boss);
        }

        private void üzenetÍrásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ujUzenet ujUzenet = new ujUzenet(1);
            flowLayoutPanel1.Controls.Add(ujUzenet);

        }

        private void üzeneteimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            uzeneteim uzeneteim = new uzeneteim();
            flowLayoutPanel1.Controls.Add(uzeneteim);
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            X.kilepes();
        }

        private void adminokToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void feladatokMódosításaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            feladatModosit feladatModosit = new feladatModosit(1);
            flowLayoutPanel1.Controls.Add(feladatModosit);
        }

        private void feladatTörléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            feladatTorlese feladatTorlese = new feladatTorlese(1);
            flowLayoutPanel1.Controls.Add(feladatTorlese);
        }

        private void bossFelulet_Load(object sender, EventArgs e)
        {


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adminAdatainakMódosíttásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            AdminAdatModosit adminAdatModosit = new AdminAdatModosit();
            flowLayoutPanel1.Controls.Add(adminAdatModosit);
        }

        private void súgóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sugo sugoHasznalat = new sugo();
            flowLayoutPanel1.Controls.Add(sugoHasznalat);
        }

        private void munkatársakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            jelenlegiMunkatarsak jelenlegi = new jelenlegiMunkatarsak();
            flowLayoutPanel1.Controls.Add(jelenlegi);
        }

        private void alkalmazottAdatainakMódosíttásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            AlkalmazottAdatModosit alkalmazottAdatModosit = new AlkalmazottAdatModosit();
            flowLayoutPanel1.Controls.Add(alkalmazottAdatModosit);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
