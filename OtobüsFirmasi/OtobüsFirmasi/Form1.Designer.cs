namespace OtobüsFirmasi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CBoxOtobusTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelTravego = new System.Windows.Forms.Panel();
            this.PanelSetra = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.LabelOtobusTuru = new System.Windows.Forms.Label();
            this.LabelKoltukNo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RbtnKadin = new System.Windows.Forms.RadioButton();
            this.RbtnErkek = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtYolcuIsim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CBoxOtobusTuru
            // 
            this.CBoxOtobusTuru.FormattingEnabled = true;
            this.CBoxOtobusTuru.Items.AddRange(new object[] {
            "Travego",
            "Setra"});
            this.CBoxOtobusTuru.Location = new System.Drawing.Point(72, 152);
            this.CBoxOtobusTuru.Name = "CBoxOtobusTuru";
            this.CBoxOtobusTuru.Size = new System.Drawing.Size(121, 21);
            this.CBoxOtobusTuru.TabIndex = 1;
            this.CBoxOtobusTuru.SelectedIndexChanged += new System.EventHandler(this.CBoxOtobusTuru_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(72, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Otobüs Türü";
            // 
            // PanelTravego
            // 
            this.PanelTravego.Location = new System.Drawing.Point(274, 132);
            this.PanelTravego.Name = "PanelTravego";
            this.PanelTravego.Size = new System.Drawing.Size(258, 432);
            this.PanelTravego.TabIndex = 3;
            // 
            // PanelSetra
            // 
            this.PanelSetra.Location = new System.Drawing.Point(274, 132);
            this.PanelSetra.Name = "PanelSetra";
            this.PanelSetra.Size = new System.Drawing.Size(258, 432);
            this.PanelSetra.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.LabelOtobusTuru);
            this.groupBox1.Controls.Add(this.LabelKoltukNo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtYolcuIsim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(548, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 254);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Otobüs Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Koltuk No:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(0, 194);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(162, 44);
            this.BtnKaydet.TabIndex = 5;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // LabelOtobusTuru
            // 
            this.LabelOtobusTuru.AutoSize = true;
            this.LabelOtobusTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelOtobusTuru.Location = new System.Drawing.Point(93, 165);
            this.LabelOtobusTuru.Name = "LabelOtobusTuru";
            this.LabelOtobusTuru.Size = new System.Drawing.Size(0, 13);
            this.LabelOtobusTuru.TabIndex = 4;
            // 
            // LabelKoltukNo
            // 
            this.LabelKoltukNo.AutoSize = true;
            this.LabelKoltukNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelKoltukNo.Location = new System.Drawing.Point(77, 138);
            this.LabelKoltukNo.Name = "LabelKoltukNo";
            this.LabelKoltukNo.Size = new System.Drawing.Size(10, 13);
            this.LabelKoltukNo.TabIndex = 3;
            this.LabelKoltukNo.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RbtnKadin);
            this.groupBox2.Controls.Add(this.RbtnErkek);
            this.groupBox2.Location = new System.Drawing.Point(0, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 47);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cinsiyet";
            // 
            // RbtnKadin
            // 
            this.RbtnKadin.AutoSize = true;
            this.RbtnKadin.Location = new System.Drawing.Point(80, 20);
            this.RbtnKadin.Name = "RbtnKadin";
            this.RbtnKadin.Size = new System.Drawing.Size(57, 17);
            this.RbtnKadin.TabIndex = 1;
            this.RbtnKadin.TabStop = true;
            this.RbtnKadin.Text = "Kadin";
            this.RbtnKadin.UseVisualStyleBackColor = true;
            // 
            // RbtnErkek
            // 
            this.RbtnErkek.AutoSize = true;
            this.RbtnErkek.Location = new System.Drawing.Point(0, 20);
            this.RbtnErkek.Name = "RbtnErkek";
            this.RbtnErkek.Size = new System.Drawing.Size(58, 17);
            this.RbtnErkek.TabIndex = 0;
            this.RbtnErkek.TabStop = true;
            this.RbtnErkek.Text = "Erkek";
            this.RbtnErkek.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // TxtYolcuIsim
            // 
            this.TxtYolcuIsim.Location = new System.Drawing.Point(6, 36);
            this.TxtYolcuIsim.Name = "TxtYolcuIsim";
            this.TxtYolcuIsim.Size = new System.Drawing.Size(100, 20);
            this.TxtYolcuIsim.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 625);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PanelTravego);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBoxOtobusTuru);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PanelSetra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CBoxOtobusTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelTravego;
        private System.Windows.Forms.Panel PanelSetra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label LabelOtobusTuru;
        private System.Windows.Forms.Label LabelKoltukNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RbtnKadin;
        private System.Windows.Forms.RadioButton RbtnErkek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtYolcuIsim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

