namespace WaterGames
{
    partial class frmSplashScreen
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
            this.pcbxScreenImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prgLoading = new System.Windows.Forms.ProgressBar();
            this.tmrLoading = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxScreenImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbxScreenImage
            // 
            this.pcbxScreenImage.Image = global::WaterGames.Properties.Resources.drop;
            this.pcbxScreenImage.Location = new System.Drawing.Point(158, 52);
            this.pcbxScreenImage.Name = "pcbxScreenImage";
            this.pcbxScreenImage.Size = new System.Drawing.Size(183, 189);
            this.pcbxScreenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxScreenImage.TabIndex = 0;
            this.pcbxScreenImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Water Games";
            // 
            // prgLoading
            // 
            this.prgLoading.Location = new System.Drawing.Point(61, 260);
            this.prgLoading.Name = "prgLoading";
            this.prgLoading.Size = new System.Drawing.Size(377, 45);
            this.prgLoading.TabIndex = 2;
            // 
            // tmrLoading
            // 
            this.tmrLoading.Tick += new System.EventHandler(this.tmrLoading_Tick);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 322);
            this.Controls.Add(this.prgLoading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbxScreenImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxScreenImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbxScreenImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prgLoading;
        private System.Windows.Forms.Timer tmrLoading;
    }
}