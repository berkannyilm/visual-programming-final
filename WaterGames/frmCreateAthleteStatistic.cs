using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterGames
{
    public partial class frmCreateAthleteStatistic : Form
    {
        public frmCreateAthleteStatistic()
        {
            InitializeComponent();
        }
        AthleteDal _athleteDal = new AthleteDal();
        AthleteCategoryDal _athleteCategory = new AthleteCategoryDal();
        CompetitionDal _competitionDal = new CompetitionDal();
        CommitteeDal _committeeDal = new CommitteeDal();
        InputHelper _inputHelper = new InputHelper();
        StatisticDal _statisticDal = new StatisticDal();
        private void frmCreateAthleteStatistic_Load(object sender, EventArgs e)
        {
            foreach (var category in _athleteCategory.GetAllCategories())
            {

                cmbxCategory.Items.Add(category.Id + " - " + category.Title);
            }
            foreach (var athlete in _athleteDal.GetAllAthletes())
            {
                cmbxAthlete.Items.Add(athlete.Id + " - " + athlete.Firstname + " " + athlete.Lastname);
            }
            foreach (var competition in _competitionDal.CompetitionList())
            {
                cmbxCompetition.Items.Add(competition.Id + " - " + competition.Title);
            }
            foreach (var committee in _committeeDal.CommitteeList())
            {
                cmbxCommittee.Items.Add(committee.Id + " - " + committee.Firstname + " " + committee.Lastname);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
            _inputHelper.CheckTextBoxValues(txtDuration,txtPerformance,txtPoint,txtRanking);
            _inputHelper.CheckComboboxValues(cmbxCommittee, cmbxCompetition, cmbxAthlete, cmbxCategory);
            if (_inputHelper.status == true)
            {
                string[] athlete = cmbxAthlete.SelectedItem.ToString().Split('-');
                string[] committee = cmbxCommittee.SelectedItem.ToString().Split('-');
                string[] competition = cmbxCompetition.SelectedItem.ToString().Split('-');
                string[] category = cmbxCategory.SelectedItem.ToString().Split('-');

                _statisticDal.AddStatistic(new Statistic
                {
                    AthlelteId = Convert.ToInt32(athlete[0]),
                    CommitteeId = Convert.ToInt32(committee[0]),
                    CompetitionId = Convert.ToInt32(competition[0]), 
                    CategoryId = Convert.ToInt32(category[0]),
                    Point =Convert.ToInt32(txtPoint.Text),
                    Duration=txtDuration.Text,
                    Performance=Convert.ToInt32(txtPerformance.Text),
                    Ranking=Convert.ToInt32(txtRanking.Text)
                });
                MessageBox.Show("Statistic Added!","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                _inputHelper.ClearTextBox(txtDuration, txtPerformance, txtPoint, txtRanking);
                _inputHelper.ClearCombobox(cmbxAthlete, cmbxCategory, cmbxCommittee, cmbxCompetition);
            }
        }

        private void frmCreateAthleteStatistic_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDashboard frmDashboard =new frmDashboard();
            this.Hide();
            frmDashboard.Show();
        }
    }
}
