namespace Controls.UserControls.Vehicles
{
    partial class VehicleList
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
            licensText = new TextBox();
            colorText = new TextBox();
            typeText = new TextBox();
            brandText = new TextBox();
            deleteBTn = new Button();
            editBtn = new Button();
            label2 = new Label();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // licensText
            // 
            licensText.Location = new Point(389, 121);
            licensText.Name = "licensText";
            licensText.Size = new Size(171, 27);
            licensText.TabIndex = 28;
            // 
            // colorText
            // 
            colorText.Location = new Point(389, 231);
            colorText.Name = "colorText";
            colorText.Size = new Size(171, 27);
            colorText.TabIndex = 27;
            // 
            // typeText
            // 
            typeText.Location = new Point(389, 194);
            typeText.Name = "typeText";
            typeText.Size = new Size(171, 27);
            typeText.TabIndex = 26;
            // 
            // brandText
            // 
            brandText.Location = new Point(389, 154);
            brandText.Name = "brandText";
            brandText.Size = new Size(171, 27);
            brandText.TabIndex = 25;
            // 
            // deleteBTn
            // 
            deleteBTn.Location = new Point(423, 361);
            deleteBTn.Name = "deleteBTn";
            deleteBTn.Size = new Size(93, 48);
            deleteBTn.TabIndex = 23;
            deleteBTn.Text = "Delete";
            deleteBTn.UseVisualStyleBackColor = true;
            deleteBTn.Click += deleteBTn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(423, 305);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(93, 48);
            editBtn.TabIndex = 22;
            editBtn.Text = "Update";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 231);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 20;
            label2.Text = "Color";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(292, 123);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 19;
            label6.Text = "Licenseplate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 194);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 18;
            label4.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 157);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 17;
            label1.Text = "Brand";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(20, 61);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(222, 444);
            listBox1.TabIndex = 16;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // VehicleList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(licensText);
            Controls.Add(colorText);
            Controls.Add(typeText);
            Controls.Add(brandText);
            Controls.Add(deleteBTn);
            Controls.Add(editBtn);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "VehicleList";
            Size = new Size(711, 548);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox licensText;
        private TextBox colorText;
        private TextBox typeText;
        private TextBox brandText;
        private Button deleteBTn;
        private Button editBtn;
        private Label label2;
        private Label label6;
        private Label label4;
        private Label label1;
        private ListBox listBox1;
    }
}
