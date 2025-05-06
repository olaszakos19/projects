namespace beadando_F0E7UK
{
    partial class Menu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            addNewVehicle = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            parkolásiElőzményekToolStripMenuItem = new ToolStripMenuItem();
            profilomToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(1, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(1087, 541);
            panel1.TabIndex = 1;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem4, profilomToolStripMenuItem, toolStripMenuItem7 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1088, 28);
            menuStrip2.TabIndex = 3;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { addNewVehicle, toolStripMenuItem3 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(62, 24);
            toolStripMenuItem1.Text = "Autók";
            // 
            // addNewVehicle
            // 
            addNewVehicle.Name = "addNewVehicle";
            addNewVehicle.Size = new Size(234, 26);
            addNewVehicle.Text = "Új hozzá adása";
            addNewVehicle.Click += addNewVehicle_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(234, 26);
            toolStripMenuItem3.Text = "Autóim megtekintése";
            toolStripMenuItem3.Click += ViewVehicles_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem5, toolStripMenuItem6, parkolásiElőzményekToolStripMenuItem });
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(77, 24);
            toolStripMenuItem4.Text = "Parkolás";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(258, 26);
            toolStripMenuItem5.Text = "Új parkolás índíttása";
            toolStripMenuItem5.Click += newReservationStart_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(258, 26);
            toolStripMenuItem6.Text = "Jelenlegiek megtekintése";
            toolStripMenuItem6.Click += showMyReservations_Click;
            // 
            // parkolásiElőzményekToolStripMenuItem
            // 
            parkolásiElőzményekToolStripMenuItem.Name = "parkolásiElőzményekToolStripMenuItem";
            parkolásiElőzményekToolStripMenuItem.Size = new Size(258, 26);
            parkolásiElőzményekToolStripMenuItem.Text = "Parkolási előzmények";
            parkolásiElőzményekToolStripMenuItem.Click += parkolásiElőzményekToolStripMenuItem_Click;
            // 
            // profilomToolStripMenuItem
            // 
            profilomToolStripMenuItem.Name = "profilomToolStripMenuItem";
            profilomToolStripMenuItem.Size = new Size(80, 24);
            profilomToolStripMenuItem.Text = "Profilom";
            profilomToolStripMenuItem.Click += MyProfile_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(71, 24);
            toolStripMenuItem7.Text = "Kilépés";
            toolStripMenuItem7.Click += toolStripMenuItem7_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 617);
            Controls.Add(menuStrip2);
            Controls.Add(panel1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem addNewVehicle;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem profilomToolStripMenuItem;
        private ToolStripMenuItem parkolásiElőzményekToolStripMenuItem;
    }
}