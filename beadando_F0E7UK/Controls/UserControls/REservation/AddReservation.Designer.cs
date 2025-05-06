namespace Controls
{
    partial class AddReservation
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
            label3 = new Label();
            startBtn = new Button();
            parkingBox = new ComboBox();
            myCarBox = new ComboBox();
            postalText = new Label();
            cityText = new Label();
            addressText = new Label();
            rateText = new Label();
            label8 = new Label();
            spotsBox = new ComboBox();
            label4 = new Label();
            startDate = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            endDate = new DateTimePicker();
            label7 = new Label();
            licenseText = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 55);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Parkinglot name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 296);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 1;
            label2.Text = "Car";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 115);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 2;
            label3.Text = "Parkinglot address";
            // 
            // startBtn
            // 
            startBtn.Location = new Point(350, 389);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(232, 69);
            startBtn.TabIndex = 3;
            startBtn.Text = "valami nev";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // parkingBox
            // 
            parkingBox.FormattingEnabled = true;
            parkingBox.Location = new Point(365, 52);
            parkingBox.Name = "parkingBox";
            parkingBox.Size = new Size(194, 28);
            parkingBox.TabIndex = 4;
            parkingBox.SelectedIndexChanged += parkingBox_SelectedIndexChanged;
            // 
            // myCarBox
            // 
            myCarBox.FormattingEnabled = true;
            myCarBox.Location = new Point(365, 293);
            myCarBox.Name = "myCarBox";
            myCarBox.Size = new Size(194, 28);
            myCarBox.TabIndex = 5;
            myCarBox.SelectedIndexChanged += myCarBox_SelectedIndexChanged;
            // 
            // postalText
            // 
            postalText.AutoSize = true;
            postalText.Location = new Point(379, 115);
            postalText.Name = "postalText";
            postalText.Size = new Size(15, 20);
            postalText.TabIndex = 6;
            postalText.Text = "-";
            // 
            // cityText
            // 
            cityText.AutoSize = true;
            cityText.Location = new Point(472, 115);
            cityText.Name = "cityText";
            cityText.Size = new Size(15, 20);
            cityText.TabIndex = 8;
            cityText.Text = "-";
            cityText.Click += cityText_Click;
            // 
            // addressText
            // 
            addressText.AutoSize = true;
            addressText.Location = new Point(567, 115);
            addressText.Name = "addressText";
            addressText.Size = new Size(15, 20);
            addressText.TabIndex = 7;
            addressText.Text = "-";
            // 
            // rateText
            // 
            rateText.AutoSize = true;
            rateText.Location = new Point(451, 171);
            rateText.Name = "rateText";
            rateText.Size = new Size(15, 20);
            rateText.TabIndex = 10;
            rateText.Text = "-";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(207, 171);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 9;
            label8.Text = "Hourly rate";
            // 
            // spotsBox
            // 
            spotsBox.FormattingEnabled = true;
            spotsBox.Location = new Point(365, 225);
            spotsBox.Name = "spotsBox";
            spotsBox.Size = new Size(194, 28);
            spotsBox.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 233);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 11;
            label4.Text = "Spot";
            // 
            // startDate
            // 
            startDate.CustomFormat = "yyyy.MM.dd HH:mm";
            startDate.Format = DateTimePickerFormat.Custom;
            startDate.Location = new Point(718, 282);
            startDate.MinDate = new DateTime(2025, 4, 26, 0, 0, 0, 0);
            startDate.Name = "startDate";
            startDate.Size = new Size(156, 27);
            startDate.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(638, 287);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 15;
            label5.Text = "Start date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(638, 334);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 17;
            label6.Text = "End date";
            // 
            // endDate
            // 
            endDate.CustomFormat = "yyyy.MM.dd HH:mm";
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.Location = new Point(718, 329);
            endDate.Name = "endDate";
            endDate.Size = new Size(156, 27);
            endDate.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(350, 336);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 18;
            label7.Text = "Licenseplate";
            // 
            // licenseText
            // 
            licenseText.AutoSize = true;
            licenseText.Location = new Point(488, 336);
            licenseText.Name = "licenseText";
            licenseText.Size = new Size(15, 20);
            licenseText.TabIndex = 19;
            licenseText.Text = "-";
            // 
            // AddReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Controls.Add(myCarBox);
            Controls.Add(parkingBox);
            Controls.Add(startBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddReservation";
            Size = new Size(927, 517);
            Load += AddReservation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button startBtn;
        private ComboBox parkingBox;
        private ComboBox myCarBox;
        private Label postalText;
        private Label cityText;
        private Label addressText;
        private Label rateText;
        private Label label8;
        private ComboBox spotsBox;
        private Label label4;
        private DateTimePicker startDate;
        private Label label5;
        private Label label6;
        private DateTimePicker endDate;
        private Label label7;
        private Label licenseText;
    }
}
