namespace IZSU_RSS
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnGetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSuKes = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.BtnHaber = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(415, 186);
            this.listBox1.TabIndex = 0;
            // 
            // BtnGetir
            // 
            this.BtnGetir.Location = new System.Drawing.Point(32, 12);
            this.BtnGetir.Name = "BtnGetir";
            this.BtnGetir.Size = new System.Drawing.Size(195, 23);
            this.BtnGetir.TabIndex = 1;
            this.BtnGetir.Text = "Ne Varsa Getir";
            this.BtnGetir.UseVisualStyleBackColor = true;
            this.BtnGetir.Click += new System.EventHandler(this.BtnGetir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // BtnSuKes
            // 
            this.BtnSuKes.Location = new System.Drawing.Point(459, 12);
            this.BtnSuKes.Name = "BtnSuKes";
            this.BtnSuKes.Size = new System.Drawing.Size(258, 23);
            this.BtnSuKes.TabIndex = 3;
            this.BtnSuKes.Text = "Su Kesintisi";
            this.BtnSuKes.UseVisualStyleBackColor = true;
            this.BtnSuKes.Click += new System.EventHandler(this.BtnSuKes_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(10, 251);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(420, 173);
            this.listBox2.TabIndex = 4;
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // BtnHaber
            // 
            this.BtnHaber.Location = new System.Drawing.Point(941, 12);
            this.BtnHaber.Name = "BtnHaber";
            this.BtnHaber.Size = new System.Drawing.Size(224, 23);
            this.BtnHaber.TabIndex = 5;
            this.BtnHaber.Text = "HABERLER";
            this.BtnHaber.UseVisualStyleBackColor = true;
            this.BtnHaber.Click += new System.EventHandler(this.BtnHaber_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(10, 440);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(420, 186);
            this.listBox3.TabIndex = 6;
            this.listBox3.DoubleClick += new System.EventHandler(this.listBox3_DoubleClick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(459, 71);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(793, 482);
            this.webBrowser1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 873);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.BtnHaber);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.BtnSuKes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGetir);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnGetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSuKes;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button BtnHaber;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

