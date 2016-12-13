namespace Gecisler
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
            this.BtnGonder = new System.Windows.Forms.Button();
            this.mesajTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnGonder
            // 
            this.BtnGonder.Location = new System.Drawing.Point(90, 102);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(75, 23);
            this.BtnGonder.TabIndex = 0;
            this.BtnGonder.Text = "Gönder";
            this.BtnGonder.UseVisualStyleBackColor = true;
            this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // mesajTxt
            // 
            this.mesajTxt.Location = new System.Drawing.Point(58, 76);
            this.mesajTxt.Name = "mesajTxt";
            this.mesajTxt.Size = new System.Drawing.Size(139, 20);
            this.mesajTxt.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.mesajTxt);
            this.Controls.Add(this.BtnGonder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGonder;
        private System.Windows.Forms.TextBox mesajTxt;
    }
}

