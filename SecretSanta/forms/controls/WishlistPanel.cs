using SecretSanta.domain;
using SecretSanta.forms.dialogs;
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

namespace SecretSanta.forms.controls
{
    public partial class WishlistPanel : UserControl
    {
        private SessionKey sessionKey;
        public SessionKey SessionKey
        {
            get { return sessionKey; }
            set
            {
                this.sessionKey = value;
                if (this.sessionKey == null)
                    return;
                foreach (var wishlistItem in WishlistService.GetFromSessionKey(this.sessionKey))
                    wishlist.Items.Add(wishlistItem);
                if (sessionKey.ChosenSessionKeyId.HasValue)
                {
                    int id = sessionKey.ChosenSessionKeyId.GetValueOrDefault();
                    foreach (var wishlistItem in WishlistService.GetFromSessionKey(SessionKeyService.Get(id)))
                        chosenWishlist.Items.Add(wishlistItem);
                }
            }
        }

        public WishlistPanel()
        {
            InitializeComponent();
            wishlist.DisplayMember = "Text";
            wishlist.ValueMember = "Id";
            chosenWishlist.DisplayMember = "Text";
            chosenWishlist.ValueMember = "Id";
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
