namespace FormGrafikleri3
{
    partial class GrafikFrm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ciz = new System.Windows.Forms.Button();
            this.temizlebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ciz
            // 
            this.ciz.Location = new System.Drawing.Point(675, 378);
            this.ciz.Name = "ciz";
            this.ciz.Size = new System.Drawing.Size(89, 38);
            this.ciz.TabIndex = 0;
            this.ciz.Text = "Çiz";
            this.ciz.UseVisualStyleBackColor = true;
            this.ciz.Click += new System.EventHandler(this.ciz_Click);
            // 
            // temizlebtn
            // 
            this.temizlebtn.Location = new System.Drawing.Point(675, 334);
            this.temizlebtn.Name = "temizlebtn";
            this.temizlebtn.Size = new System.Drawing.Size(89, 38);
            this.temizlebtn.TabIndex = 1;
            this.temizlebtn.Text = "Temizle";
            this.temizlebtn.UseVisualStyleBackColor = true;
            this.temizlebtn.Click += new System.EventHandler(this.temizlebtn_Click);
            // 
            // GrafikFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.temizlebtn);
            this.Controls.Add(this.ciz);
            this.Name = "GrafikFrm";
            this.Text = "Form Grafikleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ciz;
        private System.Windows.Forms.Button temizlebtn;
    }
}

