namespace UniPortal
{
    partial class OgrenciForm
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
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridOgrenci = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(64, 24);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(305, 20);
            this.TxtAd.TabIndex = 1;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(64, 50);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(305, 20);
            this.TxtSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad:";
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(64, 76);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(305, 20);
            this.TxtTel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon:";
            // 
            // DataGridOgrenci
            // 
            this.DataGridOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridOgrenci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DataGridOgrenci.Location = new System.Drawing.Point(15, 143);
            this.DataGridOgrenci.Name = "DataGridOgrenci";
            this.DataGridOgrenci.ReadOnly = true;
            this.DataGridOgrenci.Size = new System.Drawing.Size(354, 150);
            this.DataGridOgrenci.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "İsim";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Soyİsim";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefon";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEkle.Location = new System.Drawing.Point(64, 103);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(305, 23);
            this.BtnEkle.TabIndex = 7;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // OgrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 328);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.DataGridOgrenci);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label1);
            this.Name = "OgrenciForm";
            this.Text = "OgrenciForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOgrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridOgrenci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button BtnEkle;
    }
}