using Practica.Forms;
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

namespace Practica
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            customizeDesign();
            // Discord App
            // https://discord.com/branding
            // Gray Colors
            // https://www.w3schools.com/colors/colors_shades.asp
            // https://www.color-hex.com/color-palette/184
        }

        private void customizeDesign()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            //...
        }

        #region topNav

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

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

        #region sizeForm

        private int Mx, My, Sw, Sh;
        private bool mov;

        private void SizerMouseHover(object sender, EventArgs e)
        {
            /* Adjusting toolTip */
            ToolTip toolTip = new ToolTip();
            toolTip.ToolTipIcon = ToolTipIcon.None;
            toolTip.IsBalloon = true;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(bottomBorder, "Resize as you like");
        }

        void SizerMouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            My = MousePosition.Y;
            Mx = MousePosition.X;
            Sw = Width;
            Sh = Height;
            btnClose.Visible = false;
            btnMinimize.Visible = false;
            btnMaximize.Visible = false;
        }

        void SizerMouseMove(object sender, MouseEventArgs e)
        {
            if (mov == true)
            {
                Width = MousePosition.X - Mx + Sw;
                Height = MousePosition.Y - My + Sh;
            }
        }

        void SizerMouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
            btnClose.Visible = true;
            btnMinimize.Visible = true;
            btnMaximize.Visible = true;
        }
        #endregion

        #region Menu

        private void hideSubMenu()
        {
            if (panel1.Visible == true)
                panel1.Visible = false;
            if (panel2.Visible == true)
                panel2.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }




        /* AGENT PANEL */
        private void btn_Agenti_Click(object sender, EventArgs e)
        {
            showSubMenu(panel1);
            openChildForm(new AgentiForm());
        }

        private void btn_delAgent_Click(object sender, EventArgs e)
        {
            openChildForm(new delAgent());
            hideSubMenu();
        }

        private void btn_AddAgent_Click(object sender, EventArgs e)
        {
            AddAgent agent = new AddAgent();
            agent.Show();
            hideSubMenu();
        }

        /* PRODUS PANEL */
        private void btn_Produse_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            showSubMenu(panel2);
            openChildForm(new Produse());
        }

        private void btn_AddProdus_Click(object sender, EventArgs e)
        {
            AddProdus produs = new AddProdus();
            produs.Show();
            hideSubMenu();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            openChildForm(new Export());
            hideSubMenu();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            string rootFolder = @"C:\Data\";
            string authorsFile = "0552.txt";

            try
            {
                // Check if file exists with its full path    
                if (File.Exists(Path.Combine(rootFolder, authorsFile)))
                {
                    // If file found, delete it    
                    File.Delete(Path.Combine(rootFolder, authorsFile));
                    Console.WriteLine("File deleted.");
                }
                else Console.WriteLine("File not found");
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }

            // Close the app anyway
            Application.Exit();
        }

        #endregion
    }

}
