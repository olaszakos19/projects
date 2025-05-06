namespace Controls
{
    partial class Login
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
            pswdText = new TextBox();
            label3 = new Label();
            emailText = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 135);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 13;
            label4.Text = "Password";
            // 
            // pswdText
            // 
            pswdText.Location = new Point(187, 132);
            pswdText.Name = "pswdText";
            pswdText.Size = new Size(248, 27);
            pswdText.TabIndex = 12;
            pswdText.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 77);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 11;
            label3.Text = "Email";
            // 
            // emailText
            // 
            emailText.Location = new Point(187, 74);
            emailText.Name = "emailText";
            emailText.Size = new Size(248, 27);
            emailText.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(220, 206);
            button1.Name = "button1";
            button1.Size = new Size(197, 68);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(pswdText);
            Controls.Add(label3);
            Controls.Add(emailText);
            Controls.Add(button1);
            Name = "Login";
            Size = new Size(649, 372);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox pswdText;
        private Label label3;
        private TextBox emailText;
        private Button button1;
    }
}
