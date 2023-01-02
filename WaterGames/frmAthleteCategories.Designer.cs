namespace WaterGames
{
    partial class frmAthleteCategories
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
            this.txtUpdateTitle = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbxUpdateCategory = new System.Windows.Forms.GroupBox();
            this.gbxAddCategory = new System.Windows.Forms.GroupBox();
            this.dgwAthletes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateManger = new System.Windows.Forms.Button();
            this.btnAddManager = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxUpdateCategory.SuspendLayout();
            this.gbxAddCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAthletes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUpdateTitle
            // 
            this.txtUpdateTitle.Location = new System.Drawing.Point(39, 46);
            this.txtUpdateTitle.Name = "txtUpdateTitle";
            this.txtUpdateTitle.Size = new System.Drawing.Size(185, 20);
            this.txtUpdateTitle.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(39, 46);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(185, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Title:";
            // 
            // gbxUpdateCategory
            // 
            this.gbxUpdateCategory.Controls.Add(this.btnUpdateManger);
            this.gbxUpdateCategory.Controls.Add(this.txtUpdateTitle);
            this.gbxUpdateCategory.Controls.Add(this.label8);
            this.gbxUpdateCategory.Location = new System.Drawing.Point(284, 214);
            this.gbxUpdateCategory.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.gbxUpdateCategory.Name = "gbxUpdateCategory";
            this.gbxUpdateCategory.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.gbxUpdateCategory.Size = new System.Drawing.Size(241, 123);
            this.gbxUpdateCategory.TabIndex = 14;
            this.gbxUpdateCategory.TabStop = false;
            this.gbxUpdateCategory.Text = "Update a category";
            // 
            // gbxAddCategory
            // 
            this.gbxAddCategory.Controls.Add(this.btnAddManager);
            this.gbxAddCategory.Controls.Add(this.txtTitle);
            this.gbxAddCategory.Controls.Add(this.label1);
            this.gbxAddCategory.Location = new System.Drawing.Point(14, 214);
            this.gbxAddCategory.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.gbxAddCategory.Name = "gbxAddCategory";
            this.gbxAddCategory.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.gbxAddCategory.Size = new System.Drawing.Size(241, 123);
            this.gbxAddCategory.TabIndex = 13;
            this.gbxAddCategory.TabStop = false;
            this.gbxAddCategory.Text = "Add a category";
            // 
            // dgwAthletes
            // 
            this.dgwAthletes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwAthletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAthletes.Location = new System.Drawing.Point(14, 16);
            this.dgwAthletes.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.dgwAthletes.Name = "dgwAthletes";
            this.dgwAthletes.Size = new System.Drawing.Size(773, 188);
            this.dgwAthletes.TabIndex = 12;
            this.dgwAthletes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAthletes_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(546, 214);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox1.Size = new System.Drawing.Size(241, 123);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete a category";
            // 
            // btnUpdateManger
            // 
            this.btnUpdateManger.Image = global::WaterGames.Properties.Resources.update_btn_24;
            this.btnUpdateManger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateManger.Location = new System.Drawing.Point(145, 78);
            this.btnUpdateManger.Name = "btnUpdateManger";
            this.btnUpdateManger.Size = new System.Drawing.Size(79, 34);
            this.btnUpdateManger.TabIndex = 9;
            this.btnUpdateManger.Text = "Güncelle";
            this.btnUpdateManger.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateManger.UseVisualStyleBackColor = true;
            this.btnUpdateManger.Click += new System.EventHandler(this.btnUpdateManger_Click);
            // 
            // btnAddManager
            // 
            this.btnAddManager.Image = global::WaterGames.Properties.Resources.add_btn;
            this.btnAddManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddManager.Location = new System.Drawing.Point(150, 78);
            this.btnAddManager.Name = "btnAddManager";
            this.btnAddManager.Size = new System.Drawing.Size(74, 34);
            this.btnAddManager.TabIndex = 9;
            this.btnAddManager.Text = "Kaydet";
            this.btnAddManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddManager.UseVisualStyleBackColor = true;
            this.btnAddManager.Click += new System.EventHandler(this.btnAddManager_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::WaterGames.Properties.Resources.delete_btn;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(59, 46);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 34);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete a manager";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmAthleteCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxUpdateCategory);
            this.Controls.Add(this.gbxAddCategory);
            this.Controls.Add(this.dgwAthletes);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAthleteCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Athletes";
            this.Load += new System.EventHandler(this.frmAthleteCategories_Load);
            this.gbxUpdateCategory.ResumeLayout(false);
            this.gbxUpdateCategory.PerformLayout();
            this.gbxAddCategory.ResumeLayout(false);
            this.gbxAddCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAthletes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtUpdateTitle;
        private System.Windows.Forms.Button btnAddManager;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnUpdateManger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbxUpdateCategory;
        private System.Windows.Forms.GroupBox gbxAddCategory;
        private System.Windows.Forms.DataGridView dgwAthletes;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}