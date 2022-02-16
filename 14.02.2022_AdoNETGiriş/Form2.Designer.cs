
namespace _14._02._2022_AdoNETGiriş
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txturunad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.nmdfiyat = new System.Windows.Forms.NumericUpDown();
            this.nmdstok = new System.Windows.Forms.NumericUpDown();
            this.btnkategori = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnspekle = new System.Windows.Forms.Button();
            this.btnspupd = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmdfiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdstok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(15, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(880, 346);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 28);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.silToolStripMenuItem.Text = "sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı :";
            // 
            // txturunad
            // 
            this.txturunad.Location = new System.Drawing.Point(89, 27);
            this.txturunad.Name = "txturunad";
            this.txturunad.Size = new System.Drawing.Size(128, 22);
            this.txturunad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stok :";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(577, 27);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(76, 23);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // nmdfiyat
            // 
            this.nmdfiyat.Location = new System.Drawing.Point(275, 25);
            this.nmdfiyat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmdfiyat.Name = "nmdfiyat";
            this.nmdfiyat.Size = new System.Drawing.Size(120, 22);
            this.nmdfiyat.TabIndex = 4;
            // 
            // nmdstok
            // 
            this.nmdstok.Location = new System.Drawing.Point(451, 27);
            this.nmdstok.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmdstok.Name = "nmdstok";
            this.nmdstok.Size = new System.Drawing.Size(120, 22);
            this.nmdstok.TabIndex = 4;
            // 
            // btnkategori
            // 
            this.btnkategori.Location = new System.Drawing.Point(751, 12);
            this.btnkategori.Name = "btnkategori";
            this.btnkategori.Size = new System.Drawing.Size(85, 25);
            this.btnkategori.TabIndex = 3;
            this.btnkategori.Text = "Kategoriler";
            this.btnkategori.UseVisualStyleBackColor = true;
            this.btnkategori.Click += new System.EventHandler(this.btnkategori_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(577, 56);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(76, 23);
            this.btnguncelle.TabIndex = 3;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnspekle
            // 
            this.btnspekle.Location = new System.Drawing.Point(659, 27);
            this.btnspekle.Name = "btnspekle";
            this.btnspekle.Size = new System.Drawing.Size(75, 23);
            this.btnspekle.TabIndex = 5;
            this.btnspekle.Text = "SPEkle";
            this.btnspekle.UseVisualStyleBackColor = true;
            this.btnspekle.Click += new System.EventHandler(this.btnspekle_Click);
            // 
            // btnspupd
            // 
            this.btnspupd.Location = new System.Drawing.Point(659, 56);
            this.btnspupd.Name = "btnspupd";
            this.btnspupd.Size = new System.Drawing.Size(75, 23);
            this.btnspupd.TabIndex = 5;
            this.btnspupd.Text = "SPGüncelle";
            this.btnspupd.UseVisualStyleBackColor = true;
            this.btnspupd.Click += new System.EventHandler(this.btnspupd_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(763, 55);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 6;
            this.btndel.Text = "Sil";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 469);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnspupd);
            this.Controls.Add(this.btnspekle);
            this.Controls.Add(this.nmdstok);
            this.Controls.Add(this.nmdfiyat);
            this.Controls.Add(this.btnkategori);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txturunad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmdfiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdstok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txturunad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.NumericUpDown nmdfiyat;
        private System.Windows.Forms.NumericUpDown nmdstok;
        private System.Windows.Forms.Button btnkategori;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnspekle;
        private System.Windows.Forms.Button btnspupd;
        private System.Windows.Forms.Button btndel;
    }
}