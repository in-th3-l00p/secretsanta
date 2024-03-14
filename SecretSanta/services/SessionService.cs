using SecretSanta.domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SecretSanta.services
{
    internal class SessionService
    {
        public static void CreateTable()
        {
            (new SqlCommand(
                "IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'session') AND type in (N'U'))\n" +
                "BEGIN\n" +
                "CREATE TABLE session (" +
                    "id INT PRIMARY KEY IDENTITY (1, 1)," +
                    "name VARCHAR(255) NOT NULL," +
                    "location VARCHAR(255) NOT NULL," +
                ")" +
                "END",
                DatabaseConnection.Instance.Connection
            )).ExecuteNonQuery();
        }

        public static Session Create(
            string name,
            string location
        ) {
            int id = (int) (new SqlCommand(
                "INSERT INTO session (name, location) " +
                "OUTPUT INSERTED.ID " +
                String.Format("VALUES ('{0}', '{1}')", name, location),
                DatabaseConnection.Instance.Connection
                ))
                .ExecuteScalar();

            return Get(id);
        }

        public static int Count()
        {
            return DatabaseConnection.CountEntitites("session");
        }

        public static Session Get(int id)
        {
            var reader = (new SqlCommand(
                "SELECT * FROM session WHERE id=" + id.ToString(),
                DatabaseConnection.Instance.Connection
                ))
                .ExecuteReader();

            reader.Read();
            var session = new Session(
                reader.GetInt32(0),
                reader.GetString(1),
                reader.GetString(2)
            );
            reader.Close();

            return session;
        }

        public static Session Update(int id, string name, string location)
        {
            new SqlCommand(String.Format(
                "UPDATE session SET name = '{0}', location = '{1}' WHERE id={2}",
                name, location, id
            ), DatabaseConnection.Instance.Connection).ExecuteNonQuery();
            return Get(id);
        }
    }
}
