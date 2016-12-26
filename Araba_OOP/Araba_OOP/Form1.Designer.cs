namespace Araba_OOP
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
            this.NumericYakitKapasite = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumericOrtalamaTuketim100km = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NumericYakitFiyati = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NumericMesafe = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LabelUcret = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericYakitKapasite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericOrtalamaTuketim100km)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericYakitFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMesafe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelUcret);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NumericMesafe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NumericYakitFiyati);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NumericOrtalamaTuketim100km);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NumericYakitKapasite);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araba Bilgisi";
            // 
            // NumericYakitKapasite
            // 
            this.NumericYakitKapasite.Location = new System.Drawing.Point(6, 67);
            this.NumericYakitKapasite.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.NumericYakitKapasite.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NumericYakitKapasite.Name = "NumericYakitKapasite";
            this.NumericYakitKapasite.Size = new System.Drawing.Size(120, 20);
            this.NumericYakitKapasite.TabIndex = 0;
            this.NumericYakitKapasite.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yakıt Deposu Kapasite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "100 Km\'de Kaç Lt Tüketiyor?";
            // 
            // NumericOrtalamaTuketim100km
            // 
            this.NumericOrtalamaTuketim100km.DecimalPlaces = 1;
            this.NumericOrtalamaTuketim100km.Location = new System.Drawing.Point(6, 127);
            this.NumericOrtalamaTuketim100km.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NumericOrtalamaTuketim100km.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericOrtalamaTuketim100km.Name = "NumericOrtalamaTuketim100km";
            this.NumericOrtalamaTuketim100km.Size = new System.Drawing.Size(120, 20);
            this.NumericOrtalamaTuketim100km.TabIndex = 1;
            this.NumericOrtalamaTuketim100km.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yakıt Fiyatı ₺";
            // 
            // NumericYakitFiyati
            // 
            this.NumericYakitFiyati.Location = new System.Drawing.Point(6, 176);
            this.NumericYakitFiyati.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericYakitFiyati.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumericYakitFiyati.Name = "NumericYakitFiyati";
            this.NumericYakitFiyati.Size = new System.Drawing.Size(120, 20);
            this.NumericYakitFiyati.TabIndex = 2;
            this.NumericYakitFiyati.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mesafe Giriniz";
            // 
            // NumericMesafe
            // 
            this.NumericMesafe.Location = new System.Drawing.Point(6, 336);
            this.NumericMesafe.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericMesafe.Name = "NumericMesafe";
            this.NumericMesafe.Size = new System.Drawing.Size(120, 20);
            this.NumericMesafe.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "K";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LabelUcret
            // 
            this.LabelUcret.AutoSize = true;
            this.LabelUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelUcret.Location = new System.Drawing.Point(6, 392);
            this.LabelUcret.Name = "LabelUcret";
            this.LabelUcret.Size = new System.Drawing.Size(0, 13);
            this.LabelUcret.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 490);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericYakitKapasite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericOrtalamaTuketim100km)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericYakitFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMesafe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumericMesafe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumericYakitFiyati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumericOrtalamaTuketim100km;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumericYakitKapasite;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LabelUcret;
    }
}

