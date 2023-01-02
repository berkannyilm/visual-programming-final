namespace WaterGames
{
    partial class frmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chtDistrict = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtCity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtCompetitionCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtMinCompetitionPoint = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtMaxCompetitionPoint = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnShowAddAthleteStatistic = new System.Windows.Forms.Button();
            this.btnShowCommittees = new System.Windows.Forms.Button();
            this.btnShoCategories = new System.Windows.Forms.Button();
            this.btnShowAthletes = new System.Windows.Forms.Button();
            this.btnShowCompetitions = new System.Windows.Forms.Button();
            this.btnShowManagers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtDistrict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtCompetitionCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtMinCompetitionPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtMaxCompetitionPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Athelete Statistic Charts";
            // 
            // chtDistrict
            // 
            chartArea8.Name = "ChartArea1";
            this.chtDistrict.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chtDistrict.Legends.Add(legend8);
            this.chtDistrict.Location = new System.Drawing.Point(12, 283);
            this.chtDistrict.Name = "chtDistrict";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "District";
            this.chtDistrict.Series.Add(series8);
            this.chtDistrict.Size = new System.Drawing.Size(352, 172);
            this.chtDistrict.TabIndex = 1;
            this.chtDistrict.Text = "chart1";
            // 
            // chtCity
            // 
            chartArea9.Name = "ChartArea1";
            this.chtCity.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chtCity.Legends.Add(legend9);
            this.chtCity.Location = new System.Drawing.Point(12, 91);
            this.chtCity.Name = "chtCity";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "City";
            this.chtCity.Series.Add(series9);
            this.chtCity.Size = new System.Drawing.Size(352, 172);
            this.chtCity.TabIndex = 1;
            this.chtCity.Text = "chart1";
            // 
            // chtYear
            // 
            chartArea10.Name = "ChartArea1";
            this.chtYear.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chtYear.Legends.Add(legend10);
            this.chtYear.Location = new System.Drawing.Point(389, 283);
            this.chtYear.Name = "chtYear";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series10.Legend = "Legend1";
            series10.Name = "Year";
            this.chtYear.Series.Add(series10);
            this.chtYear.Size = new System.Drawing.Size(365, 172);
            this.chtYear.TabIndex = 1;
            this.chtYear.Text = "chart1";
            // 
            // chtMonth
            // 
            chartArea11.Name = "ChartArea1";
            this.chtMonth.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chtMonth.Legends.Add(legend11);
            this.chtMonth.Location = new System.Drawing.Point(389, 91);
            this.chtMonth.Name = "chtMonth";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series11.Legend = "Legend1";
            series11.Name = "Month";
            this.chtMonth.Series.Add(series11);
            this.chtMonth.Size = new System.Drawing.Size(365, 172);
            this.chtMonth.TabIndex = 1;
            this.chtMonth.Text = "chart1";
            // 
            // chtCompetitionCount
            // 
            chartArea12.Name = "ChartArea1";
            this.chtCompetitionCount.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chtCompetitionCount.Legends.Add(legend12);
            this.chtCompetitionCount.Location = new System.Drawing.Point(12, 474);
            this.chtCompetitionCount.Name = "chtCompetitionCount";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series12.Legend = "Legend1";
            series12.Name = "CompetitionCount";
            this.chtCompetitionCount.Series.Add(series12);
            this.chtCompetitionCount.Size = new System.Drawing.Size(352, 168);
            this.chtCompetitionCount.TabIndex = 1;
            this.chtCompetitionCount.Text = "chart1";
            // 
            // chtMinCompetitionPoint
            // 
            chartArea13.Name = "ChartArea1";
            this.chtMinCompetitionPoint.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chtMinCompetitionPoint.Legends.Add(legend13);
            this.chtMinCompetitionPoint.Location = new System.Drawing.Point(773, 91);
            this.chtMinCompetitionPoint.Name = "chtMinCompetitionPoint";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series13.Legend = "Legend1";
            series13.Name = "MinCompetitionPoints";
            series13.YValuesPerPoint = 2;
            this.chtMinCompetitionPoint.Series.Add(series13);
            this.chtMinCompetitionPoint.Size = new System.Drawing.Size(325, 172);
            this.chtMinCompetitionPoint.TabIndex = 1;
            // 
            // chtMaxCompetitionPoint
            // 
            chartArea14.Name = "ChartArea1";
            this.chtMaxCompetitionPoint.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chtMaxCompetitionPoint.Legends.Add(legend14);
            this.chtMaxCompetitionPoint.Location = new System.Drawing.Point(773, 283);
            this.chtMaxCompetitionPoint.Name = "chtMaxCompetitionPoint";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series14.Legend = "Legend1";
            series14.Name = "MaxCompetitionPoints";
            series14.YValuesPerPoint = 2;
            this.chtMaxCompetitionPoint.Series.Add(series14);
            this.chtMaxCompetitionPoint.Size = new System.Drawing.Size(325, 172);
            this.chtMaxCompetitionPoint.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Image = global::WaterGames.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(1022, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(76, 34);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnShowAddAthleteStatistic
            // 
            this.btnShowAddAthleteStatistic.Image = global::WaterGames.Properties.Resources.statistic;
            this.btnShowAddAthleteStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAddAthleteStatistic.Location = new System.Drawing.Point(722, 12);
            this.btnShowAddAthleteStatistic.Name = "btnShowAddAthleteStatistic";
            this.btnShowAddAthleteStatistic.Size = new System.Drawing.Size(131, 34);
            this.btnShowAddAthleteStatistic.TabIndex = 2;
            this.btnShowAddAthleteStatistic.Text = "Add AthleteStatistic";
            this.btnShowAddAthleteStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowAddAthleteStatistic.UseVisualStyleBackColor = true;
            this.btnShowAddAthleteStatistic.Click += new System.EventHandler(this.btnShowAddAthleteStatistic_Click);
            // 
            // btnShowCommittees
            // 
            this.btnShowCommittees.Image = global::WaterGames.Properties.Resources.committee;
            this.btnShowCommittees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowCommittees.Location = new System.Drawing.Point(610, 12);
            this.btnShowCommittees.Name = "btnShowCommittees";
            this.btnShowCommittees.Size = new System.Drawing.Size(106, 34);
            this.btnShowCommittees.TabIndex = 2;
            this.btnShowCommittees.Text = "All Committees";
            this.btnShowCommittees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowCommittees.UseVisualStyleBackColor = true;
            this.btnShowCommittees.Click += new System.EventHandler(this.btnShowCommittees_Click);
            // 
            // btnShoCategories
            // 
            this.btnShoCategories.Image = global::WaterGames.Properties.Resources.list;
            this.btnShoCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShoCategories.Location = new System.Drawing.Point(498, 12);
            this.btnShoCategories.Name = "btnShoCategories";
            this.btnShoCategories.Size = new System.Drawing.Size(106, 34);
            this.btnShoCategories.TabIndex = 2;
            this.btnShoCategories.Text = "All Categories";
            this.btnShoCategories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShoCategories.UseVisualStyleBackColor = true;
            this.btnShoCategories.Click += new System.EventHandler(this.btnShoCategories_Click);
            // 
            // btnShowAthletes
            // 
            this.btnShowAthletes.Image = global::WaterGames.Properties.Resources.athletenew;
            this.btnShowAthletes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAthletes.Location = new System.Drawing.Point(397, 12);
            this.btnShowAthletes.Name = "btnShowAthletes";
            this.btnShowAthletes.Size = new System.Drawing.Size(95, 34);
            this.btnShowAthletes.TabIndex = 2;
            this.btnShowAthletes.Text = "All Athletes";
            this.btnShowAthletes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowAthletes.UseVisualStyleBackColor = true;
            this.btnShowAthletes.Click += new System.EventHandler(this.btnShowAthletes_Click);
            // 
            // btnShowCompetitions
            // 
            this.btnShowCompetitions.Image = global::WaterGames.Properties.Resources.comp;
            this.btnShowCompetitions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowCompetitions.Location = new System.Drawing.Point(277, 12);
            this.btnShowCompetitions.Name = "btnShowCompetitions";
            this.btnShowCompetitions.Size = new System.Drawing.Size(114, 34);
            this.btnShowCompetitions.TabIndex = 2;
            this.btnShowCompetitions.Text = "All Competitions";
            this.btnShowCompetitions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowCompetitions.UseVisualStyleBackColor = true;
            this.btnShowCompetitions.Click += new System.EventHandler(this.btnShowCompetitions_Click);
            // 
            // btnShowManagers
            // 
            this.btnShowManagers.Image = global::WaterGames.Properties.Resources.managers;
            this.btnShowManagers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowManagers.Location = new System.Drawing.Point(166, 12);
            this.btnShowManagers.Name = "btnShowManagers";
            this.btnShowManagers.Size = new System.Drawing.Size(105, 34);
            this.btnShowManagers.TabIndex = 2;
            this.btnShowManagers.Text = "All Managers";
            this.btnShowManagers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowManagers.UseVisualStyleBackColor = true;
            this.btnShowManagers.Click += new System.EventHandler(this.btnShowManagers_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 668);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnShowAddAthleteStatistic);
            this.Controls.Add(this.btnShowCommittees);
            this.Controls.Add(this.btnShoCategories);
            this.Controls.Add(this.btnShowAthletes);
            this.Controls.Add(this.btnShowCompetitions);
            this.Controls.Add(this.btnShowManagers);
            this.Controls.Add(this.chtCity);
            this.Controls.Add(this.chtMonth);
            this.Controls.Add(this.chtMaxCompetitionPoint);
            this.Controls.Add(this.chtMinCompetitionPoint);
            this.Controls.Add(this.chtCompetitionCount);
            this.Controls.Add(this.chtYear);
            this.Controls.Add(this.chtDistrict);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDashboard_FormClosing);
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtDistrict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtCompetitionCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtMinCompetitionPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtMaxCompetitionPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtDistrict;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCompetitionCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtMinCompetitionPoint;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtMaxCompetitionPoint;
        private System.Windows.Forms.Button btnShowManagers;
        private System.Windows.Forms.Button btnShowCompetitions;
        private System.Windows.Forms.Button btnShowAthletes;
        private System.Windows.Forms.Button btnShoCategories;
        private System.Windows.Forms.Button btnShowCommittees;
        private System.Windows.Forms.Button btnShowAddAthleteStatistic;
        private System.Windows.Forms.Button btnLogout;
    }
}