namespace UniPortal
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
            this.ComboBoxKisiSec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBoxKisiSec
            // 
            this.ComboBoxKisiSec.FormattingEnabled = true;
            this.ComboBoxKisiSec.Items.AddRange(new object[] {
            "Öğrenci",
            "Öğretim Grv."});
            this.ComboBoxKisiSec.Location = new System.Drawing.Point(13, 60);
            this.ComboBoxKisiSec.Name = "ComboBoxKisiSec";
            this.ComboBoxKisiSec.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxKisiSec.TabIndex = 0;
            this.ComboBoxKisiSec.SelectedIndexChanged += new System.EventHandler(this.ComboBoxKisiSec_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kişi Seçin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxKisiSec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxKisiSec;
        private System.Windows.Forms.Label label1;
    }
}

