namespace Izsu
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
            this.TxtAboneAdi = new System.Windows.Forms.TextBox();
            this.Rdnbtnev = new System.Windows.Forms.RadioButton();
            this.Rdnbtbnsirket = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtOncekindex = new System.Windows.Forms.TextBox();
            this.TxtSonrakiindex = new System.Windows.Forms.TextBox();
            this.LstOdemeListesi = new System.Windows.Forms.ListBox();
            this.LstOdendiListesi = new System.Windows.Forms.ListBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtAboneAdi
            // 
            this.TxtAboneAdi.Location = new System.Drawing.Point(12, 25);
            this.TxtAboneAdi.Name = "TxtAboneAdi";
            this.TxtAboneAdi.Size = new System.Drawing.Size(165, 20);
            this.TxtAboneAdi.TabIndex = 1;
            // 
            // Rdnbtnev
            // 
            this.Rdnbtnev.AutoSize = true;
            this.Rdnbtnev.Location = new System.Drawing.Point(6, 31);
            this.Rdnbtnev.Name = "Rdnbtnev";
            this.Rdnbtnev.Size = new System.Drawing.Size(47, 24);
            this.Rdnbtnev.TabIndex = 2;
            this.Rdnbtnev.TabStop = true;
            this.Rdnbtnev.Text = "Ev";
            this.Rdnbtnev.UseVisualStyleBackColor = true;
            // 
            // Rdnbtbnsirket
            // 
            this.Rdnbtbnsirket.AutoSize = true;
            this.Rdnbtbnsirket.Location = new System.Drawing.Point(6, 54);
            this.Rdnbtbnsirket.Name = "Rdnbtbnsirket";
            this.Rdnbtbnsirket.Size = new System.Drawing.Size(149, 24);
            this.Rdnbtbnsirket.TabIndex = 3;
            this.Rdnbtbnsirket.TabStop = true;
            this.Rdnbtbnsirket.Text = "Şirket / Kuruluş";
            this.Rdnbtbnsirket.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Rdnbtnev);
            this.groupBox1.Controls.Add(this.Rdnbtbnsirket);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abone Tipi:";
            // 
            // TxtOncekindex
            // 
            this.TxtOncekindex.Location = new System.Drawing.Point(12, 186);
            this.TxtOncekindex.Name = "TxtOncekindex";
            this.TxtOncekindex.Size = new System.Drawing.Size(165, 20);
            this.TxtOncekindex.TabIndex = 5;
            // 
            // TxtSonrakiindex
            // 
            this.TxtSonrakiindex.Location = new System.Drawing.Point(12, 228);
            this.TxtSonrakiindex.Name = "TxtSonrakiindex";
            this.TxtSonrakiindex.Size = new System.Drawing.Size(165, 20);
            this.TxtSonrakiindex.TabIndex = 6;
            // 
            // LstOdemeListesi
            // 
            this.LstOdemeListesi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LstOdemeListesi.ForeColor = System.Drawing.Color.White;
            this.LstOdemeListesi.FormattingEnabled = true;
            this.LstOdemeListesi.Location = new System.Drawing.Point(12, 280);
            this.LstOdemeListesi.Name = "LstOdemeListesi";
            this.LstOdemeListesi.Size = new System.Drawing.Size(165, 147);
            this.LstOdemeListesi.TabIndex = 7;
            this.LstOdemeListesi.DoubleClick += new System.EventHandler(this.LstOdemeListesi_DoubleClick);
            // 
            // LstOdendiListesi
            // 
            this.LstOdendiListesi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LstOdendiListesi.ForeColor = System.Drawing.Color.White;
            this.LstOdendiListesi.FormattingEnabled = true;
            this.LstOdendiListesi.Location = new System.Drawing.Point(207, 280);
            this.LstOdendiListesi.Name = "LstOdendiListesi";
            this.LstOdendiListesi.Size = new System.Drawing.Size(165, 147);
            this.LstOdendiListesi.TabIndex = 8;
            // 
            // BtnEkle
            // 
            this.BtnEkle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnEkle.Location = new System.Drawing.Point(12, 475);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 9;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Abone Adi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ödenecek Faturalar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(207, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ödenen Faturalar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(427, 567);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.LstOdendiListesi);
            this.Controls.Add(this.LstOdemeListesi);
            this.Controls.Add(this.TxtSonrakiindex);
            this.Controls.Add(this.TxtOncekindex);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtAboneAdi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAboneAdi;
        private System.Windows.Forms.RadioButton Rdnbtnev;
        private System.Windows.Forms.RadioButton Rdnbtbnsirket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtOncekindex;
        private System.Windows.Forms.TextBox TxtSonrakiindex;
        private System.Windows.Forms.ListBox LstOdemeListesi;
        private System.Windows.Forms.ListBox LstOdendiListesi;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

