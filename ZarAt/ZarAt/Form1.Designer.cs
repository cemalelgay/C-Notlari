﻿namespace ZarAt
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
            this.Zar1 = new System.Windows.Forms.PictureBox();
            this.Zar2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Zar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zar2)).BeginInit();
            this.SuspendLayout();
            // 
            // Zar1
            // 
            this.Zar1.Image = ((System.Drawing.Image)(resources.GetObject("Zar1.Image")));
            this.Zar1.Location = new System.Drawing.Point(41, 29);
            this.Zar1.Name = "Zar1";
            this.Zar1.Size = new System.Drawing.Size(109, 87);
            this.Zar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zar1.TabIndex = 0;
            this.Zar1.TabStop = false;
            this.Zar1.Click += new System.EventHandler(this.Zar1_Click);
            // 
            // Zar2
            // 
            this.Zar2.Image = ((System.Drawing.Image)(resources.GetObject("Zar2.Image")));
            this.Zar2.Location = new System.Drawing.Point(215, 29);
            this.Zar2.Name = "Zar2";
            this.Zar2.Size = new System.Drawing.Size(103, 87);
            this.Zar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zar2.TabIndex = 2;
            this.Zar2.TabStop = false;
            this.Zar2.Click += new System.EventHandler(this.Zar2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 165);
            this.Controls.Add(this.Zar2);
            this.Controls.Add(this.Zar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Zar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Zar1;
        private System.Windows.Forms.PictureBox Zar2;
    }
}

