namespace SinemaTakip
{
    partial class Admin
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
            this.label4 = new System.Windows.Forms.Label();
            this.FilmSil = new System.Windows.Forms.Button();
            this.FilmTablosu = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.KullaniciTablosu = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.KulSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FilmTablosu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kullanıcı Tablosu :";
            // 
            // FilmSil
            // 
            this.FilmSil.Location = new System.Drawing.Point(619, 291);
            this.FilmSil.Name = "FilmSil";
            this.FilmSil.Size = new System.Drawing.Size(124, 43);
            this.FilmSil.TabIndex = 9;
            this.FilmSil.Text = "Film Sil";
            this.FilmSil.UseVisualStyleBackColor = true;
            this.FilmSil.Click += new System.EventHandler(this.FilmSil_Click);
            // 
            // FilmTablosu
            // 
            this.FilmTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilmTablosu.Location = new System.Drawing.Point(155, 197);
            this.FilmTablosu.Name = "FilmTablosu";
            this.FilmTablosu.Size = new System.Drawing.Size(425, 150);
            this.FilmTablosu.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "Film Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // KullaniciTablosu
            // 
            this.KullaniciTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KullaniciTablosu.Location = new System.Drawing.Point(157, 19);
            this.KullaniciTablosu.Name = "KullaniciTablosu";
            this.KullaniciTablosu.Size = new System.Drawing.Size(425, 150);
            this.KullaniciTablosu.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Film Tablosu :";
            // 
            // KulSil
            // 
            this.KulSil.Location = new System.Drawing.Point(619, 65);
            this.KulSil.Name = "KulSil";
            this.KulSil.Size = new System.Drawing.Size(124, 43);
            this.KulSil.TabIndex = 13;
            this.KulSil.Text = "Kullanıcı Sil";
            this.KulSil.UseVisualStyleBackColor = true;
            this.KulSil.Click += new System.EventHandler(this.button3_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 383);
            this.Controls.Add(this.KulSil);
            this.Controls.Add(this.KullaniciTablosu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FilmTablosu);
            this.Controls.Add(this.FilmSil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FilmTablosu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciTablosu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FilmSil;
        private System.Windows.Forms.DataGridView FilmTablosu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView KullaniciTablosu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button KulSil;
    }
}