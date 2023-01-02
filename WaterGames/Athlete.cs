using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterGames
{
    public class Athlete
    {
        public int Id { get; set; }
        public int categoryId { get; set; }
        public string AthleteCategory { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string IpAddress { get; set; } 
        public string Address { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public string DateOfBirth { get; set; }
        public string LicenseStartedDate { get; set; }
        public string LicenseFinishedDate { get; set; }
        public string LastLoginDate { get; set; }
        public string UpdatedDate { get; set; }
        public string CreatedDate { get; set; }
        public string ApplyStatus { get; set; } 
        public string LicenseStatus { get; set; }
        public string Status { get; set; }
    }
}
