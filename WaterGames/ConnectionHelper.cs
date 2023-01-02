using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Data;

namespace WaterGames
{
    public class ConnectionHelper
    {
        public MySqlConnection Connection;
        private string Server;
        private string Database;
        private string Username;
        private string Password;
        public ConnectionHelper()
        {
            MysqlConfiguration();
        }

        private void MysqlConfiguration()
        {
            Server = "localhost";
            Database = "watergames";
            Username = "root";
            Password = "12345678";
            string ConnectionString;
            ConnectionString = "SERVER=" + Server + ";" + "DATABASE=" +
            Database + ";" + "UID=" + Username + ";" + "PASSWORD=" + Password + ";";
            Connection = new MySqlConnection(ConnectionString);
        }

        //Open connction

        public bool OpenConnection()
        {
            try
            {
                Connection.Open(); 
                return true;
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Veritabanı bağlantısı açılırken bir sorun oluştu: " + ex.ToString());
                return false;
            }
        }

        public void CheckConnectionState()
        {
            if (Connection.State==ConnectionState.Closed)
            {
                OpenConnection();
            }
        }
        //Close connection
        public bool CloseConnection()
        {
            try
            {
                Connection.Clone();
                return true;
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Bir hata oluştu: " + ex.ToString());
                return false;
            }
        }
    }
}
