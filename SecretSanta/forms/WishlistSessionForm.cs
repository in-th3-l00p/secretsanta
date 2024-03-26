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

namespace SecretSanta.forms
{
    public partial class WishlistSessionForm : Form
    {
        private SessionKey sessionKey;
        public WishlistSessionForm(string connectKey)
        {
            InitializeComponent();
            this.sessionKey = SessionKeyService.Get(connectKey);
            wishlistPanel.SessionKey = this.sessionKey;
        }

        private void WishlistSessionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            MainForm.Instance.Show();
        }
    }
}
