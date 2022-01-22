
namespace Practica
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_AddProdus = new System.Windows.Forms.Button();
            this.btn_Produse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_delAgent = new System.Windows.Forms.Button();
            this.btn_AddAgent = new System.Windows.Forms.Button();
            this.btn_Agenti = new System.Windows.Forms.Button();
            this.topNavPanel = new System.Windows.Forms.Panel();
            this.topNavHeader = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rightBorder = new System.Windows.Forms.Panel();
            this.bottomBorder = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.topNavPanel.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.panelSideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelSideMenu.Controls.Add(this.btn_LogOut);
            this.panelSideMenu.Controls.Add(this.btn_Export);
            this.panelSideMenu.Controls.Add(this.panel2);
            this.panelSideMenu.Controls.Add(this.btn_Produse);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Controls.Add(this.btn_Agenti);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 37);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(187, 513);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.panelSideMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.panelSideMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btn_LogOut.FlatAppearance.BorderSize = 0;
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogOut.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_LogOut.Location = new System.Drawing.Point(0, 475);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(117, 38);
            this.btn_LogOut.TabIndex = 6;
            this.btn_LogOut.Text = "Log out";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btn_Export.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Export.FlatAppearance.BorderSize = 0;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Export.Location = new System.Drawing.Point(0, 278);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(187, 55);
            this.btn_Export.TabIndex = 5;
            this.btn_Export.Text = "Exporta";
            this.btn_Export.UseVisualStyleBackColor = false;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_AddProdus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 59);
            this.panel2.TabIndex = 4;
            // 
            // btn_AddProdus
            // 
            this.btn_AddProdus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btn_AddProdus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AddProdus.FlatAppearance.BorderSize = 0;
            this.btn_AddProdus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddProdus.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_AddProdus.Location = new System.Drawing.Point(0, 0);
            this.btn_AddProdus.Name = "btn_AddProdus";
            this.btn_AddProdus.Size = new System.Drawing.Size(187, 55);
            this.btn_AddProdus.TabIndex = 1;
            this.btn_AddProdus.Text = "Adauga produs";
            this.btn_AddProdus.UseVisualStyleBackColor = false;
            this.btn_AddProdus.Click += new System.EventHandler(this.btn_AddProdus_Click);
            // 
            // btn_Produse
            // 
            this.btn_Produse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btn_Produse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Produse.FlatAppearance.BorderSize = 0;
            this.btn_Produse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Produse.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Produse.Location = new System.Drawing.Point(0, 164);
            this.btn_Produse.Name = "btn_Produse";
            this.btn_Produse.Size = new System.Drawing.Size(187, 55);
            this.btn_Produse.TabIndex = 3;
            this.btn_Produse.Text = "Produse";
            this.btn_Produse.UseVisualStyleBackColor = false;
            this.btn_Produse.Click += new System.EventHandler(this.btn_Produse_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_delAgent);
            this.panel1.Controls.Add(this.btn_AddAgent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 109);
            this.panel1.TabIndex = 2;
            // 
            // btn_delAgent
            // 
            this.btn_delAgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btn_delAgent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_delAgent.FlatAppearance.BorderSize = 0;
            this.btn_delAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delAgent.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_delAgent.Location = new System.Drawing.Point(0, 55);
            this.btn_delAgent.Name = "btn_delAgent";
            this.btn_delAgent.Size = new System.Drawing.Size(187, 55);
            this.btn_delAgent.TabIndex = 3;
            this.btn_delAgent.Text = "Sterge agent";
            this.btn_delAgent.UseVisualStyleBackColor = false;
            this.btn_delAgent.Click += new System.EventHandler(this.btn_delAgent_Click);
            // 
            // btn_AddAgent
            // 
            this.btn_AddAgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btn_AddAgent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AddAgent.FlatAppearance.BorderSize = 0;
            this.btn_AddAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddAgent.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_AddAgent.Location = new System.Drawing.Point(0, 0);
            this.btn_AddAgent.Name = "btn_AddAgent";
            this.btn_AddAgent.Size = new System.Drawing.Size(187, 55);
            this.btn_AddAgent.TabIndex = 2;
            this.btn_AddAgent.Text = "Adauga agent";
            this.btn_AddAgent.UseVisualStyleBackColor = false;
            this.btn_AddAgent.Click += new System.EventHandler(this.btn_AddAgent_Click);
            // 
            // btn_Agenti
            // 
            this.btn_Agenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btn_Agenti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Agenti.FlatAppearance.BorderSize = 0;
            this.btn_Agenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agenti.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Agenti.Location = new System.Drawing.Point(0, 0);
            this.btn_Agenti.Name = "btn_Agenti";
            this.btn_Agenti.Size = new System.Drawing.Size(187, 55);
            this.btn_Agenti.TabIndex = 1;
            this.btn_Agenti.Text = "Agenti";
            this.btn_Agenti.UseVisualStyleBackColor = false;
            this.btn_Agenti.Click += new System.EventHandler(this.btn_Agenti_Click);
            // 
            // topNavPanel
            // 
            this.topNavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.topNavPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topNavPanel.Controls.Add(this.topNavHeader);
            this.topNavPanel.Controls.Add(this.btnMinimize);
            this.topNavPanel.Controls.Add(this.btnMaximize);
            this.topNavPanel.Controls.Add(this.btnClose);
            this.topNavPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topNavPanel.Location = new System.Drawing.Point(0, 0);
            this.topNavPanel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.topNavPanel.Name = "topNavPanel";
            this.topNavPanel.Size = new System.Drawing.Size(900, 37);
            this.topNavPanel.TabIndex = 1;
            this.topNavPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.topNavPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.topNavPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            // 
            // topNavHeader
            // 
            this.topNavHeader.AutoSize = true;
            this.topNavHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topNavHeader.Location = new System.Drawing.Point(12, 8);
            this.topNavHeader.Name = "topNavHeader";
            this.topNavHeader.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.topNavHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.topNavHeader.Size = new System.Drawing.Size(105, 21);
            this.topNavHeader.TabIndex = 0;
            this.topNavHeader.Text = "Application";
            this.topNavHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.topNavHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.topNavHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.topNavHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMinimize.Location = new System.Drawing.Point(816, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnMinimize.Size = new System.Drawing.Size(28, 37);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMaximize.Location = new System.Drawing.Point(844, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(28, 37);
            this.btnMaximize.TabIndex = 5;
            this.btnMaximize.Text = "o";
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClose.Location = new System.Drawing.Point(872, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(187, 37);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(698, 498);
            this.panelContent.TabIndex = 2;
            this.panelContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.panelContent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.panelContent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Application";
            // 
            // rightBorder
            // 
            this.rightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.rightBorder.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorder.Location = new System.Drawing.Point(885, 37);
            this.rightBorder.Name = "rightBorder";
            this.rightBorder.Size = new System.Drawing.Size(15, 513);
            this.rightBorder.TabIndex = 3;
            this.rightBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SizerMouseDown);
            this.rightBorder.MouseHover += new System.EventHandler(this.SizerMouseHover);
            this.rightBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizerMouseMove);
            this.rightBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SizerMouseUp);
            // 
            // bottomBorder
            // 
            this.bottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.bottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBorder.Location = new System.Drawing.Point(187, 535);
            this.bottomBorder.Name = "bottomBorder";
            this.bottomBorder.Size = new System.Drawing.Size(698, 15);
            this.bottomBorder.TabIndex = 4;
            this.bottomBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SizerMouseDown);
            this.bottomBorder.MouseHover += new System.EventHandler(this.SizerMouseHover);
            this.bottomBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizerMouseMove);
            this.bottomBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SizerMouseUp);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.bottomBorder);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.rightBorder);
            this.Controls.Add(this.topNavPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practica";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            this.panelSideMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.topNavPanel.ResumeLayout(false);
            this.topNavPanel.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel topNavPanel;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label topNavHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel rightBorder;
        private System.Windows.Forms.Panel bottomBorder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_AddProdus;
        private System.Windows.Forms.Button btn_Produse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_AddAgent;
        private System.Windows.Forms.Button btn_Agenti;
        private System.Windows.Forms.Button btn_delAgent;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_LogOut;
    }
}

