﻿namespace CemalElgay_KafeSiparisi
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnSiparis = new System.Windows.Forms.Button();
            this.BtnOdeme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumericYemek = new System.Windows.Forms.NumericUpDown();
            this.NumericIcecek = new System.Windows.Forms.NumericUpDown();
            this.ComboBoxYemek = new System.Windows.Forms.ComboBox();
            this.ComboBoxIcecek = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericYemek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIcecek)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masalar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ComboBoxIcecek);
            this.groupBox2.Controls.Add(this.ComboBoxYemek);
            this.groupBox2.Controls.Add(this.NumericIcecek);
            this.groupBox2.Controls.Add(this.NumericYemek);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(13, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 147);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Siparis";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(274, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 160);
            this.listBox1.TabIndex = 2;
            // 
            // BtnSiparis
            // 
            this.BtnSiparis.Location = new System.Drawing.Point(13, 461);
            this.BtnSiparis.Name = "BtnSiparis";
            this.BtnSiparis.Size = new System.Drawing.Size(177, 23);
            this.BtnSiparis.TabIndex = 3;
            this.BtnSiparis.Text = "SİPARİŞ VER";
            this.BtnSiparis.UseVisualStyleBackColor = true;
            // 
            // BtnOdeme
            // 
            this.BtnOdeme.Location = new System.Drawing.Point(345, 221);
            this.BtnOdeme.Name = "BtnOdeme";
            this.BtnOdeme.Size = new System.Drawing.Size(75, 23);
            this.BtnOdeme.TabIndex = 4;
            this.BtnOdeme.Text = "ÖDEME";
            this.BtnOdeme.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yemek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "İçecek";
            // 
            // NumericYemek
            // 
            this.NumericYemek.Location = new System.Drawing.Point(284, 68);
            this.NumericYemek.Name = "NumericYemek";
            this.NumericYemek.Size = new System.Drawing.Size(45, 23);
            this.NumericYemek.TabIndex = 2;
            // 
            // NumericIcecek
            // 
            this.NumericIcecek.Location = new System.Drawing.Point(284, 113);
            this.NumericIcecek.Name = "NumericIcecek";
            this.NumericIcecek.Size = new System.Drawing.Size(45, 23);
            this.NumericIcecek.TabIndex = 3;
            // 
            // ComboBoxYemek
            // 
            this.ComboBoxYemek.FormattingEnabled = true;
            this.ComboBoxYemek.Location = new System.Drawing.Point(69, 70);
            this.ComboBoxYemek.Name = "ComboBoxYemek";
            this.ComboBoxYemek.Size = new System.Drawing.Size(209, 24);
            this.ComboBoxYemek.TabIndex = 5;
            // 
            // ComboBoxIcecek
            // 
            this.ComboBoxIcecek.FormattingEnabled = true;
            this.ComboBoxIcecek.Location = new System.Drawing.Point(69, 113);
            this.ComboBoxIcecek.Name = "ComboBoxIcecek";
            this.ComboBoxIcecek.Size = new System.Drawing.Size(209, 24);
            this.ComboBoxIcecek.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(274, 194);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 21);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dolar";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(345, 194);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 21);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Euro";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton3.Location = new System.Drawing.Point(411, 194);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 21);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Pound";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 503);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BtnOdeme);
            this.Controls.Add(this.BtnSiparis);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericYemek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericIcecek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnSiparis;
        private System.Windows.Forms.Button BtnOdeme;
        private System.Windows.Forms.NumericUpDown NumericIcecek;
        private System.Windows.Forms.NumericUpDown NumericYemek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxIcecek;
        private System.Windows.Forms.ComboBox ComboBoxYemek;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

