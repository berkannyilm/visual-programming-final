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
    public partial class frmAthleteScreen : Form
    {
        frmAthleteLogin frmAthleteLogin;
        AthleteDal athleteDal = new AthleteDal();
        ChartDal chartDal = new ChartDal();
        public frmAthleteScreen(frmAthleteLogin getLoginForm)
        {
            InitializeComponent();
            frmAthleteLogin = getLoginForm;
        }

        private void frmAthleteScreen_Load(object sender, EventArgs e)
        {
            string Username = frmAthleteLogin.Username;
            foreach (var chart in chartDal.GetAthleteStatistics(Username))
            {
                chtCompetitionPoints.Series["Yarismalar"].Points.AddXY("(" + chart.Month + "-" + chart.Year + ")", chart.Point);
                chtPerformance.Series["Performance"].Points.AddXY("(" + chart.Month + "-" + chart.Year + ")", chart.Performance);
                chtRanking.Series["Ranking"].Points.AddXY("(" + chart.Month + "-" + chart.Year + ")", chart.Ranking);
                lstDuration.Items.Add("("+chart.CompetitionTitle+") yarışmasını "+ chart.Duration+" sürede tamamladınız.");
            }

            foreach (var athelete in athleteDal.GetAthleteDetail(Username))
            {
                lblFirstnameLastname.Text = athelete.Firstname + " " + athelete.Lastname;
                lblCategory.Text = athelete.AthleteCategory;
                lblUsername.Text = athelete.Username;
                lblPassword.Text = athelete.Password;
                lblWeight.Text = athelete.Weight.ToString();
                lblHeight.Text = athelete.Height.ToString();
                lblAge.Text = athelete.Age.ToString();
                lblDateOfBirth.Text = athelete.DateOfBirth.ToString();
                lblLastLoginDate.Text = athelete.LastLoginDate.ToString();
                lblUpdatedDate.Text = athelete.UpdatedDate.ToString();
                lblLicenseStatus.Text = athelete.LicenseStatus.ToString();
                lblLicenseStartedDate.Text = athelete.LicenseStartedDate.ToString();
                lblLicenseFinishedDate.Text = athelete.LicenseFinishedDate.ToString();
                lblAddress.Text = athelete.Address;
                lblCity.Text = athelete.City;
                lblDistrict.Text = athelete.District;

            }
        }

        private void frmAthleteScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.Show();
        }
    }
}
