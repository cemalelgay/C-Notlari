namespace UniPortal
{
    partial class AkademisyenForm
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
            this.DataGridAkademisyen = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtGorevi = new System.Windows.Forms.TextBox();
            this.TxtBolum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAkademisyen)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridAkademisyen
            // 
            this.DataGridAkademisyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAkademisyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DataGridAkademisyen.Location = new System.Drawing.Point(12, 190);
            this.DataGridAkademisyen.Name = "DataGridAkademisyen";
            this.DataGridAkademisyen.ReadOnly = true;
            this.DataGridAkademisyen.Size = new System.Drawing.Size(354, 150);
            this.DataGridAkademisyen.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "İsim";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Soyİsim";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefon";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Bölüm";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Görev";
            this.Column5.Name = "Column5";
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(59, 64);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(305, 20);
            this.TxtTel.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefon:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(59, 38);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(305, 20);
            this.TxtSoyad.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Soyad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(58, 12);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(305, 20);
            this.TxtAd.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ad:";
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEkle.Location = new System.Drawing.Point(58, 161);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(305, 23);
            this.BtnEkle.TabIndex = 15;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Görevi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bölüm:";
            // 
            // TxtGorevi
            // 
            this.TxtGorevi.Location = new System.Drawing.Point(59, 125);
            this.TxtGorevi.Name = "TxtGorevi";
            this.TxtGorevi.Size = new System.Drawing.Size(305, 20);
            this.TxtGorevi.TabIndex = 19;
            // 
            // TxtBolum
            // 
            this.TxtBolum.Location = new System.Drawing.Point(58, 93);
            this.TxtBolum.Name = "TxtBolum";
            this.TxtBolum.Size = new System.Drawing.Size(305, 20);
            this.TxtBolum.TabIndex = 18;
            // 
            // AkademisyenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 376);
            this.Controls.Add(this.TxtGorevi);
            this.Controls.Add(this.TxtBolum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DataGridAkademisyen);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEkle);
            this.Name = "AkademisyenForm";
            this.Text = "AkademisyenForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAkademisyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridAkademisyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtGorevi;
        private System.Windows.Forms.TextBox TxtBolum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}