namespace Controls
{
    partial class UserReservationList
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
            parkingLots = new ComboBox();
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            a = new Label();
            startDate = new Label();
            hourRate = new Label();
            spotText = new Label();
            endDate = new Label();
            label9 = new Label();
            closeBtn = new Button();
            label4 = new Label();
            sum = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // parkingLots
            // 
            parkingLots.FormattingEnabled = true;
            parkingLots.Location = new Point(112, 23);
            parkingLots.Name = "parkingLots";
            parkingLots.Size = new Size(204, 28);
            parkingLots.TabIndex = 0;
            parkingLots.Text = "Choose a  parkinglot";
            parkingLots.SelectedIndexChanged += parkingLots_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Parkinglot";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(34, 167);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(228, 324);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(519, 273);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 3;
            label2.Text = "Spot number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(531, 231);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 4;
            label3.Text = "Hourly rate";
            // 
            // a
            // 
            a.AutoSize = true;
            a.Location = new Point(546, 130);
            a.Name = "a";
            a.Size = new Size(74, 20);
            a.TabIndex = 5;
            a.Text = "Start date";
            // 
            // startDate
            // 
            startDate.AutoSize = true;
            startDate.Location = new Point(653, 130);
            startDate.Name = "startDate";
            startDate.Size = new Size(15, 20);
            startDate.TabIndex = 8;
            startDate.Text = "-";
            // 
            // hourRate
            // 
            hourRate.AutoSize = true;
            hourRate.Location = new Point(653, 231);
            hourRate.Name = "hourRate";
            hourRate.Size = new Size(15, 20);
            hourRate.TabIndex = 7;
            hourRate.Text = "-";
            // 
            // spotText
            // 
            spotText.AutoSize = true;
            spotText.Location = new Point(653, 273);
            spotText.Name = "spotText";
            spotText.Size = new Size(15, 20);
            spotText.TabIndex = 6;
            spotText.Text = "-";
            // 
            // endDate
            // 
            endDate.AutoSize = true;
            endDate.Location = new Point(653, 184);
            endDate.Name = "endDate";
            endDate.Size = new Size(15, 20);
            endDate.TabIndex = 10;
            endDate.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(546, 184);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 9;
            label9.Text = "End date";
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(564, 377);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(131, 62);
            closeBtn.TabIndex = 13;
            closeBtn.Text = "Close now";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 127);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 14;
            label4.Text = "Cars";
            // 
            // sum
            // 
            sum.AutoSize = true;
            sum.Location = new Point(656, 309);
            sum.Name = "sum";
            sum.Size = new Size(15, 20);
            sum.TabIndex = 16;
            sum.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(549, 309);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 15;
            label6.Text = "Summary";
            // 
            // UserReservationList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(sum);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(closeBtn);
            Controls.Add(endDate);
            Controls.Add(label9);
            Controls.Add(startDate);
            Controls.Add(hourRate);
            Controls.Add(spotText);
            Controls.Add(a);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(parkingLots);
            Name = "UserReservationList";
            Size = new Size(988, 525);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox parkingLots;
        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private Label label3;
        private Label a;
        private Label startDate;
        private Label hourRate;
        private Label spotText;
        private Label endDate;
        private Label label9;
        private Button closeBtn;
        private Label label4;
        private Label sum;
        private Label label6;
    }
}
