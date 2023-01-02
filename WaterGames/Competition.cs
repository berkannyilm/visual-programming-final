using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterGames
{
    public class Competition
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string CategoryTitle { get; set; }
        public string Record { get; set; }
        public int MaximumCapacity { get; set; }
        public string CreatedDate { get; set; }
    }
}
