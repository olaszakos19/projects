namespace AdminControls.Vehicles
{
    partial class AdminCarList
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
            listBox1 = new ListBox();
            label1 = new Label();
            label4 = new Label();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            editBtn = new Button();
            deleteBTn = new Button();
            ownerBox = new ComboBox();
            brandText = new TextBox();
            typeText = new TextBox();
            colorText = new TextBox();
            licensText = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(23, 50);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(222, 404);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(370, 98);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 1;
            label1.Text = "Brand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(378, 135);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 3;
            label4.Text = "Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(327, 64);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 5;
            label6.Text = "Licenseplate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 172);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 6;
            label2.Text = "Color";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 230);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 7;
            label3.Text = "Owner";
            // 
            // editBtn
            // 
            editBtn.Location = new Point(455, 306);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(93, 48);
            editBtn.TabIndex = 8;
            editBtn.Text = "Update";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBTn
            // 
            deleteBTn.Location = new Point(455, 362);
            deleteBTn.Name = "deleteBTn";
            deleteBTn.Size = new Size(93, 48);
            deleteBTn.TabIndex = 9;
            deleteBTn.Text = "Delete";
            deleteBTn.UseVisualStyleBackColor = true;
            deleteBTn.Click += deleteBTn_Click;
            // 
            // ownerBox
            // 
            ownerBox.FormattingEnabled = true;
            ownerBox.Location = new Point(434, 227);
            ownerBox.Name = "ownerBox";
            ownerBox.Size = new Size(161, 28);
            ownerBox.TabIndex = 11;
            // 
            // brandText
            // 
            brandText.Location = new Point(424, 95);
            brandText.Name = "brandText";
            brandText.Size = new Size(171, 27);
            brandText.TabIndex = 12;
            // 
            // typeText
            // 
            typeText.Location = new Point(424, 135);
            typeText.Name = "typeText";
            typeText.Size = new Size(171, 27);
            typeText.TabIndex = 13;
            // 
            // colorText
            // 
            colorText.Location = new Point(424, 172);
            colorText.Name = "colorText";
            colorText.Size = new Size(171, 27);
            colorText.TabIndex = 14;
            // 
            // licensText
            // 
            licensText.Location = new Point(424, 62);
            licensText.Name = "licensText";
            licensText.Size = new Size(171, 27);
            licensText.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 18);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 16;
            label5.Text = "Vehicles";
            // 
            // AdminCarList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(licensText);
            Controls.Add(colorText);
            Controls.Add(typeText);
            Controls.Add(brandText);
            Controls.Add(ownerBox);
            Controls.Add(deleteBTn);
            Controls.Add(editBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "AdminCarList";
            Size = new Size(1000, 483);
            Load += AdminCarList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label4;
        private Label label6;
        private Label label2;
        private Label label3;
        private Button editBtn;
        private Button deleteBTn;
        private ComboBox ownerBox;
        private TextBox brandText;
        private TextBox typeText;
        private TextBox colorText;
        private TextBox licensText;
        private Label label5;
    }
}
