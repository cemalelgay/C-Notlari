namespace IZSUFormApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GroupBoxAbone = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxAboneTuru = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAboneNo = new System.Windows.Forms.TextBox();
            this.GroupBoxFatura = new System.Windows.Forms.GroupBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnGetir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtFaturaAdSoyad = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtFaturaGuncelSayac = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtFaturaOncekiSayac = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtFaturaAboneNo = new System.Windows.Forms.TextBox();
            this.BtnBas = new System.Windows.Forms.Button();
            this.dgvBilgiler = new System.Windows.Forms.DataGridView();
            this.BtnTumunuGetir = new System.Windows.Forms.Button();
            this.lblToplamBorc = new System.Windows.Forms.Label();
            this.TxtToplamBorc = new System.Windows.Forms.TextBox();
            this.GroupBoxAbone.SuspendLayout();
            this.GroupBoxFatura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilgiler)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxAbone
            // 
            this.GroupBoxAbone.BackColor = System.Drawing.Color.DarkGreen;
            this.GroupBoxAbone.Controls.Add(this.label2);
            this.GroupBoxAbone.Controls.Add(this.cboxAboneTuru);
            this.GroupBoxAbone.Controls.Add(this.label4);
            this.GroupBoxAbone.Controls.Add(this.TxtAdSoyad);
            this.GroupBoxAbone.Controls.Add(this.BtnKaydet);
            this.GroupBoxAbone.Controls.Add(this.label1);
            this.GroupBoxAbone.Controls.Add(this.TxtAboneNo);
            this.GroupBoxAbone.Location = new System.Drawing.Point(13, 118);
            this.GroupBoxAbone.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBoxAbone.Name = "GroupBoxAbone";
            this.GroupBoxAbone.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBoxAbone.Size = new System.Drawing.Size(259, 220);
            this.GroupBoxAbone.TabIndex = 0;
            this.GroupBoxAbone.TabStop = false;
            this.GroupBoxAbone.Text = "Abone Bilgisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Abone Türü:";
            // 
            // cboxAboneTuru
            // 
            this.cboxAboneTuru.FormattingEnabled = true;
            this.cboxAboneTuru.Location = new System.Drawing.Point(115, 120);
            this.cboxAboneTuru.Name = "cboxAboneTuru";
            this.cboxAboneTuru.Size = new System.Drawing.Size(121, 24);
            this.cboxAboneTuru.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ad Soyad:";
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(115, 72);
            this.TxtAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(132, 23);
            this.TxtAdSoyad.TabIndex = 1;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.DarkRed;
            this.BtnKaydet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnKaydet.Location = new System.Drawing.Point(11, 166);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(225, 28);
            this.BtnKaydet.TabIndex = 6;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Abone No:";
            // 
            // TxtAboneNo
            // 
            this.TxtAboneNo.Location = new System.Drawing.Point(115, 36);
            this.TxtAboneNo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAboneNo.Name = "TxtAboneNo";
            this.TxtAboneNo.Size = new System.Drawing.Size(132, 23);
            this.TxtAboneNo.TabIndex = 0;
            this.TxtAboneNo.Leave += new System.EventHandler(this.TxtAboneNo_Leave);
            // 
            // GroupBoxFatura
            // 
            this.GroupBoxFatura.BackColor = System.Drawing.Color.DarkGreen;
            this.GroupBoxFatura.Controls.Add(this.BtnTumunuGetir);
            this.GroupBoxFatura.Controls.Add(this.dtTarih);
            this.GroupBoxFatura.Controls.Add(this.label7);
            this.GroupBoxFatura.Controls.Add(this.BtnGetir);
            this.GroupBoxFatura.Controls.Add(this.label9);
            this.GroupBoxFatura.Controls.Add(this.TxtFaturaAdSoyad);
            this.GroupBoxFatura.Controls.Add(this.BtnEkle);
            this.GroupBoxFatura.Controls.Add(this.label10);
            this.GroupBoxFatura.Controls.Add(this.TxtFaturaGuncelSayac);
            this.GroupBoxFatura.Controls.Add(this.label11);
            this.GroupBoxFatura.Controls.Add(this.TxtFaturaOncekiSayac);
            this.GroupBoxFatura.Controls.Add(this.label12);
            this.GroupBoxFatura.Controls.Add(this.TxtFaturaAboneNo);
            this.GroupBoxFatura.Location = new System.Drawing.Point(280, 13);
            this.GroupBoxFatura.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBoxFatura.Name = "GroupBoxFatura";
            this.GroupBoxFatura.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBoxFatura.Size = new System.Drawing.Size(259, 325);
            this.GroupBoxFatura.TabIndex = 1;
            this.GroupBoxFatura.TabStop = false;
            this.GroupBoxFatura.Text = "Fatura Bilgileri";
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(114, 105);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(132, 23);
            this.dtTarih.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tarih:";
            // 
            // BtnGetir
            // 
            this.BtnGetir.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnGetir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnGetir.Location = new System.Drawing.Point(150, 247);
            this.BtnGetir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGetir.Name = "BtnGetir";
            this.BtnGetir.Size = new System.Drawing.Size(96, 28);
            this.BtnGetir.TabIndex = 7;
            this.BtnGetir.Text = "GETİR";
            this.BtnGetir.UseVisualStyleBackColor = false;
            this.BtnGetir.Click += new System.EventHandler(this.BtnGetir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ad Soyad:";
            // 
            // TxtFaturaAdSoyad
            // 
            this.TxtFaturaAdSoyad.Enabled = false;
            this.TxtFaturaAdSoyad.Location = new System.Drawing.Point(115, 72);
            this.TxtFaturaAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFaturaAdSoyad.Name = "TxtFaturaAdSoyad";
            this.TxtFaturaAdSoyad.Size = new System.Drawing.Size(132, 23);
            this.TxtFaturaAdSoyad.TabIndex = 1;
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.DarkRed;
            this.BtnEkle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEkle.Location = new System.Drawing.Point(11, 247);
            this.BtnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(96, 28);
            this.BtnEkle.TabIndex = 6;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 183);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Güncel Sayaç:";
            // 
            // TxtFaturaGuncelSayac
            // 
            this.TxtFaturaGuncelSayac.Location = new System.Drawing.Point(114, 177);
            this.TxtFaturaGuncelSayac.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFaturaGuncelSayac.Name = "TxtFaturaGuncelSayac";
            this.TxtFaturaGuncelSayac.Size = new System.Drawing.Size(132, 23);
            this.TxtFaturaGuncelSayac.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 148);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Önceki Sayaç:";
            // 
            // TxtFaturaOncekiSayac
            // 
            this.TxtFaturaOncekiSayac.Location = new System.Drawing.Point(114, 142);
            this.TxtFaturaOncekiSayac.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFaturaOncekiSayac.Name = "TxtFaturaOncekiSayac";
            this.TxtFaturaOncekiSayac.Size = new System.Drawing.Size(132, 23);
            this.TxtFaturaOncekiSayac.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 36);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Abone No:";
            // 
            // TxtFaturaAboneNo
            // 
            this.TxtFaturaAboneNo.Enabled = false;
            this.TxtFaturaAboneNo.Location = new System.Drawing.Point(115, 36);
            this.TxtFaturaAboneNo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFaturaAboneNo.Name = "TxtFaturaAboneNo";
            this.TxtFaturaAboneNo.Size = new System.Drawing.Size(132, 23);
            this.TxtFaturaAboneNo.TabIndex = 0;
            // 
            // BtnBas
            // 
            this.BtnBas.BackColor = System.Drawing.Color.Transparent;
            this.BtnBas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBas.BackgroundImage")));
            this.BtnBas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBas.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBas.Location = new System.Drawing.Point(13, 37);
            this.BtnBas.Name = "BtnBas";
            this.BtnBas.Size = new System.Drawing.Size(75, 65);
            this.BtnBas.TabIndex = 2;
            this.BtnBas.UseVisualStyleBackColor = false;
            this.BtnBas.Click += new System.EventHandler(this.BtnBas_Click);
            // 
            // dgvBilgiler
            // 
            this.dgvBilgiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilgiler.Location = new System.Drawing.Point(575, 85);
            this.dgvBilgiler.MultiSelect = false;
            this.dgvBilgiler.Name = "dgvBilgiler";
            this.dgvBilgiler.ReadOnly = true;
            this.dgvBilgiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBilgiler.Size = new System.Drawing.Size(560, 433);
            this.dgvBilgiler.TabIndex = 3;
            this.dgvBilgiler.DoubleClick += new System.EventHandler(this.dgvBilgiler_DoubleClick);
            // 
            // BtnTumunuGetir
            // 
            this.BtnTumunuGetir.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnTumunuGetir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnTumunuGetir.Location = new System.Drawing.Point(35, 289);
            this.BtnTumunuGetir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTumunuGetir.Name = "BtnTumunuGetir";
            this.BtnTumunuGetir.Size = new System.Drawing.Size(183, 28);
            this.BtnTumunuGetir.TabIndex = 14;
            this.BtnTumunuGetir.Text = "Tüm Kayıtları Getir";
            this.BtnTumunuGetir.UseVisualStyleBackColor = false;
            this.BtnTumunuGetir.Click += new System.EventHandler(this.BtnTumunuGetir_Click);
            // 
            // lblToplamBorc
            // 
            this.lblToplamBorc.AutoSize = true;
            this.lblToplamBorc.Location = new System.Drawing.Point(932, 55);
            this.lblToplamBorc.Name = "lblToplamBorc";
            this.lblToplamBorc.Size = new System.Drawing.Size(92, 17);
            this.lblToplamBorc.TabIndex = 4;
            this.lblToplamBorc.Text = "Toplam Borç:";
            // 
            // TxtToplamBorc
            // 
            this.TxtToplamBorc.Enabled = false;
            this.TxtToplamBorc.Location = new System.Drawing.Point(1030, 52);
            this.TxtToplamBorc.Name = "TxtToplamBorc";
            this.TxtToplamBorc.ReadOnly = true;
            this.TxtToplamBorc.Size = new System.Drawing.Size(100, 23);
            this.TxtToplamBorc.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1150, 530);
            this.Controls.Add(this.TxtToplamBorc);
            this.Controls.Add(this.lblToplamBorc);
            this.Controls.Add(this.dgvBilgiler);
            this.Controls.Add(this.BtnBas);
            this.Controls.Add(this.GroupBoxFatura);
            this.Controls.Add(this.GroupBoxAbone);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxAbone.ResumeLayout(false);
            this.GroupBoxAbone.PerformLayout();
            this.GroupBoxFatura.ResumeLayout(false);
            this.GroupBoxFatura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilgiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.GroupBox GroupBoxAbone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAboneNo;
        private System.Windows.Forms.ComboBox cboxAboneTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GroupBoxFatura;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnGetir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtFaturaAdSoyad;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtFaturaGuncelSayac;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtFaturaOncekiSayac;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtFaturaAboneNo;
        private System.Windows.Forms.Button BtnBas;
        private System.Windows.Forms.DataGridView dgvBilgiler;
        private System.Windows.Forms.Button BtnTumunuGetir;
        private System.Windows.Forms.Label lblToplamBorc;
        private System.Windows.Forms.TextBox TxtToplamBorc;
    }
}

