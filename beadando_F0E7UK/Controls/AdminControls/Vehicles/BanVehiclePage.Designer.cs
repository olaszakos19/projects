namespace Controls.AdminControls.Vehicles
{
    partial class BanVehiclePage
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
            reasonBox = new RichTextBox();
            parkingBox = new ComboBox();
            vehicleBox = new ListBox();
            BanHammer = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // reasonBox
            // 
            reasonBox.Location = new Point(386, 143);
            reasonBox.Name = "reasonBox";
            reasonBox.Size = new Size(351, 201);
            reasonBox.TabIndex = 0;
            reasonBox.Text = "";
            // 
            // parkingBox
            // 
            parkingBox.FormattingEnabled = true;
            parkingBox.Location = new Point(149, 21);
            parkingBox.Name = "parkingBox";
            parkingBox.Size = new Size(189, 28);
            parkingBox.TabIndex = 1;
            // 
            // vehicleBox
            // 
            vehicleBox.FormattingEnabled = true;
            vehicleBox.Location = new Point(47, 130);
            vehicleBox.Name = "vehicleBox";
            vehicleBox.Size = new Size(218, 284);
            vehicleBox.TabIndex = 2;
            vehicleBox.SelectedIndexChanged += vehicleBox_SelectedIndexChanged;
            // 
            // BanHammer
            // 
            BanHammer.Location = new Point(878, 191);
            BanHammer.Name = "BanHammer";
            BanHammer.Size = new Size(153, 52);
            BanHammer.TabIndex = 3;
            BanHammer.Text = "Ban";
            BanHammer.UseVisualStyleBackColor = true;
            BanHammer.Click += BanHammer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(409, 106);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 4;
            label1.Text = "Reason";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 24);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 5;
            label2.Text = "Parkinglot";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 87);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 6;
            label3.Text = "Vehicles";
            // 
            // BanVehiclePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BanHammer);
            Controls.Add(vehicleBox);
            Controls.Add(parkingBox);
            Controls.Add(reasonBox);
            Name = "BanVehiclePage";
            Size = new Size(1084, 439);
            Load += BanVehiclePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox reasonBox;
        private ComboBox parkingBox;
        private ListBox vehicleBox;
        private Button BanHammer;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
