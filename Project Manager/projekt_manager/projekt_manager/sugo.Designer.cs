
namespace projekt_manager
{
    partial class sugo
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
            this.ArticleList = new System.Windows.Forms.ListBox();
            this.ReadingSite = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ArticleList
            // 
            this.ArticleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArticleList.FormattingEnabled = true;
            this.ArticleList.ItemHeight = 15;
            this.ArticleList.Location = new System.Drawing.Point(3, 3);
            this.ArticleList.Name = "ArticleList";
            this.ArticleList.Size = new System.Drawing.Size(300, 544);
            this.ArticleList.TabIndex = 0;
            this.ArticleList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ReadingSite
            // 
            this.ReadingSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReadingSite.Location = new System.Drawing.Point(333, 3);
            this.ReadingSite.Name = "ReadingSite";
            this.ReadingSite.ReadOnly = true;
            this.ReadingSite.Size = new System.Drawing.Size(724, 554);
            this.ReadingSite.TabIndex = 2;
            this.ReadingSite.Text = "";
            // 
            // sugo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReadingSite);
            this.Controls.Add(this.ArticleList);
            this.Name = "sugo";
            this.Size = new System.Drawing.Size(1096, 560);
            this.Load += new System.EventHandler(this.sugo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ArticleList;
        private System.Windows.Forms.RichTextBox ReadingSite;
    }
}
