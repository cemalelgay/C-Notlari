namespace Tiyatro_SQL
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
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TxtYonetmen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.TxtSenarist = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtOyunadi = new System.Windows.Forms.TextBox();
            this.TxtOyuncuListesi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OyunAdi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Oyuncu Listesi:";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(268, 191);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(36, 23);
            this.BtnEkle.TabIndex = 8;
            this.BtnEkle.Text = "+";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtYonetmen
            // 
            this.TxtYonetmen.Location = new System.Drawing.Point(141, 152);
            this.TxtYonetmen.Name = "TxtYonetmen";
            this.TxtYonetmen.Size = new System.Drawing.Size(100, 20);
            this.TxtYonetmen.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yönetmen:";
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(268, 233);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(36, 23);
            this.BtnSil.TabIndex = 11;
            this.BtnSil.Text = "-";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // TxtSenarist
            // 
            this.TxtSenarist.Location = new System.Drawing.Point(141, 194);
            this.TxtSenarist.Name = "TxtSenarist";
            this.TxtSenarist.Size = new System.Drawing.Size(100, 20);
            this.TxtSenarist.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Senarist:";
            // 
            // TxtOyunadi
            // 
            this.TxtOyunadi.Location = new System.Drawing.Point(141, 68);
            this.TxtOyunadi.Name = "TxtOyunadi";
            this.TxtOyunadi.Size = new System.Drawing.Size(100, 20);
            this.TxtOyunadi.TabIndex = 12;
            // 
            // TxtOyuncuListesi
            // 
            this.TxtOyuncuListesi.Location = new System.Drawing.Point(141, 114);
            this.TxtOyuncuListesi.Name = "TxtOyuncuListesi";
            this.TxtOyuncuListesi.Size = new System.Drawing.Size(100, 20);
            this.TxtOyuncuListesi.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(401, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 191);
            this.dataGridView1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID:";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(141, 240);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 20);
            this.TxtID.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 466);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtOyuncuListesi);
            this.Controls.Add(this.TxtOyunadi);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.TxtSenarist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtYonetmen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.TextBox TxtSenarist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtOyunadi;
        private System.Windows.Forms.TextBox TxtOyuncuListesi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtYonetmen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtID;
    }
}

