namespace WaterGames
{
    partial class frmAthleteLogin
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.pcbxLoginIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLoginIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(146, 79);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(248, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(146, 39);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(248, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Image = global::WaterGames.Properties.Resources.btn_login;
            this.ButtonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLogin.Location = new System.Drawing.Point(412, 36);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(86, 67);
            this.ButtonLogin.TabIndex = 8;
            this.ButtonLogin.Text = "Giriş Yap";
            this.ButtonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // pcbxLoginIcon
            // 
            this.pcbxLoginIcon.Image = global::WaterGames.Properties.Resources.usering;
            this.pcbxLoginIcon.Location = new System.Drawing.Point(25, 22);
            this.pcbxLoginIcon.Name = "pcbxLoginIcon";
            this.pcbxLoginIcon.Size = new System.Drawing.Size(93, 88);
            this.pcbxLoginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxLoginIcon.TabIndex = 5;
            this.pcbxLoginIcon.TabStop = false;
            // 
            // frmAthleteLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 134);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pcbxLoginIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAthleteLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Athlete Login Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAthleteLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmAthleteLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLoginIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pcbxLoginIcon;
    }
}