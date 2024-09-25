
namespace projekt_manager
{
    partial class dolgozoiFelulet
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.feladataimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üzenetekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üzenetÍrásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üzeneteimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.súgóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feladataimToolStripMenuItem,
            this.üzenetekToolStripMenuItem,
            this.profilomToolStripMenuItem,
            this.súgóToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(124, 742);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // feladataimToolStripMenuItem
            // 
            this.feladataimToolStripMenuItem.Name = "feladataimToolStripMenuItem";
            this.feladataimToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.feladataimToolStripMenuItem.Text = "Feladataim";
            this.feladataimToolStripMenuItem.Click += new System.EventHandler(this.feladataimToolStripMenuItem_Click);
            // 
            // üzenetekToolStripMenuItem
            // 
            this.üzenetekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üzenetÍrásaToolStripMenuItem,
            this.üzeneteimToolStripMenuItem});
            this.üzenetekToolStripMenuItem.Image = global::projekt_manager.Properties.Resources.message;
            this.üzenetekToolStripMenuItem.Name = "üzenetekToolStripMenuItem";
            this.üzenetekToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.üzenetekToolStripMenuItem.Text = "Üzenetek";
            this.üzenetekToolStripMenuItem.Click += new System.EventHandler(this.üzenetekToolStripMenuItem_Click);
            // 
            // üzenetÍrásaToolStripMenuItem
            // 
            this.üzenetÍrásaToolStripMenuItem.Name = "üzenetÍrásaToolStripMenuItem";
            this.üzenetÍrásaToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.üzenetÍrásaToolStripMenuItem.Text = "Üzenet írása";
            this.üzenetÍrásaToolStripMenuItem.Click += new System.EventHandler(this.üzenetÍrásaToolStripMenuItem_Click);
            // 
            // üzeneteimToolStripMenuItem
            // 
            this.üzeneteimToolStripMenuItem.Name = "üzeneteimToolStripMenuItem";
            this.üzeneteimToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.üzeneteimToolStripMenuItem.Text = "Üzeneteim";
            this.üzeneteimToolStripMenuItem.Click += new System.EventHandler(this.üzeneteimToolStripMenuItem_Click);
            // 
            // profilomToolStripMenuItem
            // 
            this.profilomToolStripMenuItem.Image = global::projekt_manager.Properties.Resources.profile;
            this.profilomToolStripMenuItem.Name = "profilomToolStripMenuItem";
            this.profilomToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.profilomToolStripMenuItem.Text = "Profilom";
            this.profilomToolStripMenuItem.Click += new System.EventHandler(this.profilomToolStripMenuItem_Click);
            // 
            // súgóToolStripMenuItem
            // 
            this.súgóToolStripMenuItem.Name = "súgóToolStripMenuItem";
            this.súgóToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.súgóToolStripMenuItem.Text = "Súgó";
            this.súgóToolStripMenuItem.Click += new System.EventHandler(this.súgóToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(127, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1230, 745);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // dolgozoiFelulet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "dolgozoiFelulet";
            this.Size = new System.Drawing.Size(1357, 742);
            this.Load += new System.EventHandler(this.dolgozoiFelulet_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem feladataimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üzenetekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üzenetÍrásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üzeneteimToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem profilomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem súgóToolStripMenuItem;
    }
}
