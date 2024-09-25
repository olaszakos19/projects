using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace projekt_manager
{
    public partial class adminfelulet : UserControl
    {


        public adminfelulet()
        {
            InitializeComponent();

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.Purple,
                                                                       Color.Blue,
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }


        private void kiadottFeladatokToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dolgozókToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void újFelvételeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            dolgozoFelvetele felvetele = new dolgozoFelvetele();
            flowLayoutPanel1.Controls.Add(felvetele);
        }

        private void jelenlegiekÁttekintéseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dolgozóKirúgásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            torles torles = new torles(2);
            flowLayoutPanel1.Controls.Add(torles);
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {

            X.kilepes(X.felhasznalo, "admins");
        }

        private void profilomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            adminProfil adminProfil = new adminProfil(X.felhasznalo);
            flowLayoutPanel1.Controls.Add(adminProfil);
        }

        private void újÜzenetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ujUzenet ujUzenet = new ujUzenet(0);
            flowLayoutPanel1.Controls.Add(ujUzenet);
        }

        private void üzeneteimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            uzeneteim uzeneteim = new uzeneteim();
            flowLayoutPanel1.Controls.Add(uzeneteim);

        }

        private void súgóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sugo sugoHasznalat = new sugo();
            flowLayoutPanel1.Controls.Add(sugoHasznalat);
        }


        private void újFeladatKiírásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            feladatKiiras kiiras = new feladatKiiras();
            flowLayoutPanel1.Controls.Add(kiiras);
        }

        private void jelenlegiFeladatokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            feladatok feladatok = new feladatok(1);
            flowLayoutPanel1.Controls.Add(feladatok);
        }

        private void feladatMódosíttásaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            feladatModosit feladatModosit = new feladatModosit(0);
            flowLayoutPanel1.Controls.Add(feladatModosit);
        }

        private void feladatTörléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            feladatTorlese feladatTorlese = new feladatTorlese(1);
            flowLayoutPanel1.Controls.Add(feladatTorlese);
        }


        private void adminfelulet_Load(object sender, EventArgs e)
        {

        }

        private void alkalmazottAdatainakMódosíttásaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            AlkalmazottAdatModosit alkalmazottAdatModosit = new AlkalmazottAdatModosit();
            flowLayoutPanel1.Controls.Add(alkalmazottAdatModosit);
        }

        private void munkatársakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            jelenlegiMunkatarsak jelenlegi = new jelenlegiMunkatarsak();
            flowLayoutPanel1.Controls.Add(jelenlegi);
        }

        private void súgóToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sugo sugoHasznalat = new sugo();
            flowLayoutPanel1.Controls.Add(sugoHasznalat);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            adminProfil adminProfil = new adminProfil(X.felhasznalo);
            flowLayoutPanel1.Controls.Add(adminProfil);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
