namespace Controls.AdminControls.ReserVation
{
    partial class AdminReservationHistory
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
            button2 = new Button();
            resetBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            vehcleBox = new ComboBox();
            parkingBox = new ComboBox();
            datePick = new DateTimePicker();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(144, 384);
            button2.Name = "button2";
            button2.Size = new Size(164, 69);
            button2.TabIndex = 17;
            button2.Text = "Export to XML";
            button2.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(144, 271);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(164, 69);
            resetBtn.TabIndex = 16;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 186);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 15;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 129);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 14;
            label2.Text = "Vehicle";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 74);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 13;
            label1.Text = "Parkinglot";
            // 
            // vehcleBox
            // 
            vehcleBox.FormattingEnabled = true;
            vehcleBox.Location = new Point(134, 126);
            vehcleBox.Name = "vehcleBox";
            vehcleBox.Size = new Size(185, 28);
            vehcleBox.TabIndex = 12;
            vehcleBox.Text = "Choose a vehicle";
            // 
            // parkingBox
            // 
            parkingBox.FormattingEnabled = true;
            parkingBox.Location = new Point(134, 71);
            parkingBox.Name = "parkingBox";
            parkingBox.Size = new Size(185, 28);
            parkingBox.TabIndex = 11;
            parkingBox.Text = "Choose a parkinglot";
            // 
            // datePick
            // 
            datePick.CustomFormat = "yyyy-MM";
            datePick.Format = DateTimePickerFormat.Custom;
            datePick.Location = new Point(181, 181);
            datePick.Name = "datePick";
            datePick.ShowUpDown = true;
            datePick.Size = new Size(90, 27);
            datePick.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(386, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(723, 479);
            dataGridView1.TabIndex = 9;
            // 
            // AdminReservationHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(resetBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(vehcleBox);
            Controls.Add(parkingBox);
            Controls.Add(datePick);
            Controls.Add(dataGridView1);
            Name = "AdminReservationHistory";
            Size = new Size(1178, 504);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button resetBtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox vehcleBox;
        private ComboBox parkingBox;
        private DateTimePicker datePick;
        private DataGridView dataGridView1;
    }
}
