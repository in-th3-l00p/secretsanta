using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SecretSanta.domain
{
    internal class WishlistItem
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int sessionKeyId;
        public int SessionKeyId 
        {
            get { return  sessionKeyId; }
            set { sessionKeyId = value; }
        }

        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public WishlistItem()
        {

        }

        public WishlistItem(int id, int sessionKeyId, string text)
        {
            Id = id;
            SessionKeyId = sessionKeyId;
            Text = text;
        }

        public WishlistItem(WishlistItem other)
        {
            this.Id = other.Id;
            this.SessionKeyId = other.SessionKeyId;
            this.Text = other.Text;
        }
    }
}
