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
    public partial class frmAthleteCategories : Form
    {
        public frmAthleteCategories()
        {
            InitializeComponent();
        }
        AthleteCategoryDal _athleteCategoryDal = new AthleteCategoryDal();
        InputHelper _inputHelper = new InputHelper();
        private void frmAthleteCategories_Load(object sender, EventArgs e)
        { 
            btnDelete.Enabled= false;
            gbxUpdateCategory.Enabled = false;
            LoadCategories();
           
        }

        private void LoadCategories()
        {
            dgwAthletes.DataSource = _athleteCategoryDal.GetAllCategories();
        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            _inputHelper.CheckTextBoxValues(txtTitle);
            if (_inputHelper.status == true)
            {
                _athleteCategoryDal.AddCategory(new AthleteCategory
                {
                    Title = txtTitle.Text
                });
                LoadCategories();
                MessageBox.Show("Category Added!");
            }
            _inputHelper.ClearTextBox(txtUpdateTitle);
        }

        private void dgwAthletes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdateTitle.Text = dgwAthletes.CurrentRow.Cells[1].Value.ToString();
            gbxUpdateCategory.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdateManger_Click(object sender, EventArgs e)
        {
            _inputHelper.CheckTextBoxValues(txtUpdateTitle);
            if (_inputHelper.status == true)
            {
                _athleteCategoryDal.UpdateCategory(new AthleteCategory
                {
                    Id = Convert.ToInt32(dgwAthletes.CurrentRow.Cells[0].Value),
                    Title = txtUpdateTitle.Text
                }); ;
                LoadCategories();
                MessageBox.Show("Category Updated!");
                gbxUpdateCategory.Enabled = false;
                btnDelete.Enabled = false;
            }
            _inputHelper.ClearTextBox(txtUpdateTitle);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dgwAthletes.CurrentRow.Cells[0].Value);
            _athleteCategoryDal.DeleteCategory(Id);
            LoadCategories();
            MessageBox.Show("Category Deleted!");
            gbxUpdateCategory.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}
