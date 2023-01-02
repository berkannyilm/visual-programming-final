using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterGames
{
    public class StatisticDal
    {
        ConnectionHelper _connectionHelper = new ConnectionHelper();

        public List<Statistic> GetStatistics()
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand statisticCommand = new MySqlCommand("SELECT * FROM statistics", _connectionHelper.Connection);
            MySqlDataReader readerStatistic = statisticCommand.ExecuteReader();
            List<Statistic> statistics = new List<Statistic>();
            while (readerStatistic.Read())
            {
                Statistic statistic = new Statistic
                {
                    Id = Convert.ToInt32(readerStatistic["Id"]), 
                    AthlelteId = Convert.ToInt32(readerStatistic["AtheleteId"]),
                    CategoryId = Convert.ToInt32(readerStatistic["CategoryId"]),
                    CommitteeId = Convert.ToInt32(readerStatistic["CommitteeId"]),
                    CompetitionId = Convert.ToInt32(readerStatistic["CompetitionId"]),
                    Ranking = Convert.ToInt32(readerStatistic["Ranking"]),
                    Duration = readerStatistic["Duration"].ToString(),
                    Performance = Convert.ToInt32(readerStatistic["Performance"]),
                    Point = Convert.ToInt32(readerStatistic["Point"]),
                    CreatedDate = readerStatistic["CreatedDate"].ToString(),
                };
                statistics.Add(statistic);
            }
            readerStatistic.Close();
            _connectionHelper.Connection.Close();
            return statistics;

        }

        public void AddStatistic(Statistic statistic)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand addStatisticCommand =
            new MySqlCommand("INSERT INTO atheletestatistics (AtheleteId,CategoryId,CommitteeId,CompetitionId,Ranking,Duration,Performance,Point) VALUES(@AtheleteId,@CategoryId ,@CommitteeId, @CompetitionId, @Ranking, @Duration, @Performance, @Point)", _connectionHelper.Connection);
            addStatisticCommand.Parameters.AddWithValue("@AtheleteId", statistic.AthlelteId);
            addStatisticCommand.Parameters.AddWithValue("@CategoryId", statistic.CategoryId);
            addStatisticCommand.Parameters.AddWithValue("@CommitteeId", statistic.CommitteeId);
            addStatisticCommand.Parameters.AddWithValue("@CompetitionId", statistic.CompetitionId);
            addStatisticCommand.Parameters.AddWithValue("@Ranking", statistic.Ranking);
            addStatisticCommand.Parameters.AddWithValue("@Duration", statistic.Duration);
            addStatisticCommand.Parameters.AddWithValue("@Performance", statistic.Performance);
            addStatisticCommand.Parameters.AddWithValue("@Point", statistic.Point);
            addStatisticCommand.ExecuteNonQuery();
            _connectionHelper.CloseConnection();

        }

    }
}
