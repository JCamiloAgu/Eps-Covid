using MySql.Data.MySqlClient;
using System.Configuration;

namespace CitasEps.Services
{
    class ConnectionService
    {
        private readonly string server = ConfigurationManager.AppSettings.Get("db_server");
        private readonly string database = ConfigurationManager.AppSettings.Get("db_database");
        private readonly string port = ConfigurationManager.AppSettings.Get("db_port");
        private readonly string user = ConfigurationManager.AppSettings.Get("db_user");
        private readonly string password = ConfigurationManager.AppSettings.Get("db_password");
        private readonly MySqlConnection connection = new MySqlConnection();

        public MySqlConnection Open()
        {
            string stringConnection = string.Format("Server={0}; Database={1}; Uid={2}; Pwd={3}; port={4};", server, database, user, password, port);
            connection.ConnectionString = stringConnection;
            connection.Open();
            return connection;
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
