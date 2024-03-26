using SecretSanta.forms;
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

namespace SecretSanta
{
    public partial class MainForm : Form
    {
        private static MainForm instance; 
        public static MainForm Instance { get { return instance; } }

        public MainForm()
        {
            instance = this;
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var formSender = sender as Form;

            var createForm = new CreateSessionForm();
            this.Hide();
            createForm.Show();
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            if (!SessionKeyService.Exists(codeTextBox.Text))
            {
                MessageBox.Show(
                    "Codul dat este invalid",
                    "Eroare",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            var sessionKey = SessionKeyService.Get(codeTextBox.Text);
            if (!sessionKey.Owner && !sessionKey.ChosenSessionKeyId.HasValue)
                return;

            if (!sessionKey.Owner)
            {
                var wishlistSessionForm = new WishlistSessionForm(codeTextBox.Text);
                this.Hide();
                wishlistSessionForm.Show();
            } else
            {
                var sessionForm = new SessionForm(codeTextBox.Text);
                this.Hide();
                sessionForm.Show();
            }
        }
    }
}
