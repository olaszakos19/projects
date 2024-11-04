
namespace projekt_manager
{
    partial class torles
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.d1 = new System.Windows.Forms.Label();
            this.szk = new System.Windows.Forms.Label();
            this.fn = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.watcher = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(21, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(445, 484);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(542, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(542, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Felhaszáló név:";
            // 
            // d1
            // 
            this.d1.AutoSize = true;
            this.d1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.d1.Location = new System.Drawing.Point(542, 271);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(131, 20);
            this.d1.TabIndex = 3;
            this.d1.Text = "Szakképesíttése:";
            // 
            // szk
            // 
            this.szk.AutoSize = true;
            this.szk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szk.Location = new System.Drawing.Point(737, 271);
            this.szk.Name = "szk";
            this.szk.Size = new System.Drawing.Size(14, 20);
            this.szk.TabIndex = 7;
            this.szk.Text = "-";
            // 
            // fn
            // 
            this.fn.AutoSize = true;
            this.fn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fn.Location = new System.Drawing.Point(737, 201);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(14, 20);
            this.fn.TabIndex = 6;
            this.fn.Text = "-";
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.n.Location = new System.Drawing.Point(737, 111);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(14, 20);
            this.n.TabIndex = 5;
            this.n.Text = "-";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(907, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "Törlés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // d2
            // 
            this.d2.AutoSize = true;
            this.d2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.d2.Location = new System.Drawing.Point(542, 397);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(122, 20);
            this.d2.TabIndex = 11;
            this.d2.Text = "Eddigi feladatai:";
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(697, 314);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(170, 184);
            this.listBox2.TabIndex = 12;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // watcher
            // 
            this.watcher.Enabled = true;
            this.watcher.Tick += new System.EventHandler(this.watcher_Tick);
            // 
            // torles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.szk);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.n);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "torles";
            this.Size = new System.Drawing.Size(1094, 531);
            this.Load += new System.EventHandler(this.torles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label d1;
        private System.Windows.Forms.Label szk;
        private System.Windows.Forms.Label fn;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label d2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Timer watcher;
    }
}
