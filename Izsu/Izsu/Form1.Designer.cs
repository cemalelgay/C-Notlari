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
            this.TxtOncekiSayac = new System.Windows.Forms.TextBox();
            this.TxtSonSayac = new System.Windows.Forms.TextBox();
            this.ListBoxOdenecekler = new System.Windows.Forms.ListBox();
            this.ListBoxOdenenler = new System.Windows.Forms.ListBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAboneNo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtAboneAdi
            // 
            this.TxtAboneAdi.Location = new System.Drawing.Point(207, 25);
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
            this.Rdnbtbnsirket.Size = new System.Drawing.Size(74, 24);
            this.Rdnbtbnsirket.TabIndex = 3;
            this.Rdnbtbnsirket.TabStop = true;
            this.Rdnbtbnsirket.Text = "Şirket";
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
            // TxtOncekiSayac
            // 
            this.TxtOncekiSayac.Location = new System.Drawing.Point(12, 186);
            this.TxtOncekiSayac.Name = "TxtOncekiSayac";
            this.TxtOncekiSayac.Size = new System.Drawing.Size(165, 20);
            this.TxtOncekiSayac.TabIndex = 5;
            // 
            // TxtSonSayac
            // 
            this.TxtSonSayac.Location = new System.Drawing.Point(12, 228);
            this.TxtSonSayac.Name = "TxtSonSayac";
            this.TxtSonSayac.Size = new System.Drawing.Size(165, 20);
            this.TxtSonSayac.TabIndex = 6;
            // 
            // ListBoxOdenecekler
            // 
            this.ListBoxOdenecekler.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ListBoxOdenecekler.ForeColor = System.Drawing.Color.White;
            this.ListBoxOdenecekler.FormattingEnabled = true;
            this.ListBoxOdenecekler.Location = new System.Drawing.Point(12, 280);
            this.ListBoxOdenecekler.Name = "ListBoxOdenecekler";
            this.ListBoxOdenecekler.Size = new System.Drawing.Size(165, 147);
            this.ListBoxOdenecekler.TabIndex = 7;
            this.ListBoxOdenecekler.DoubleClick += new System.EventHandler(this.LstOdemeListesi_DoubleClick);
            // 
            // ListBoxOdenenler
            // 
            this.ListBoxOdenenler.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ListBoxOdenenler.ForeColor = System.Drawing.Color.White;
            this.ListBoxOdenenler.FormattingEnabled = true;
            this.ListBoxOdenenler.Location = new System.Drawing.Point(207, 280);
            this.ListBoxOdenenler.Name = "ListBoxOdenenler";
            this.ListBoxOdenenler.Size = new System.Drawing.Size(165, 147);
            this.ListBoxOdenenler.TabIndex = 8;
            this.ListBoxOdenenler.DoubleClick += new System.EventHandler(this.ListBoxOdenenler_DoubleClick);
            // 
            // BtnEkle
            // 
            this.BtnEkle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnEkle.Location = new System.Drawing.Point(123, 452);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(126, 23);
            this.BtnEkle.TabIndex = 9;
            this.BtnEkle.Text = "KAYIT EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Abone Adi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ödenecek Faturalar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(207, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ödenen Faturalar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Önceki Sayaç";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Son Sayaç";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Abone No:";
            // 
            // TxtAboneNo
            // 
            this.TxtAboneNo.Location = new System.Drawing.Point(12, 25);
            this.TxtAboneNo.Name = "TxtAboneNo";
            this.TxtAboneNo.Size = new System.Drawing.Size(165, 20);
            this.TxtAboneNo.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(427, 567);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtAboneNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.ListBoxOdenenler);
            this.Controls.Add(this.ListBoxOdenecekler);
            this.Controls.Add(this.TxtSonSayac);
            this.Controls.Add(this.TxtOncekiSayac);
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
        private System.Windows.Forms.TextBox TxtOncekiSayac;
        private System.Windows.Forms.TextBox TxtSonSayac;
        private System.Windows.Forms.ListBox ListBoxOdenecekler;
        private System.Windows.Forms.ListBox ListBoxOdenenler;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAboneNo;
    }
}

