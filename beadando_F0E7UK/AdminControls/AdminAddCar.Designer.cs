namespace AdminControls
{
    partial class AdminAddCar
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
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            colorBox = new TextBox();
            brandBox = new TextBox();
            typeBox = new TextBox();
            licenseBox = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(391, 402);
            button1.Name = "button1";
            button1.Size = new Size(188, 61);
            button1.TabIndex = 17;
            button1.Text = "Register Car";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(247, 272);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 16;
            label4.Text = "Color";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 206);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 15;
            label3.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 141);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 14;
            label2.Text = "Brand";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 67);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 13;
            label1.Text = "Licenseplate";
            // 
            // colorBox
            // 
            colorBox.Location = new Point(375, 269);
            colorBox.Name = "colorBox";
            colorBox.Size = new Size(224, 27);
            colorBox.TabIndex = 12;
            // 
            // brandBox
            // 
            brandBox.Location = new Point(375, 138);
            brandBox.Name = "brandBox";
            brandBox.Size = new Size(224, 27);
            brandBox.TabIndex = 11;
            // 
            // typeBox
            // 
            typeBox.Location = new Point(375, 203);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(224, 27);
            typeBox.TabIndex = 10;
            // 
            // licenseBox
            // 
            licenseBox.Location = new Point(375, 64);
            licenseBox.Name = "licenseBox";
            licenseBox.Size = new Size(224, 27);
            licenseBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 340);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 18;
            label5.Text = "Owner";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(375, 332);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 28);
            comboBox1.TabIndex = 19;
            // 
            // AdminAddCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(colorBox);
            Controls.Add(brandBox);
            Controls.Add(typeBox);
            Controls.Add(licenseBox);
            Name = "AdminAddCar";
            Size = new Size(931, 522);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox colorBox;
        private TextBox brandBox;
        private TextBox typeBox;
        private TextBox licenseBox;
        private Label label5;
        private ComboBox comboBox1;
    }
}
