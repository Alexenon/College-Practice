using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.UserControls
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        /* Login Button */
        private void btnLogin_Click(object sender, EventArgs e)
        {

            LoginForm lg = new LoginForm();
            string password = Practica.LoginForm.EncodePasswordToBase64(txtPassword.Text);

            // If Login and Email Labels are not empty
            if (String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Complete All Fields!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // If Login And Passwords are Correct
            else if (Practica.Classes.DatabaseCon.is_Email_Password_Correct(txtEmail.Text, password))
            {

                // Open Another Form and close login form
                var App = new FormMain();
                App.Show();
                Application.OpenForms["LoginForm"].Hide();

                if (checkBox1.Checked)
                {
                    addFile(Practica.Classes.DatabaseCon.selectUser(txtEmail.Text));
                }
            }

            else
            {
                MessageBox.Show("Email or Password is incorect!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /* Click Here Label */
        private void lblFooter_2_Click(object sender, EventArgs e)
        {
            // Denumirea la Mapa punct denumire Forma
            if (!LoginForm.Instance._pnlContainer.Controls.ContainsKey("Registration"))
            {
                this.Parent.Controls.Add(LoginForm.rgs);
                this.Parent.Controls.Remove(this);
            }

        }

        private static void addFile(string idUser)
        {
            string fileName = @"C:\data\0552.txt";

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes(idUser);
                    fs.Write(title, 0, title.Length);
                }

                // Open the stream and read it back.    
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
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


        #endregion

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
