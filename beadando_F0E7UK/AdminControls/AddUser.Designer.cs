namespace AdminControls
{
    partial class AddUser
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
            button1 = new Button();
            isadmin = new CheckBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 291);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 17;
            label4.Text = "Password";
            // 
            // passwordText
            // 
            passwordText.Location = new Point(223, 288);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(248, 27);
            passwordText.TabIndex = 16;
            passwordText.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 233);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 15;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 167);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 14;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 117);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 13;
            label1.Text = "First Name";
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(223, 164);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(248, 27);
            lastNameText.TabIndex = 12;
            // 
            // emmailText
            // 
            emmailText.Location = new Point(223, 230);
            emmailText.Name = "emmailText";
            emmailText.Size = new Size(248, 27);
            emmailText.TabIndex = 11;
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(223, 114);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(248, 27);
            firstNameText.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(255, 408);
            button1.Name = "button1";
            button1.Size = new Size(197, 68);
            button1.TabIndex = 9;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // isadmin
            // 
            isadmin.AutoSize = true;
            isadmin.Location = new Point(298, 348);
            isadmin.Name = "isadmin";
            isadmin.Size = new Size(82, 24);
            isadmin.TabIndex = 18;
            isadmin.Text = "Admin?";
            isadmin.UseVisualStyleBackColor = true;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(isadmin);
            Controls.Add(label4);
            Controls.Add(passwordText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lastNameText);
            Controls.Add(emmailText);
            Controls.Add(firstNameText);
            Controls.Add(button1);
            Name = "AddUser";
            Size = new Size(773, 540);
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
        private Button button1;
        private CheckBox isadmin;
    }
}
