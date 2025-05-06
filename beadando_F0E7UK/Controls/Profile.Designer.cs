namespace Controls
{
    partial class Profile
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
            label4 = new Label();
            passwordText = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lastNameText = new TextBox();
            emmailText = new TextBox();
            firstNameText = new TextBox();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 219);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 27;
            label4.Text = "Password";
            // 
            // passwordText
            // 
            passwordText.Location = new Point(170, 216);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(248, 27);
            passwordText.TabIndex = 26;
            passwordText.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 161);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 25;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 95);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 24;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 45);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 23;
            label1.Text = "First Name";
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(170, 92);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(248, 27);
            lastNameText.TabIndex = 22;
            // 
            // emmailText
            // 
            emmailText.Location = new Point(170, 158);
            emmailText.Name = "emmailText";
            emmailText.Size = new Size(248, 27);
            emmailText.TabIndex = 21;
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(170, 42);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(248, 27);
            firstNameText.TabIndex = 20;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(179, 296);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(197, 68);
            saveBtn.TabIndex = 19;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(passwordText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lastNameText);
            Controls.Add(emmailText);
            Controls.Add(firstNameText);
            Controls.Add(saveBtn);
            Name = "Profile";
            Size = new Size(582, 421);
            Load += Profile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox passwordText;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox lastNameText;
        private TextBox emmailText;
        private TextBox firstNameText;
        private Button saveBtn;
    }
}
