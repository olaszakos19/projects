namespace AdminControls.Parkinglot
{
    partial class AddParkinglot
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
            postalCodeText = new TextBox();
            cityText = new TextBox();
            adressText = new TextBox();
            addBtn = new Button();
            capacityCount = new NumericUpDown();
            label4 = new Label();
            nameText = new TextBox();
            label5 = new Label();
            label6 = new Label();
            hourlyRate = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)capacityCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hourlyRate).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 198);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Postalcode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 241);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 1;
            label2.Text = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 281);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Adress";
            // 
            // postalCodeText
            // 
            postalCodeText.Location = new Point(357, 195);
            postalCodeText.Name = "postalCodeText";
            postalCodeText.Size = new Size(125, 27);
            postalCodeText.TabIndex = 3;
            // 
            // cityText
            // 
            cityText.Location = new Point(357, 238);
            cityText.Name = "cityText";
            cityText.Size = new Size(125, 27);
            cityText.TabIndex = 4;
            // 
            // adressText
            // 
            adressText.Location = new Point(357, 278);
            adressText.Name = "adressText";
            adressText.Size = new Size(125, 27);
            adressText.TabIndex = 5;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(294, 425);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(267, 55);
            addBtn.TabIndex = 6;
            addBtn.Text = "Add Parkinglot";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // capacityCount
            // 
            capacityCount.Location = new Point(448, 335);
            capacityCount.Name = "capacityCount";
            capacityCount.Size = new Size(69, 27);
            capacityCount.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 337);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 8;
            label4.Text = "Capacity";
            // 
            // nameText
            // 
            nameText.Location = new Point(357, 104);
            nameText.Name = "nameText";
            nameText.Size = new Size(238, 27);
            nameText.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(178, 107);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 9;
            label5.Text = "Parkinglot name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(301, 370);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 12;
            label6.Text = "Hourly rate";
            // 
            // hourlyRate
            // 
            hourlyRate.Location = new Point(448, 368);
            hourlyRate.Maximum = new decimal(new int[] { 800, 0, 0, 0 });
            hourlyRate.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            hourlyRate.Name = "hourlyRate";
            hourlyRate.Size = new Size(69, 27);
            hourlyRate.TabIndex = 11;
            hourlyRate.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // AddParkinglot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(hourlyRate);
            Controls.Add(nameText);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(capacityCount);
            Controls.Add(addBtn);
            Controls.Add(adressText);
            Controls.Add(cityText);
            Controls.Add(postalCodeText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddParkinglot";
            Size = new Size(820, 513);
            ((System.ComponentModel.ISupportInitialize)capacityCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)hourlyRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox postalCodeText;
        private TextBox cityText;
        private TextBox adressText;
        private Button addBtn;
        private NumericUpDown capacityCount;
        private Label label4;
        private TextBox nameText;
        private Label label5;
        private Label label6;
        private NumericUpDown hourlyRate;
    }
}
