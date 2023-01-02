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

    public class AthleteDal
    {
        ConnectionHelper _connectionHelper = new ConnectionHelper();
        EncryptionHelper _encryptionHelper = new EncryptionHelper();
        public bool checkStatus = false;
        public List<Athlete> GetAllAthletes()
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand athleteCommand = new MySqlCommand("SELECT * FROM athletes INNER JOIN athletecategories ON athletes.athleteCategoryId=athletecategories.Id WHERE Status IN('1')", _connectionHelper.Connection);
            MySqlDataReader readerAthelete = athleteCommand.ExecuteReader();
            List<Athlete> athletes = new List<Athlete>();
            while (readerAthelete.Read())
            {
                Athlete athlete = new Athlete
                {
                    Id = Convert.ToInt32(readerAthelete["id"]),
                    categoryId = Convert.ToInt32(readerAthelete["athleteCategoryId"]),
                    AthleteCategory = readerAthelete["Title"].ToString(),
                    Firstname = readerAthelete["Firstname"].ToString(),
                    Lastname = readerAthelete["Lastname"].ToString(),
                    Username = readerAthelete["Username"].ToString(),
                    Password = _encryptionHelper.Decrypt(readerAthelete["Password"].ToString()),
                    Age = Convert.ToInt32(readerAthelete["Age"]), 
                    Weight = Convert.ToInt32(readerAthelete["Weight"]),
                    Height = Convert.ToInt32(readerAthelete["Height"]),
                    Address = readerAthelete["Address"].ToString(),
                    District = readerAthelete["District"].ToString(),
                    City = readerAthelete["City"].ToString(),
                    IpAddress = readerAthelete["IpAddress"].ToString(),
                    DateOfBirth = readerAthelete["DateOfBirth"].ToString(),
                    LicenseStartedDate = readerAthelete["LicenseStartedDate"].ToString(),
                    LicenseFinishedDate = readerAthelete["LicenseFinishedDate"].ToString(),
                    LastLoginDate = readerAthelete["LastLoginDate"].ToString(),
                    UpdatedDate = readerAthelete["UpdatedDate"].ToString(),
                    CreatedDate = readerAthelete["CreatedDate"].ToString(),
                    ApplyStatus = readerAthelete["ApplyStatus"].ToString(),
                    LicenseStatus = readerAthelete["LicenseStatus"].ToString(),
                    Status = "Active"
                };
                athletes.Add(athlete);
            }
            readerAthelete.Close();
            _connectionHelper.Connection.Close();
            return athletes;

        }


        public void AddAthlete(Athlete Athlete)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand addAthleteCommand =
            new MySqlCommand("INSERT INTO athletes (athleteCategoryId, Firstname, Lastname, Username, Password, Weight, Height, Age, Address, City, District, IpAddress, UpdatedDate,DateOfBirth, LicenseStartedDate, LicenseFinishedDate, ApplyStatus ) VALUES(@athleteCategoryId,@Firstname,@Lastname,@Username,@Password, @Weight, @Height, @Age, @Address, @City, @District, @IpAddress, @UpdatedDate, @DateOfBirth,@LicenseStartedDate, @LicenseFinishedDate , @ApplyStatus)", _connectionHelper.Connection);
            addAthleteCommand.Parameters.AddWithValue("@athleteCategoryId", Athlete.categoryId);
            addAthleteCommand.Parameters.AddWithValue("@FirstName", Athlete.Firstname);
            addAthleteCommand.Parameters.AddWithValue("@Lastname", Athlete.Lastname);
            addAthleteCommand.Parameters.AddWithValue("@Username", Athlete.Username);
            addAthleteCommand.Parameters.AddWithValue("@Password", _encryptionHelper.Encrypt(Athlete.Password));
            addAthleteCommand.Parameters.AddWithValue("@Weight", Athlete.Weight);
            addAthleteCommand.Parameters.AddWithValue("@Height", Athlete.Height);
            addAthleteCommand.Parameters.AddWithValue("@Age", Athlete.Age);
            addAthleteCommand.Parameters.AddWithValue("@Address", Athlete.Address);
            addAthleteCommand.Parameters.AddWithValue("@City", Athlete.City);
            addAthleteCommand.Parameters.AddWithValue("@District", Athlete.District);
            addAthleteCommand.Parameters.AddWithValue("@IpAddress", Athlete.IpAddress);
            addAthleteCommand.Parameters.AddWithValue("@UpdatedDate", Athlete.UpdatedDate);
            addAthleteCommand.Parameters.AddWithValue("@DateOfBirth", Athlete.DateOfBirth);
            addAthleteCommand.Parameters.AddWithValue("@LicenseStartedDate", Athlete.LicenseStartedDate);
            addAthleteCommand.Parameters.AddWithValue("@LicenseFinishedDate", Athlete.LicenseFinishedDate);
            addAthleteCommand.Parameters.AddWithValue("@ApplyStatus", Athlete.ApplyStatus);
            addAthleteCommand.ExecuteNonQuery();
            _connectionHelper.CloseConnection();

        }
        public void UpdateAthlete(Athlete Athlete)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand UpdateAthleteCommand = new MySqlCommand("UPDATE athletes SET athleteCategoryId=@athleteCategoryId, Firstname=@Firstname, Lastname=@Lastname, Password=@Password, Weight=@Weight, Height=@Height, Age=@Age, Address=@Address, City=@City, District=@District, IpAddress=@IpAddress, UpdatedDate=@UpdatedDate,DateOfBirth=@DateOfBirth, LicenseStartedDate=@LicenseStartedDate, LicenseFinishedDate=@LicenseFinishedDate ,ApplyStatus=@ApplyStatus  WHERE Id=@Id", _connectionHelper.Connection);
            UpdateAthleteCommand.Parameters.AddWithValue("@Id", Athlete.Id);
            UpdateAthleteCommand.Parameters.AddWithValue("@athleteCategoryId", Athlete.categoryId);
            UpdateAthleteCommand.Parameters.AddWithValue("@FirstName", Athlete.Firstname);
            UpdateAthleteCommand.Parameters.AddWithValue("@Lastname", Athlete.Lastname);
            UpdateAthleteCommand.Parameters.AddWithValue("@Password", _encryptionHelper.Encrypt(Athlete.Password));
            UpdateAthleteCommand.Parameters.AddWithValue("@Weight", Athlete.Weight);
            UpdateAthleteCommand.Parameters.AddWithValue("@Height", Athlete.Height);
            UpdateAthleteCommand.Parameters.AddWithValue("@Age", Athlete.Age);
            UpdateAthleteCommand.Parameters.AddWithValue("@Address", Athlete.Address);
            UpdateAthleteCommand.Parameters.AddWithValue("@City", Athlete.City);
            UpdateAthleteCommand.Parameters.AddWithValue("@District", Athlete.District);
            UpdateAthleteCommand.Parameters.AddWithValue("@IpAddress", Athlete.IpAddress);
            UpdateAthleteCommand.Parameters.AddWithValue("@UpdatedDate", Athlete.UpdatedDate);
            UpdateAthleteCommand.Parameters.AddWithValue("@DateOfBirth", Athlete.DateOfBirth);
            UpdateAthleteCommand.Parameters.AddWithValue("@LicenseStartedDate", Athlete.LicenseStartedDate);
            UpdateAthleteCommand.Parameters.AddWithValue("@LicenseFinishedDate", Athlete.LicenseFinishedDate);
            UpdateAthleteCommand.Parameters.AddWithValue("@ApplyStatus", Athlete.ApplyStatus);
            UpdateAthleteCommand.ExecuteNonQuery();
            _connectionHelper.CloseConnection();

        }
        public void DeleteAthlete(int Id)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand deleteAthleteCommand = new MySqlCommand("DELETE FROM athletes WHERE Id=@Id", _connectionHelper.Connection);
            deleteAthleteCommand.Parameters.AddWithValue("@Id", Id);
            deleteAthleteCommand.ExecuteNonQuery();
            _connectionHelper.CloseConnection();

        }
        public void GetAthlete(Athlete Athlete)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand GetAthleteCommand = new MySqlCommand("SELECT * FROM athletes WHERE Username=@Username AND Password=@Password", _connectionHelper.Connection);
            GetAthleteCommand.Parameters.AddWithValue("@Username", Athlete.Username);
            GetAthleteCommand.Parameters.AddWithValue("@Password", _encryptionHelper.Encrypt(Athlete.Password));
            MySqlDataReader readerAthlete = GetAthleteCommand.ExecuteReader();
            if (readerAthlete.Read())
            {
                checkStatus = true;
            }
            else
            {
                checkStatus = false;
            }
            readerAthlete.Close();
            _connectionHelper.CloseConnection();
        }

        public List<Athlete> GetAthleteDetail(string Username)
        {
            _connectionHelper.CheckConnectionState(); 
            MySqlCommand GetAthleteDetailCommand = new MySqlCommand("SELECT * FROM athletes INNER JOIN athletecategories ON athletes.athleteCategoryId=athletecategories.Id WHERE Username=@Username", _connectionHelper.Connection);
            GetAthleteDetailCommand.Parameters.AddWithValue("@Username", Username);
            MySqlDataReader readerAthlete = GetAthleteDetailCommand.ExecuteReader();
            List<Athlete> athleteDetail = new List<Athlete>();
            if (readerAthlete.Read())
            {
                Athlete athlete = new Athlete
                {
                    Id = Convert.ToInt32(readerAthlete["Id"]),  
                    AthleteCategory = readerAthlete["Title"].ToString(),
                    Firstname = readerAthlete["Firstname"].ToString(),
                    Lastname = readerAthlete["Lastname"].ToString(),
                    Username = readerAthlete["Username"].ToString(),
                    Password = _encryptionHelper.Decrypt(readerAthlete["Password"].ToString()),
                    Age = Convert.ToInt32(readerAthlete["Age"]),
                    Weight = Convert.ToInt32(readerAthlete["Weight"]),
                    Height = Convert.ToInt32(readerAthlete["Height"]),
                    Address = readerAthlete["Address"].ToString(),
                    District = readerAthlete["District"].ToString(),
                    City = readerAthlete["City"].ToString(), 
                    DateOfBirth = readerAthlete["DateOfBirth"].ToString(),
                    LicenseStartedDate = readerAthlete["LicenseStartedDate"].ToString(),
                    LicenseFinishedDate = readerAthlete["LicenseFinishedDate"].ToString(),
                    LastLoginDate = readerAthlete["LastLoginDate"].ToString(),
                    UpdatedDate = readerAthlete["UpdatedDate"].ToString(),  
                    LicenseStatus = readerAthlete["LicenseStatus"].ToString() 
                };
                athleteDetail.Add(athlete);
            }
            
            readerAthlete.Close();
            _connectionHelper.CloseConnection();
            return athleteDetail;
        }
        public void CheckUserInAthlete(string Username)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand checkUserInAthleteCommand = new MySqlCommand("SELECT * FROM athletes WHERE Username=@Username", _connectionHelper.Connection);
            checkUserInAthleteCommand.Parameters.AddWithValue("@Username", Username);
            MySqlDataReader readerAthlete = checkUserInAthleteCommand.ExecuteReader();
            if (readerAthlete.Read())
            {
                checkStatus = true;
            }
            else
            {
                checkStatus = false;
            }
            readerAthlete.Close();
            _connectionHelper.CloseConnection();
        }

        public void UpdateLoginAthlete(Athlete Athlete)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand updateLoginAthleteCommand = new MySqlCommand("UPDATE athletes SET LastLoginDate=@LastLoginDate, IpAddress=@IpAddress WHERE Username=@Username", _connectionHelper.Connection);
            updateLoginAthleteCommand.Parameters.AddWithValue("@Username", Athlete.Username);
            updateLoginAthleteCommand.Parameters.AddWithValue("@IpAddress", Athlete.IpAddress);
            updateLoginAthleteCommand.Parameters.AddWithValue("@LastLoginDate", Athlete.LastLoginDate);
            updateLoginAthleteCommand.ExecuteNonQuery();
            _connectionHelper.CloseConnection();
        }
    }
}
