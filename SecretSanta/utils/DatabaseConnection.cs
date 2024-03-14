using SecretSanta.services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretSanta
{
    internal class DatabaseConnection
    {
        private SqlConnection connection;
        public SqlConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        } 

        private static DatabaseConnection instance = null;
        public static DatabaseConnection Instance
        {
            get { return instance; }
        }

        private DatabaseConnection(string connectionString)
        {
            this.connection = new SqlConnection(connectionString);
        }

        public static void Initialize()
        {
            instance = new DatabaseConnection(
                "Server = localhost\\MSSQLSERVER01; Database = master; Trusted_Connection = True;"
            );
            instance.Connection.Open();

            SessionService.CreateTable();
            SessionKeyService.CreateTable();
        }

        public static int CountEntitites(string table)
        {
            return (int) (new SqlCommand(
                "SELECT COUNT(*) FROM " + table,
                DatabaseConnection.Instance.Connection
                )).ExecuteScalar();
        }
    }
}
