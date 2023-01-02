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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnShowDashboard_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin(); 
            this.Hide();
            frmLogin.Show();
        }

        private void btnShowAtheleteLogin_Click(object sender, EventArgs e)
        {
            frmAthleteLogin frmAthleteLogin = new frmAthleteLogin();
            this.Hide();
            frmAthleteLogin.Show();
        }

        private void btnShowApplyScreen_Click(object sender, EventArgs e)
        {
            frmAthleteApplyScreen frmAthleteApplyScreen = new frmAthleteApplyScreen();
            this.Hide();
            frmAthleteApplyScreen.Show();
        }
    }
}
