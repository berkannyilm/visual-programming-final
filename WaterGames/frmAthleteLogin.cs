using MySqlX.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterGames
{
    public partial class frmAthleteLogin : Form
    {
        public frmAthleteLogin()
        {
            InitializeComponent();
        }
        public string Username; 
        private void frmAthleteLogin_Load(object sender, EventArgs e)
        {

        }
        ConnectionHelper connectToDB = new ConnectionHelper();
        Athlete athlete = new Athlete();
        AthleteDal athleteDal = new AthleteDal();
        InputHelper inputHelper = new InputHelper();
        
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string hostName = Dns.GetHostName();
            DateTime dateTime = DateTime.Now;
            string IpAddress = Dns.GetHostByName(hostName).AddressList[0].ToString();
            inputHelper.CheckTextBoxValues(txtUsername,txtPassword);
            if (inputHelper.status==true)
            {
                Username=txtUsername.Text;
                athleteDal.GetAthlete(new Athlete
                { 
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                });
                athleteDal.UpdateLoginAthlete(new Athlete
                {
                    Username = txtUsername.Text,
                    IpAddress = IpAddress,
                    LastLoginDate = dateTime.ToString("yyyy-MM-dd H:mm:ss")
                });
                if (athleteDal.checkStatus == true)
                {
                    frmAthleteScreen frmAthleteScreen = new frmAthleteScreen(this);
                    MessageBox.Show("Login successful, you are redirected!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide(); 
                    frmAthleteScreen.Show();
                }
                else
                {
                    MessageBox.Show("User not found!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
           
        }

        private void frmAthleteLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.Show();
        }
    }
}
