namespace Kentkart_OOP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBakiye = new System.Windows.Forms.TextBox();
            this.GBoxOkulAdi = new System.Windows.Forms.GroupBox();
            this.TxtOkuladi = new System.Windows.Forms.TextBox();
            this.RadioBtnTam = new System.Windows.Forms.RadioButton();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.RadioBtnOgretmen = new System.Windows.Forms.RadioButton();
            this.RadioBtnOgrenci = new System.Windows.Forms.RadioButton();
            this.ListBoxYolcular = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.GBoxOkulAdi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtBakiye);
            this.groupBox1.Controls.Add(this.GBoxOkulAdi);
            this.groupBox1.Controls.Add(this.RadioBtnTam);
            this.groupBox1.Controls.Add(this.BtnEkle);
            this.groupBox1.Controls.Add(this.RadioBtnOgretmen);
            this.groupBox1.Controls.Add(this.RadioBtnOgrenci);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kart Oluştur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(122, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bakiye:";
            // 
            // TxtBakiye
            // 
            this.TxtBakiye.Location = new System.Drawing.Point(125, 53);
            this.TxtBakiye.Name = "TxtBakiye";
            this.TxtBakiye.Size = new System.Drawing.Size(100, 26);
            this.TxtBakiye.TabIndex = 6;
            // 
            // GBoxOkulAdi
            // 
            this.GBoxOkulAdi.Controls.Add(this.TxtOkuladi);
            this.GBoxOkulAdi.Location = new System.Drawing.Point(119, 95);
            this.GBoxOkulAdi.Name = "GBoxOkulAdi";
            this.GBoxOkulAdi.Size = new System.Drawing.Size(122, 68);
            this.GBoxOkulAdi.TabIndex = 5;
            this.GBoxOkulAdi.TabStop = false;
            this.GBoxOkulAdi.Text = "Okul Adi";
            // 
            // TxtOkuladi
            // 
            this.TxtOkuladi.Location = new System.Drawing.Point(6, 30);
            this.TxtOkuladi.Name = "TxtOkuladi";
            this.TxtOkuladi.Size = new System.Drawing.Size(100, 26);
            this.TxtOkuladi.TabIndex = 3;
            // 
            // RadioBtnTam
            // 
            this.RadioBtnTam.AutoSize = true;
            this.RadioBtnTam.Location = new System.Drawing.Point(7, 25);
            this.RadioBtnTam.Name = "RadioBtnTam";
            this.RadioBtnTam.Size = new System.Drawing.Size(61, 24);
            this.RadioBtnTam.TabIndex = 3;
            this.RadioBtnTam.TabStop = true;
            this.RadioBtnTam.Text = "Tam";
            this.RadioBtnTam.UseVisualStyleBackColor = true;
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEkle.Location = new System.Drawing.Point(7, 135);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 28);
            this.BtnEkle.TabIndex = 2;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // RadioBtnOgretmen
            // 
            this.RadioBtnOgretmen.AutoSize = true;
            this.RadioBtnOgretmen.Location = new System.Drawing.Point(7, 94);
            this.RadioBtnOgretmen.Name = "RadioBtnOgretmen";
            this.RadioBtnOgretmen.Size = new System.Drawing.Size(106, 24);
            this.RadioBtnOgretmen.TabIndex = 1;
            this.RadioBtnOgretmen.TabStop = true;
            this.RadioBtnOgretmen.Text = "Ögretmen";
            this.RadioBtnOgretmen.UseVisualStyleBackColor = true;
            // 
            // RadioBtnOgrenci
            // 
            this.RadioBtnOgrenci.AutoSize = true;
            this.RadioBtnOgrenci.Location = new System.Drawing.Point(7, 55);
            this.RadioBtnOgrenci.Name = "RadioBtnOgrenci";
            this.RadioBtnOgrenci.Size = new System.Drawing.Size(89, 24);
            this.RadioBtnOgrenci.TabIndex = 0;
            this.RadioBtnOgrenci.TabStop = true;
            this.RadioBtnOgrenci.Text = "Ögrenci";
            this.RadioBtnOgrenci.UseVisualStyleBackColor = true;
            this.RadioBtnOgrenci.CheckedChanged += new System.EventHandler(this.RadioBtnOgrenci_CheckedChanged);
            // 
            // ListBoxYolcular
            // 
            this.ListBoxYolcular.FormattingEnabled = true;
            this.ListBoxYolcular.Location = new System.Drawing.Point(10, 266);
            this.ListBoxYolcular.Name = "ListBoxYolcular";
            this.ListBoxYolcular.Size = new System.Drawing.Size(228, 147);
            this.ListBoxYolcular.TabIndex = 1;
            this.ListBoxYolcular.DoubleClick += new System.EventHandler(this.ListBoxYolcular_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yolcular";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxYolcular);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";           
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBoxOkulAdi.ResumeLayout(false);
            this.GBoxOkulAdi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioBtnOgretmen;
        private System.Windows.Forms.RadioButton RadioBtnOgrenci;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.RadioButton RadioBtnTam;
        private System.Windows.Forms.ListBox ListBoxYolcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBoxOkulAdi;
        private System.Windows.Forms.TextBox TxtOkuladi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBakiye;
    }
}

