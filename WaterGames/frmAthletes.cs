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
    public partial class frmAthletes : Form
    {
        public frmAthletes()
        {
            InitializeComponent();
        }
        bool selectedCombobox;
        AthleteDal _athleteDal = new AthleteDal();
        AthleteCategoryDal _athleteCategory = new AthleteCategoryDal();
        JsonHelper _jsonHelper = new JsonHelper();
        string hostName = Dns.GetHostName();
        DateTime dateTime = DateTime.Now;
        private void frmAthletes_Load(object sender, EventArgs e)
        {
            cmbxDistrict.Enabled = false;
            cmbxUpdateDistrict.Enabled = false;
            gbxUpdateAthlete.Enabled = false;
            btnDelete.Enabled = false;
            _athleteCategory.addCategoryToCombobox(cmbxCategoryId, cmbxUpdateCategoryId);
            _jsonHelper.addCityToComboBox(cmbxCity, cmbxUpdateCity);

            LoadAthletes();
        }

        private void LoadAthletes()
        {
            dgwAthletes.DataSource = _athleteDal.GetAllAthletes();
        }
        InputHelper _inputHelper = new InputHelper();
        private void btnAddManager_Click(object sender, EventArgs e)
        {

            _inputHelper.DateTimePickerDateTimeComparison(dtpicLicenseStartedDate, dtpicLicenseFinishedDate);
            _inputHelper.CheckTextBoxValues(txtFirstname, txtLastname, txtUsername, txtPassword, txtAddress, txtWeight, txtAge, txtHeight);
            _inputHelper.CheckComboboxValues(cmbxCity, cmbxDistrict, cmbxCategoryId);

            if (_inputHelper.status == true)
            {

                _athleteDal.CheckUserInAthlete(txtUsername.Text);

                if (_athleteDal.checkStatus == false)
                {
                    string DateOfBirth = dtpicDateOfBirth.Value.ToString("yyyy-MM-dd");
                    string LicenseStartedDate = dtpicLicenseStartedDate.Value.ToString("yyyy-MM-dd");
                    string LicenseFinishedDate = dtpicLicenseFinishedDate.Value.ToString("yyyy-MM-dd");

                    int categoryId = _athleteCategory.GetCategory(cmbxCategoryId.SelectedItem.ToString());
                    string IpAddress = Dns.GetHostByName(hostName).AddressList[0].ToString();

                    _athleteDal.AddAthlete(new Athlete
                    {
                        categoryId = categoryId,
                        Firstname = txtFirstname.Text,
                        Lastname = txtLastname.Text,
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        Age = Convert.ToInt32(txtAge.Text),
                        Weight = Convert.ToInt32(txtWeight.Text),
                        Height = Convert.ToInt32(txtHeight.Text),
                        City = cmbxCity.SelectedItem.ToString(),
                        Address = txtAddress.Text,
                        District = cmbxDistrict.SelectedItem.ToString(),
                        IpAddress = IpAddress,
                        ApplyStatus = "Active",
                        UpdatedDate = dateTime.ToString("yyyy-MM-dd H:mm:ss"),
                        DateOfBirth = DateOfBirth,
                        LicenseStartedDate = LicenseStartedDate,
                        LicenseFinishedDate = LicenseFinishedDate
                    });
                    LoadAthletes();
                    MessageBox.Show("Athlete Added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _inputHelper.ClearTextBox(txtFirstname, txtLastname, txtPassword, txtUsername, txtAddress, txtWeight, txtAge, txtHeight);
                    _inputHelper.ClearCombobox(cmbxDistrict, cmbxCategoryId, cmbxCity);
                    _inputHelper.ClearDateTimePicker(dtpicDateOfBirth, dtpicLicenseStartedDate, dtpicLicenseFinishedDate);
                }
                else
                {
                    MessageBox.Show("This username is already used", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgwAthletes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            gbxUpdateAthlete.Enabled = true;
            txtUpdateUsername.Enabled = false;
            int Id = Convert.ToInt32(dgwAthletes.CurrentRow.Cells[0].Value);
            cmbxUpdateCategoryId.SelectedItem = dgwAthletes.CurrentRow.Cells[2].Value.ToString();
            cmbxUpdateCity.SelectedItem = dgwAthletes.CurrentRow.Cells[10].Value.ToString();
            cmbxUpdateDistrict.SelectedItem = dgwAthletes.CurrentRow.Cells[9].Value.ToString();
            txtUpdateFirstname.Text = dgwAthletes.CurrentRow.Cells[3].Value.ToString();
            txtUpdateLastname.Text = dgwAthletes.CurrentRow.Cells[4].Value.ToString();
            txtUpdateUsername.Text = dgwAthletes.CurrentRow.Cells[5].Value.ToString();
            txtUpdatePassword.Text = dgwAthletes.CurrentRow.Cells[6].Value.ToString();
            txtUpdateAddress.Text = dgwAthletes.CurrentRow.Cells[8].Value.ToString();
            txtUpdateWeight.Text = dgwAthletes.CurrentRow.Cells[11].Value.ToString();
            txtUpdateAge.Text = dgwAthletes.CurrentRow.Cells[12].Value.ToString();
            txtUpdateHeight.Text = dgwAthletes.CurrentRow.Cells[13].Value.ToString();
            dtpicUpdateDateOfBirth.Value = Convert.ToDateTime(dgwAthletes.CurrentRow.Cells[14].Value.ToString());
            dtpicUpdateStartedDate.Value = Convert.ToDateTime(dgwAthletes.CurrentRow.Cells[15].Value.ToString());
            dtpicUpdateFinishedDate.Value = Convert.ToDateTime(dgwAthletes.CurrentRow.Cells[16].Value.ToString());
        }

        private void btnUpdateManger_Click(object sender, EventArgs e)
        {
            
            _inputHelper.CheckTextBoxValues(txtUpdateFirstname, txtUpdateLastname, txtUpdateUsername, txtUpdatePassword, txtUpdateAddress, txtUpdateAge, txtUpdateHeight, txtUpdateWeight);
            _inputHelper.CheckComboboxValues(cmbxUpdateCity, cmbxUpdateDistrict, cmbxUpdateCategoryId);
            _inputHelper.DateTimePickerDateTimeComparison(dtpicUpdateStartedDate, dtpicUpdateFinishedDate);


            if (_inputHelper.status == true)
            {
                _athleteDal.CheckUserInAthlete(txtUsername.Text);

                if (_athleteDal.checkStatus == false)
                {

                    string DateOfBirth = dtpicDateOfBirth.Value.ToString("yyyy-MM-dd");
                    string LicenseStartedDate = dtpicUpdateStartedDate.Value.ToString("yyyy-MM-dd");
                    string LicenseFinishedDate = dtpicUpdateFinishedDate.Value.ToString("yyyy-MM-dd");

                    int Id = Convert.ToInt32(dgwAthletes.CurrentRow.Cells[0].Value);
                    int categoryId = _athleteCategory.GetCategory(cmbxUpdateCategoryId.SelectedItem.ToString());
                    string IpAddress = Dns.GetHostByName(hostName).AddressList[0].ToString();
                    Athlete athlete = new Athlete
                    {
                        Id = Id,
                        categoryId = categoryId,
                        Firstname = txtUpdateFirstname.Text,
                        Lastname = txtUpdateLastname.Text,
                        Password = txtUpdatePassword.Text,
                        City = cmbxUpdateCity.SelectedItem.ToString(),
                        Age = Convert.ToInt32(txtUpdateAge.Text),
                        Weight = Convert.ToInt32(txtUpdateWeight.Text),
                        Height = Convert.ToInt32(txtUpdateHeight.Text),
                        Address = txtUpdateAddress.Text,
                        District = cmbxUpdateDistrict.SelectedItem.ToString(),
                        IpAddress = IpAddress,
                        UpdatedDate = dateTime.ToString("yyyy-MM-dd H:mm:ss"),
                        LicenseStartedDate = LicenseStartedDate,
                        LicenseFinishedDate = LicenseFinishedDate,
                        DateOfBirth = DateOfBirth,
                        ApplyStatus = "Active"
                    };
                    _athleteDal.UpdateAthlete(athlete);
                    LoadAthletes();
                    MessageBox.Show("Athlete Updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _inputHelper.ClearTextBox(txtUpdateFirstname, txtUpdateLastname, txtUpdatePassword, txtUpdateUsername, txtUpdateAddress, txtUpdateAge, txtUpdateHeight, txtUpdateWeight);
                    _inputHelper.ClearCombobox(cmbxUpdateCategoryId, cmbxUpdateCity, cmbxUpdateDistrict);
                    _inputHelper.ClearDateTimePicker(dtpicUpdateDateOfBirth, dtpicUpdateFinishedDate, dtpicUpdateStartedDate);
                    gbxUpdateAthlete.Enabled = false;
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
            InputHelper checkInputValues = new InputHelper();
            int Id = Convert.ToInt32(dgwAthletes.CurrentRow.Cells[0].Value);
            _athleteDal.DeleteAthlete(Id);
            LoadAthletes();
            MessageBox.Show("Athlete Deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _inputHelper.ClearTextBox(txtUpdateFirstname, txtUpdateLastname, txtUpdatePassword, txtUpdateUsername, txtUpdateAddress, txtUpdateAge, txtUpdateHeight, txtUpdateWeight);
            _inputHelper.ClearCombobox(cmbxUpdateCity, cmbxUpdateDistrict, cmbxUpdateCategoryId);
            gbxUpdateAthlete.Enabled = false;
        }

        private void frmAthletes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void cmbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDistrict(false);
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

        private void cmbxUpdateCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDistrict(true);
        }


    }
}
