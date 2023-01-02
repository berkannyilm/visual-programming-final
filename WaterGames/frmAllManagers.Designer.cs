namespace WaterGames
{
    partial class frmAllManagers
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
            this.dgwManagers = new System.Windows.Forms.DataGridView();
            this.gbxAddManager = new System.Windows.Forms.GroupBox();
            this.btnAddManager = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxUpdateManager = new System.Windows.Forms.GroupBox();
            this.btnUpdateManger = new System.Windows.Forms.Button();
            this.txtUpdatePassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpdateUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdateLastname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdateFirstname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwManagers)).BeginInit();
            this.gbxAddManager.SuspendLayout();
            this.gbxUpdateManager.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwManagers
            // 
            this.dgwManagers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwManagers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwManagers.Location = new System.Drawing.Point(12, 21);
            this.dgwManagers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgwManagers.Name = "dgwManagers";
            this.dgwManagers.Size = new System.Drawing.Size(928, 122);
            this.dgwManagers.TabIndex = 0;
            this.dgwManagers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwManagers_CellClick);
            // 
            // gbxAddManager
            // 
            this.gbxAddManager.Controls.Add(this.btnAddManager);
            this.gbxAddManager.Controls.Add(this.txtPassword);
            this.gbxAddManager.Controls.Add(this.label4);
            this.gbxAddManager.Controls.Add(this.txtUsername);
            this.gbxAddManager.Controls.Add(this.label3);
            this.gbxAddManager.Controls.Add(this.txtLastname);
            this.gbxAddManager.Controls.Add(this.label2);
            this.gbxAddManager.Controls.Add(this.txtFirstname);
            this.gbxAddManager.Controls.Add(this.label1);
            this.gbxAddManager.Location = new System.Drawing.Point(12, 150);
            this.gbxAddManager.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxAddManager.Name = "gbxAddManager";
            this.gbxAddManager.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxAddManager.Size = new System.Drawing.Size(289, 155);
            this.gbxAddManager.TabIndex = 1;
            this.gbxAddManager.TabStop = false;
            this.gbxAddManager.Text = "Add a manager";
            // 
            // btnAddManager
            // 
            this.btnAddManager.Image = global::WaterGames.Properties.Resources.add_btn;
            this.btnAddManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddManager.Location = new System.Drawing.Point(180, 115);
            this.btnAddManager.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAddManager.Name = "btnAddManager";
            this.btnAddManager.Size = new System.Drawing.Size(89, 35);
            this.btnAddManager.TabIndex = 9;
            this.btnAddManager.Text = "Kaydet";
            this.btnAddManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddManager.UseVisualStyleBackColor = true;
            this.btnAddManager.Click += new System.EventHandler(this.btnAddManager_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(85, 92);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(183, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(85, 72);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(183, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username:";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(85, 51);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(183, 20);
            this.txtLastname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lastname:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(85, 30);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(183, 20);
            this.txtFirstname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname:";
            // 
            // gbxUpdateManager
            // 
            this.gbxUpdateManager.Controls.Add(this.btnUpdateManger);
            this.gbxUpdateManager.Controls.Add(this.txtUpdatePassword);
            this.gbxUpdateManager.Controls.Add(this.label5);
            this.gbxUpdateManager.Controls.Add(this.txtUpdateUsername);
            this.gbxUpdateManager.Controls.Add(this.label6);
            this.gbxUpdateManager.Controls.Add(this.txtUpdateLastname);
            this.gbxUpdateManager.Controls.Add(this.label7);
            this.gbxUpdateManager.Controls.Add(this.txtUpdateFirstname);
            this.gbxUpdateManager.Controls.Add(this.label8);
            this.gbxUpdateManager.Location = new System.Drawing.Point(336, 150);
            this.gbxUpdateManager.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxUpdateManager.Name = "gbxUpdateManager";
            this.gbxUpdateManager.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbxUpdateManager.Size = new System.Drawing.Size(289, 155);
            this.gbxUpdateManager.TabIndex = 10;
            this.gbxUpdateManager.TabStop = false;
            this.gbxUpdateManager.Text = "Update a manager";
            // 
            // btnUpdateManger
            // 
            this.btnUpdateManger.Image = global::WaterGames.Properties.Resources.update_btn_24;
            this.btnUpdateManger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateManger.Location = new System.Drawing.Point(178, 115);
            this.btnUpdateManger.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnUpdateManger.Name = "btnUpdateManger";
            this.btnUpdateManger.Size = new System.Drawing.Size(91, 35);
            this.btnUpdateManger.TabIndex = 9;
            this.btnUpdateManger.Text = "Güncelle";
            this.btnUpdateManger.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateManger.UseVisualStyleBackColor = true;
            this.btnUpdateManger.Click += new System.EventHandler(this.btnUpdateManger_Click);
            // 
            // txtUpdatePassword
            // 
            this.txtUpdatePassword.Location = new System.Drawing.Point(85, 92);
            this.txtUpdatePassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtUpdatePassword.Name = "txtUpdatePassword";
            this.txtUpdatePassword.PasswordChar = '*';
            this.txtUpdatePassword.Size = new System.Drawing.Size(183, 20);
            this.txtUpdatePassword.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password:";
            // 
            // txtUpdateUsername
            // 
            this.txtUpdateUsername.Location = new System.Drawing.Point(85, 72);
            this.txtUpdateUsername.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtUpdateUsername.Name = "txtUpdateUsername";
            this.txtUpdateUsername.Size = new System.Drawing.Size(183, 20);
            this.txtUpdateUsername.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Username:";
            // 
            // txtUpdateLastname
            // 
            this.txtUpdateLastname.Location = new System.Drawing.Point(85, 51);
            this.txtUpdateLastname.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtUpdateLastname.Name = "txtUpdateLastname";
            this.txtUpdateLastname.Size = new System.Drawing.Size(183, 20);
            this.txtUpdateLastname.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Lastname:";
            // 
            // txtUpdateFirstname
            // 
            this.txtUpdateFirstname.Location = new System.Drawing.Point(85, 30);
            this.txtUpdateFirstname.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtUpdateFirstname.Name = "txtUpdateFirstname";
            this.txtUpdateFirstname.Size = new System.Drawing.Size(183, 20);
            this.txtUpdateFirstname.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Firstname:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(650, 150);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(289, 155);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete a manager";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::WaterGames.Properties.Resources.delete_btn;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(84, 62);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 43);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete a manager";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmAllManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxUpdateManager);
            this.Controls.Add(this.gbxAddManager);
            this.Controls.Add(this.dgwManagers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmAllManagers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Managers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAllManagers_FormClosing);
            this.Load += new System.EventHandler(this.frmAllManagers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwManagers)).EndInit();
            this.gbxAddManager.ResumeLayout(false);
            this.gbxAddManager.PerformLayout();
            this.gbxUpdateManager.ResumeLayout(false);
            this.gbxUpdateManager.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwManagers;
        private System.Windows.Forms.GroupBox gbxAddManager;
        private System.Windows.Forms.Button btnAddManager;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxUpdateManager;
        private System.Windows.Forms.Button btnUpdateManger;
        private System.Windows.Forms.TextBox txtUpdatePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUpdateUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdateLastname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdateFirstname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
    }
}