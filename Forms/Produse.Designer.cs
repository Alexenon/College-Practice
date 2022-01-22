
namespace Practica.Forms
{
    partial class Produse
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_infoProduse = new System.Windows.Forms.Button();
            this.btn_produseTop = new System.Windows.Forms.Button();
            this.btn_avgPret = new System.Windows.Forms.Button();
            this.btn_Oferte = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(287, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produse";
            // 
            // btn_infoProduse
            // 
            this.btn_infoProduse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btn_infoProduse.FlatAppearance.BorderSize = 0;
            this.btn_infoProduse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_infoProduse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_infoProduse.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_infoProduse.Location = new System.Drawing.Point(27, 210);
            this.btn_infoProduse.Name = "btn_infoProduse";
            this.btn_infoProduse.Size = new System.Drawing.Size(161, 53);
            this.btn_infoProduse.TabIndex = 2;
            this.btn_infoProduse.Text = "Informatie produse";
            this.btn_infoProduse.UseVisualStyleBackColor = false;
            this.btn_infoProduse.Click += new System.EventHandler(this.btn_infoProduse_Click);
            // 
            // btn_produseTop
            // 
            this.btn_produseTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btn_produseTop.FlatAppearance.BorderSize = 0;
            this.btn_produseTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_produseTop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_produseTop.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_produseTop.Location = new System.Drawing.Point(27, 295);
            this.btn_produseTop.Name = "btn_produseTop";
            this.btn_produseTop.Size = new System.Drawing.Size(161, 53);
            this.btn_produseTop.TabIndex = 3;
            this.btn_produseTop.Text = "Cele mai vandute produse";
            this.btn_produseTop.UseVisualStyleBackColor = false;
            this.btn_produseTop.Click += new System.EventHandler(this.btn_produseTop_Click);
            // 
            // btn_avgPret
            // 
            this.btn_avgPret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btn_avgPret.FlatAppearance.BorderSize = 0;
            this.btn_avgPret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_avgPret.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_avgPret.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_avgPret.Location = new System.Drawing.Point(27, 373);
            this.btn_avgPret.Name = "btn_avgPret";
            this.btn_avgPret.Size = new System.Drawing.Size(161, 53);
            this.btn_avgPret.TabIndex = 4;
            this.btn_avgPret.Text = "Pretul mediu";
            this.btn_avgPret.UseVisualStyleBackColor = false;
            this.btn_avgPret.Click += new System.EventHandler(this.btn_avgPret_Click);
            // 
            // btn_Oferte
            // 
            this.btn_Oferte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btn_Oferte.FlatAppearance.BorderSize = 0;
            this.btn_Oferte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Oferte.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Oferte.Location = new System.Drawing.Point(27, 126);
            this.btn_Oferte.Name = "btn_Oferte";
            this.btn_Oferte.Size = new System.Drawing.Size(161, 53);
            this.btn_Oferte.TabIndex = 5;
            this.btn_Oferte.Text = "Oferte";
            this.btn_Oferte.UseVisualStyleBackColor = false;
            this.btn_Oferte.Click += new System.EventHandler(this.btn_Oferte_Click);
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(215, 126);
            this.panelContent.MinimumSize = new System.Drawing.Size(450, 300);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(450, 350);
            this.panelContent.TabIndex = 6;
            // 
            // Produse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(698, 498);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.btn_Oferte);
            this.Controls.Add(this.btn_avgPret);
            this.Controls.Add(this.btn_produseTop);
            this.Controls.Add(this.btn_infoProduse);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Produse";
            this.Text = "Agenti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_infoProduse;
        private System.Windows.Forms.Button btn_produseTop;
        private System.Windows.Forms.Button btn_avgPret;
        private System.Windows.Forms.Button btn_Oferte;
        private System.Windows.Forms.Panel panelContent;
    }
}