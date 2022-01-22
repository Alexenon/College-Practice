
namespace Practica.UserControls
{
    partial class Registration
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pbMail = new System.Windows.Forms.PictureBox();
            this.lblFooter_2 = new System.Windows.Forms.Label();
            this.lblFooter_1 = new System.Windows.Forms.Label();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.pbPassword2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Green;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegister.Location = new System.Drawing.Point(105, 184);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(170, 55);
            this.btnRegister.TabIndex = 61;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUsername.Location = new System.Drawing.Point(120, 56);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(175, 27);
            this.txtUsername.TabIndex = 60;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(120, 101);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(175, 27);
            this.txtPassword.TabIndex = 59;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmail.Location = new System.Drawing.Point(120, 12);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 27);
            this.txtEmail.TabIndex = 58;
            // 
            // pbMail
            // 
            this.pbMail.Image = ((System.Drawing.Image)(resources.GetObject("pbMail.Image")));
            this.pbMail.Location = new System.Drawing.Point(82, 7);
            this.pbMail.Name = "pbMail";
            this.pbMail.Size = new System.Drawing.Size(32, 32);
            this.pbMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMail.TabIndex = 57;
            this.pbMail.TabStop = false;
            // 
            // lblFooter_2
            // 
            this.lblFooter_2.AutoSize = true;
            this.lblFooter_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFooter_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFooter_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFooter_2.Location = new System.Drawing.Point(305, 250);
            this.lblFooter_2.Name = "lblFooter_2";
            this.lblFooter_2.Size = new System.Drawing.Size(30, 15);
            this.lblFooter_2.TabIndex = 56;
            this.lblFooter_2.Text = "here";
            this.lblFooter_2.Click += new System.EventHandler(this.lbl_here_Click);
            // 
            // lblFooter_1
            // 
            this.lblFooter_1.AutoSize = true;
            this.lblFooter_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFooter_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFooter_1.Location = new System.Drawing.Point(50, 250);
            this.lblFooter_1.Name = "lblFooter_1";
            this.lblFooter_1.Size = new System.Drawing.Size(259, 15);
            this.lblFooter_1.TabIndex = 55;
            this.lblFooter_1.Text = "Do you already have an account? You can log in";
            // 
            // pbPassword
            // 
            this.pbPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbPassword.Image")));
            this.pbPassword.Location = new System.Drawing.Point(82, 96);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(32, 32);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPassword.TabIndex = 54;
            this.pbPassword.TabStop = false;
            this.pbPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPassword_MouseDown);
            this.pbPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPassword_MouseUp);
            // 
            // pbUsername
            // 
            this.pbUsername.Image = ((System.Drawing.Image)(resources.GetObject("pbUsername.Image")));
            this.pbUsername.Location = new System.Drawing.Point(82, 51);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(32, 32);
            this.pbUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsername.TabIndex = 53;
            this.pbUsername.TabStop = false;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword2.Location = new System.Drawing.Point(120, 146);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(175, 27);
            this.txtPassword2.TabIndex = 63;
            // 
            // pbPassword2
            // 
            this.pbPassword2.Image = ((System.Drawing.Image)(resources.GetObject("pbPassword2.Image")));
            this.pbPassword2.Location = new System.Drawing.Point(82, 141);
            this.pbPassword2.Name = "pbPassword2";
            this.pbPassword2.Size = new System.Drawing.Size(32, 32);
            this.pbPassword2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPassword2.TabIndex = 62;
            this.pbPassword2.TabStop = false;
            this.pbPassword2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPassword2_MouseDown);
            this.pbPassword2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPassword2_MouseUp);
            // 
            // Registration
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.pbPassword2);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pbMail);
            this.Controls.Add(this.lblFooter_2);
            this.Controls.Add(this.lblFooter_1);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.pbUsername);
            this.Name = "Registration";
            this.Size = new System.Drawing.Size(380, 280);
            ((System.ComponentModel.ISupportInitialize)(this.pbMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pbMail;
        private System.Windows.Forms.Label lblFooter_2;
        private System.Windows.Forms.Label lblFooter_1;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.PictureBox pbUsername;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.PictureBox pbPassword2;
    }
}
