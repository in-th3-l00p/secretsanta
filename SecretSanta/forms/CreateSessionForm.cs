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

namespace SecretSanta
{
    public partial class CreateSessionForm : Form
    {
        public CreateSessionForm()
        {
            InitializeComponent();
        }

        private static void LengthErrorMessageBox(string field)
        {
            MessageBox.Show(
                field + " trebuie sa aiba o dimensiune intre 1 si 255 de caractere", 
                "Eroare", 
                MessageBoxButtons.OK, MessageBoxIcon.Error
            );
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            var location = locationTextBox.Text;
            var ownerName = yourNameTextBox.Text;
            var ownerEmail = yourEmailTextBox.Text;

            // validation
            if (name.Length < 1 || name.Length > 255) 
            {
                LengthErrorMessageBox("Numele");
                return;
            }

            if (location.Length < 1 || location.Length > 255) 
            {
                LengthErrorMessageBox("Locatia");
                return;
            }

            if (ownerName.Length < 1 || ownerName.Length > 255) 
            {
                LengthErrorMessageBox("Numele tau");
                return;
            }

            if (ownerEmail.Length < 1 || ownerEmail.Length > 255)
            {
                LengthErrorMessageBox("Emailul tau");
                return;
            }

            var session = SessionService.Create(name, location);
            var sessionKey = SessionKeyService.Create(ownerName, ownerEmail, session.Id, true);
            var sessionForm = new SessionForm(session, sessionKey);

            this.Dispose();
            sessionForm.Show();
        }

        private void CreateSessionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            MainForm.Instance.Show();
        }
    }
}
