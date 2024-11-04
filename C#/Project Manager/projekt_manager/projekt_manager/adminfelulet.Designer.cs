
namespace projekt_manager
{
    partial class adminfelulet
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
            this.kiadottFeladatokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újFeladatKiírásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jelenlegiFeladatokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feladatMódosíttásaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.feladatTörléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dolgozókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újFelvételeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dolgozóKirúgásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alkalmazottAdatainakMódosíttásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üzenetekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újÜzenetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üzeneteimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.munkatársakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.kiadottFeladatokToolStripMenuItem,
            this.dolgozókToolStripMenuItem,
            this.üzenetekToolStripMenuItem,
            this.toolStripMenuItem1,
            this.munkatársakToolStripMenuItem,
            this.súgóToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(148, 742);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // kiadottFeladatokToolStripMenuItem
            // 
            this.kiadottFeladatokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újFeladatKiírásaToolStripMenuItem,
            this.jelenlegiFeladatokToolStripMenuItem,
            this.feladatMódosíttásaToolStripMenuItem1,
            this.feladatTörléseToolStripMenuItem});
            this.kiadottFeladatokToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kiadottFeladatokToolStripMenuItem.Name = "kiadottFeladatokToolStripMenuItem";
            this.kiadottFeladatokToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.kiadottFeladatokToolStripMenuItem.Text = "Feladatok";
            this.kiadottFeladatokToolStripMenuItem.Click += new System.EventHandler(this.kiadottFeladatokToolStripMenuItem_Click);
            // 
            // újFeladatKiírásaToolStripMenuItem
            // 
            this.újFeladatKiírásaToolStripMenuItem.Name = "újFeladatKiírásaToolStripMenuItem";
            this.újFeladatKiírásaToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.újFeladatKiírásaToolStripMenuItem.Text = "Új feladat kiírása";
            this.újFeladatKiírásaToolStripMenuItem.Click += new System.EventHandler(this.újFeladatKiírásaToolStripMenuItem_Click);
            // 
            // jelenlegiFeladatokToolStripMenuItem
            // 
            this.jelenlegiFeladatokToolStripMenuItem.Name = "jelenlegiFeladatokToolStripMenuItem";
            this.jelenlegiFeladatokToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.jelenlegiFeladatokToolStripMenuItem.Text = "Jelenlegi feladatok";
            this.jelenlegiFeladatokToolStripMenuItem.Click += new System.EventHandler(this.jelenlegiFeladatokToolStripMenuItem_Click);
            // 
            // feladatMódosíttásaToolStripMenuItem1
            // 
            this.feladatMódosíttásaToolStripMenuItem1.Name = "feladatMódosíttásaToolStripMenuItem1";
            this.feladatMódosíttásaToolStripMenuItem1.Size = new System.Drawing.Size(252, 30);
            this.feladatMódosíttásaToolStripMenuItem1.Text = "Feladat módosíttása";
            this.feladatMódosíttásaToolStripMenuItem1.Click += new System.EventHandler(this.feladatMódosíttásaToolStripMenuItem1_Click);
            // 
            // feladatTörléseToolStripMenuItem
            // 
            this.feladatTörléseToolStripMenuItem.Name = "feladatTörléseToolStripMenuItem";
            this.feladatTörléseToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.feladatTörléseToolStripMenuItem.Text = "Feladat törlése";
            this.feladatTörléseToolStripMenuItem.Click += new System.EventHandler(this.feladatTörléseToolStripMenuItem_Click);
            // 
            // dolgozókToolStripMenuItem
            // 
            this.dolgozókToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újFelvételeToolStripMenuItem,
            this.dolgozóKirúgásaToolStripMenuItem,
            this.alkalmazottAdatainakMódosíttásaToolStripMenuItem});
            this.dolgozókToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dolgozókToolStripMenuItem.Name = "dolgozókToolStripMenuItem";
            this.dolgozókToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.dolgozókToolStripMenuItem.Text = "Alkalmazottak";
            this.dolgozókToolStripMenuItem.Click += new System.EventHandler(this.dolgozókToolStripMenuItem_Click);
            // 
            // újFelvételeToolStripMenuItem
            // 
            this.újFelvételeToolStripMenuItem.Name = "újFelvételeToolStripMenuItem";
            this.újFelvételeToolStripMenuItem.Size = new System.Drawing.Size(377, 30);
            this.újFelvételeToolStripMenuItem.Text = "Új felvétele";
            this.újFelvételeToolStripMenuItem.Click += new System.EventHandler(this.újFelvételeToolStripMenuItem_Click);
            // 
            // dolgozóKirúgásaToolStripMenuItem
            // 
            this.dolgozóKirúgásaToolStripMenuItem.Name = "dolgozóKirúgásaToolStripMenuItem";
            this.dolgozóKirúgásaToolStripMenuItem.Size = new System.Drawing.Size(377, 30);
            this.dolgozóKirúgásaToolStripMenuItem.Text = "Alkalmazott kirúgása";
            this.dolgozóKirúgásaToolStripMenuItem.Click += new System.EventHandler(this.dolgozóKirúgásaToolStripMenuItem_Click);
            // 
            // alkalmazottAdatainakMódosíttásaToolStripMenuItem
            // 
            this.alkalmazottAdatainakMódosíttásaToolStripMenuItem.Name = "alkalmazottAdatainakMódosíttásaToolStripMenuItem";
            this.alkalmazottAdatainakMódosíttásaToolStripMenuItem.Size = new System.Drawing.Size(377, 30);
            this.alkalmazottAdatainakMódosíttásaToolStripMenuItem.Text = "Alkalmazott adatainak módosíttása";
            this.alkalmazottAdatainakMódosíttásaToolStripMenuItem.Click += new System.EventHandler(this.alkalmazottAdatainakMódosíttásaToolStripMenuItem_Click_1);
            // 
            // üzenetekToolStripMenuItem
            // 
            this.üzenetekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újÜzenetToolStripMenuItem,
            this.üzeneteimToolStripMenuItem});
            this.üzenetekToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.üzenetekToolStripMenuItem.Image = global::projekt_manager.Properties.Resources.message_w;
            this.üzenetekToolStripMenuItem.Name = "üzenetekToolStripMenuItem";
            this.üzenetekToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.üzenetekToolStripMenuItem.Text = "Üzenetek";
            // 
            // újÜzenetToolStripMenuItem
            // 
            this.újÜzenetToolStripMenuItem.Name = "újÜzenetToolStripMenuItem";
            this.újÜzenetToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.újÜzenetToolStripMenuItem.Text = "Üzenet írása ";
            this.újÜzenetToolStripMenuItem.Click += new System.EventHandler(this.újÜzenetToolStripMenuItem_Click);
            // 
            // üzeneteimToolStripMenuItem
            // 
            this.üzeneteimToolStripMenuItem.Name = "üzeneteimToolStripMenuItem";
            this.üzeneteimToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.üzeneteimToolStripMenuItem.Text = "Üzeneteim";
            this.üzeneteimToolStripMenuItem.Click += new System.EventHandler(this.üzeneteimToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 29);
            this.toolStripMenuItem1.Text = "Profilom";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // munkatársakToolStripMenuItem
            // 
            this.munkatársakToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.munkatársakToolStripMenuItem.Name = "munkatársakToolStripMenuItem";
            this.munkatársakToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.munkatársakToolStripMenuItem.Text = "Munkatársak";
            this.munkatársakToolStripMenuItem.Click += new System.EventHandler(this.munkatársakToolStripMenuItem_Click);
            // 
            // súgóToolStripMenuItem
            // 
            this.súgóToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.súgóToolStripMenuItem.Name = "súgóToolStripMenuItem";
            this.súgóToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.súgóToolStripMenuItem.Text = "Súgó";
            this.súgóToolStripMenuItem.Click += new System.EventHandler(this.súgóToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(151, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1065, 742);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // adminfelulet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "adminfelulet";
            this.Size = new System.Drawing.Size(1357, 742);
            this.Load += new System.EventHandler(this.adminfelulet_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kiadottFeladatokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dolgozókToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újFelvételeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dolgozóKirúgásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem súgóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üzenetekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újÜzenetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üzeneteimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újFeladatKiírásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jelenlegiFeladatokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feladatMódosíttásaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem feladatTörléseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alkalmazottAdatainakMódosíttásaToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem munkatársakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
