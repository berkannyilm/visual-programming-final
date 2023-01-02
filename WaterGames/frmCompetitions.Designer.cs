namespace WaterGames
{
    partial class frmCompetitions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxUpdateCompetition = new System.Windows.Forms.GroupBox();
            this.btnUpdateCompetition = new System.Windows.Forms.Button();
            this.cmbxUpdateCategoryId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpdateCapacity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdateRecord = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdateTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbxAddCompetition = new System.Windows.Forms.GroupBox();
            this.cmbxCategoryId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddCompetition = new System.Windows.Forms.Button();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwCompetitions = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.gbxUpdateCompetition.SuspendLayout();
            this.gbxAddCompetition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompetitions)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(656, 212);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox1.Size = new System.Drawing.Size(201, 200);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete a manager";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::WaterGames.Properties.Resources.delete_btn;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(47, 99);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 34);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete a manager";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxUpdateCompetition
            // 
            this.gbxUpdateCompetition.Controls.Add(this.btnUpdateCompetition);
            this.gbxUpdateCompetition.Controls.Add(this.cmbxUpdateCategoryId);
            this.gbxUpdateCompetition.Controls.Add(this.label5);
            this.gbxUpdateCompetition.Controls.Add(this.txtUpdateCapacity);
            this.gbxUpdateCompetition.Controls.Add(this.label6);
            this.gbxUpdateCompetition.Controls.Add(this.txtUpdateRecord);
            this.gbxUpdateCompetition.Controls.Add(this.label7);
            this.gbxUpdateCompetition.Controls.Add(this.txtUpdateTitle);
            this.gbxUpdateCompetition.Controls.Add(this.label8);
            this.gbxUpdateCompetition.Location = new System.Drawing.Point(326, 212);
            this.gbxUpdateCompetition.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.gbxUpdateCompetition.Name = "gbxUpdateCompetition";
            this.gbxUpdateCompetition.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.gbxUpdateCompetition.Size = new System.Drawing.Size(303, 200);
            this.gbxUpdateCompetition.TabIndex = 14;
            this.gbxUpdateCompetition.TabStop = false;
            this.gbxUpdateCompetition.Text = "Update a competition";
            // 
            // btnUpdateCompetition
            // 
            this.btnUpdateCompetition.Image = global::WaterGames.Properties.Resources.update_btn_24;
            this.btnUpdateCompetition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCompetition.Location = new System.Drawing.Point(194, 158);
            this.btnUpdateCompetition.Name = "btnUpdateCompetition";
            this.btnUpdateCompetition.Size = new System.Drawing.Size(81, 34);
            this.btnUpdateCompetition.TabIndex = 14;
            this.btnUpdateCompetition.Text = "Güncelle";
            this.btnUpdateCompetition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCompetition.UseVisualStyleBackColor = true;
            this.btnUpdateCompetition.Click += new System.EventHandler(this.btnUpdateCompetition_Click);
            // 
            // cmbxUpdateCategoryId
            // 
            this.cmbxUpdateCategoryId.FormattingEnabled = true;
            this.cmbxUpdateCategoryId.Location = new System.Drawing.Point(122, 31);
            this.cmbxUpdateCategoryId.Name = "cmbxUpdateCategoryId";
            this.cmbxUpdateCategoryId.Size = new System.Drawing.Size(153, 21);
            this.cmbxUpdateCategoryId.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Category:";
            // 
            // txtUpdateCapacity
            // 
            this.txtUpdateCapacity.Location = new System.Drawing.Point(122, 126);
            this.txtUpdateCapacity.Name = "txtUpdateCapacity";
            this.txtUpdateCapacity.Size = new System.Drawing.Size(153, 20);
            this.txtUpdateCapacity.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Max Capacity:";
            // 
            // txtUpdateRecord
            // 
            this.txtUpdateRecord.Location = new System.Drawing.Point(122, 94);
            this.txtUpdateRecord.Name = "txtUpdateRecord";
            this.txtUpdateRecord.Size = new System.Drawing.Size(153, 20);
            this.txtUpdateRecord.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Record:";
            // 
            // txtUpdateTitle
            // 
            this.txtUpdateTitle.Location = new System.Drawing.Point(122, 62);
            this.txtUpdateTitle.Name = "txtUpdateTitle";
            this.txtUpdateTitle.Size = new System.Drawing.Size(153, 20);
            this.txtUpdateTitle.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Title:";
            // 
            // gbxAddCompetition
            // 
            this.gbxAddCompetition.Controls.Add(this.cmbxCategoryId);
            this.gbxAddCompetition.Controls.Add(this.label4);
            this.gbxAddCompetition.Controls.Add(this.btnAddCompetition);
            this.gbxAddCompetition.Controls.Add(this.txtCapacity);
            this.gbxAddCompetition.Controls.Add(this.label3);
            this.gbxAddCompetition.Controls.Add(this.txtRecord);
            this.gbxAddCompetition.Controls.Add(this.label2);
            this.gbxAddCompetition.Controls.Add(this.txtTitle);
            this.gbxAddCompetition.Controls.Add(this.label1);
            this.gbxAddCompetition.Location = new System.Drawing.Point(11, 212);
            this.gbxAddCompetition.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.gbxAddCompetition.Name = "gbxAddCompetition";
            this.gbxAddCompetition.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.gbxAddCompetition.Size = new System.Drawing.Size(285, 200);
            this.gbxAddCompetition.TabIndex = 13;
            this.gbxAddCompetition.TabStop = false;
            this.gbxAddCompetition.Text = "Add a competition";
            // 
            // cmbxCategoryId
            // 
            this.cmbxCategoryId.FormattingEnabled = true;
            this.cmbxCategoryId.Location = new System.Drawing.Point(92, 32);
            this.cmbxCategoryId.Name = "cmbxCategoryId";
            this.cmbxCategoryId.Size = new System.Drawing.Size(161, 21);
            this.cmbxCategoryId.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category:";
            // 
            // btnAddCompetition
            // 
            this.btnAddCompetition.Image = global::WaterGames.Properties.Resources.add_btn;
            this.btnAddCompetition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCompetition.Location = new System.Drawing.Point(171, 158);
            this.btnAddCompetition.Name = "btnAddCompetition";
            this.btnAddCompetition.Size = new System.Drawing.Size(82, 34);
            this.btnAddCompetition.TabIndex = 9;
            this.btnAddCompetition.Text = "Kaydet";
            this.btnAddCompetition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCompetition.UseVisualStyleBackColor = true;
            this.btnAddCompetition.Click += new System.EventHandler(this.btnAddCompetition_Click);
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(92, 126);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(161, 20);
            this.txtCapacity.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max Capacity:";
            // 
            // txtRecord
            // 
            this.txtRecord.Location = new System.Drawing.Point(92, 94);
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.Size = new System.Drawing.Size(161, 20);
            this.txtRecord.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Record:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(92, 62);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(161, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // dgwCompetitions
            // 
            this.dgwCompetitions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCompetitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCompetitions.Location = new System.Drawing.Point(11, 14);
            this.dgwCompetitions.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dgwCompetitions.Name = "dgwCompetitions";
            this.dgwCompetitions.Size = new System.Drawing.Size(846, 188);
            this.dgwCompetitions.TabIndex = 12;
            this.dgwCompetitions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCompetitions_CellClick);
            // 
            // frmCompetitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxUpdateCompetition);
            this.Controls.Add(this.gbxAddCompetition);
            this.Controls.Add(this.dgwCompetitions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmCompetitions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Competitions";
            this.Load += new System.EventHandler(this.frmCompetitions_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbxUpdateCompetition.ResumeLayout(false);
            this.gbxUpdateCompetition.PerformLayout();
            this.gbxAddCompetition.ResumeLayout(false);
            this.gbxAddCompetition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompetitions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxUpdateCompetition;
        private System.Windows.Forms.TextBox txtUpdateCapacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdateRecord;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdateTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbxAddCompetition;
        private System.Windows.Forms.Button btnAddCompetition;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwCompetitions;
        private System.Windows.Forms.ComboBox cmbxUpdateCategoryId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxCategoryId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdateCompetition;
    }
}