namespace OzanSuDagıtım
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
            this.BtnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUrunIsmi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUrunFiyat = new System.Windows.Forms.NumericUpDown();
            this.numericUrunLitre = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUrunFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUrunLitre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEkle.Location = new System.Drawing.Point(467, 39);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 58);
            this.BtnEkle.TabIndex = 1;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Urun İsmi:";
            // 
            // TxtUrunIsmi
            // 
            this.TxtUrunIsmi.Location = new System.Drawing.Point(15, 76);
            this.TxtUrunIsmi.Name = "TxtUrunIsmi";
            this.TxtUrunIsmi.Size = new System.Drawing.Size(100, 20);
            this.TxtUrunIsmi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Urun Fiyat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Urun Litre:";
            // 
            // numericUrunFiyat
            // 
            this.numericUrunFiyat.DecimalPlaces = 2;
            this.numericUrunFiyat.Location = new System.Drawing.Point(162, 75);
            this.numericUrunFiyat.Name = "numericUrunFiyat";
            this.numericUrunFiyat.Size = new System.Drawing.Size(120, 20);
            this.numericUrunFiyat.TabIndex = 9;
            // 
            // numericUrunLitre
            // 
            this.numericUrunLitre.DecimalPlaces = 2;
            this.numericUrunLitre.Location = new System.Drawing.Point(312, 77);
            this.numericUrunLitre.Name = "numericUrunLitre";
            this.numericUrunLitre.Size = new System.Drawing.Size(120, 20);
            this.numericUrunLitre.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(527, 295);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 487);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numericUrunLitre);
            this.Controls.Add(this.numericUrunFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUrunIsmi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUrunFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUrunLitre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUrunIsmi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUrunFiyat;
        private System.Windows.Forms.NumericUpDown numericUrunLitre;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

