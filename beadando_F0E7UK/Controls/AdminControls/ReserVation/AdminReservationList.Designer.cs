namespace Controls.AdminControls.ReserVation
{
    partial class AdminReservationList
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label9 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            lotNameTExt = new TextBox();
            deleteBTn = new Button();
            dateTimePicker1 = new DateTimePicker();
            chartOccupancy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label7 = new Label();
            listBox2 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            toText = new Label();
            fromText = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)chartOccupancy).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 22);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 30;
            label9.Text = "Parkinglots";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 62);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 23;
            label1.Text = "Parking lot name";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(54, 59);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(200, 364);
            listBox1.TabIndex = 21;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lotNameTExt
            // 
            lotNameTExt.Location = new Point(425, 62);
            lotNameTExt.Name = "lotNameTExt";
            lotNameTExt.Size = new Size(176, 27);
            lotNameTExt.TabIndex = 32;
            // 
            // deleteBTn
            // 
            deleteBTn.Location = new Point(637, 267);
            deleteBTn.Name = "deleteBTn";
            deleteBTn.Size = new Size(125, 51);
            deleteBTn.TabIndex = 37;
            deleteBTn.Text = "Close reservation";
            deleteBTn.UseVisualStyleBackColor = true;
            deleteBTn.Click += deleteBTn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1016, 92);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(132, 27);
            dateTimePicker1.TabIndex = 38;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // chartOccupancy
            // 
            chartOccupancy.BorderlineColor = Color.Transparent;
            chartArea2.Name = "ChartArea1";
            chartOccupancy.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartOccupancy.Legends.Add(legend2);
            chartOccupancy.Location = new Point(910, 150);
            chartOccupancy.Name = "chartOccupancy";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartOccupancy.Series.Add(series2);
            chartOccupancy.Size = new Size(255, 209);
            chartOccupancy.TabIndex = 39;
            chartOccupancy.Text = "chart1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(825, 97);
            label7.Name = "label7";
            label7.Size = new Size(174, 20);
            label7.TabIndex = 40;
            label7.Text = "Telítettség ezen a napon:";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(335, 154);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(239, 164);
            listBox2.TabIndex = 41;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(623, 177);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 42;
            label2.Text = "Start date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(623, 218);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 43;
            label3.Text = "End date";
            // 
            // toText
            // 
            toText.AutoSize = true;
            toText.Location = new Point(713, 218);
            toText.Name = "toText";
            toText.Size = new Size(15, 20);
            toText.TabIndex = 45;
            toText.Text = "-";
            // 
            // fromText
            // 
            fromText.AutoSize = true;
            fromText.Location = new Point(713, 177);
            fromText.Name = "fromText";
            fromText.Size = new Size(15, 20);
            fromText.TabIndex = 44;
            fromText.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(345, 131);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 46;
            label6.Text = "Vehicles in lot";
            // 
            // AdminReservationList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(toText);
            Controls.Add(fromText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(label7);
            Controls.Add(chartOccupancy);
            Controls.Add(dateTimePicker1);
            Controls.Add(deleteBTn);
            Controls.Add(lotNameTExt);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "AdminReservationList";
            Size = new Size(1245, 465);
            Load += AdminReservationList_Load;
            ((System.ComponentModel.ISupportInitialize)chartOccupancy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label1;
        private ListBox listBox1;
        private TextBox lotNameTExt;
        private Button deleteBTn;
        private DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOccupancy;
        private Label label7;
        private ListBox listBox2;
        private Label label2;
        private Label label3;
        private Label toText;
        private Label fromText;
        private Label label6;
    }
}
