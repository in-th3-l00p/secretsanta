using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretSanta.domain
{
    public class Session
    {
        private int id;
        private string name;
        private string location;

        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public string Location { get { return location; } }

        public Session() { }
        public Session(int id, string name, string location)
        {
            this.id = id;
            this.name = name;
            this.location = location;
        }
        public Session(Session other)
        {
            this.id = other.id;
            this.name = other.name;
            this.location = other.location; 
        }
    }
}
