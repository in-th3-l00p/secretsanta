using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretSanta.domain
{
    public class SessionKey
    {
        private int id;
        private string name;
        private string email;
        private string key;
        private int sessionId;
        private bool owner;

        public int Id { get { return id; } }
        public string Name { 
            get { return name; } 
            set { name = value; }
        }
        public string Email { 
            get { return email; } 
            set { email = value; }
        }
        public string Key { get { return key; } }
        public int SessionId { get { return sessionId; } }
        public bool Owner { get { return owner; } }

        public SessionKey() { }
        public SessionKey(int id, string name, string email, string key, int sessionId, bool owner)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.key = key;
            this.sessionId = sessionId;
            this.owner = owner;
        }
        public SessionKey(SessionKey other)
        {
            this.id = other.id;
            this.name = other.name;
            this.email = other.email;
            this.key = other.key;
            this.sessionId = other.sessionId;
            this.owner = other.owner;
        }

        public SessionKey(SqlDataReader reader)
        {
            this.id = reader.GetInt32(0);
            this.name = reader.GetString(1);
            this.email = reader.GetString(2);
            this.key = reader.GetString(3);
            this.owner = reader.GetBoolean(4);
            this.sessionId = reader.GetInt32(5);
        }
    }
}
