namespace Controls.UserControls.REservation
{
    partial class ReservationHistory
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
            dataGridView1 = new DataGridView();
            datePick = new DateTimePicker();
            parkingBox = new ComboBox();
            vehcleBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            resetBtn = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(381, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(706, 527);
            dataGridView1.TabIndex = 0;
            // 
            // datePick
            // 
            datePick.CustomFormat = "yyyy-MM";
            datePick.Format = DateTimePickerFormat.Custom;
            datePick.Location = new Point(173, 207);
            datePick.Name = "datePick";
            datePick.ShowUpDown = true;
            datePick.Size = new Size(90, 27);
            datePick.TabIndex = 1;
            datePick.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // parkingBox
            // 
            parkingBox.FormattingEnabled = true;
            parkingBox.Location = new Point(126, 97);
            parkingBox.Name = "parkingBox";
            parkingBox.Size = new Size(185, 28);
            parkingBox.TabIndex = 2;
            parkingBox.Text = "Choose a parkinglot";
            parkingBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // vehcleBox
            // 
            vehcleBox.FormattingEnabled = true;
            vehcleBox.Location = new Point(126, 152);
            vehcleBox.Name = "vehcleBox";
            vehcleBox.Size = new Size(185, 28);
            vehcleBox.TabIndex = 3;
            vehcleBox.Text = "Choose a vehicle";
            vehcleBox.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 100);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Parkinglot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 155);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 5;
            label2.Text = "Vehicle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 212);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 6;
            label3.Text = "Date";
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(136, 297);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(164, 69);
            resetBtn.TabIndex = 7;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(136, 410);
            button2.Name = "button2";
            button2.Size = new Size(164, 69);
            button2.TabIndex = 8;
            button2.Text = "Export to XML";
            button2.UseVisualStyleBackColor = true;
            // 
            // ReservationHistory
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
            Name = "ReservationHistory";
            Size = new Size(1087, 527);
            Load += ReservationHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker datePick;
        private ComboBox parkingBox;
        private ComboBox vehcleBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button resetBtn;
        private Button button2;
    }
}
