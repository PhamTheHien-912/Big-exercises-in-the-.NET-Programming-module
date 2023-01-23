
namespace Detai
{
    partial class InBaiBao
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLDT1 = new Detai.QLDT1();
            this.View_3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_3TableAdapter = new Detai.QLDT1TableAdapters.View_3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLDT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Detai.InBaiBaoBC.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1343, 534);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLDT1
            // 
            this.QLDT1.DataSetName = "QLDT1";
            this.QLDT1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_3BindingSource
            // 
            this.View_3BindingSource.DataMember = "View_3";
            this.View_3BindingSource.DataSource = this.QLDT1;
            // 
            // View_3TableAdapter
            // 
            this.View_3TableAdapter.ClearBeforeFill = true;
            // 
            // InBaiBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 534);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InBaiBao";
            this.Text = "InBaiBao";
            this.Load += new System.EventHandler(this.InBaiBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLDT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_3BindingSource;
        private QLDT1 QLDT1;
        private QLDT1TableAdapters.View_3TableAdapter View_3TableAdapter;
    }
}