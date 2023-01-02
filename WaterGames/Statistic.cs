using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterGames
{
    public class Statistic
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } 
        public int AthlelteId { get; set; }
        public int CommitteeId { get; set; }
        public int CompetitionId { get; set; }
        public int Ranking { get; set; }
        public string Duration { get; set; }
        public int Performance { get; set; }
        public int Point { get; set; }
        public string CreatedDate { get; set; }
    }
}
