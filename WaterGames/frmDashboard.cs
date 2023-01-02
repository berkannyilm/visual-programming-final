using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WaterGames
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        frmAllManagers frmAllManagers = new frmAllManagers();
        frmAthletes frmAthletes = new frmAthletes();
        frmAthleteCategories frmAthleteCategories = new frmAthleteCategories();

        ChartDal _chartDal = new ChartDal();
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            foreach (var chartByDistrict in _chartDal.ChartByDistrict())
            {
                chtDistrict.Series["District"].Points.AddXY(chartByDistrict.District, chartByDistrict.Count);
            }
            foreach (var chartByCity in _chartDal.ChartByCity())
            {
                chtCity.Series["City"].Points.AddXY(chartByCity.City, chartByCity.Count);
            }
            foreach (var chartByMonth in _chartDal.ChartByMontly())
            {
                chtMonth.Series["Month"].Points.AddXY(chartByMonth.Month, chartByMonth.Count);
            }
            foreach (var chartByYear in _chartDal.ChartByYearly())
            {
                chtYear.Series["Year"].Points.AddXY(chartByYear.Year, chartByYear.Count);
            }
            foreach (var chartByCompetition in _chartDal.ChartByCompetition())
            {
                chtCompetitionCount.Series["CompetitionCount"].Points.AddXY(chartByCompetition.CompetitionTitle, chartByCompetition.Count);
            }

            foreach (var chartByMinPoints in _chartDal.ChartByMinPointCompetition())
            {
                chtMinCompetitionPoint.Series["MinCompetitionPoints"].Points.AddXY(chartByMinPoints.CompetitionTitle, chartByMinPoints.Point);
            }
            foreach (var chartByMaxPoints in _chartDal.ChartByMaxPointCompetition())
            {
                chtMaxCompetitionPoint.Series["MaxCompetitionPoints"].Points.AddXY(chartByMaxPoints.CompetitionTitle, chartByMaxPoints.Point);
            }
        }
        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void MenuItemShowManagers_Click(object sender, EventArgs e)
        {
            frmAllManagers.Show();

        }

        private void MenuItemShowAthletes_Click(object sender, EventArgs e)
        {
            frmAthletes.Show();
        }

        private void MenuStripShowAthleteCategories_Click(object sender, EventArgs e)
        {
            frmAthleteCategories.Show();
        }

       

        private void btnShowAddAthleteStatistic_Click(object sender, EventArgs e)
        {
            frmCreateAthleteStatistic frmCreateAthleteStatistic = new frmCreateAthleteStatistic();
            this.Hide();
            frmCreateAthleteStatistic.Show();
        }

        private void btnShowCommittees_Click(object sender, EventArgs e)
        {
            frmCommittees frmCommittees = new frmCommittees(); 
            frmCommittees.Show();
        }

        private void btnShoCategories_Click(object sender, EventArgs e)
        {
            frmAthleteCategories frmAthleteCategories = new frmAthleteCategories(); 
            frmAthleteCategories.Show();
        }

        private void btnShowAthletes_Click(object sender, EventArgs e)
        {
            frmAthletes frmAthletes = new frmAthletes(); 
            frmAthletes.Show();
        }

        private void btnShowCompetitions_Click(object sender, EventArgs e)
        {
            frmCompetitions frmCompetitions = new frmCompetitions();
            frmCompetitions.Show();
        }

        private void btnShowManagers_Click(object sender, EventArgs e)
        {
            frmAllManagers frmAllManagers =new frmAllManagers();
            frmAllManagers.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
