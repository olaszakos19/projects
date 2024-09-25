using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace projekt_manager
{
    public partial class dolgozoiFelulet : UserControl
    {

        public dolgozoiFelulet()
        {
            InitializeComponent();
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

        private void feladataimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            feladataim feladataim = new feladataim();
            flowLayoutPanel1.Controls.Add(feladataim);
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            X.kilepes(X.felhasznalo, "workers");
        }

        private void üzenetekToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void üzenetÍrásaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void profilomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            alkalmazottProfil alkalmazottProfil = new alkalmazottProfil();
            flowLayoutPanel1.Controls.Add(alkalmazottProfil);
        }



        private void dolgozoiFelulet_Load(object sender, EventArgs e)
        {
        }

        private void súgóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sugo sugoHasznalat = new sugo();
            flowLayoutPanel1.Controls.Add(sugoHasznalat);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
