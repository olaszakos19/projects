namespace Controls.AdminControls
{
    partial class AdminDashboard
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
            label1 = new Label();
            label2 = new Label();
            parkingCount = new Label();
            userCount = new Label();
            totalVhicle = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F);
            label1.Location = new Point(109, 134);
            label1.Name = "label1";
            label1.Size = new Size(220, 38);
            label1.TabIndex = 0;
            label1.Text = "Total user count:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.Location = new Point(109, 193);
            label2.Name = "label2";
            label2.Size = new Size(292, 38);
            label2.TabIndex = 1;
            label2.Text = "Total parkinglot count:";
            // 
            // parkingCount
            // 
            parkingCount.AutoSize = true;
            parkingCount.Font = new Font("Segoe UI", 12F);
            parkingCount.Location = new Point(407, 200);
            parkingCount.Name = "parkingCount";
            parkingCount.Size = new Size(20, 28);
            parkingCount.TabIndex = 3;
            parkingCount.Text = "-";
            // 
            // userCount
            // 
            userCount.AutoSize = true;
            userCount.Font = new Font("Segoe UI", 12F);
            userCount.Location = new Point(352, 141);
            userCount.Name = "userCount";
            userCount.Size = new Size(20, 28);
            userCount.TabIndex = 2;
            userCount.Text = "-";
            // 
            // totalVhicle
            // 
            totalVhicle.AutoSize = true;
            totalVhicle.Font = new Font("Segoe UI", 12F);
            totalVhicle.Location = new Point(407, 261);
            totalVhicle.Name = "totalVhicle";
            totalVhicle.Size = new Size(20, 28);
            totalVhicle.TabIndex = 5;
            totalVhicle.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F);
            label6.Location = new Point(109, 254);
            label6.Name = "label6";
            label6.Size = new Size(253, 38);
            label6.TabIndex = 4;
            label6.Text = "Total vehicle count:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(870, 207);
            label7.Name = "label7";
            label7.Size = new Size(20, 28);
            label7.TabIndex = 7;
            label7.Text = "-";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F);
            label8.Location = new Point(572, 200);
            label8.Name = "label8";
            label8.Size = new Size(285, 38);
            label8.TabIndex = 6;
            label8.Text = "Most used parkinglot:";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(totalVhicle);
            Controls.Add(label6);
            Controls.Add(parkingCount);
            Controls.Add(userCount);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminDashboard";
            Size = new Size(1267, 546);
            Load += AdminDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label parkingCount;
        private Label userCount;
        private Label totalVhicle;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
