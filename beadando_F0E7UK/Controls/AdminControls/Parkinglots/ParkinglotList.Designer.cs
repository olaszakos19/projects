namespace AdminControls.Parkinglots
{
    partial class ParkinglotList
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
            editBtn = new Button();
            deleteBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            bannedList = new ListBox();
            label7 = new Label();
            unbanBtn = new Button();
            rate = new NumericUpDown();
            lotName = new TextBox();
            postalText = new TextBox();
            cityText = new TextBox();
            addressText = new TextBox();
            cap = new NumericUpDown();
            label9 = new Label();
            label10 = new Label();
            top5 = new ListBox();
            label8 = new Label();
            occupationText = new Label();
            ((System.ComponentModel.ISupportInitialize)rate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cap).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(43, 59);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(200, 364);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(288, 342);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(125, 68);
            editBtn.TabIndex = 1;
            editBtn.Text = "Update";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(451, 342);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(125, 68);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 62);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 3;
            label1.Text = "Parking lot name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 113);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 4;
            label2.Text = "Postal code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(374, 150);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 5;
            label3.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(346, 186);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 6;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(323, 257);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 7;
            label5.Text = "Hourly rate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(342, 222);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 8;
            label6.Text = "Capacity";
            // 
            // bannedList
            // 
            bannedList.FormattingEnabled = true;
            bannedList.Location = new Point(729, 221);
            bannedList.Name = "bannedList";
            bannedList.Size = new Size(357, 84);
            bannedList.TabIndex = 9;
            bannedList.SelectedIndexChanged += bannedList_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(729, 187);
            label7.Name = "label7";
            label7.Size = new Size(115, 20);
            label7.TabIndex = 10;
            label7.Text = "Banned vehicles";
            // 
            // unbanBtn
            // 
            unbanBtn.Location = new Point(845, 360);
            unbanBtn.Name = "unbanBtn";
            unbanBtn.Size = new Size(125, 50);
            unbanBtn.TabIndex = 11;
            unbanBtn.Text = "Unban vehicle";
            unbanBtn.UseVisualStyleBackColor = true;
            unbanBtn.Click += unbanBtn_Click;
            // 
            // rate
            // 
            rate.Location = new Point(451, 255);
            rate.Maximum = new decimal(new int[] { 800, 0, 0, 0 });
            rate.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            rate.Name = "rate";
            rate.Size = new Size(64, 27);
            rate.TabIndex = 14;
            rate.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // lotName
            // 
            lotName.Location = new Point(426, 59);
            lotName.Name = "lotName";
            lotName.Size = new Size(229, 27);
            lotName.TabIndex = 15;
            // 
            // postalText
            // 
            postalText.Location = new Point(426, 109);
            postalText.Name = "postalText";
            postalText.Size = new Size(186, 27);
            postalText.TabIndex = 16;
            // 
            // cityText
            // 
            cityText.Location = new Point(426, 147);
            cityText.Name = "cityText";
            cityText.Size = new Size(186, 27);
            cityText.TabIndex = 17;
            // 
            // addressText
            // 
            addressText.Location = new Point(426, 183);
            addressText.Name = "addressText";
            addressText.Size = new Size(186, 27);
            addressText.TabIndex = 18;
            // 
            // cap
            // 
            cap.Location = new Point(451, 220);
            cap.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            cap.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            cap.Name = "cap";
            cap.Size = new Size(64, 27);
            cap.TabIndex = 19;
            cap.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 22);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 20;
            label9.Text = "Parkinglots";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(732, 52);
            label10.Name = "label10";
            label10.Size = new Size(162, 20);
            label10.TabIndex = 22;
            label10.Text = "Top 5 Vehicle in this lot";
            // 
            // top5
            // 
            top5.FormattingEnabled = true;
            top5.Location = new Point(732, 86);
            top5.Name = "top5";
            top5.Size = new Size(357, 84);
            top5.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(340, 295);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 12;
            label8.Text = "Capacity";
            // 
            // occupationText
            // 
            occupationText.AutoSize = true;
            occupationText.Location = new Point(451, 295);
            occupationText.Name = "occupationText";
            occupationText.Size = new Size(15, 20);
            occupationText.TabIndex = 13;
            occupationText.Text = "-";
            // 
            // ParkinglotList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label10);
            Controls.Add(top5);
            Controls.Add(label9);
            Controls.Add(cap);
            Controls.Add(addressText);
            Controls.Add(cityText);
            Controls.Add(postalText);
            Controls.Add(lotName);
            Controls.Add(rate);
            Controls.Add(occupationText);
            Controls.Add(label8);
            Controls.Add(unbanBtn);
            Controls.Add(label7);
            Controls.Add(bannedList);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(listBox1);
            Name = "ParkinglotList";
            Size = new Size(1111, 521);
            ((System.ComponentModel.ISupportInitialize)rate).EndInit();
            ((System.ComponentModel.ISupportInitialize)cap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button editBtn;
        private Button deleteBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox bannedList;
        private Label label7;
        private Button unbanBtn;
        private NumericUpDown rate;
        private TextBox lotName;
        private TextBox postalText;
        private TextBox cityText;
        private TextBox addressText;
        private NumericUpDown cap;
        private Label label9;
        private Label label10;
        private ListBox top5;
        private Label label8;
        private Label occupationText;
    }
}
