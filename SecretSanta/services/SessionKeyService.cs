using SecretSanta.domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretSanta.services
{
    internal class SessionKeyService
    {
        public static void CreateTable()
        {
            (new SqlCommand(
                "IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'session_key') AND type in (N'U'))\n" +
                "BEGIN\n" +
                "CREATE TABLE session_key (" +
                "id INT PRIMARY KEY IDENTITY (1, 1)," +
                "name VARCHAR(255) NOT NULL," +
                "email VARCHAR(255)," +
                "connect_key VARCHAR(50) NOT NULL," +
                "owner BIT NOT NULL," +
                "session_id INT NOT NULL," +
                "FOREIGN KEY (session_id) REFERENCES session(id)," +
                ")" +
                "END",
                DatabaseConnection.Instance.Connection
            )).ExecuteNonQuery();
        }

        private static Random random = new Random();

        private static string GenerateKey()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 50)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static bool KeyExists(string key)
        {
            return (int) (new SqlCommand(
                String.Format("SELECT COUNT(*) FROM session_key WHERE connect_key='{0}'", key),
                DatabaseConnection.Instance.Connection
                )).ExecuteScalar() != 0;
        }

        public static SessionKey Create(string name, string email, int sessionId, bool owner = false)
        {
            string key;
            do {
                key = GenerateKey();
            } while (KeyExists(key));

            int id = (int) (new SqlCommand(
                "INSERT INTO session_key (name, email, connect_key, session_id, owner) " +
                " OUTPUT INSERTED.ID " +
                String.Format(
                    "VALUES ('{0}', '{1}', '{2}', {3}, {4})", 
                    name, email, key, sessionId, (owner ? "1" : "0")
                ),
                DatabaseConnection.Instance.Connection
            )).ExecuteScalar();

            return Get(id);
        }

        public static int Count()
        {
            return DatabaseConnection.CountEntitites("session_key");
        }

        public static bool Exists(string connectKey)
        {
            return (int) (new SqlCommand(
                "SELECT COUNT(*) FROM session_key WHERE connect_key = '" + connectKey + "'",
                DatabaseConnection.Instance.Connection
                )).ExecuteScalar() == 1;
        }

        public static SessionKey Get(int id)
        {
            var reader = (new SqlCommand(
                "SELECT * FROM session_key WHERE id = " + id.ToString(),
                DatabaseConnection.Instance.Connection
                )).ExecuteReader();
            reader.Read();
            var sessionKey = new SessionKey(reader);
            reader.Close();
            return sessionKey;
        }

        public static SessionKey Get(string connectKey)
        {
            var reader = (new SqlCommand(
                "SELECT * FROM session_key WHERE connect_key = '" + connectKey + "'",
                DatabaseConnection.Instance.Connection
                )).ExecuteReader();
            reader.Read();
            var sessionKey = new SessionKey(reader);
            reader.Close();
            return sessionKey;
        }

        public static List<SessionKey> GetFromSession(Session session)
        {
            var reader = (new SqlCommand(
                "SELECT * FROM session_key WHERE session_id=" + session.Id.ToString(),
                DatabaseConnection.Instance.Connection
                )).ExecuteReader();
            var keys = new List<SessionKey>();
            while (reader.Read())
                keys.Add(new SessionKey(reader));
            reader.Close();
            return keys;
        }

        public static void Update(SessionKey sessionKey)
        {
            (new SqlCommand(
                String.Format(
                    "UPDATE session_key SET name = '{0}', email = '{1}' WHERE id = {2}",
                    sessionKey.Name, sessionKey.Email, sessionKey.Id
                ),
                DatabaseConnection.Instance.Connection
            )).ExecuteNonQuery();
        }
    }
}
