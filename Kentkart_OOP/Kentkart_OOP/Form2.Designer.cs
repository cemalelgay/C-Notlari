namespace Kentkart_OOP
{
    partial class Form2
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
            this.TxtBakiye = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnYukle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBakiye
            // 
            this.TxtBakiye.Location = new System.Drawing.Point(129, 49);
            this.TxtBakiye.Name = "TxtBakiye";
            this.TxtBakiye.Size = new System.Drawing.Size(100, 20);
            this.TxtBakiye.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yükleme Miktarı:";
            // 
            // BtnYukle
            // 
            this.BtnYukle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnYukle.Location = new System.Drawing.Point(15, 81);
            this.BtnYukle.Name = "BtnYukle";
            this.BtnYukle.Size = new System.Drawing.Size(234, 35);
            this.BtnYukle.TabIndex = 2;
            this.BtnYukle.Text = "YUKLE";
            this.BtnYukle.UseVisualStyleBackColor = false;
            this.BtnYukle.Click += new System.EventHandler(this.BtnYukle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 128);
            this.Controls.Add(this.BtnYukle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBakiye);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBakiye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnYukle;
    }
}