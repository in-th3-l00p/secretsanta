using SecretSanta.domain;
using SecretSanta.forms.controls;
using SecretSanta.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretSanta
{
    public partial class SessionForm : Form
    {
        private readonly Session session;
        private SessionKey key;
        private List<SessionKey> users;

        private UserUpdatePanel userUpdatePanel = new UserUpdatePanel();

        private void InitializeComponentData()
        {
            this.sessionUpdatePanel.Session = session;
            this.sessionUpdatePanel.SessionKey = key;
            this.sessionUpdatePanel.Users = users;

            foreach (var user in users) {
                var item = new ListViewItem(user.Name);
                item.Tag = user.Id;
                this.usersList.Items.Add(item);
            }

            this.userUpdatePanel.UserUpdated += userUpdatePanel_UserUpdated;
        }

        public SessionForm(string connectKey)
        {
            key = SessionKeyService.Get(connectKey);
            session = SessionService.Get(key.SessionId);
            users = SessionKeyService.GetFromSession(session);

            InitializeComponent();
            InitializeComponentData();
        }

        public SessionForm(Session session, SessionKey key)
        {
            this.session = session;
            this.key = key;
            this.users = SessionKeyService.GetFromSession(session);

            InitializeComponent();
            InitializeComponentData();
        }

        private void SessionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            MainForm.Instance.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var sessionKey = SessionKeyService.Create(
                "User " + SessionKeyService.Count().ToString(), 
                "", 
                session.Id
                );
            var item = new ListViewItem(sessionKey.Name);
            item.Tag = sessionKey.Id;
            this.usersList.Items.Add(item);
            users.Add(sessionKey);
        }

        private void usersList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
            {
                mainLayout.Controls.Remove(userUpdatePanel);
                mainLayout.Controls.Add(sessionUpdatePanel);
                return;
            }

            var id = (int)e.Item.Tag;
            int index = 0;
            while (index <  users.Count && users[index].Id != id) 
                index++; 
            userUpdatePanel.SessionKey = new SessionKey(users[index]);

            if (mainLayout.Controls.Contains(sessionUpdatePanel))
            {
                mainLayout.Controls.Remove(sessionUpdatePanel);
                mainLayout.Controls.Add(userUpdatePanel);
            }
        }

        private void userUpdatePanel_UserUpdated(SessionKey newSessionKey)
        {
            int usersIndex = 0;
            while (usersIndex < users.Count && users[usersIndex].Id != newSessionKey.Id)
                usersIndex++;
            users[usersIndex].Name = newSessionKey.Name;
            users[usersIndex].Email = newSessionKey.Email;
            foreach (var listItem in usersList.Items)
            {
                var listViewItem = listItem as ListViewItem;
                Nullable<int> currentUserId = listViewItem.Tag as Nullable<int>;
                if (!currentUserId.HasValue)
                    return;
                var currentUser = SessionKeyService.Get(currentUserId.Value);
                if (currentUser.Id != users[usersIndex].Id)
                    continue;
                listViewItem.Text = currentUser.Name;
            }
        }
    }
}
