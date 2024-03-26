using SecretSanta.domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretSanta.services
{
    internal class WishlistService
    {
        public static void CreateTable()
        {
            (new SqlCommand(
                "IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'wishlist_item') AND type in (N'U'))\n" +
                "BEGIN\n" +
                "CREATE TABLE wishlist_item (" +
                    "id INT PRIMARY KEY IDENTITY (1, 1)," +
                    "session_key_id INT NOT NULL," +
                    "text VARCHAR(255) NOT NULL," +
                ")" +
                "END",
                DatabaseConnection.Instance.Connection
            )).ExecuteNonQuery();
        }

        public static WishlistItem Create(
            SessionKey key,
            string text
        ) {
            int id = (int) (new SqlCommand(
                "INSERT INTO wishlist_item (session_key_id, text) " +
                "OUTPUT INSERTED.ID " +
                String.Format("VALUES ({0}, '{1}')", key.Id, text),
                DatabaseConnection.Instance.Connection
                ))
                .ExecuteScalar();

            return Get(id);
        }

        public static int Count()
        {
            return DatabaseConnection.CountEntitites("wishlist_item");
        }

        public static WishlistItem Get(int id)
        {
            var reader = (new SqlCommand(
                "SELECT * FROM wishlist_item WHERE id=" + id.ToString(),
                DatabaseConnection.Instance.Connection
                ))
                .ExecuteReader();

            reader.Read();
            var session = new WishlistItem(
                reader.GetInt32(0),
                reader.GetInt32(1),
                reader.GetString(2)
            );
            reader.Close();

            return session;
        }

        public static List<WishlistItem> GetFromSessionKey(SessionKey sessionKey)
        {
            var list = new List<WishlistItem>();
            var reader = (new SqlCommand(
                "SELECT * FROM wishlist_item WHERE session_key_id=" + sessionKey.Id,
                DatabaseConnection.Instance.Connection
                ))
                .ExecuteReader();
            while (reader.Read())
            {
                var session = new WishlistItem(
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetString(2)
                );
                list.Add(session);
            }
            reader.Close();
            return list;
        }

        public static WishlistItem Update(int id, string text)
        {
            new SqlCommand(String.Format(
                "UPDATE wishlist_item SET text = '{0}' WHERE id={1}",
                text, id
            ), DatabaseConnection.Instance.Connection).ExecuteNonQuery();
            return Get(id);
        }

        public static void Delete(int id)
        {
            new SqlCommand(
                String.Format("DELETE FROM wishlist_item WHERE id={0}", id), 
                DatabaseConnection.Instance.Connection
            ).ExecuteNonQuery();
        }
    }
}
