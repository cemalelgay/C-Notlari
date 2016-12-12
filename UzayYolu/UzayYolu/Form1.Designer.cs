namespace UzayYolu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SpaceShip = new System.Windows.Forms.PictureBox();
            this.rocket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).BeginInit();
            this.SuspendLayout();
            // 
            // SpaceShip
            // 
            this.SpaceShip.BackColor = System.Drawing.Color.Transparent;
            this.SpaceShip.Image = ((System.Drawing.Image)(resources.GetObject("SpaceShip.Image")));
            this.SpaceShip.Location = new System.Drawing.Point(12, 12);
            this.SpaceShip.Name = "SpaceShip";
            this.SpaceShip.Size = new System.Drawing.Size(128, 93);
            this.SpaceShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpaceShip.TabIndex = 0;
            this.SpaceShip.TabStop = false;
            // 
            // rocket
            // 
            this.rocket.BackColor = System.Drawing.Color.Transparent;
            this.rocket.Image = ((System.Drawing.Image)(resources.GetObject("rocket.Image")));
            this.rocket.Location = new System.Drawing.Point(12, 132);
            this.rocket.Name = "rocket";
            this.rocket.Size = new System.Drawing.Size(19, 21);
            this.rocket.TabIndex = 1;
            this.rocket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 346);
            this.Controls.Add(this.rocket);
            this.Controls.Add(this.SpaceShip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SpaceShip;
        private System.Windows.Forms.PictureBox rocket;
        private System.Windows.Forms.Timer timer1;
    }
}

