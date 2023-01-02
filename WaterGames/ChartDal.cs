using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterGames
{
    public class ChartDal
    {
        ConnectionHelper _connectionHelper = new ConnectionHelper();
        EncryptionHelper _encryptionHelper = new EncryptionHelper();
        public List<Chart> GetAllAthleteStatistics()
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand athleteStatisticCommand = new MySqlCommand("SELECT" +
                " athletes.Firstname AS AthleteFirstname," +
                " athletes.Lastname AS AthleteLastname," +
                " competitions.Title AS CompetitionTitle," +
                " committees.Firstname AS CommitteeFirstName," +
                " committees.Lastname AS CommitteeLastname, " +
                "athletecategories.Title AS CategoryTitle, " +
                "atheletestatistics.* FROM atheletestatistics " +
                "INNER JOIN athletes ON atheletestatistics.AtheleteId = athletes.Id " +
                "INNER JOIN competitions ON atheletestatistics.CompetitionId = competitions.Id " +
                "INNER JOIN committees ON atheletestatistics.CommitteeId = committees.Id " +
                "INNER JOIN athletecategories ON atheletestatistics.CategoryId = athletecategories.Id", _connectionHelper.Connection);
            MySqlDataReader reader = athleteStatisticCommand.ExecuteReader();
            List<Chart> statistics = new List<Chart>();
            while (reader.Read())
            {
                Chart chart = new Chart
                {
                    AthleteFirstnameLastname = reader["AthleteFirstname"].ToString() + reader["AthleteLastname"].ToString(),
                    CommitteeFirstnameLastname = reader["CommitteeFirstName"].ToString() + reader["CommitteeLastname"].ToString(),
                    CategoryTitle = reader["CategoryTitle"].ToString(),
                    CompetitionTitle = reader["CompetitionTitle"].ToString(),
                    Point = Convert.ToInt32(reader["Point"]),
                    Duration = reader["Duration"].ToString(),
                    Performance = Convert.ToInt32(reader["Performance"]),
                    Ranking = Convert.ToInt32(reader["Ranking"])
                };
                statistics.Add(chart);
            }
            reader.Close();
            _connectionHelper.Connection.Close();
            return statistics; 
        }
        public List<Chart> GetAthleteStatistics(string Username )
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand athleteStatisticCommand = new MySqlCommand("SELECT" +
                " SUM(atheletestatistics.Point) AS Point," +
                " SUM(atheletestatistics.Performance) AS Performance," +
                " MONTH(atheletestatistics.CreatedDate) AS Month, " +
                "YEAR(atheletestatistics.CreatedDate) AS Year, " + 
                " athletes.Firstname AS AthleteFirstname," +
                " athletes.Lastname AS AthleteLastname," +
                " competitions.Title AS CompetitionTitle," +
                " committees.Firstname AS CommitteeFirstName," +
                " committees.Lastname AS CommitteeLastname, " +
                "athletecategories.Title AS CategoryTitle, " +
                "atheletestatistics.* FROM atheletestatistics " +
                "INNER JOIN athletes ON atheletestatistics.AtheleteId = athletes.Id " +
                "INNER JOIN competitions ON atheletestatistics.CompetitionId = competitions.Id " +
                "INNER JOIN committees ON atheletestatistics.CommitteeId = committees.Id " +
                "INNER JOIN athletecategories ON atheletestatistics.CategoryId = athletecategories.Id " +
                "WHERE athletes.Username=@Username" +
                " GROUP BY Year, Month", _connectionHelper.Connection);
            athleteStatisticCommand.Parameters.AddWithValue("@Username", Username); 
            MySqlDataReader reader = athleteStatisticCommand.ExecuteReader();
            List<Chart> statistics = new List<Chart>();
            while (reader.Read())
            {
                Chart chart = new Chart
                {
                    AthleteFirstnameLastname = reader["AthleteFirstname"].ToString() + reader["AthleteLastname"].ToString(),
                    CommitteeFirstnameLastname = reader["CommitteeFirstName"].ToString() + reader["CommitteeLastname"].ToString(),
                    CategoryTitle = reader["CategoryTitle"].ToString(),
                    Year = reader["Year"].ToString(),
                    Month = reader["Month"].ToString(), 
                    CompetitionTitle = reader["CompetitionTitle"].ToString(),
                    Point = Convert.ToInt32(reader["Point"]),
                    Duration = reader["Duration"].ToString(),
                    Performance = Convert.ToInt32(reader["Performance"]),
                    Ranking = Convert.ToInt32(reader["Ranking"])
                };
                statistics.Add(chart);
            }
            reader.Close();
            _connectionHelper.Connection.Close();
            return statistics;
        }

        public List<Chart> ChartByDistrict()
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand chartByDistrictCommand = new MySqlCommand("SELECT" +
                " COUNT(*) AS Count,"+
                " athletes.District AS District" +
                " FROM atheletestatistics " +
                "INNER JOIN athletes ON atheletestatistics.AtheleteId = athletes.Id " +
                "INNER JOIN competitions ON atheletestatistics.CompetitionId = competitions.Id " +
                "INNER JOIN committees ON atheletestatistics.CommitteeId = committees.Id " +
                "INNER JOIN athletecategories ON atheletestatistics.CategoryId = athletecategories.Id " +
                " GROUP BY District", _connectionHelper.Connection); 
            MySqlDataReader reader = chartByDistrictCommand.ExecuteReader();
            List<Chart> districtCounts = new List<Chart>();
            while (reader.Read())
            {
                Chart chart = new Chart
                {
                    Count = Convert.ToInt32(reader["Count"]),
                    District = reader["District"].ToString(),
                };
                districtCounts.Add(chart);
            }
            reader.Close();
            _connectionHelper.Connection.Close();
            return districtCounts;
        }
        public List<Chart> ChartByCity()
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand chartByCityCommand = new MySqlCommand("SELECT" +
                " COUNT(*) AS Count," +
                " athletes.City AS City" +
                " FROM atheletestatistics " +
                "INNER JOIN athletes ON atheletestatistics.AtheleteId = athletes.Id " +
                "INNER JOIN competitions ON atheletestatistics.CompetitionId = competitions.Id " +
                "INNER JOIN committees ON atheletestatistics.CommitteeId = committees.Id " +
                "INNER JOIN athletecategories ON atheletestatistics.CategoryId = athletecategories.Id " +
                " GROUP BY City", _connectionHelper.Connection);
            MySqlDataReader reader = chartByCityCommand.ExecuteReader();
            List<Chart> cityCounts = new List<Chart>();
            while (reader.Read())
            {
                Chart chart = new Chart
                {
                    Count = Convert.ToInt32(reader["Count"]),
                    City = reader["City"].ToString(),
                };
                cityCounts.Add(chart);
            }
            reader.Close();
            _connectionHelper.Connection.Close();
            return cityCounts;
        }
        public List<Chart> ChartByMontly()
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand chartByMontlyCommand = new MySqlCommand("SELECT" +
                " COUNT(*) AS Count," +
                " MONTH(atheletestatistics.CreatedDate) AS Month, " +
                " YEAR(atheletestatistics.CreatedDate) AS Year " +
                " FROM atheletestatistics " +
                "INNER JOIN athletes ON atheletestatistics.AtheleteId = athletes.Id " +
                "INNER JOIN competitions ON atheletestatistics.CompetitionId = competitions.Id " +
                "INNER JOIN committees ON atheletestatistics.CommitteeId = committees.Id " +
                "INNER JOIN athletecategories ON atheletestatistics.CategoryId = athletecategories.Id " +
                " GROUP BY Month, Year", _connectionHelper.Connection);
            MySqlDataReader reader = chartByMontlyCommand.ExecuteReader();
            List<Chart> montlyCounts = new List<Chart>();
            while (reader.Read())
            {
                Chart chart = new Chart
                {
                    Count = Convert.ToInt32(reader["Count"]),
                    Month = reader["Month"].ToString(),
                };
                montlyCounts.Add(chart);
            }
            reader.Close();
            _connectionHelper.Connection.Close();
            return montlyCounts;
        }
        public List<Chart> ChartByYearly()
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand chartByYearlyCommand = new MySqlCommand("SELECT" +
                " COUNT(*) AS Count," + 
                " YEAR(atheletestatistics.CreatedDate) AS Year " +
                " FROM atheletestatistics " +
                "INNER JOIN athletes ON atheletestatistics.AtheleteId = athletes.Id " +
                "INNER JOIN competitions ON atheletestatistics.CompetitionId = competitions.Id " +
                "INNER JOIN committees ON atheletestatistics.CommitteeId = committees.Id " +
                "INNER JOIN athletecategories ON atheletestatistics.CategoryId = athletecategories.Id " +
                " GROUP BY  Year", _connectionHelper.Connection);
            MySqlDataReader reader = chartByYearlyCommand.ExecuteReader();
            List<Chart> yearlyCounts = new List<Chart>();
            while (reader.Read())
            {
                Chart chart = new Chart
                {
                    Count = Convert.ToInt32(reader["Count"]),
                    Year = reader["Year"].ToString(),
                };
                yearlyCounts.Add(chart);
            }
            reader.Close();
            _connectionHelper.Connection.Close();
            return yearlyCounts;
        }
        public List<Chart> ChartByCompetition()
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand chartByCompetitionCommand = new MySqlCommand("SELECT" +
                " COUNT(*) AS Count," +
                " competitions.Title AS CompetitionTitle " +
                " FROM atheletestatistics " +
                "INNER JOIN athletes ON atheletestatistics.AtheleteId = athletes.Id " +
                "INNER JOIN competitions ON atheletestatistics.CompetitionId = competitions.Id " +
                "INNER JOIN committees ON atheletestatistics.CommitteeId = committees.Id " +
                "INNER JOIN athletecategories ON atheletestatistics.CategoryId = athletecategories.Id " +
                " GROUP BY  CompetitionTitle", _connectionHelper.Connection);
            MySqlDataReader reader = chartByCompetitionCommand.ExecuteReader();
            List<Chart> competitionCounts = new List<Chart>();
            while (reader.Read())
            {
                Chart chart = new Chart
                {
                    Count = Convert.ToInt32(reader["Count"]),
                    CompetitionTitle = reader["CompetitionTitle"].ToString(),
                };
                competitionCounts.Add(chart);
            }
            reader.Close();
            _connectionHelper.Connection.Close();
            return competitionCounts;
        }
        public List<Chart> ChartByMaxPointCompetition()
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand MaxPointByCompetitionCommand = new MySqlCommand("SELECT" +
                " MAX(Point) AS Point," +
                " competitions.Title AS CompetitionTitle " +
                " FROM atheletestatistics " +
                "INNER JOIN athletes ON atheletestatistics.AtheleteId = athletes.Id " +
                "INNER JOIN competitions ON atheletestatistics.CompetitionId = competitions.Id " +
                "INNER JOIN committees ON atheletestatistics.CommitteeId = committees.Id " +
                "INNER JOIN athletecategories ON atheletestatistics.CategoryId = athletecategories.Id " +
                " GROUP BY CompetitionTitle", _connectionHelper.Connection);
            MySqlDataReader reader = MaxPointByCompetitionCommand.ExecuteReader();
            List<Chart> maxPointByCompetitionCounts = new List<Chart>();
            while (reader.Read())
            {
                Chart chart = new Chart
                {
                    Point = Convert.ToInt32(reader["Point"]),
                    CompetitionTitle = reader["CompetitionTitle"].ToString(),
                };
                maxPointByCompetitionCounts.Add(chart);
            }
            reader.Close();
            _connectionHelper.Connection.Close();
            return maxPointByCompetitionCounts;
        }
        public List<Chart> ChartByMinPointCompetition()
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand MaxPointByCompetitionCommand = new MySqlCommand("SELECT" +
                " MIN(Point) AS Point," +
                " competitions.Title AS CompetitionTitle " + 
                " FROM atheletestatistics " +
                "INNER JOIN athletes ON atheletestatistics.AtheleteId = athletes.Id " +
                "INNER JOIN competitions ON atheletestatistics.CompetitionId = competitions.Id " +
                "INNER JOIN committees ON atheletestatistics.CommitteeId = committees.Id " +
                "INNER JOIN athletecategories ON atheletestatistics.CategoryId = athletecategories.Id " +
                " GROUP BY CompetitionTitle ", _connectionHelper.Connection);
            MySqlDataReader reader = MaxPointByCompetitionCommand.ExecuteReader();
            List<Chart> minPointByCompetitionCounts = new List<Chart>();
            while (reader.Read())
            {
                Chart chart = new Chart
                {
                    Point = Convert.ToInt32(reader["Point"]),
                    CompetitionTitle = reader["CompetitionTitle"].ToString(),
                };
                minPointByCompetitionCounts.Add(chart);
            }
            reader.Close();
            _connectionHelper.Connection.Close();
            return minPointByCompetitionCounts;
        }
    }
}
