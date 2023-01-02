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
    public partial class frmCompetitions : Form
    {
        public frmCompetitions()
        {
            InitializeComponent();
        }
        Competition _competition = new Competition();
        CompetitionDal _competitionDal = new CompetitionDal();
        AthleteCategoryDal _athleteCategory = new AthleteCategoryDal();
        InputHelper _inputHelper = new InputHelper();
        private void LoadCompetitions()
        {
            dgwCompetitions.DataSource = _competitionDal.CompetitionList();
        }
        private void frmCompetitions_Load(object sender, EventArgs e)
        {
            LoadCompetitions();
            _athleteCategory.addCategoryToCombobox(cmbxCategoryId, cmbxUpdateCategoryId);
            gbxUpdateCompetition.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAddCompetition_Click(object sender, EventArgs e)
        {
            _inputHelper.CheckTextBoxValues(txtTitle, txtRecord, txtCapacity);
            _inputHelper.CheckComboboxValues(cmbxCategoryId);

            if (_inputHelper.status == true)
            {
                int categoryId = _athleteCategory.GetCategory(cmbxCategoryId.SelectedItem.ToString());
                _competitionDal.AddCompetition(new Competition
                {
                    CategoryId = categoryId,
                    Title = txtTitle.Text,
                    Record = txtRecord.Text,
                    MaximumCapacity = Convert.ToInt32(txtCapacity.Text)
                });

                LoadCompetitions();
                MessageBox.Show("Competition Added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _inputHelper.ClearTextBox(txtTitle, txtRecord, txtCapacity);
                _inputHelper.ClearCombobox(cmbxUpdateCategoryId);
            }
        }

        private void dgwCompetitions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbxUpdateCompetition.Enabled = true;
            btnDelete.Enabled = true;
            cmbxUpdateCategoryId.SelectedItem = dgwCompetitions.CurrentRow.Cells[3].Value.ToString();
            txtUpdateTitle.Text = dgwCompetitions.CurrentRow.Cells[2].Value.ToString();
            txtUpdateRecord.Text = dgwCompetitions.CurrentRow.Cells[4].Value.ToString();
            txtUpdateCapacity.Text = dgwCompetitions.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUpdateCompetition_Click(object sender, EventArgs e)
        {
            _inputHelper.CheckTextBoxValues(txtUpdateTitle, txtUpdateRecord, txtUpdateCapacity);
            _inputHelper.CheckComboboxValues(cmbxUpdateCategoryId);

            if (_inputHelper.status == true)
            {
                int Id = Convert.ToInt32(dgwCompetitions.CurrentRow.Cells[0].Value);
                int categoryId = _athleteCategory.GetCategory(cmbxUpdateCategoryId.SelectedItem.ToString());
                _competitionDal.UpdateCompetiton(new Competition
                {
                    Id = Id,
                    CategoryId = categoryId,
                    Title = txtUpdateTitle.Text,
                    Record = txtUpdateRecord.Text,
                    MaximumCapacity = Convert.ToInt32(txtUpdateCapacity.Text)
                });

                LoadCompetitions();
                MessageBox.Show("Competition Updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _inputHelper.ClearTextBox(txtUpdateTitle, txtUpdateRecord, txtUpdateCapacity);
                _inputHelper.ClearCombobox(cmbxUpdateCategoryId);
                gbxUpdateCompetition.Enabled = false;
                btnDelete.Enabled = false;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgwCompetitions.CurrentRow.Cells[0].Value);
            _competitionDal.DeleteCompetition(Id);
            LoadCompetitions();
            MessageBox.Show("Manager Deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _inputHelper.ClearTextBox(txtUpdateCapacity,txtUpdateRecord,txtUpdateTitle);
            _inputHelper.ClearCombobox(cmbxUpdateCategoryId);
            gbxUpdateCompetition.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}
