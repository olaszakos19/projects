namespace Controls.AdminControls.ReserVation
{
    partial class AdminAddReservation
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
            licenseText = new Label();
            label7 = new Label();
            label6 = new Label();
            endDate = new DateTimePicker();
            label5 = new Label();
            startDate = new DateTimePicker();
            spotsBox = new ComboBox();
            label4 = new Label();
            rateText = new Label();
            label8 = new Label();
            cityText = new Label();
            addressText = new Label();
            postalText = new Label();
            vehicleBox = new ComboBox();
            parkingBox = new ComboBox();
            startBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            userBox = new ComboBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // licenseText
            // 
            licenseText.AutoSize = true;
            licenseText.Location = new Point(388, 384);
            licenseText.Name = "licenseText";
            licenseText.Size = new Size(15, 20);
            licenseText.TabIndex = 38;
            licenseText.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(250, 384);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 37;
            label7.Text = "Licenseplate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(620, 161);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 36;
            label6.Text = "End date";
            // 
            // endDate
            // 
            endDate.CustomFormat = "yyyy.MM.dd HH:mm";
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.Location = new Point(700, 156);
            endDate.Name = "endDate";
            endDate.Size = new Size(156, 27);
            endDate.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(620, 114);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 34;
            label5.Text = "Start date";
            // 
            // startDate
            // 
            startDate.CustomFormat = "yyyy.MM.dd HH:mm";
            startDate.Format = DateTimePickerFormat.Custom;
            startDate.Location = new Point(700, 109);
            startDate.MinDate = new DateTime(2025, 4, 26, 0, 0, 0, 0);
            startDate.Name = "startDate";
            startDate.Size = new Size(156, 27);
            startDate.TabIndex = 33;
            // 
            // spotsBox
            // 
            spotsBox.FormattingEnabled = true;
            spotsBox.Location = new Point(265, 235);
            spotsBox.Name = "spotsBox";
            spotsBox.Size = new Size(194, 28);
            spotsBox.TabIndex = 32;
            spotsBox.SelectedIndexChanged += spotsBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 243);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 31;
            label4.Text = "Spot";
            // 
            // rateText
            // 
            rateText.AutoSize = true;
            rateText.Location = new Point(351, 181);
            rateText.Name = "rateText";
            rateText.Size = new Size(15, 20);
            rateText.TabIndex = 30;
            rateText.Text = "-";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(106, 181);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 29;
            label8.Text = "Hourly rate";
            // 
            // cityText
            // 
            cityText.AutoSize = true;
            cityText.Location = new Point(372, 125);
            cityText.Name = "cityText";
            cityText.Size = new Size(15, 20);
            cityText.TabIndex = 28;
            cityText.Text = "-";
            // 
            // addressText
            // 
            addressText.AutoSize = true;
            addressText.Location = new Point(467, 125);
            addressText.Name = "addressText";
            addressText.Size = new Size(15, 20);
            addressText.TabIndex = 27;
            addressText.Text = "-";
            // 
            // postalText
            // 
            postalText.AutoSize = true;
            postalText.Location = new Point(279, 125);
            postalText.Name = "postalText";
            postalText.Size = new Size(15, 20);
            postalText.TabIndex = 26;
            postalText.Text = "-";
            // 
            // vehicleBox
            // 
            vehicleBox.FormattingEnabled = true;
            vehicleBox.Location = new Point(265, 341);
            vehicleBox.Name = "vehicleBox";
            vehicleBox.Size = new Size(194, 28);
            vehicleBox.TabIndex = 25;
            vehicleBox.SelectedIndexChanged += myCarBox_SelectedIndexChanged;
            // 
            // parkingBox
            // 
            parkingBox.FormattingEnabled = true;
            parkingBox.Location = new Point(265, 62);
            parkingBox.Name = "parkingBox";
            parkingBox.Size = new Size(194, 28);
            parkingBox.TabIndex = 24;
            parkingBox.SelectedIndexChanged += parkingBox_SelectedIndexChanged;
            // 
            // startBtn
            // 
            startBtn.Location = new Point(250, 428);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(232, 69);
            startBtn.TabIndex = 23;
            startBtn.Text = "valami nev";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 125);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 22;
            label3.Text = "Parkinglot address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 344);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 21;
            label2.Text = "Car";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 65);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 20;
            label1.Text = "Parkinglot name";
            // 
            // userBox
            // 
            userBox.FormattingEnabled = true;
            userBox.Location = new Point(265, 294);
            userBox.Name = "userBox";
            userBox.Size = new Size(194, 28);
            userBox.TabIndex = 40;
            userBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(152, 297);
            label11.Name = "label11";
            label11.Size = new Size(38, 20);
            label11.TabIndex = 39;
            label11.Text = "User";
            // 
            // AdminAddReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(userBox);
            Controls.Add(label11);
            Controls.Add(licenseText);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(endDate);
            Controls.Add(label5);
            Controls.Add(startDate);
            Controls.Add(spotsBox);
            Controls.Add(label4);
            Controls.Add(rateText);
            Controls.Add(label8);
            Controls.Add(cityText);
            Controls.Add(addressText);
            Controls.Add(postalText);
            Controls.Add(vehicleBox);
            Controls.Add(parkingBox);
            Controls.Add(startBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminAddReservation";
            Size = new Size(929, 526);
            Load += AddReservation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label licenseText;
        private Label label7;
        private Label label6;
        private DateTimePicker endDate;
        private Label label5;
        private DateTimePicker startDate;
        private ComboBox spotsBox;
        private Label label4;
        private Label rateText;
        private Label label8;
        private Label cityText;
        private Label addressText;
        private Label postalText;
        private ComboBox vehicleBox;
        private ComboBox parkingBox;
        private Button startBtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox userBox;
        private Label label11;
    }
}
