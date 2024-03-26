using SecretSanta.domain;
using SecretSanta.forms.dialogs;
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
                foreach (var wishlistItem in WishlistService.GetFromSessionKey(sessionKey))
                    wishlist.Items.Add(wishlistItem);
                if (sessionKey.ChosenSessionKeyId.HasValue)
                {
                    int id = sessionKey.ChosenSessionKeyId.GetValueOrDefault();
                    foreach (var wishlistItem in WishlistService.GetFromSessionKey(SessionKeyService.Get(id)))
                        chosenWishlist.Items.Add(wishlistItem);
                }
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
            wishlist.DisplayMember = "Text";
            wishlist.ValueMember = "Id";
            chosenWishlist.DisplayMember = "Text";
            chosenWishlist.ValueMember = "Id";
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

            for (int i = 0; i < shuffledUsers.Count - 1; i++)
                SessionKeyService.SetChosen(shuffledUsers[i], shuffledUsers[i + 1].Id); 
            SessionKeyService.SetChosen(shuffledUsers[shuffledUsers.Count - 1], shuffledUsers[0].Id); 

            var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("5b881f556a7d8b", "79a102b3b837ff"),
                EnableSsl = true
            };

            for (int i = 0; i < shuffledUsers.Count - 1; i++)
            {
                client.Send(
                    "secretsanta@test.com", shuffledUsers[i].Email, "Secret Santa",
                    shuffledUsers[i + 1].Name 
                );
            }

            client.Send(
                "secretsanta@test.com", shuffledUsers[shuffledUsers.Count - 1].Email, "Secret Santa",
                shuffledUsers[0].Name 
            );

            MessageBox.Show("Mesajele au fost trimise");
        }

        private void SessionTextChanged(object sender, EventArgs e)
        {
            SessionService.Update(session.Id, nameTextBox.Text, locationTextBox.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            WishlistItem item = WishlistService.Create(
                sessionKey, 
                "Item " + WishlistService.Count().ToString()
            );

            wishlist.Items.Add(item);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (wishlist.SelectedItem.Equals(null))
                return;
            var wishlistItem = wishlist.SelectedItem as WishlistItem;
            WishlistService.Delete(wishlistItem.Id);
            wishlist.Items.Remove(wishlist.SelectedItem);
        }

        private void wishlist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (wishlist.SelectedItems.Equals(null))
                return;
            WishlistItemEdit editDialog = new WishlistItemEdit();
            editDialog.CurrentWishlistItem = wishlist.SelectedItem as WishlistItem;
            editDialog.ShowDialog();

            wishlist.Items.Clear();
            foreach (var wishlistItem in WishlistService.GetFromSessionKey(sessionKey))
                wishlist.Items.Add(wishlistItem);
        }
    }
}
