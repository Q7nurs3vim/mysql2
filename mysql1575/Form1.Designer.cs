namespace mysql1575
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwFilmler = new System.Windows.Forms.DataGridView();
            this.btnelesriri = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilmler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwFilmler
            // 
            this.dgwFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilmler.Location = new System.Drawing.Point(1, 222);
            this.dgwFilmler.Name = "dgwFilmler";
            this.dgwFilmler.Size = new System.Drawing.Size(798, 232);
            this.dgwFilmler.TabIndex = 0;
            // 
            // btnelesriri
            // 
            this.btnelesriri.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnelesriri.Location = new System.Drawing.Point(1, 170);
            this.btnelesriri.Name = "btnelesriri";
            this.btnelesriri.Size = new System.Drawing.Size(125, 46);
            this.btnelesriri.TabIndex = 1;
            this.btnelesriri.Text = "ELEŞTİRİLER";
            this.btnelesriri.UseVisualStyleBackColor = false;
            this.btnelesriri.Click += new System.EventHandler(this.btnelesriri_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(144, 170);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(107, 46);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "btn1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnelesriri);
            this.Controls.Add(this.dgwFilmler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFilmler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFilmler;
        private System.Windows.Forms.Button btnelesriri;
        private System.Windows.Forms.Button btn1;
    }
}

