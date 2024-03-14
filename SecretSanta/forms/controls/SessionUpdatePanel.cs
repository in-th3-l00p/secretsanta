using SecretSanta.domain;
using SecretSanta.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretSanta.forms.controls
{
    public partial class SessionUpdatePanel : UserControl
    {
        private static Random random = new Random();
        public TextBox NameTextBox { get { return nameTextBox; } }
        public TextBox LocationTextBox { get { return locationTextBox; } }
        public TextBox KeyTextBox { get { return keyTextBox; } }

        private Session session;
        public Session Session 
        {
            get { return session; }
            set
            {
                session = value;
                if (session == null)
                    return;
                nameTextBox.Text = value.Name;
                locationTextBox.Text = value.Location;
            }
        }

        private SessionKey sessionKey;
        public SessionKey SessionKey
        {
            get { return sessionKey; }
            set
            {
                sessionKey = value;
                if (sessionKey == null)
                    return;
                keyTextBox.Text = value.Key;
            }
        }

        private List<SessionKey> users;
        public List<SessionKey> Users
        {
            get { return users; }
            set { users = value; }
        }

        public SessionUpdatePanel()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            foreach (var user in users)
            {
                try
                {
                    new MailAddress(user.Email);
                } catch
                {
                    valid = false;
                    break;
                }
            }

            if (!valid)
            {
                MessageBox.Show(
                    "Utilizatorii au adrese de email invalide",
                    "Eroare",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            List<SessionKey> shuffledUsers = new List<SessionKey>();
            foreach (var user in users)
                shuffledUsers.Add(new SessionKey(user));
            for (int hi = shuffledUsers.Count - 1; hi >= 0; hi--)
            {
                int lo = random.Next(0, hi);
                var aux = shuffledUsers[hi];
                shuffledUsers[hi] = shuffledUsers[lo];
                shuffledUsers[lo] = aux;
            }

            var client = new SmtpClient("live.smtp.mailtrap.io", 587)
            {
                Credentials = new NetworkCredential("api", "f4bcb542ceee2d7f953d17f1192e8f09"),
                EnableSsl = true
            };

            for (int i = 0; i < shuffledUsers.Count - 1; i++)
            {
                client.Send(
                    "mailtrap@demomailtrap.com", shuffledUsers[i].Email, "Secret Santa",
                    shuffledUsers[i + 1].Name 
                );
            }

            client.Send(
                "mailtrap@demomailtrap.com", shuffledUsers[shuffledUsers.Count - 1].Email, "Secret Santa",
                shuffledUsers[0].Name 
            );

            MessageBox.Show("Mesajele au fost trimise");
        }

        private void SessionTextChanged(object sender, EventArgs e)
        {
            SessionService.Update(session.Id, nameTextBox.Text, locationTextBox.Text);
        }
    }
}
