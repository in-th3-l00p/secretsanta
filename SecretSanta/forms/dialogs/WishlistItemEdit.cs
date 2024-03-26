using SecretSanta.domain;
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

namespace SecretSanta.forms.dialogs
{
    public partial class WishlistItemEdit : Form
    {
        private WishlistItem currentWishlistItem;
        public WishlistItem CurrentWishlistItem
        {
            get { return currentWishlistItem; } 
            set
            {
                this.currentWishlistItem = value;
                this.ItemTextBox.Text = value.Text;
                this.Invalidate();
            }
        }

        public WishlistItemEdit()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (this.currentWishlistItem == null)
                return;
            WishlistService.Update(currentWishlistItem.Id, ItemTextBox.Text);
            this.Close();
        }
    }
}
