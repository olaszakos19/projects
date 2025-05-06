namespace Controls.AdminControls.ReserVation
{
    partial class RevenuePage
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
            label3 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            monthBox = new DateTimePicker();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(123, 323);
            button2.Name = "button2";
            button2.Size = new Size(164, 69);
            button2.TabIndex = 17;
            button2.Text = "Export to XML";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 212);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 15;
            label3.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 148);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 13;
            label1.Text = "Parkinglot";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 28);
            comboBox1.TabIndex = 11;
            comboBox1.Text = "Choose a parkinglot";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // monthBox
            // 
            monthBox.CustomFormat = "yyyy-MM";
            monthBox.Format = DateTimePickerFormat.Custom;
            monthBox.Location = new Point(170, 207);
            monthBox.Name = "monthBox";
            monthBox.ShowUpDown = true;
            monthBox.Size = new Size(90, 27);
            monthBox.TabIndex = 10;
            monthBox.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(404, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(706, 461);
            dataGridView1.TabIndex = 9;
            // 
            // RevenuePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(monthBox);
            Controls.Add(dataGridView1);
            Name = "RevenuePage";
            Size = new Size(1194, 542);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label3;
        private Label label1;
        private ComboBox comboBox1;
        private DateTimePicker monthBox;
        private DataGridView dataGridView1;
    }
}
