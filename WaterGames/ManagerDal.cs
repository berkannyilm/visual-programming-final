using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WaterGames
{
    public class ManagerDal
    {
        ConnectionHelper _connectionHelper = new ConnectionHelper();
        EncryptionHelper _encryptionHelper = new EncryptionHelper();
        public bool checkStatus = false; 
        public List<Manager> GetAllManagers()
        {
            _connectionHelper.CheckConnectionState(); 
            MySqlCommand managerCommand = new MySqlCommand("SELECT * FROM managers", _connectionHelper.Connection);
            MySqlDataReader readerManager = managerCommand.ExecuteReader();
            List<Manager> managers = new List<Manager>();
            while (readerManager.Read())
            {
                Manager manager = new Manager
                {
                    Id = Convert.ToInt32(readerManager["id"]),
                    Firstname = readerManager["Firstname"].ToString(),
                    Lastname = readerManager["Lastname"].ToString(),
                    Username = readerManager["Username"].ToString(),
                    Password = _encryptionHelper.Decrypt(readerManager["Password"].ToString()),
                    IpAddress = readerManager["IpAddress"].ToString(),
                    LastLoginDate = readerManager["LastLoginDate"].ToString(),
                    UpdatedDate = readerManager["UpdatedDate"].ToString(),
                    CreatedDate = readerManager["CreatedDate"].ToString()
                };
                managers.Add(manager);
            }
            readerManager.Close();
            _connectionHelper.Connection.Close();
            return managers;

        }
 
        public void AddManager(Manager manager)
        {
            _connectionHelper.CheckConnectionState(); 
            MySqlCommand addManagerCommand=
            new MySqlCommand("INSERT INTO managers (Firstname, Lastname, Username, Password, IpAddress, UpdatedDate ) VALUES(@Firstname,@Lastname,@Username,@Password,@IpAddress, @UpdatedDate)", _connectionHelper.Connection);
            addManagerCommand.Parameters.AddWithValue("@FirstName",manager.Firstname);
            addManagerCommand.Parameters.AddWithValue("@Lastname", manager.Lastname);
            addManagerCommand.Parameters.AddWithValue("@Username", manager.Username);
            addManagerCommand.Parameters.AddWithValue("@Password", _encryptionHelper.Encrypt(manager.Password));
            addManagerCommand.Parameters.AddWithValue("@IpAddress", manager.IpAddress);
            addManagerCommand.Parameters.AddWithValue("@UpdatedDate", manager.UpdatedDate);
            addManagerCommand.ExecuteNonQuery();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
            _connectionHelper.CloseConnection();
            
        }
        public void UpdateManager(Manager manager)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand updateManagerCommand = new MySqlCommand("UPDATE managers SET Firstname=@Firstname, Lastname=@Lastname, Password=@Password, IpAddress=@IpAddress, UpdatedDate=@UpdatedDate  WHERE Id=@Id", _connectionHelper.Connection);
            updateManagerCommand.Parameters.AddWithValue("@Id", manager.Id);
            updateManagerCommand.Parameters.AddWithValue("@FirstName", manager.Firstname);
            updateManagerCommand.Parameters.AddWithValue("@Lastname", manager.Lastname);
            updateManagerCommand.Parameters.AddWithValue("@Password", _encryptionHelper.Encrypt(manager.Password));
            updateManagerCommand.Parameters.AddWithValue("@IpAddress", manager.IpAddress);
            updateManagerCommand.Parameters.AddWithValue("@UpdatedDate", manager.UpdatedDate);
            updateManagerCommand.ExecuteNonQuery();
            _connectionHelper.CloseConnection();

        }
        public void DeleteManager(int Id)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand deleteManagerCommand = new MySqlCommand("DELETE FROM managers  WHERE Id=@Id", _connectionHelper.Connection);
            deleteManagerCommand.Parameters.AddWithValue("@Id",Id);
            deleteManagerCommand.ExecuteNonQuery();
            _connectionHelper.CloseConnection();

        }
        public void GetManager(Manager manager)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand getManagerCommand = new MySqlCommand("SELECT * FROM managers WHERE Username=@Username AND Password=@Password", _connectionHelper.Connection);
            getManagerCommand.Parameters.AddWithValue("@Username", manager.Username);
            getManagerCommand.Parameters.AddWithValue("@Password", _encryptionHelper.Encrypt(manager.Password));
            MySqlDataReader readerManager = getManagerCommand.ExecuteReader();
            if (readerManager.Read())
            {  
                checkStatus = true;
            }
            else
            {
                checkStatus = false;
            }
            readerManager.Close();
            _connectionHelper.CloseConnection();
        }
        public void CheckUserInManager(string Username)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand checkUserInManagerCommand = new MySqlCommand("SELECT * FROM managers WHERE Username=@Username", _connectionHelper.Connection);
            checkUserInManagerCommand.Parameters.AddWithValue("@Username", Username);
            MySqlDataReader readerManager = checkUserInManagerCommand.ExecuteReader();
            if (readerManager.Read())
            {
                checkStatus = true;
            }
            else
            {
                checkStatus = false;
            }
          
            readerManager.Close();
            _connectionHelper.CloseConnection(); 
        }

        public void UpdateLoginManager(Manager manager)
        {
            _connectionHelper.CheckConnectionState();
            MySqlCommand updateLoginManagerCommand = new MySqlCommand("UPDATE managers SET LastLoginDate=@LastLoginDate, IpAddress=@IpAddress WHERE Username=@Username", _connectionHelper.Connection);
            updateLoginManagerCommand.Parameters.AddWithValue("@Username", manager.Username);
            updateLoginManagerCommand.Parameters.AddWithValue("@IpAddress", manager.IpAddress);
            updateLoginManagerCommand.Parameters.AddWithValue("@LastLoginDate", manager.LastLoginDate);
            updateLoginManagerCommand.ExecuteNonQuery();
            _connectionHelper.CloseConnection();
        }
    }
}
