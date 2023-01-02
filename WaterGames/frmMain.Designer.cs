namespace WaterGames
{
    partial class frmMain
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
            this.btnShowApplyScreen = new System.Windows.Forms.Button();
            this.btnShowAtheleteLogin = new System.Windows.Forms.Button();
            this.btnShowDashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowApplyScreen
            // 
            this.btnShowApplyScreen.Image = global::WaterGames.Properties.Resources.apply_form_new;
            this.btnShowApplyScreen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowApplyScreen.Location = new System.Drawing.Point(73, 36);
            this.btnShowApplyScreen.Name = "btnShowApplyScreen";
            this.btnShowApplyScreen.Size = new System.Drawing.Size(145, 56);
            this.btnShowApplyScreen.TabIndex = 0;
            this.btnShowApplyScreen.Text = "Apply Screen";
            this.btnShowApplyScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowApplyScreen.UseVisualStyleBackColor = true;
            this.btnShowApplyScreen.Click += new System.EventHandler(this.btnShowApplyScreen_Click);
            // 
            // btnShowAtheleteLogin
            // 
            this.btnShowAtheleteLogin.Image = global::WaterGames.Properties.Resources.ath_login;
            this.btnShowAtheleteLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAtheleteLogin.Location = new System.Drawing.Point(73, 98);
            this.btnShowAtheleteLogin.Name = "btnShowAtheleteLogin";
            this.btnShowAtheleteLogin.Size = new System.Drawing.Size(145, 56);
            this.btnShowAtheleteLogin.TabIndex = 0;
            this.btnShowAtheleteLogin.Text = "Athlete Screen";
            this.btnShowAtheleteLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowAtheleteLogin.UseVisualStyleBackColor = true;
            this.btnShowAtheleteLogin.Click += new System.EventHandler(this.btnShowAtheleteLogin_Click);
            // 
            // btnShowDashboard
            // 
            this.btnShowDashboard.Image = global::WaterGames.Properties.Resources.ds50;
            this.btnShowDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowDashboard.Location = new System.Drawing.Point(73, 160);
            this.btnShowDashboard.Name = "btnShowDashboard";
            this.btnShowDashboard.Size = new System.Drawing.Size(145, 56);
            this.btnShowDashboard.TabIndex = 0;
            this.btnShowDashboard.Text = "Dashboard";
            this.btnShowDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowDashboard.UseVisualStyleBackColor = true;
            this.btnShowDashboard.Click += new System.EventHandler(this.btnShowDashboard_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 260);
            this.Controls.Add(this.btnShowDashboard);
            this.Controls.Add(this.btnShowAtheleteLogin);
            this.Controls.Add(this.btnShowApplyScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowApplyScreen;
        private System.Windows.Forms.Button btnShowAtheleteLogin;
        private System.Windows.Forms.Button btnShowDashboard;
    }
}