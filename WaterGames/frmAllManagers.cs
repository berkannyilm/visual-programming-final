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
    public partial class frmAllManagers : Form
    {
        public frmAllManagers()
        {
            InitializeComponent();
        }
        ManagerDal _managerDal = new ManagerDal();
        InputHelper _inputHelper =new InputHelper();
        string hostName = Dns.GetHostName(); 
        DateTime dateTime = DateTime.Now;
        private void frmAllManagers_Load(object sender, EventArgs e)
        {
            LoadManagers();
            gbxUpdateManager.Enabled = false; 
            btnDelete.Enabled = false;
        }

        private void LoadManagers()
        {
            dgwManagers.DataSource = _managerDal.GetAllManagers();
        }

       
        private void btnAddManager_Click(object sender, EventArgs e)
        {
           _inputHelper.CheckTextBoxValues(txtFirstname, txtLastname, txtUsername, txtPassword);
            if (_inputHelper.status == true)
            {
                _managerDal.CheckUserInManager(txtUsername.Text);

                if (_managerDal.checkStatus == false)
                {
                    string IpAddress = Dns.GetHostByName(hostName).AddressList[0].ToString();
                    _managerDal.AddManager(new Manager
                    {
                        Firstname = txtFirstname.Text,
                        Lastname = txtLastname.Text,
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        IpAddress = IpAddress,
                        UpdatedDate = dateTime.ToString("yyyy-MM-dd H:mm:ss")
                    });
                    LoadManagers();
                    MessageBox.Show("Manager Added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _inputHelper.ClearTextBox(txtFirstname, txtLastname, txtPassword, txtUsername);
                }
                else
                {
                    MessageBox.Show("This username is already used", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void frmAllManagers_FormClosing(object sender, FormClosingEventArgs e)
        {
       
        }

        private void dgwManagers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            gbxUpdateManager.Enabled = true;
            txtUpdateUsername.Enabled = false; 

            txtUpdateFirstname.Text = dgwManagers.CurrentRow.Cells[1].Value.ToString();
            txtUpdateLastname.Text = dgwManagers.CurrentRow.Cells[2].Value.ToString();
            txtUpdateUsername.Text = dgwManagers.CurrentRow.Cells[3].Value.ToString();
            txtUpdatePassword.Text = dgwManagers.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnUpdateManger_Click(object sender, EventArgs e)
        {
            _inputHelper.CheckTextBoxValues(txtUpdateFirstname, txtUpdateLastname, txtUpdateUsername, txtUpdatePassword);

            if (_inputHelper.status == true)
            {
                _managerDal.CheckUserInManager(txtUsername.Text);

                if (_managerDal.checkStatus == false)
                {
                    string IpAddress = Dns.GetHostByName(hostName).AddressList[0].ToString();
                    Manager manager = new Manager
                    {
                        Id = Convert.ToInt32(dgwManagers.CurrentRow.Cells[0].Value),
                        Firstname = txtUpdateFirstname.Text,
                        Lastname = txtUpdateLastname.Text, 
                        Password = txtUpdatePassword.Text,
                        IpAddress = IpAddress,
                        UpdatedDate = dateTime.ToString("yyyy-MM-dd H:mm:ss")
                    };
                    _managerDal.UpdateManager(manager);
                    LoadManagers();
                    MessageBox.Show("Manager Updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _inputHelper.ClearTextBox(txtUpdateFirstname, txtUpdateLastname, txtUpdatePassword, txtUpdateUsername);
                    gbxUpdateManager.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                { 
                    MessageBox.Show("This username is already used", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
              
            }
        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        { 
            int Id = Convert.ToInt32(dgwManagers.CurrentRow.Cells[0].Value);
            _managerDal.DeleteManager(Id);
            LoadManagers();
            MessageBox.Show("Manager Deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _inputHelper.ClearTextBox(txtUpdateFirstname, txtUpdateLastname, txtUpdatePassword, txtUpdateUsername);
            gbxUpdateManager.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}
