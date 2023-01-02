using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterGames
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
      
        ConnectionHelper connectToDB = new ConnectionHelper(); 
        ManagerDal _managerDal = new ManagerDal();

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        InputHelper _inputHelper = new InputHelper();
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            frmDashboard frmDashboard = new frmDashboard();
            string hostName = Dns.GetHostName();
            DateTime dateTime = DateTime.Now;
            string IpAddress = Dns.GetHostByName(hostName).AddressList[0].ToString();

            _inputHelper.CheckTextBoxValues(txtUsername, txtPassword);
            if (_inputHelper.status == true)
            {
                _managerDal.GetManager(new Manager
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                });
                _managerDal.UpdateLoginManager(new Manager
                {
                    Username = txtUsername.Text,
                    IpAddress = IpAddress,
                    LastLoginDate = dateTime.ToString("yyyy-MM-dd H:mm:ss")
                });
                if (_managerDal.checkStatus == true)
                {
                    MessageBox.Show("Login successful, you are redirected!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmDashboard.Show();
                }
                else
                {
                    MessageBox.Show("User not found!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
