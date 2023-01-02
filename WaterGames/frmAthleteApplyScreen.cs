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
    public partial class frmAthleteApplyScreen : Form
    {

        InputHelper _inputHelper = new InputHelper();
        JsonHelper _jsonHelper = new JsonHelper();
        AthleteDal _athleteDal = new AthleteDal();
        Athlete _athlete = new Athlete();
        AthleteCategoryDal _athleteCategory = new AthleteCategoryDal();
        frmMain frmMain = new frmMain();
        frmAthleteLogin frmAthleteLogin = new frmAthleteLogin();
        public frmAthleteApplyScreen()
        {
            InitializeComponent();
        }
        private void getDistrict()
        {
            cmbxDistrict.Enabled = true;
            cmbxDistrict.Items.Clear();

            foreach (var city in _jsonHelper.getCitiesFromJsonFile())
            {
                foreach (var district in _jsonHelper.getDistrictsFromJsonFile())
                {

                    if (city.CityName == cmbxCity.SelectedItem.ToString() && city.Id == district.CityId)
                    {
                        cmbxDistrict.Items.Add(district.DistrictTitle);
                    }

                }
            }
        }
        private void btnAddAAthlete_Click(object sender, EventArgs e)
        {
            string hostName = Dns.GetHostName();
            DateTime dateTime = DateTime.Now;
   
            _inputHelper.CheckTextBoxValues(txtFirstname, txtLastname, txtUsername, txtPassword, txtAddress);
            _inputHelper.CheckComboboxValues(cmbxCity, cmbxDistrict, cmbxCategoryId);
            if (_inputHelper.status == true)
            {
                int categoryId = _athleteCategory.GetCategory(cmbxCategoryId.SelectedItem.ToString());
                string IpAddress = Dns.GetHostByName(hostName).AddressList[0].ToString();

                _athleteDal.CheckUserInAthlete(txtUsername.Text);

                if (_athleteDal.checkStatus == false)
                {
                    _athleteDal.AddAthlete(new Athlete
                    {
                        categoryId = categoryId,
                        Firstname = txtFirstname.Text,
                        Lastname = txtLastname.Text,
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        City = cmbxCity.SelectedItem.ToString(),
                        Address = txtAddress.Text,
                        District = cmbxDistrict.SelectedItem.ToString(),
                        IpAddress = IpAddress,
                        UpdatedDate = dateTime.ToString("yyyy-MM-dd H:mm:ss"),
                        ApplyStatus = "InActive"

                    });

                    MessageBox.Show("Your apply has received.!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _inputHelper.ClearTextBox(txtFirstname, txtLastname, txtPassword, txtUsername, txtAddress);
                    _inputHelper.ClearCombobox(cmbxDistrict, cmbxCategoryId, cmbxCity);
                    this.Hide();
                    frmAthleteLogin.Show();
                }
                else
                {
                    MessageBox.Show("This username is already used", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void frmAthleteApplyScreen_Load(object sender, EventArgs e)
        {
            cmbxDistrict.Enabled = false;
            _jsonHelper.addCityToComboBox(cmbxCity);
            _athleteCategory.addCategoryToCombobox(cmbxCategoryId);
        }

        private void cmbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDistrict();
        }

        private void frmAthleteApplyScreen_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Hide();
            frmMain.Show();
        }
    }
}
