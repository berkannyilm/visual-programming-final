using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterGames
{
    public class CompetitionDal
    {
        ConnectionHelper _connectionHelper = new ConnectionHelper();
        public int competitionId;
        public List<Competition> CompetitionList()
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand competitionCommand = new MySqlCommand("SELECT athletecategories.Title AS CategoryTitle, competitions.* FROM competitions INNER JOIN athletecategories ON competitions.categoryId=athletecategories.Id ", _connectionHelper.Connection);
            MySqlDataReader readerCompetition = competitionCommand.ExecuteReader();
            List<Competition> competitions = new List<Competition>();
            while (readerCompetition.Read())
            {
                Competition competition = new Competition
                {
                    Id = Convert.ToInt32(readerCompetition["Id"]),
                    CategoryId = Convert.ToInt32(readerCompetition["categoryId"]),
                    CategoryTitle = readerCompetition["CategoryTitle"].ToString(),
                    Title = readerCompetition["Title"].ToString(),
                    Record = readerCompetition["Record"].ToString(),
                    MaximumCapacity = Convert.ToInt32(readerCompetition["MaximumCapacity"]),
                    CreatedDate = readerCompetition["CreatedDate"].ToString()
                };
                competitions.Add(competition);
            }
            readerCompetition.Close();
            _connectionHelper.Connection.Close();
            return competitions;
        }
        public void AddCompetition(Competition competition)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand addcompetitionCommand =
            new MySqlCommand("INSERT INTO competitions (categoryId, Title, Record, MaximumCapacity) VALUES(@categoryId,@Title,@Record,@MaximumCapacity)", _connectionHelper.Connection);
            addcompetitionCommand.Parameters.AddWithValue("@categoryId", competition.CategoryId);
            addcompetitionCommand.Parameters.AddWithValue("@Title", competition.Title);
            addcompetitionCommand.Parameters.AddWithValue("@Record", competition.Record);
            addcompetitionCommand.Parameters.AddWithValue("@MaximumCapacity", competition.MaximumCapacity);
            addcompetitionCommand.ExecuteNonQuery();
            _connectionHelper.CloseConnection();

        }
        public void UpdateCompetiton(Competition competition)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand updateCompetitionCommand = new MySqlCommand("UPDATE competitions SET categoryId=@categoryId,Title=@Title, Record=@Record, MaximumCapacity=@MaximumCapacity WHERE Id=@Id", _connectionHelper.Connection);
            updateCompetitionCommand.Parameters.AddWithValue("@Id", competition.Id);
            updateCompetitionCommand.Parameters.AddWithValue("@categoryId", competition.CategoryId);
            updateCompetitionCommand.Parameters.AddWithValue("@Title", competition.Title);
            updateCompetitionCommand.Parameters.AddWithValue("@Record", competition.Record);
            updateCompetitionCommand.Parameters.AddWithValue("@MaximumCapacity", competition.MaximumCapacity);
            updateCompetitionCommand.ExecuteNonQuery();
            _connectionHelper.CloseConnection();

        }
        public void DeleteCompetition(int Id)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand deleteCompetitionCommand = new MySqlCommand("DELETE FROM competitions WHERE Id=@Id", _connectionHelper.Connection);
            deleteCompetitionCommand.Parameters.AddWithValue("@Id", Id);
            deleteCompetitionCommand.ExecuteNonQuery();
            _connectionHelper.CloseConnection();

        }
        public int GetCategory(string competitionTitle)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand getCompetitionCommand = new MySqlCommand("SELECT * FROM competitions WHERE Title=@Title ", _connectionHelper.Connection);
            getCompetitionCommand.Parameters.AddWithValue("@Title", competitionTitle);
            MySqlDataReader readerCompetition= getCompetitionCommand.ExecuteReader();
            if (readerCompetition.Read())
            {
                competitionId = readerCompetition.GetInt32(0);
                readerCompetition.Close();
            }
            _connectionHelper.CloseConnection();
            return competitionId;
        }
    }
}
