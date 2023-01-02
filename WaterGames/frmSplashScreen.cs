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
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            prgLoading.Maximum = 200;
            tmrLoading.Interval= 10;
            tmrLoading.Enabled= true;
            prgLoading.BackColor = Color.WhiteSmoke;
            prgLoading.ForeColor = Color.Blue;
        }

        frmMain frmMain = new frmMain();
        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            if (prgLoading.Value == prgLoading.Maximum)
            {
                tmrLoading.Enabled = false;
                this.Hide();
                frmMain.ShowDialog();
            }
            else
            {
                prgLoading.Value += 1;
            }
        }
    }
}
