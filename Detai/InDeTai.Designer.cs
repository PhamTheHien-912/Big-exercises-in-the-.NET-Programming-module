
namespace Detai
{
    partial class InDeTai
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
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLDT1 = new Detai.QLDT1();
            this.View_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_2TableAdapter = new Detai.QLDT1TableAdapters.View_2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLDT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_2BindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Detai.InbaocaoDeTai.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(2, 12);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1517, 437);
            this.reportViewer2.TabIndex = 0;
            // 
            // QLDT1
            // 
            this.QLDT1.DataSetName = "QLDT1";
            this.QLDT1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_2BindingSource
            // 
            this.View_2BindingSource.DataMember = "View_2";
            this.View_2BindingSource.DataSource = this.QLDT1;
            // 
            // View_2TableAdapter
            // 
            this.View_2TableAdapter.ClearBeforeFill = true;
            // 
            // InDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 450);
            this.Controls.Add(this.reportViewer2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InDeTai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In danh sách đề tài khoa học";
            this.Load += new System.EventHandler(this.InDeTai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLDT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource View_2BindingSource;
        private QLDT1 QLDT1;
        private QLDT1TableAdapters.View_2TableAdapter View_2TableAdapter;
    }
}