namespace LockSimulatorIoT
{
    partial class homelockform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homelockform));
            this.lockBtn = new System.Windows.Forms.Button();
            this.unlockBtn = new System.Windows.Forms.Button();
            this.lockpicturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lockpicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // lockBtn
            // 
            this.lockBtn.Location = new System.Drawing.Point(79, 229);
            this.lockBtn.Name = "lockBtn";
            this.lockBtn.Size = new System.Drawing.Size(141, 113);
            this.lockBtn.TabIndex = 0;
            this.lockBtn.Text = "Lock";
            this.lockBtn.UseVisualStyleBackColor = true;
            this.lockBtn.Click += new System.EventHandler(this.lockBtn_Click);
            // 
            // unlockBtn
            // 
            this.unlockBtn.Location = new System.Drawing.Point(510, 229);
            this.unlockBtn.Name = "unlockBtn";
            this.unlockBtn.Size = new System.Drawing.Size(141, 113);
            this.unlockBtn.TabIndex = 1;
            this.unlockBtn.Text = "Unlock";
            this.unlockBtn.UseVisualStyleBackColor = true;
            this.unlockBtn.Click += new System.EventHandler(this.unlockBtn_Click);
            // 
            // lockpicturebox
            // 
            this.lockpicturebox.Image = ((System.Drawing.Image)(resources.GetObject("lockpicturebox.Image")));
            this.lockpicturebox.Location = new System.Drawing.Point(288, 28);
            this.lockpicturebox.Name = "lockpicturebox";
            this.lockpicturebox.Size = new System.Drawing.Size(168, 160);
            this.lockpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lockpicturebox.TabIndex = 3;
            this.lockpicturebox.TabStop = false;
            // 
            // homelockform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lockpicturebox);
            this.Controls.Add(this.unlockBtn);
            this.Controls.Add(this.lockBtn);
            this.MaximizeBox = false;
            this.Name = "homelockform";
            this.Text = "Home Lock";
            this.Load += new System.EventHandler(this.homelockform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lockpicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lockBtn;
        private System.Windows.Forms.Button unlockBtn;
        private System.Windows.Forms.PictureBox lockpicturebox;
    }
}

