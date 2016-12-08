namespace NeKadarKaldi
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
            this.OkBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gunlukSaatTxtB = new System.Windows.Forms.TextBox();
            this.uykusaat = new System.Windows.Forms.Label();
            this.gunSaatTxtB = new System.Windows.Forms.TextBox();
            this.HesapBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.yasTxtB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(167, 50);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Günde Kaç Saat Çalışıyorsun?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gunlukSaatTxtB
            // 
            this.gunlukSaatTxtB.Location = new System.Drawing.Point(15, 50);
            this.gunlukSaatTxtB.Name = "gunlukSaatTxtB";
            this.gunlukSaatTxtB.Size = new System.Drawing.Size(100, 20);
            this.gunlukSaatTxtB.TabIndex = 2;
            // 
            // uykusaat
            // 
            this.uykusaat.AutoSize = true;
            this.uykusaat.Location = new System.Drawing.Point(12, 90);
            this.uykusaat.Name = "uykusaat";
            this.uykusaat.Size = new System.Drawing.Size(156, 13);
            this.uykusaat.TabIndex = 3;
            this.uykusaat.Text = "Günde Kaç Saat Uyuyorsunuz?";
            // 
            // gunSaatTxtB
            // 
            this.gunSaatTxtB.Location = new System.Drawing.Point(12, 118);
            this.gunSaatTxtB.Name = "gunSaatTxtB";
            this.gunSaatTxtB.Size = new System.Drawing.Size(100, 20);
            this.gunSaatTxtB.TabIndex = 4;
            // 
            // HesapBtn
            // 
            this.HesapBtn.Location = new System.Drawing.Point(167, 155);
            this.HesapBtn.Name = "HesapBtn";
            this.HesapBtn.Size = new System.Drawing.Size(75, 23);
            this.HesapBtn.TabIndex = 5;
            this.HesapBtn.Text = "HESAP";
            this.HesapBtn.UseVisualStyleBackColor = true;
            this.HesapBtn.Click += new System.EventHandler(this.HesapBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kaç Yaşına Kadar Yaşıcaksınız?";
            // 
            // yasTxtB
            // 
            this.yasTxtB.Location = new System.Drawing.Point(12, 186);
            this.yasTxtB.Name = "yasTxtB";
            this.yasTxtB.Size = new System.Drawing.Size(100, 20);
            this.yasTxtB.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.yasTxtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HesapBtn);
            this.Controls.Add(this.gunSaatTxtB);
            this.Controls.Add(this.uykusaat);
            this.Controls.Add(this.gunlukSaatTxtB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gunlukSaatTxtB;
        private System.Windows.Forms.Label uykusaat;
        private System.Windows.Forms.TextBox gunSaatTxtB;
        private System.Windows.Forms.Button HesapBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yasTxtB;
    }
}

