
namespace Practica.Forms
{
    partial class avgSalariu
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.companieDataSet1 = new Practica.CompanieDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.salariuMediuDataSet = new Practica.SalariuMediuDataSet();
            this.salariuMediuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salariuMediuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salariuMediuTableAdapter = new Practica.SalariuMediuDataSetTableAdapters.SalariuMediuTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companieDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salariuMediuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salariuMediuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salariuMediuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // companieDataSet1
            // 
            this.companieDataSet1.DataSetName = "CompanieDataSet";
            this.companieDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "avgSalary";
            reportDataSource1.Value = this.salariuMediuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Practica.Reports.ReportAvgSalariu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(71, 86);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(307, 230);
            this.reportViewer1.TabIndex = 0;
            // 
            // salariuMediuDataSet
            // 
            this.salariuMediuDataSet.DataSetName = "SalariuMediuDataSet";
            this.salariuMediuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salariuMediuDataSetBindingSource
            // 
            this.salariuMediuDataSetBindingSource.DataSource = this.salariuMediuDataSet;
            this.salariuMediuDataSetBindingSource.Position = 0;
            // 
            // salariuMediuBindingSource
            // 
            this.salariuMediuBindingSource.DataMember = "SalariuMediu";
            this.salariuMediuBindingSource.DataSource = this.salariuMediuDataSetBindingSource;
            // 
            // salariuMediuTableAdapter
            // 
            this.salariuMediuTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salariu Mediu";
            // 
            // avgSalariu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "avgSalariu";
            this.Text = "avgSalariu";
            this.Load += new System.EventHandler(this.avgSalariu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companieDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salariuMediuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salariuMediuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salariuMediuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CompanieDataSet companieDataSet1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private SalariuMediuDataSet salariuMediuDataSet;
        private System.Windows.Forms.BindingSource salariuMediuDataSetBindingSource;
        private System.Windows.Forms.BindingSource salariuMediuBindingSource;
        private SalariuMediuDataSetTableAdapters.SalariuMediuTableAdapter salariuMediuTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}