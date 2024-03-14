using SecretSanta.domain;
using SecretSanta.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretSanta.forms.controls
{
    public partial class UserUpdatePanel : UserControl
    {
        public delegate void UserUpdate(SessionKey newSessionKey);
        public event UserUpdate UserUpdated;

        public TextBox NameTextBox { get { return nameTextBox; } }
        public TextBox EmailTextBox { get { return emailTextBox; } }

        private SessionKey sessionKey = null;
        public SessionKey SessionKey
        {
            get { return sessionKey; }
            set { 
                this.sessionKey = value;
                nameTextBox.Text = value.Name;
                emailTextBox.Text = value.Email;
                keyTextBox.Text = value.Key;
            }
        }

        public UserUpdatePanel()
        {
            InitializeComponent();

            nameTextBox.TextChanged += (s, e) => UpdateData();
            emailTextBox.TextChanged += (s, e) => UpdateData();
        }

        private void UpdateData()
        {
            var newSessionKey = new SessionKey(sessionKey);
            newSessionKey.Name = nameTextBox.Text;
            newSessionKey.Email = emailTextBox.Text;
            SessionKeyService.Update(newSessionKey);
            UserUpdated.Invoke(newSessionKey);
        }
    }
}
