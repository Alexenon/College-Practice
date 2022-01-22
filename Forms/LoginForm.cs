using Practica.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private static LoginForm _obj;
        public static UserControls.Login lgn;
        public static UserControls.Registration rgs;

        public static string EncodePasswordToBase64(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        //public Panel mainPanel = 

        public static LoginForm Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new LoginForm();
                }
                return _obj;
            }
        }

        public Panel _pnlContainer
        {
            get { return pnlContainer; }
            set { pnlContainer = value; }
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Login Lg = new Login();
            //pnlContainer.AutoSize = false;
            //pnlContainer.Controls.Add(Lg);

            lgn = new UserControls.Login();
            rgs = new UserControls.Registration();
            _pnlContainer.Controls.Add(lgn);


        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region moveForm

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

    }
}
