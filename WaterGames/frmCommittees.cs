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
    public partial class frmCommittees : Form
    {
        public frmCommittees()
        {
            InitializeComponent();
        }

        CommitteeDal _committeeDal = new CommitteeDal();
        InputHelper _inputHelper = new InputHelper();
        JsonHelper _jsonHelper = new JsonHelper();
        DateTime dateTime = new DateTime();
        string hostName = Dns.GetHostName();
        private void frmCommittes_Load(object sender, EventArgs e)
        {
            gbxUpdateCommitte.Enabled = false;
            btnDelete.Enabled = false;
            _jsonHelper.addCityToComboBox(cmbxCity, cmbxUpdateCity);
            LoadCommittes();

        }

        private void LoadCommittes()
        {
            dgwComittes.DataSource = _committeeDal.CommitteeList();
        }

        private void getDistrict(bool selectedCombobox)
        {
            cmbxUpdateDistrict.Enabled = true;
            cmbxDistrict.Enabled = true;
            cmbxDistrict.Items.Clear();
            cmbxUpdateDistrict.Items.Clear();

            foreach (var city in _jsonHelper.getCitiesFromJsonFile())
            {
                foreach (var district in _jsonHelper.getDistrictsFromJsonFile())
                {
                    switch (selectedCombobox)
                    {
                        case false:
                            if (city.CityName == cmbxCity.SelectedItem.ToString() && city.Id == district.CityId)
                            {
                                cmbxDistrict.Items.Add(district.DistrictTitle);
                            }
                            break;

                        case true:
                            if (city.CityName == cmbxUpdateCity.SelectedItem.ToString() && city.Id == district.CityId)
                            {
                                cmbxUpdateDistrict.Items.Add(district.DistrictTitle);
                            }
                            break;

                        default:
                            cmbxDistrict.Items.Add(district.DistrictTitle);
                            cmbxUpdateDistrict.Items.Add(district.DistrictTitle);
                            break;
                    }
                }
            }
        }



        private void btnAddComitte_Click(object sender, EventArgs e)
        {

            _inputHelper.CheckTextBoxValues(txtFirstname, txtLastname, txtUsername, txtPassword, txtAddress);
            _inputHelper.CheckComboboxValues(cmbxCity, cmbxDistrict);

            string DateOfBirth = dtpicDateOfBirth.Value.ToString("yyyy-MM-dd");
            string IpAddress = Dns.GetHostByName(hostName).AddressList[0].ToString();

            if (_inputHelper.status == true)
            {
                _committeeDal.CheckUserInCommittee(txtUsername.Text);

                if (_committeeDal.checkStatus == false)
                {
                    _committeeDal.AddCommittee(new Committee
                    {
                        Firstname = txtFirstname.Text,
                        Lastname = txtLastname.Text,
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        IpAddress = IpAddress,
                        Address = txtAddress.Text,
                        City = cmbxCity.SelectedItem.ToString(),
                        District = cmbxDistrict.SelectedItem.ToString(),
                        DateOfBirth = DateOfBirth,
                        UpdatedDate = dateTime.ToString("yyyy-MM-dd H:mm:ss"),
                    });
                    _inputHelper.ClearTextBox(txtFirstname, txtLastname, txtUsername, txtPassword, txtAddress);
                    _inputHelper.ClearCombobox(cmbxCity, cmbxDistrict);
                    _inputHelper.CheckDateTimePickers(dtpicDateOfBirth);
                    LoadCommittes();
                    MessageBox.Show("Committee Member Added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This username is already used!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cmbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDistrict(false);
        }

        private void cmbxUpdateCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDistrict(true);
        }

        private void dgwComittes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbxUpdateCommitte.Enabled = true;
            txtUpdateUsername.Enabled = false;
            btnDelete.Enabled = true;
            dtpicUpdateDateOfBirth.Value = Convert.ToDateTime(dgwComittes.CurrentRow.Cells[10].Value);
            cmbxUpdateCity.SelectedItem = dgwComittes.CurrentRow.Cells[7].Value.ToString();
            cmbxUpdateDistrict.SelectedItem = dgwComittes.CurrentRow.Cells[6].Value.ToString();
            txtUpdateAddress.Text = dgwComittes.CurrentRow.Cells[5].Value.ToString();
            txtUpdatePassword.Text = dgwComittes.CurrentRow.Cells[4].Value.ToString();
            txtUpdateUsername.Text = dgwComittes.CurrentRow.Cells[3].Value.ToString();
            txtUpdateFirstname.Text = dgwComittes.CurrentRow.Cells[1].Value.ToString();
            txtUpdateLastname.Text = dgwComittes.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUpdateCommitte_Click(object sender, EventArgs e)
        { 
            _inputHelper.CheckComboboxValues(cmbxUpdateCity, cmbxUpdateDistrict);
            _inputHelper.CheckTextBoxValues(txtUpdateFirstname, txtUpdateLastname, txtUpdatePassword, txtUpdateAddress);
           
            if (_inputHelper.status == true)
            {
                string DateOfBirth = dtpicDateOfBirth.Value.ToString("yyyy-MM-dd");
                string IpAddress = Dns.GetHostByName(hostName).AddressList[0].ToString();
                int Id = Convert.ToInt32(dgwComittes.CurrentRow.Cells[0].Value);
                _committeeDal.UpdateCommittee(new Committee
                {
                    Id = Id,
                    Firstname = txtUpdateFirstname.Text,
                    Lastname = txtUpdateLastname.Text,
                    Password = txtUpdatePassword.Text,
                    IpAddress = IpAddress,
                    Address = txtUpdateAddress.Text,
                    City = cmbxUpdateCity.SelectedItem.ToString(),
                    District = cmbxUpdateDistrict.SelectedItem.ToString(),
                    DateOfBirth = DateOfBirth,
                    UpdatedDate = dateTime.ToString("yyyy-MM-dd H:mm:ss"),
                });
                _inputHelper.ClearTextBox(txtUpdateFirstname, txtUpdateLastname, txtUpdatePassword, txtUpdateAddress, txtUpdateUsername);
                _inputHelper.ClearCombobox(cmbxUpdateCity, cmbxUpdateDistrict);
                _inputHelper.ClearDateTimePicker(dtpicUpdateDateOfBirth);
                LoadCommittes();
                MessageBox.Show("Committee Member Updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbxUpdateCommitte.Enabled = false;
                btnDelete.Enabled = false;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgwComittes.CurrentRow.Cells[0].Value);
            _committeeDal.DeleteCommittee(Id);
            _inputHelper.ClearTextBox(txtUpdateFirstname, txtUpdateLastname, txtUpdatePassword, txtUpdateAddress, txtUpdateUsername);
            _inputHelper.ClearCombobox(cmbxUpdateCity, cmbxUpdateDistrict);
            LoadCommittes();
            MessageBox.Show("Committee Member Deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gbxUpdateCommitte.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}

