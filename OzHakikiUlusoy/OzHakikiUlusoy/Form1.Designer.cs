namespace OzHakikiUlusoy
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMusteriAd = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.GBoxCinsiyet = new System.Windows.Forms.GroupBox();
            this.CBoxOtobusTuru = new System.Windows.Forms.ComboBox();
            this.RadioBtnErkek = new System.Windows.Forms.RadioButton();
            this.RadioBtnKadin = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.LBoxMusteriler = new System.Windows.Forms.ListBox();
            this.GBoxCinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad SoyAd";
            // 
            // TxtMusteriAd
            // 
            this.TxtMusteriAd.Location = new System.Drawing.Point(12, 25);
            this.TxtMusteriAd.Name = "TxtMusteriAd";
            this.TxtMusteriAd.Size = new System.Drawing.Size(100, 20);
            this.TxtMusteriAd.TabIndex = 1;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnKaydet.Location = new System.Drawing.Point(1, 179);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(75, 23);
            this.BtnKaydet.TabIndex = 2;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // GBoxCinsiyet
            // 
            this.GBoxCinsiyet.Controls.Add(this.RadioBtnKadin);
            this.GBoxCinsiyet.Controls.Add(this.RadioBtnErkek);
            this.GBoxCinsiyet.Location = new System.Drawing.Point(1, 68);
            this.GBoxCinsiyet.Name = "GBoxCinsiyet";
            this.GBoxCinsiyet.Size = new System.Drawing.Size(89, 65);
            this.GBoxCinsiyet.TabIndex = 3;
            this.GBoxCinsiyet.TabStop = false;
            this.GBoxCinsiyet.Text = "Cinsiyet";
            // 
            // CBoxOtobusTuru
            // 
            this.CBoxOtobusTuru.FormattingEnabled = true;
            this.CBoxOtobusTuru.Items.AddRange(new object[] {
            "Setra",
            "Travego",
            "433"});
            this.CBoxOtobusTuru.Location = new System.Drawing.Point(1, 152);
            this.CBoxOtobusTuru.Name = "CBoxOtobusTuru";
            this.CBoxOtobusTuru.Size = new System.Drawing.Size(121, 21);
            this.CBoxOtobusTuru.TabIndex = 4;
            // 
            // RadioBtnErkek
            // 
            this.RadioBtnErkek.AutoSize = true;
            this.RadioBtnErkek.Location = new System.Drawing.Point(0, 20);
            this.RadioBtnErkek.Name = "RadioBtnErkek";
            this.RadioBtnErkek.Size = new System.Drawing.Size(53, 17);
            this.RadioBtnErkek.TabIndex = 0;
            this.RadioBtnErkek.TabStop = true;
            this.RadioBtnErkek.Text = "Erkek";
            this.RadioBtnErkek.UseVisualStyleBackColor = true;
            // 
            // RadioBtnKadin
            // 
            this.RadioBtnKadin.AutoSize = true;
            this.RadioBtnKadin.Location = new System.Drawing.Point(0, 43);
            this.RadioBtnKadin.Name = "RadioBtnKadin";
            this.RadioBtnKadin.Size = new System.Drawing.Size(52, 17);
            this.RadioBtnKadin.TabIndex = 1;
            this.RadioBtnKadin.TabStop = true;
            this.RadioBtnKadin.Text = "Kadın";
            this.RadioBtnKadin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Otobüs Turu";
            // 
            // LBoxMusteriler
            // 
            this.LBoxMusteriler.FormattingEnabled = true;
            this.LBoxMusteriler.Location = new System.Drawing.Point(204, 25);
            this.LBoxMusteriler.Name = "LBoxMusteriler";
            this.LBoxMusteriler.Size = new System.Drawing.Size(270, 225);
            this.LBoxMusteriler.TabIndex = 6;
            this.LBoxMusteriler.DoubleClick += new System.EventHandler(this.LBoxMusteriler_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 261);
            this.Controls.Add(this.LBoxMusteriler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBoxOtobusTuru);
            this.Controls.Add(this.GBoxCinsiyet);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtMusteriAd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GBoxCinsiyet.ResumeLayout(false);
            this.GBoxCinsiyet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMusteriAd;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.GroupBox GBoxCinsiyet;
        private System.Windows.Forms.RadioButton RadioBtnKadin;
        private System.Windows.Forms.RadioButton RadioBtnErkek;
        private System.Windows.Forms.ComboBox CBoxOtobusTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LBoxMusteriler;
    }
}

