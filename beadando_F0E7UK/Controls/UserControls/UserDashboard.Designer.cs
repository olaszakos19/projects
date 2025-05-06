namespace Controls.UserControls
{
    partial class UserDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            label1 = new Label();
            vCount = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            startDate = new DateTimePicker();
            endDate = new DateTimePicker();
            rCount = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F);
            label1.Location = new Point(108, 109);
            label1.Name = "label1";
            label1.Size = new Size(253, 38);
            label1.TabIndex = 0;
            label1.Text = "Total vehicle count:";
            // 
            // vCount
            // 
            vCount.AutoSize = true;
            vCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            vCount.Location = new Point(404, 123);
            vCount.Name = "vCount";
            vCount.Size = new Size(20, 28);
            vCount.TabIndex = 2;
            vCount.Text = "-";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(339, 245);
            chart1.Name = "chart1";
            chart1.Size = new Size(673, 265);
            chart1.TabIndex = 3;
            chart1.Text = "chart1";
            // 
            // startDate
            // 
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Location = new Point(386, 189);
            startDate.Name = "startDate";
            startDate.Size = new Size(126, 27);
            startDate.TabIndex = 4;
            startDate.ValueChanged += startDate_ValueChanged;
            // 
            // endDate
            // 
            endDate.Format = DateTimePickerFormat.Short;
            endDate.Location = new Point(750, 189);
            endDate.Name = "endDate";
            endDate.Size = new Size(126, 27);
            endDate.TabIndex = 5;
            endDate.ValueChanged += endDate_ValueChanged;
            // 
            // rCount
            // 
            rCount.AutoSize = true;
            rCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            rCount.Location = new Point(404, 69);
            rCount.Name = "rCount";
            rCount.Size = new Size(20, 28);
            rCount.TabIndex = 7;
            rCount.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new Point(136, 59);
            label3.Name = "label3";
            label3.Size = new Size(225, 38);
            label3.TabIndex = 6;
            label3.Text = "Aktív parkolások:";
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rCount);
            Controls.Add(label3);
            Controls.Add(endDate);
            Controls.Add(startDate);
            Controls.Add(chart1);
            Controls.Add(vCount);
            Controls.Add(label1);
            Name = "UserDashboard";
            Size = new Size(1213, 577);
            Load += UserDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label vCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DateTimePicker startDate;
        private DateTimePicker endDate;
        private Label rCount;
        private Label label3;
    }
}
