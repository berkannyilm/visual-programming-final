namespace WaterGames
{
    partial class frmAthletes
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateManger = new System.Windows.Forms.Button();
            this.txtUpdatePassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpdateUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdateLastname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdateFirstname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbxUpdateAthlete = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.dtpicUpdateFinishedDate = new System.Windows.Forms.DateTimePicker();
            this.label28 = new System.Windows.Forms.Label();
            this.txtUpdateWeight = new System.Windows.Forms.TextBox();
            this.dtpicUpdateStartedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpicUpdateDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtUpdateAddress = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUpdateHeight = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUpdateAge = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbxUpdateDistrict = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbxUpdateCity = new System.Windows.Forms.ComboBox();
            this.cmbxUpdateCategoryId = new System.Windows.Forms.ComboBox();
            this.btnAddManager = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.gbxAddManager = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.dtpicLicenseFinishedDate = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.dtpicLicenseStartedDate = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.dtpicDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbxDistrict = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbxCity = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbxCategoryId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwAthletes = new System.Windows.Forms.DataGridView();
            this.gbxUpdateAthlete.SuspendLayout();
            this.gbxAddManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAthletes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::WaterGames.Properties.Resources.delete_btn;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(330, 250);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 34);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete a athlete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateManger
            // 
            this.btnUpdateManger.Image = global::WaterGames.Properties.Resources.update_btn_24;
            this.btnUpdateManger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateManger.Location = new System.Drawing.Point(457, 247);
            this.btnUpdateManger.Name = "btnUpdateManger";
            this.btnUpdateManger.Size = new System.Drawing.Size(83, 37);
            this.btnUpdateManger.TabIndex = 30;
            this.btnUpdateManger.Text = "Güncelle";
            this.btnUpdateManger.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateManger.UseVisualStyleBackColor = true;
            this.btnUpdateManger.Click += new System.EventHandler(this.btnUpdateManger_Click);
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
            // gbxUpdateAthlete
            // 
            this.gbxUpdateAthlete.Controls.Add(this.btnDelete);
            this.gbxUpdateAthlete.Controls.Add(this.label27);
            this.gbxUpdateAthlete.Controls.Add(this.label26);
            this.gbxUpdateAthlete.Controls.Add(this.dtpicUpdateFinishedDate);
            this.gbxUpdateAthlete.Controls.Add(this.label28);
            this.gbxUpdateAthlete.Controls.Add(this.txtUpdateWeight);
            this.gbxUpdateAthlete.Controls.Add(this.dtpicUpdateStartedDate);
            this.gbxUpdateAthlete.Controls.Add(this.dtpicUpdateDateOfBirth);
            this.gbxUpdateAthlete.Controls.Add(this.txtUpdateAddress);
            this.gbxUpdateAthlete.Controls.Add(this.label20);
            this.gbxUpdateAthlete.Controls.Add(this.label15);
            this.gbxUpdateAthlete.Controls.Add(this.txtUpdateHeight);
            this.gbxUpdateAthlete.Controls.Add(this.label21);
            this.gbxUpdateAthlete.Controls.Add(this.label16);
            this.gbxUpdateAthlete.Controls.Add(this.txtUpdateAge);
            this.gbxUpdateAthlete.Controls.Add(this.label10);
            this.gbxUpdateAthlete.Controls.Add(this.label22);
            this.gbxUpdateAthlete.Controls.Add(this.cmbxUpdateDistrict);
            this.gbxUpdateAthlete.Controls.Add(this.label17);
            this.gbxUpdateAthlete.Controls.Add(this.btnUpdateManger);
            this.gbxUpdateAthlete.Controls.Add(this.cmbxUpdateCity);
            this.gbxUpdateAthlete.Controls.Add(this.cmbxUpdateCategoryId);
            this.gbxUpdateAthlete.Controls.Add(this.txtUpdatePassword);
            this.gbxUpdateAthlete.Controls.Add(this.label5);
            this.gbxUpdateAthlete.Controls.Add(this.txtUpdateUsername);
            this.gbxUpdateAthlete.Controls.Add(this.label6);
            this.gbxUpdateAthlete.Controls.Add(this.txtUpdateLastname);
            this.gbxUpdateAthlete.Controls.Add(this.label7);
            this.gbxUpdateAthlete.Controls.Add(this.txtUpdateFirstname);
            this.gbxUpdateAthlete.Controls.Add(this.label8);
            this.gbxUpdateAthlete.Location = new System.Drawing.Point(611, 273);
            this.gbxUpdateAthlete.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.gbxUpdateAthlete.Name = "gbxUpdateAthlete";
            this.gbxUpdateAthlete.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.gbxUpdateAthlete.Size = new System.Drawing.Size(588, 299);
            this.gbxUpdateAthlete.TabIndex = 14;
            this.gbxUpdateAthlete.TabStop = false;
            this.gbxUpdateAthlete.Text = "Update a athlete";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(27, 120);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(115, 13);
            this.label27.TabIndex = 32;
            this.label27.Text = "License Finished Date:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(69, 66);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 13);
            this.label26.TabIndex = 30;
            this.label26.Text = "Doğum Tarihi:";
            // 
            // dtpicUpdateFinishedDate
            // 
            this.dtpicUpdateFinishedDate.Location = new System.Drawing.Point(147, 116);
            this.dtpicUpdateFinishedDate.Name = "dtpicUpdateFinishedDate";
            this.dtpicUpdateFinishedDate.Size = new System.Drawing.Size(153, 20);
            this.dtpicUpdateFinishedDate.TabIndex = 19;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(32, 94);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(110, 13);
            this.label28.TabIndex = 30;
            this.label28.Text = "License Started Date:";
            // 
            // txtUpdateWeight
            // 
            this.txtUpdateWeight.Location = new System.Drawing.Point(387, 213);
            this.txtUpdateWeight.Name = "txtUpdateWeight";
            this.txtUpdateWeight.Size = new System.Drawing.Size(153, 20);
            this.txtUpdateWeight.TabIndex = 29;
            // 
            // dtpicUpdateStartedDate
            // 
            this.dtpicUpdateStartedDate.Location = new System.Drawing.Point(147, 89);
            this.dtpicUpdateStartedDate.Name = "dtpicUpdateStartedDate";
            this.dtpicUpdateStartedDate.Size = new System.Drawing.Size(153, 20);
            this.dtpicUpdateStartedDate.TabIndex = 18;
            // 
            // dtpicUpdateDateOfBirth
            // 
            this.dtpicUpdateDateOfBirth.Location = new System.Drawing.Point(147, 61);
            this.dtpicUpdateDateOfBirth.Name = "dtpicUpdateDateOfBirth";
            this.dtpicUpdateDateOfBirth.Size = new System.Drawing.Size(153, 20);
            this.dtpicUpdateDateOfBirth.TabIndex = 17;
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.Location = new System.Drawing.Point(147, 202);
            this.txtUpdateAddress.Multiline = true;
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(153, 31);
            this.txtUpdateAddress.TabIndex = 22;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(355, 217);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "Kilo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(94, 207);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Address:";
            // 
            // txtUpdateHeight
            // 
            this.txtUpdateHeight.Location = new System.Drawing.Point(387, 184);
            this.txtUpdateHeight.Name = "txtUpdateHeight";
            this.txtUpdateHeight.Size = new System.Drawing.Size(153, 20);
            this.txtUpdateHeight.TabIndex = 28;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(354, 187);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(28, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "Boy:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(67, 176);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Select District:";
            // 
            // txtUpdateAge
            // 
            this.txtUpdateAge.Location = new System.Drawing.Point(387, 153);
            this.txtUpdateAge.Name = "txtUpdateAge";
            this.txtUpdateAge.Size = new System.Drawing.Size(153, 20);
            this.txtUpdateAge.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Select Category:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(354, 156);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 13);
            this.label22.TabIndex = 24;
            this.label22.Text = "Yaş:";
            // 
            // cmbxUpdateDistrict
            // 
            this.cmbxUpdateDistrict.FormattingEnabled = true;
            this.cmbxUpdateDistrict.Location = new System.Drawing.Point(147, 172);
            this.cmbxUpdateDistrict.Name = "cmbxUpdateDistrict";
            this.cmbxUpdateDistrict.Size = new System.Drawing.Size(153, 21);
            this.cmbxUpdateDistrict.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(82, 146);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Select City:";
            // 
            // cmbxUpdateCity
            // 
            this.cmbxUpdateCity.FormattingEnabled = true;
            this.cmbxUpdateCity.Location = new System.Drawing.Point(147, 142);
            this.cmbxUpdateCity.Name = "cmbxUpdateCity";
            this.cmbxUpdateCity.Size = new System.Drawing.Size(153, 21);
            this.cmbxUpdateCity.TabIndex = 20;
            this.cmbxUpdateCity.SelectedIndexChanged += new System.EventHandler(this.cmbxUpdateCity_SelectedIndexChanged);
            // 
            // cmbxUpdateCategoryId
            // 
            this.cmbxUpdateCategoryId.FormattingEnabled = true;
            this.cmbxUpdateCategoryId.Location = new System.Drawing.Point(147, 31);
            this.cmbxUpdateCategoryId.Name = "cmbxUpdateCategoryId";
            this.cmbxUpdateCategoryId.Size = new System.Drawing.Size(153, 21);
            this.cmbxUpdateCategoryId.TabIndex = 16;
            // 
            // btnAddManager
            // 
            this.btnAddManager.Image = global::WaterGames.Properties.Resources.add_btn;
            this.btnAddManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddManager.Location = new System.Drawing.Point(461, 228);
            this.btnAddManager.Name = "btnAddManager";
            this.btnAddManager.Size = new System.Drawing.Size(75, 34);
            this.btnAddManager.TabIndex = 15;
            this.btnAddManager.Text = "Kaydet";
            this.btnAddManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddManager.UseVisualStyleBackColor = true;
            this.btnAddManager.Click += new System.EventHandler(this.btnAddManager_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(383, 118);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(153, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(383, 91);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(153, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username:";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(383, 64);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(153, 20);
            this.txtLastname.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lastname:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(383, 36);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(153, 20);
            this.txtFirstname.TabIndex = 8;
            // 
            // gbxAddManager
            // 
            this.gbxAddManager.Controls.Add(this.label25);
            this.gbxAddManager.Controls.Add(this.dtpicLicenseFinishedDate);
            this.gbxAddManager.Controls.Add(this.label24);
            this.gbxAddManager.Controls.Add(this.dtpicLicenseStartedDate);
            this.gbxAddManager.Controls.Add(this.label23);
            this.gbxAddManager.Controls.Add(this.dtpicDateOfBirth);
            this.gbxAddManager.Controls.Add(this.txtWeight);
            this.gbxAddManager.Controls.Add(this.label19);
            this.gbxAddManager.Controls.Add(this.txtHeight);
            this.gbxAddManager.Controls.Add(this.label18);
            this.gbxAddManager.Controls.Add(this.txtAge);
            this.gbxAddManager.Controls.Add(this.label11);
            this.gbxAddManager.Controls.Add(this.txtAddress);
            this.gbxAddManager.Controls.Add(this.label14);
            this.gbxAddManager.Controls.Add(this.label13);
            this.gbxAddManager.Controls.Add(this.cmbxDistrict);
            this.gbxAddManager.Controls.Add(this.label12);
            this.gbxAddManager.Controls.Add(this.cmbxCity);
            this.gbxAddManager.Controls.Add(this.label9);
            this.gbxAddManager.Controls.Add(this.cmbxCategoryId);
            this.gbxAddManager.Controls.Add(this.btnAddManager);
            this.gbxAddManager.Controls.Add(this.txtPassword);
            this.gbxAddManager.Controls.Add(this.label4);
            this.gbxAddManager.Controls.Add(this.txtUsername);
            this.gbxAddManager.Controls.Add(this.label3);
            this.gbxAddManager.Controls.Add(this.txtLastname);
            this.gbxAddManager.Controls.Add(this.label2);
            this.gbxAddManager.Controls.Add(this.txtFirstname);
            this.gbxAddManager.Controls.Add(this.label1);
            this.gbxAddManager.Location = new System.Drawing.Point(45, 273);
            this.gbxAddManager.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.gbxAddManager.Name = "gbxAddManager";
            this.gbxAddManager.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.gbxAddManager.Size = new System.Drawing.Size(562, 299);
            this.gbxAddManager.TabIndex = 13;
            this.gbxAddManager.TabStop = false;
            this.gbxAddManager.Text = "Add a athlete";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(16, 113);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(115, 13);
            this.label25.TabIndex = 28;
            this.label25.Text = "License Finished Date:";
            // 
            // dtpicLicenseFinishedDate
            // 
            this.dtpicLicenseFinishedDate.Location = new System.Drawing.Point(135, 110);
            this.dtpicLicenseFinishedDate.Name = "dtpicLicenseFinishedDate";
            this.dtpicLicenseFinishedDate.Size = new System.Drawing.Size(153, 20);
            this.dtpicLicenseFinishedDate.TabIndex = 4;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(21, 87);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(110, 13);
            this.label24.TabIndex = 26;
            this.label24.Text = "License Started Date:";
            // 
            // dtpicLicenseStartedDate
            // 
            this.dtpicLicenseStartedDate.Location = new System.Drawing.Point(135, 83);
            this.dtpicLicenseStartedDate.Name = "dtpicLicenseStartedDate";
            this.dtpicLicenseStartedDate.Size = new System.Drawing.Size(153, 20);
            this.dtpicLicenseStartedDate.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(58, 60);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = "Doğum Tarihi:";
            // 
            // dtpicDateOfBirth
            // 
            this.dtpicDateOfBirth.Location = new System.Drawing.Point(135, 56);
            this.dtpicDateOfBirth.Name = "dtpicDateOfBirth";
            this.dtpicDateOfBirth.Size = new System.Drawing.Size(153, 20);
            this.dtpicDateOfBirth.TabIndex = 2;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(383, 201);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(153, 20);
            this.txtWeight.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(352, 206);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "Kilo:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(383, 146);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(153, 20);
            this.txtHeight.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(350, 149);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Boy:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(383, 174);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(153, 20);
            this.txtAge.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(351, 178);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Yaş:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(135, 191);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(153, 30);
            this.txtAddress.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(83, 194);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Address:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(89, 168);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "District:";
            // 
            // cmbxDistrict
            // 
            this.cmbxDistrict.FormattingEnabled = true;
            this.cmbxDistrict.Location = new System.Drawing.Point(135, 164);
            this.cmbxDistrict.Name = "cmbxDistrict";
            this.cmbxDistrict.Size = new System.Drawing.Size(153, 21);
            this.cmbxDistrict.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(104, 139);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "City:";
            // 
            // cmbxCity
            // 
            this.cmbxCity.FormattingEnabled = true;
            this.cmbxCity.Location = new System.Drawing.Point(135, 136);
            this.cmbxCity.Name = "cmbxCity";
            this.cmbxCity.Size = new System.Drawing.Size(153, 21);
            this.cmbxCity.TabIndex = 5;
            this.cmbxCity.SelectedIndexChanged += new System.EventHandler(this.cmbxCity_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Select Category:";
            // 
            // cmbxCategoryId
            // 
            this.cmbxCategoryId.FormattingEnabled = true;
            this.cmbxCategoryId.Location = new System.Drawing.Point(135, 30);
            this.cmbxCategoryId.Name = "cmbxCategoryId";
            this.cmbxCategoryId.Size = new System.Drawing.Size(153, 21);
            this.cmbxCategoryId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname:";
            // 
            // dgwAthletes
            // 
            this.dgwAthletes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwAthletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAthletes.Location = new System.Drawing.Point(17, 14);
            this.dgwAthletes.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dgwAthletes.Name = "dgwAthletes";
            this.dgwAthletes.Size = new System.Drawing.Size(1219, 231);
            this.dgwAthletes.TabIndex = 12;
            this.dgwAthletes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAthletes_CellClick);
            // 
            // frmAthletes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 586);
            this.Controls.Add(this.gbxUpdateAthlete);
            this.Controls.Add(this.gbxAddManager);
            this.Controls.Add(this.dgwAthletes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAthletes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Athletes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAthletes_FormClosing);
            this.Load += new System.EventHandler(this.frmAthletes_Load);
            this.gbxUpdateAthlete.ResumeLayout(false);
            this.gbxUpdateAthlete.PerformLayout();
            this.gbxAddManager.ResumeLayout(false);
            this.gbxAddManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAthletes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateManger;
        private System.Windows.Forms.TextBox txtUpdatePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUpdateUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdateLastname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdateFirstname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbxUpdateAthlete;
        private System.Windows.Forms.Button btnAddManager;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.GroupBox gbxAddManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwAthletes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbxUpdateCategoryId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbxCategoryId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbxUpdateDistrict;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbxUpdateCity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbxDistrict;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbxCity;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUpdateWeight;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtUpdateHeight;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtUpdateAge;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DateTimePicker dtpicLicenseFinishedDate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dtpicLicenseStartedDate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpicDateOfBirth;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker dtpicUpdateFinishedDate;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DateTimePicker dtpicUpdateStartedDate;
        private System.Windows.Forms.DateTimePicker dtpicUpdateDateOfBirth;
    }
}