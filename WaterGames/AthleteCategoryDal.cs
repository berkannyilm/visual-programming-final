using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterGames
{
    public class AthleteCategoryDal
    {
        ConnectionHelper _connectionHelper = new ConnectionHelper();
        public int categoryId;
        public List<AthleteCategory> GetAllCategories()
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand categoryCommand = new MySqlCommand("SELECT * FROM athletecategories", _connectionHelper.Connection);
            MySqlDataReader readerCategory = categoryCommand.ExecuteReader();
            List<AthleteCategory> categories = new List<AthleteCategory>();
            while (readerCategory.Read())
            {
                AthleteCategory athleteCategory = new AthleteCategory
                {
                    Id = Convert.ToInt32(readerCategory["id"]),
                    Title = readerCategory["Title"].ToString()
                };
                categories.Add(athleteCategory);
            }
            readerCategory.Close();
            _connectionHelper.Connection.Close();
            return categories;

        }

        public void addCategoryToCombobox(ComboBox comboBox, params ComboBox[] comboBoxes)
        { 
            foreach (var categoryTitle in GetAllCategories())
            {
                comboBox.Items.Add(categoryTitle.Title);
                foreach (var _comboBox in comboBoxes)
                {
                    _comboBox.Items.Add(categoryTitle.Title);
                }
            }
        }
       
        public void AddCategory(AthleteCategory athleteCategory)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand addCategoryCommand =
            new MySqlCommand("INSERT INTO athletecategories (Title) VALUES(@Title)", _connectionHelper.Connection);
            addCategoryCommand.Parameters.AddWithValue("@Title", athleteCategory.Title);
            addCategoryCommand.ExecuteNonQuery();
            _connectionHelper.CloseConnection();

        }
        public void UpdateCategory(AthleteCategory athleteCategory)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand updateCategoryCommand = new MySqlCommand("UPDATE athletecategories SET Title=@Title WHERE Id=@Id", _connectionHelper.Connection);
            updateCategoryCommand.Parameters.AddWithValue("@Id", athleteCategory.Id);
            updateCategoryCommand.Parameters.AddWithValue("@Title", athleteCategory.Title);
            updateCategoryCommand.ExecuteNonQuery();
            _connectionHelper.CloseConnection();

        }
        public void DeleteCategory(int Id)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand deleteCategoryCommand = new MySqlCommand("DELETE FROM athletecategories WHERE Id=@Id", _connectionHelper.Connection);
            deleteCategoryCommand.Parameters.AddWithValue("@Id", Id);
            deleteCategoryCommand.ExecuteNonQuery();
            _connectionHelper.CloseConnection();

        }

        public int GetCategory(string categoryTitle)
        {
             _connectionHelper.CheckConnectionState();
            MySqlCommand getCategoryCommand = new MySqlCommand("SELECT * FROM athletecategories WHERE Title=@Title ", _connectionHelper.Connection);
            getCategoryCommand.Parameters.AddWithValue("@Title", categoryTitle);
            MySqlDataReader readerCategories = getCategoryCommand.ExecuteReader();
            if (readerCategories.Read())
            {
                categoryId = readerCategories.GetInt32(0);
                readerCategories.Close();
            }
            _connectionHelper.CloseConnection();
            return categoryId;
        }

    }
}
