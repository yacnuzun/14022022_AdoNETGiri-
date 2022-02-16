
namespace _14._02._2022_AdoNETGiriş
{
    partial class Form1
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
            this.lsturunler = new System.Windows.Forms.ListBox();
            this.lstkategoriler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsturunler
            // 
            this.lsturunler.FormattingEnabled = true;
            this.lsturunler.ItemHeight = 16;
            this.lsturunler.Location = new System.Drawing.Point(45, 12);
            this.lsturunler.Name = "lsturunler";
            this.lsturunler.Size = new System.Drawing.Size(311, 164);
            this.lsturunler.TabIndex = 0;
            // 
            // lstkategoriler
            // 
            this.lstkategoriler.FormattingEnabled = true;
            this.lstkategoriler.ItemHeight = 16;
            this.lstkategoriler.Location = new System.Drawing.Point(45, 195);
            this.lstkategoriler.Name = "lstkategoriler";
            this.lstkategoriler.Size = new System.Drawing.Size(311, 164);
            this.lstkategoriler.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstkategoriler);
            this.Controls.Add(this.lsturunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsturunler;
        private System.Windows.Forms.ListBox lstkategoriler;
    }
}

