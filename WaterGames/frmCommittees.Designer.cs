namespace WaterGames
{
    partial class frmCommittees
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
            this.gbxUpdateCommitte = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.dtpicUpdateDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtUpdateAddress = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbxUpdateDistrict = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnUpdateCommitte = new System.Windows.Forms.Button();
            this.cmbxUpdateCity = new System.Windows.Forms.ComboBox();
            this.txtUpdatePassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpdateUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdateLastname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdateFirstname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgwComittes = new System.Windows.Forms.DataGridView();
            this.label23 = new System.Windows.Forms.Label();
            this.dtpicDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbxDistrict = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbxCity = new System.Windows.Forms.ComboBox();
            this.btnAddComitte = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxAddCommittee = new System.Windows.Forms.GroupBox();
            this.gbxUpdateCommitte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwComittes)).BeginInit();
            this.gbxAddCommittee.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxUpdateCommitte
            // 
            this.gbxUpdateCommitte.Controls.Add(this.btnDelete);
            this.gbxUpdateCommitte.Controls.Add(this.label26);
            this.gbxUpdateCommitte.Controls.Add(this.dtpicUpdateDateOfBirth);
            this.gbxUpdateCommitte.Controls.Add(this.txtUpdateAddress);
            this.gbxUpdateCommitte.Controls.Add(this.label15);
            this.gbxUpdateCommitte.Controls.Add(this.label16);
            this.gbxUpdateCommitte.Controls.Add(this.cmbxUpdateDistrict);
            this.gbxUpdateCommitte.Controls.Add(this.label17);
            this.gbxUpdateCommitte.Controls.Add(this.btnUpdateCommitte);
            this.gbxUpdateCommitte.Controls.Add(this.cmbxUpdateCity);
            this.gbxUpdateCommitte.Controls.Add(this.txtUpdatePassword);
            this.gbxUpdateCommitte.Controls.Add(this.label5);
            this.gbxUpdateCommitte.Controls.Add(this.txtUpdateUsername);
            this.gbxUpdateCommitte.Controls.Add(this.label6);
            this.gbxUpdateCommitte.Controls.Add(this.txtUpdateLastname);
            this.gbxUpdateCommitte.Controls.Add(this.label7);
            this.gbxUpdateCommitte.Controls.Add(this.txtUpdateFirstname);
            this.gbxUpdateCommitte.Controls.Add(this.label8);
            this.gbxUpdateCommitte.Location = new System.Drawing.Point(609, 273);
            this.gbxUpdateCommitte.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.gbxUpdateCommitte.Name = "gbxUpdateCommitte";
            this.gbxUpdateCommitte.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.gbxUpdateCommitte.Size = new System.Drawing.Size(588, 210);
            this.gbxUpdateCommitte.TabIndex = 17;
            this.gbxUpdateCommitte.TabStop = false;
            this.gbxUpdateCommitte.Text = "Update a committe";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::WaterGames.Properties.Resources.delete_btn;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(330, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 34);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete a athlete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(69, 42);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 13);
            this.label26.TabIndex = 30;
            this.label26.Text = "Doğum Tarihi:";
            // 
            // dtpicUpdateDateOfBirth
            // 
            this.dtpicUpdateDateOfBirth.Location = new System.Drawing.Point(147, 37);
            this.dtpicUpdateDateOfBirth.Name = "dtpicUpdateDateOfBirth";
            this.dtpicUpdateDateOfBirth.Size = new System.Drawing.Size(153, 20);
            this.dtpicUpdateDateOfBirth.TabIndex = 17;
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.Location = new System.Drawing.Point(147, 123);
            this.txtUpdateAddress.Multiline = true;
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(153, 63);
            this.txtUpdateAddress.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(94, 128);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Address:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(67, 97);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Select District:";
            // 
            // cmbxUpdateDistrict
            // 
            this.cmbxUpdateDistrict.FormattingEnabled = true;
            this.cmbxUpdateDistrict.Location = new System.Drawing.Point(147, 93);
            this.cmbxUpdateDistrict.Name = "cmbxUpdateDistrict";
            this.cmbxUpdateDistrict.Size = new System.Drawing.Size(153, 21);
            this.cmbxUpdateDistrict.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(82, 67);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Select City:";
            // 
            // btnUpdateCommitte
            // 
            this.btnUpdateCommitte.Image = global::WaterGames.Properties.Resources.update_btn_24;
            this.btnUpdateCommitte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCommitte.Location = new System.Drawing.Point(457, 152);
            this.btnUpdateCommitte.Name = "btnUpdateCommitte";
            this.btnUpdateCommitte.Size = new System.Drawing.Size(83, 34);
            this.btnUpdateCommitte.TabIndex = 30;
            this.btnUpdateCommitte.Text = "Güncelle";
            this.btnUpdateCommitte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCommitte.UseVisualStyleBackColor = true;
            this.btnUpdateCommitte.Click += new System.EventHandler(this.btnUpdateCommitte_Click);
            // 
            // cmbxUpdateCity
            // 
            this.cmbxUpdateCity.FormattingEnabled = true;
            this.cmbxUpdateCity.Location = new System.Drawing.Point(147, 63);
            this.cmbxUpdateCity.Name = "cmbxUpdateCity";
            this.cmbxUpdateCity.Size = new System.Drawing.Size(153, 21);
            this.cmbxUpdateCity.TabIndex = 20;
            this.cmbxUpdateCity.SelectedIndexChanged += new System.EventHandler(this.cmbxUpdateCity_SelectedIndexChanged);
            // 
            // txtUpdatePassword
            // 
            this.txtUpdatePassword.Location = new System.Drawing.Point(387, 122);
            this.txtUpdatePassword.Name = "txtUpdatePassword";
            this.txtUpdatePassword.PasswordChar = '*';
            this.txtUpdatePassword.Size = new System.Drawing.Size(153, 20);
            this.txtUpdatePassword.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password:";
            // 
            // txtUpdateUsername
            // 
            this.txtUpdateUsername.Location = new System.Drawing.Point(387, 62);
            this.txtUpdateUsername.Name = "txtUpdateUsername";
            this.txtUpdateUsername.Size = new System.Drawing.Size(153, 20);
            this.txtUpdateUsername.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Username:";
            // 
            // txtUpdateLastname
            // 
            this.txtUpdateLastname.Location = new System.Drawing.Point(387, 94);
            this.txtUpdateLastname.Name = "txtUpdateLastname";
            this.txtUpdateLastname.Size = new System.Drawing.Size(153, 20);
            this.txtUpdateLastname.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Lastname:";
            // 
            // txtUpdateFirstname
            // 
            this.txtUpdateFirstname.Location = new System.Drawing.Point(387, 32);
            this.txtUpdateFirstname.Name = "txtUpdateFirstname";
            this.txtUpdateFirstname.Size = new System.Drawing.Size(153, 20);
            this.txtUpdateFirstname.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Firstname:";
            // 
            // dgwComittes
            // 
            this.dgwComittes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwComittes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwComittes.Location = new System.Drawing.Point(15, 14);
            this.dgwComittes.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dgwComittes.Name = "dgwComittes";
            this.dgwComittes.Size = new System.Drawing.Size(1219, 231);
            this.dgwComittes.TabIndex = 15;
            this.dgwComittes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwComittes_CellClick);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 42);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 13);
            this.label23.TabIndex = 48;
            this.label23.Text = "Doğum Tarihi:";
            // 
            // dtpicDateOfBirth
            // 
            this.dtpicDateOfBirth.Location = new System.Drawing.Point(89, 39);
            this.dtpicDateOfBirth.Name = "dtpicDateOfBirth";
            this.dtpicDateOfBirth.Size = new System.Drawing.Size(153, 20);
            this.dtpicDateOfBirth.TabIndex = 33;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(89, 127);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(153, 54);
            this.txtAddress.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 130);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Address:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 99);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "District:";
            // 
            // cmbxDistrict
            // 
            this.cmbxDistrict.FormattingEnabled = true;
            this.cmbxDistrict.Location = new System.Drawing.Point(89, 95);
            this.cmbxDistrict.Name = "cmbxDistrict";
            this.cmbxDistrict.Size = new System.Drawing.Size(153, 21);
            this.cmbxDistrict.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 70);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "City:";
            // 
            // cmbxCity
            // 
            this.cmbxCity.FormattingEnabled = true;
            this.cmbxCity.Location = new System.Drawing.Point(89, 67);
            this.cmbxCity.Name = "cmbxCity";
            this.cmbxCity.Size = new System.Drawing.Size(153, 21);
            this.cmbxCity.TabIndex = 35;
            this.cmbxCity.SelectedIndexChanged += new System.EventHandler(this.cmbxCity_SelectedIndexChanged);
            // 
            // btnAddComitte
            // 
            this.btnAddComitte.Image = global::WaterGames.Properties.Resources.add_btn;
            this.btnAddComitte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddComitte.Location = new System.Drawing.Point(415, 152);
            this.btnAddComitte.Name = "btnAddComitte";
            this.btnAddComitte.Size = new System.Drawing.Size(75, 34);
            this.btnAddComitte.TabIndex = 45;
            this.btnAddComitte.Text = "Kaydet";
            this.btnAddComitte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddComitte.UseVisualStyleBackColor = true;
            this.btnAddComitte.Click += new System.EventHandler(this.btnAddComitte_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(337, 118);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(153, 20);
            this.txtPassword.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(337, 91);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(153, 20);
            this.txtUsername.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Username:";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(337, 64);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(153, 20);
            this.txtLastname.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Lastname:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(337, 36);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(153, 20);
            this.txtFirstname.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Firstname:";
            // 
            // gbxAddCommittee
            // 
            this.gbxAddCommittee.Controls.Add(this.txtPassword);
            this.gbxAddCommittee.Controls.Add(this.label23);
            this.gbxAddCommittee.Controls.Add(this.label4);
            this.gbxAddCommittee.Controls.Add(this.txtUsername);
            this.gbxAddCommittee.Controls.Add(this.dtpicDateOfBirth);
            this.gbxAddCommittee.Controls.Add(this.btnAddComitte);
            this.gbxAddCommittee.Controls.Add(this.label3);
            this.gbxAddCommittee.Controls.Add(this.txtAddress);
            this.gbxAddCommittee.Controls.Add(this.cmbxCity);
            this.gbxAddCommittee.Controls.Add(this.label14);
            this.gbxAddCommittee.Controls.Add(this.txtLastname);
            this.gbxAddCommittee.Controls.Add(this.label1);
            this.gbxAddCommittee.Controls.Add(this.label12);
            this.gbxAddCommittee.Controls.Add(this.label13);
            this.gbxAddCommittee.Controls.Add(this.label2);
            this.gbxAddCommittee.Controls.Add(this.txtFirstname);
            this.gbxAddCommittee.Controls.Add(this.cmbxDistrict);
            this.gbxAddCommittee.Location = new System.Drawing.Point(50, 273);
            this.gbxAddCommittee.Name = "gbxAddCommittee";
            this.gbxAddCommittee.Size = new System.Drawing.Size(511, 210);
            this.gbxAddCommittee.TabIndex = 49;
            this.gbxAddCommittee.TabStop = false;
            this.gbxAddCommittee.Text = "Add a committee";
            // 
            // frmCommittees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 505);
            this.Controls.Add(this.gbxAddCommittee);
            this.Controls.Add(this.gbxUpdateCommitte);
            this.Controls.Add(this.dgwComittes);
            this.Name = "frmCommittees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Committees";
            this.Load += new System.EventHandler(this.frmCommittes_Load);
            this.gbxUpdateCommitte.ResumeLayout(false);
            this.gbxUpdateCommitte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwComittes)).EndInit();
            this.gbxAddCommittee.ResumeLayout(false);
            this.gbxAddCommittee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUpdateCommitte;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker dtpicUpdateDateOfBirth;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbxUpdateDistrict;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnUpdateCommitte;
        private System.Windows.Forms.ComboBox cmbxUpdateCity;
        private System.Windows.Forms.TextBox txtUpdatePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUpdateUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdateLastname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdateFirstname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgwComittes;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpicDateOfBirth;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbxDistrict;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbxCity;
        private System.Windows.Forms.Button btnAddComitte;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxAddCommittee;
    }
}