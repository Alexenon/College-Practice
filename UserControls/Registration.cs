using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.UserControls
{
    public partial class Registration : UserControl
    {
        public Registration()
        {
            InitializeComponent();
        }

        /* Register Button */
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            string password = Practica.LoginForm.EncodePasswordToBase64(txtPassword.Text);

            if (String.IsNullOrEmpty(txtUsername.Text) 
                || String.IsNullOrEmpty(txtEmail.Text) 
                || String.IsNullOrEmpty(txtPassword.Text) 
                || String.IsNullOrEmpty(txtPassword2.Text))
            {
                MessageBox.Show("Complete All Fields!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text != txtPassword2.Text)
            {
                MessageBox.Show("The passwords doesn't match", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Practica.Classes.DatabaseCon.is_Email_Taken(txtEmail.Text))
            {
                MessageBox.Show("This email is already taken!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            // Daca lungimea fiecarui element este destul de lunga
            else if (txtUsername.Text.Length < 3 || txtEmail.Text.Length < 6 || txtPassword.Text.Length < 4)
            {
                MessageBox.Show("The name, email or password is too short", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Daca lungimea fiecarui element este destul de lunga
            else if (txtUsername.Text.Length > 12 || txtEmail.Text.Length > 12 || txtPassword.Text.Length > 12)
            {
                MessageBox.Show("The name, email or password is too long", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Daca emailul contine semnul aron sau punct
            else if (!txtEmail.Text.Contains("@") && !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("The following email doesn't exist", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                Practica.Classes.DatabaseCon.InsertUser(txtUsername.Text, txtEmail.Text, password);
                MessageBox.Show("You have now an account", "Congratulation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /* Click Here Label */
        private void lbl_here_Click(object sender, EventArgs e)
        {
            if (!LoginForm.Instance._pnlContainer.Controls.ContainsKey("Login"))
            {
                this.Parent.Controls.Add(LoginForm.lgn);
                this.Parent.Controls.Remove(this);
            }
        }

        #region Events
        private void pbPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void pbPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void pbPassword2_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword2.PasswordChar = '\0';
        }

        private void pbPassword2_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword2.PasswordChar = '*';
        }

        #endregion

    }
}
