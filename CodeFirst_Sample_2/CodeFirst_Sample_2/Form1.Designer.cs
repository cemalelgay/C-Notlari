namespace CodeFirst_Sample_2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Islemler = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTumUrunler = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUrunEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.DGridList = new System.Windows.Forms.DataGridView();
            this.GBoxUrunEkle = new System.Windows.Forms.GroupBox();
            this.CBoxUrunKategori = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumUrunFiyati = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridList)).BeginInit();
            this.GBoxUrunEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUrunFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Islemler});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Islemler
            // 
            this.Islemler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemTumUrunler,
            this.MenuItemUrunEkle});
            this.Islemler.Name = "Islemler";
            this.Islemler.Size = new System.Drawing.Size(60, 20);
            this.Islemler.Text = "İşlemler";
            // 
            // MenuItemTumUrunler
            // 
            this.MenuItemTumUrunler.Name = "MenuItemTumUrunler";
            this.MenuItemTumUrunler.Size = new System.Drawing.Size(152, 22);
            this.MenuItemTumUrunler.Text = "Tüm Ürünler";
            this.MenuItemTumUrunler.Click += new System.EventHandler(this.MenuItemTumUrunler_Click);
            // 
            // MenuItemUrunEkle
            // 
            this.MenuItemUrunEkle.Name = "MenuItemUrunEkle";
            this.MenuItemUrunEkle.Size = new System.Drawing.Size(152, 22);
            this.MenuItemUrunEkle.Text = "Urun Ekle";
            this.MenuItemUrunEkle.Click += new System.EventHandler(this.MenuItemUrunEkle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnKaydet.Location = new System.Drawing.Point(55, 228);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(160, 23);
            this.BtnKaydet.TabIndex = 1;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // DGridList
            // 
            this.DGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridList.Location = new System.Drawing.Point(12, 56);
            this.DGridList.Name = "DGridList";
            this.DGridList.Size = new System.Drawing.Size(324, 257);
            this.DGridList.TabIndex = 2;
            // 
            // GBoxUrunEkle
            // 
            this.GBoxUrunEkle.Controls.Add(this.CBoxUrunKategori);
            this.GBoxUrunEkle.Controls.Add(this.label3);
            this.GBoxUrunEkle.Controls.Add(this.NumUrunFiyati);
            this.GBoxUrunEkle.Controls.Add(this.label2);
            this.GBoxUrunEkle.Controls.Add(this.BtnKaydet);
            this.GBoxUrunEkle.Controls.Add(this.TxtUrunAdi);
            this.GBoxUrunEkle.Controls.Add(this.label1);
            this.GBoxUrunEkle.Location = new System.Drawing.Point(342, 56);
            this.GBoxUrunEkle.Name = "GBoxUrunEkle";
            this.GBoxUrunEkle.Size = new System.Drawing.Size(263, 257);
            this.GBoxUrunEkle.TabIndex = 4;
            this.GBoxUrunEkle.TabStop = false;
            this.GBoxUrunEkle.Text = "ÜRÜN EKLE";
            // 
            // CBoxUrunKategori
            // 
            this.CBoxUrunKategori.FormattingEnabled = true;
            this.CBoxUrunKategori.Location = new System.Drawing.Point(9, 167);
            this.CBoxUrunKategori.Name = "CBoxUrunKategori";
            this.CBoxUrunKategori.Size = new System.Drawing.Size(121, 21);
            this.CBoxUrunKategori.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Urun Kategori :";
            // 
            // NumUrunFiyati
            // 
            this.NumUrunFiyati.DecimalPlaces = 2;
            this.NumUrunFiyati.Location = new System.Drawing.Point(6, 99);
            this.NumUrunFiyati.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumUrunFiyati.Name = "NumUrunFiyati";
            this.NumUrunFiyati.Size = new System.Drawing.Size(120, 20);
            this.NumUrunFiyati.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Urun Fiyat:";
            // 
            // TxtUrunAdi
            // 
            this.TxtUrunAdi.Location = new System.Drawing.Point(6, 44);
            this.TxtUrunAdi.Name = "TxtUrunAdi";
            this.TxtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.TxtUrunAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Urun Ismi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 392);
            this.Controls.Add(this.GBoxUrunEkle);
            this.Controls.Add(this.DGridList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Stok Takip";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridList)).EndInit();
            this.GBoxUrunEkle.ResumeLayout(false);
            this.GBoxUrunEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUrunFiyati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.DataGridView DGridList;
        private System.Windows.Forms.ToolStripMenuItem Islemler;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTumUrunler;
        private System.Windows.Forms.GroupBox GBoxUrunEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumUrunFiyati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxUrunKategori;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUrunEkle;
    }
}

