
namespace Practica.Forms
{
    partial class AgentiForm
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
            this.btn_smallAgent = new System.Windows.Forms.Button();
            this.btn_Pensionari = new System.Windows.Forms.Button();
            this.btn_avgSalariu = new System.Windows.Forms.Button();
            this.btn_infoAgent = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_smallAgent
            // 
            this.btn_smallAgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btn_smallAgent.FlatAppearance.BorderSize = 0;
            this.btn_smallAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_smallAgent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_smallAgent.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_smallAgent.Location = new System.Drawing.Point(27, 210);
            this.btn_smallAgent.Name = "btn_smallAgent";
            this.btn_smallAgent.Size = new System.Drawing.Size(161, 53);
            this.btn_smallAgent.TabIndex = 2;
            this.btn_smallAgent.Text = "Cel mai tanar agent";
            this.btn_smallAgent.UseVisualStyleBackColor = false;
            this.btn_smallAgent.Click += new System.EventHandler(this.btn_smallAgent_Click);
            // 
            // btn_Pensionari
            // 
            this.btn_Pensionari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btn_Pensionari.FlatAppearance.BorderSize = 0;
            this.btn_Pensionari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pensionari.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Pensionari.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Pensionari.Location = new System.Drawing.Point(27, 295);
            this.btn_Pensionari.Name = "btn_Pensionari";
            this.btn_Pensionari.Size = new System.Drawing.Size(161, 53);
            this.btn_Pensionari.TabIndex = 3;
            this.btn_Pensionari.Text = "Afisarea pensionarilor";
            this.btn_Pensionari.UseVisualStyleBackColor = false;
            this.btn_Pensionari.Click += new System.EventHandler(this.btn_Pensionari_Click);
            // 
            // btn_avgSalariu
            // 
            this.btn_avgSalariu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btn_avgSalariu.FlatAppearance.BorderSize = 0;
            this.btn_avgSalariu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_avgSalariu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_avgSalariu.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_avgSalariu.Location = new System.Drawing.Point(27, 373);
            this.btn_avgSalariu.Name = "btn_avgSalariu";
            this.btn_avgSalariu.Size = new System.Drawing.Size(161, 53);
            this.btn_avgSalariu.TabIndex = 4;
            this.btn_avgSalariu.Text = "Salariu mediu";
            this.btn_avgSalariu.UseVisualStyleBackColor = false;
            this.btn_avgSalariu.Click += new System.EventHandler(this.btn_avgSalariu_Click);
            // 
            // btn_infoAgent
            // 
            this.btn_infoAgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btn_infoAgent.FlatAppearance.BorderSize = 0;
            this.btn_infoAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_infoAgent.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_infoAgent.Location = new System.Drawing.Point(27, 126);
            this.btn_infoAgent.Name = "btn_infoAgent";
            this.btn_infoAgent.Size = new System.Drawing.Size(161, 53);
            this.btn_infoAgent.TabIndex = 5;
            this.btn_infoAgent.Text = "Informartie agent";
            this.btn_infoAgent.UseVisualStyleBackColor = false;
            this.btn_infoAgent.Click += new System.EventHandler(this.btn_infoAgent_Click);
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(215, 126);
            this.panelContent.MinimumSize = new System.Drawing.Size(450, 300);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(450, 350);
            this.panelContent.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(306, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Agenti";
            // 
            // AgentiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(698, 498);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.btn_infoAgent);
            this.Controls.Add(this.btn_avgSalariu);
            this.Controls.Add(this.btn_Pensionari);
            this.Controls.Add(this.btn_smallAgent);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AgentiForm";
            this.Text = "Agenti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_smallAgent;
        private System.Windows.Forms.Button btn_Pensionari;
        private System.Windows.Forms.Button btn_avgSalariu;
        private System.Windows.Forms.Button btn_infoAgent;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label2;
    }
}