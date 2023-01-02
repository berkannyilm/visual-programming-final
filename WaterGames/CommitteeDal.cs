using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WaterGames
{

    public class CommitteeDal
    {
        ConnectionHelper _connectionHelper = new ConnectionHelper();
        EncryptionHelper _encryptionHelper = new EncryptionHelper();
        public int committeeId;
        public bool checkStatus=false;
        public List<Committee> CommitteeList()
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand commiteCommand = new MySqlCommand("SELECT * FROM committees ", _connectionHelper.Connection);
            MySqlDataReader readercommittee = commiteCommand.ExecuteReader();
            List<Committee> committees = new List<Committee>();
            while (readercommittee.Read())
            {
                Committee committee = new Committee
                {
                    Id = Convert.ToInt32(readercommittee["Id"]),
                    Firstname = readercommittee["Firstname"].ToString(),
                    Lastname = readercommittee["Lastname"].ToString(),
                    Username = readercommittee["Username"].ToString(),
                    Password = _encryptionHelper.Decrypt(readercommittee["Password"].ToString()),
                    Address = readercommittee["Address"].ToString(),
                    District = readercommittee["District"].ToString(),
                    City = readercommittee["City"].ToString(),
                    IpAddress = readercommittee["IpAddress"].ToString(),
                    Status = readercommittee["Status"].ToString(),
                    DateOfBirth = readercommittee["DateOfBirth"].ToString(),
                    LastLoginDate = readercommittee["LastLoginDate"].ToString(),
                    UpdatedDate = readercommittee["UpdatedDate"].ToString(),
                    CreatedDate = readercommittee["CreatedDate"].ToString()
                };
                committees.Add(committee);
            }
            readercommittee.Close();
            _connectionHelper.Connection.Close();
            return committees;
        }
        public void AddCommittee(Committee committee)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand addCommitteeCommand =
            new MySqlCommand("INSERT INTO committees (Firstname, Lastname, Username, Password, Address, District, City, IpAddress, DateOfBirth, UpdatedDate) VALUES(@Firstname,@Lastname,@Username,@Password, @Address, @District,@City, @IpAddress, @DateOfBirth, @UpdatedDate)", _connectionHelper.Connection);
            addCommitteeCommand.Parameters.AddWithValue("@Firstname", committee.Firstname);
            addCommitteeCommand.Parameters.AddWithValue("@Lastname", committee.Lastname);
            addCommitteeCommand.Parameters.AddWithValue("@Username", committee.Username); 
            addCommitteeCommand.Parameters.AddWithValue("@Password", _encryptionHelper.Encrypt(committee.Password));
            addCommitteeCommand.Parameters.AddWithValue("@Address", committee.Address);
            addCommitteeCommand.Parameters.AddWithValue("@District", committee.District);
            addCommitteeCommand.Parameters.AddWithValue("@City", committee.City);
            addCommitteeCommand.Parameters.AddWithValue("@IpAddress", committee.IpAddress);
            addCommitteeCommand.Parameters.AddWithValue("@DateOfBirth", committee.DateOfBirth);
            addCommitteeCommand.Parameters.AddWithValue("@UpdatedDate", committee.UpdatedDate);
            addCommitteeCommand.ExecuteNonQuery();
            _connectionHelper.CloseConnection();

        }
        public void UpdateCommittee(Committee committee)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand updateCommitteeCommand =
            new MySqlCommand("UPDATE committees SET Firstname=@Firstname, Lastname=@Lastname, Password=@Password, Address=@Address, District=@District, City=@City, IpAddress=@IpAddress, DateOfBirth=@DateOfBirth, UpdatedDate=@UpdatedDate WHERE Id=@Id", _connectionHelper.Connection);
            updateCommitteeCommand.Parameters.AddWithValue("@Id", committee.Id);
            updateCommitteeCommand.Parameters.AddWithValue("@Firstname", committee.Firstname);
            updateCommitteeCommand.Parameters.AddWithValue("@Lastname", committee.Lastname); 
            updateCommitteeCommand.Parameters.AddWithValue("@Password", _encryptionHelper.Encrypt(committee.Password));
            updateCommitteeCommand.Parameters.AddWithValue("@Address", committee.Address);
            updateCommitteeCommand.Parameters.AddWithValue("@District", committee.District);
            updateCommitteeCommand.Parameters.AddWithValue("@City", committee.City);
            updateCommitteeCommand.Parameters.AddWithValue("@IpAddress", committee.IpAddress);
            updateCommitteeCommand.Parameters.AddWithValue("@DateOfBirth", committee.DateOfBirth);
            updateCommitteeCommand.Parameters.AddWithValue("@UpdatedDate", committee.UpdatedDate);
            updateCommitteeCommand.ExecuteNonQuery();
            _connectionHelper.CloseConnection();

        }
        public void CheckUserInCommittee(string Username)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand checkUserInCommitteeCommand = new MySqlCommand("SELECT * FROM committees WHERE Username=@Username", _connectionHelper.Connection);
            checkUserInCommitteeCommand.Parameters.AddWithValue("@Username", Username);
            MySqlDataReader readerCommittee = checkUserInCommitteeCommand.ExecuteReader();
            if (readerCommittee.Read())
            {
                checkStatus = true;
            }
            else
            {
                checkStatus = false;
            }
            readerCommittee.Close();
            _connectionHelper.CloseConnection();
        }
        public void DeleteCommittee(int Id)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand deleteCommitteeCommand = new MySqlCommand("DELETE FROM committees WHERE Id=@Id", _connectionHelper.Connection);
            deleteCommitteeCommand.Parameters.AddWithValue("@Id", Id);
            deleteCommitteeCommand.ExecuteNonQuery();
            _connectionHelper.CloseConnection();

        }
    }
}
