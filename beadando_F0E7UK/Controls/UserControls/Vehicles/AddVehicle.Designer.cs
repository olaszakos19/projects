namespace Controls.UserControls.Vehicles
{
    partial class AddVehicle
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
            licenseBox = new TextBox();
            typeBox = new TextBox();
            brandBox = new TextBox();
            colorBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // licenseBox
            // 
            licenseBox.Location = new Point(306, 91);
            licenseBox.Name = "licenseBox";
            licenseBox.Size = new Size(224, 27);
            licenseBox.TabIndex = 0;
            // 
            // typeBox
            // 
            typeBox.Location = new Point(306, 230);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(224, 27);
            typeBox.TabIndex = 1;
            // 
            // brandBox
            // 
            brandBox.Location = new Point(306, 165);
            brandBox.Name = "brandBox";
            brandBox.Size = new Size(224, 27);
            brandBox.TabIndex = 2;
            // 
            // colorBox
            // 
            colorBox.Location = new Point(306, 296);
            colorBox.Name = "colorBox";
            colorBox.Size = new Size(224, 27);
            colorBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 94);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 4;
            label1.Text = "Licenseplate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 168);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 5;
            label2.Text = "Brand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 233);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 6;
            label3.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 299);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 7;
            label4.Text = "Color";
            // 
            // button1
            // 
            button1.Location = new Point(326, 378);
            button1.Name = "button1";
            button1.Size = new Size(188, 61);
            button1.TabIndex = 8;
            button1.Text = "Register Car";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(colorBox);
            Controls.Add(brandBox);
            Controls.Add(typeBox);
            Controls.Add(licenseBox);
            Name = "AddCar";
            Size = new Size(873, 475);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox licenseBox;
        private TextBox typeBox;
        private TextBox brandBox;
        private TextBox colorBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}
