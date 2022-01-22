
namespace Practica.Forms
{
    partial class Export
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.companieDataSet = new Practica.CompanieDataSet();
            this.agentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentiTableAdapter = new Practica.CompanieDataSetTableAdapters.AgentiTableAdapter();
            this.companieDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OferteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProduseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.companieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OferteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProduseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Gray;
            reportDataSource1.Name = "Agenti";
            reportDataSource1.Value = this.agentiBindingSource;
            reportDataSource2.Name = "Oferte";
            reportDataSource2.Value = this.OferteBindingSource;
            reportDataSource3.Name = "Produse";
            reportDataSource3.Value = this.ProduseBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Practica.Reports.ReportAgenti.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(26, 53);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(650, 370);
            this.reportViewer1.TabIndex = 0;
            // 
            // companieDataSet
            // 
            this.companieDataSet.DataSetName = "CompanieDataSet";
            this.companieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentiBindingSource
            // 
            this.agentiBindingSource.DataMember = "Agenti";
            this.agentiBindingSource.DataSource = this.companieDataSet;
            // 
            // agentiTableAdapter
            // 
            this.agentiTableAdapter.ClearBeforeFill = true;
            // 
            // companieDataSetBindingSource
            // 
            this.companieDataSetBindingSource.DataSource = this.companieDataSet;
            this.companieDataSetBindingSource.Position = 0;
            // 
            // OferteBindingSource
            // 
            this.OferteBindingSource.DataMember = "Oferte";
            this.OferteBindingSource.DataSource = this.companieDataSet;
            // 
            // ProduseBindingSource
            // 
            this.ProduseBindingSource.DataMember = "Produse";
            this.ProduseBindingSource.DataSource = this.companieDataSet;
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(698, 498);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Export";
            this.Text = "Export";
            this.Load += new System.EventHandler(this.Export_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OferteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProduseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CompanieDataSet companieDataSet;
        private System.Windows.Forms.BindingSource agentiBindingSource;
        private CompanieDataSetTableAdapters.AgentiTableAdapter agentiTableAdapter;
        private System.Windows.Forms.BindingSource companieDataSetBindingSource;
        private System.Windows.Forms.BindingSource OferteBindingSource;
        private System.Windows.Forms.BindingSource ProduseBindingSource;
    }
}