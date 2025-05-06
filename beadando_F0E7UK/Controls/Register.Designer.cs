namespace Controls
{
    partial class Register
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
            firstNameText = new TextBox();
            emmailText = new TextBox();
            lastNameText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            passwordText = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(294, 315);
            button1.Name = "button1";
            button1.Size = new Size(197, 68);
            button1.TabIndex = 0;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(261, 67);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(248, 27);
            firstNameText.TabIndex = 1;
            // 
            // emmailText
            // 
            emmailText.Location = new Point(261, 183);
            emmailText.Name = "emmailText";
            emmailText.Size = new Size(248, 27);
            emmailText.TabIndex = 2;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(261, 117);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(248, 27);
            lastNameText.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 70);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 4;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 120);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 5;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 186);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 244);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 8;
            label4.Text = "Password";
            // 
            // passwordText
            // 
            passwordText.Location = new Point(261, 241);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(248, 27);
            passwordText.TabIndex = 7;
            passwordText.UseSystemPasswordChar = true;
            // 
            // Register
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
            Controls.Add(button1);
            Name = "Register";
            Size = new Size(800, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox firstNameText;
        private TextBox emmailText;
        private TextBox lastNameText;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox passwordText;
    }
}
