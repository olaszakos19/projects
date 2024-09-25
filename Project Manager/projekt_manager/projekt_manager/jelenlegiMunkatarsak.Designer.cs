
namespace projekt_manager
{
    partial class jelenlegiMunkatarsak
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
            this.components = new System.ComponentModel.Container();
            this.watcher = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ceoList = new System.Windows.Forms.ListBox();
            this.adminList = new System.Windows.Forms.ListBox();
            this.employeeList = new System.Windows.Forms.ListBox();
            this.isLoggedInLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.professionLabel = new System.Windows.Forms.Label();
            this.avatarPicture = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // watcher
            // 
            this.watcher.Enabled = true;
            this.watcher.Tick += new System.EventHandler(this.watcher_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Munkacsoport";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rendszergazdák";
            // 
            // ceoList
            // 
            this.ceoList.FormattingEnabled = true;
            this.ceoList.Location = new System.Drawing.Point(30, 102);
            this.ceoList.Name = "ceoList";
            this.ceoList.Size = new System.Drawing.Size(137, 43);
            this.ceoList.TabIndex = 3;
            this.ceoList.SelectedIndexChanged += new System.EventHandler(this.ceoList_SelectedIndexChanged);
            // 
            // adminList
            // 
            this.adminList.FormattingEnabled = true;
            this.adminList.Location = new System.Drawing.Point(30, 375);
            this.adminList.Name = "adminList";
            this.adminList.Size = new System.Drawing.Size(137, 134);
            this.adminList.TabIndex = 4;
            this.adminList.SelectedIndexChanged += new System.EventHandler(this.adminList_SelectedIndexChanged);
            // 
            // employeeList
            // 
            this.employeeList.FormattingEnabled = true;
            this.employeeList.Location = new System.Drawing.Point(30, 168);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(137, 186);
            this.employeeList.TabIndex = 5;
            this.employeeList.SelectedIndexChanged += new System.EventHandler(this.employeeList_SelectedIndexChanged);
            // 
            // isLoggedInLabel
            // 
            this.isLoggedInLabel.AutoSize = true;
            this.isLoggedInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.isLoggedInLabel.Location = new System.Drawing.Point(739, 102);
            this.isLoggedInLabel.Name = "isLoggedInLabel";
            this.isLoggedInLabel.Size = new System.Drawing.Size(0, 25);
            this.isLoggedInLabel.TabIndex = 6;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(460, 107);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 18);
            this.nameLabel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(384, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Név:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(384, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Szakképesítése:";
            // 
            // professionLabel
            // 
            this.professionLabel.AutoSize = true;
            this.professionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.professionLabel.Location = new System.Drawing.Point(573, 212);
            this.professionLabel.Name = "professionLabel";
            this.professionLabel.Size = new System.Drawing.Size(0, 18);
            this.professionLabel.TabIndex = 10;
            // 
            // avatarPicture
            // 
            this.avatarPicture.Location = new System.Drawing.Point(389, 351);
            this.avatarPicture.Name = "avatarPicture";
            this.avatarPicture.Size = new System.Drawing.Size(141, 158);
            this.avatarPicture.TabIndex = 11;
            this.avatarPicture.TabStop = false;
            this.avatarPicture.Click += new System.EventHandler(this.avatarPicture_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(383, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Válasszon egy munkatársat!";
            // 
            // jelenlegiMunkatarsak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.avatarPicture);
            this.Controls.Add(this.professionLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.isLoggedInLabel);
            this.Controls.Add(this.employeeList);
            this.Controls.Add(this.adminList);
            this.Controls.Add(this.ceoList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "jelenlegiMunkatarsak";
            this.Size = new System.Drawing.Size(1094, 531);
            this.Load += new System.EventHandler(this.jelenlegiMunkatarsak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer watcher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ceoList;
        private System.Windows.Forms.ListBox adminList;
        private System.Windows.Forms.ListBox employeeList;
        private System.Windows.Forms.Label isLoggedInLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label professionLabel;
        private System.Windows.Forms.PictureBox avatarPicture;
        private System.Windows.Forms.Label label4;
    }
}
