namespace MainMenu
{
    partial class FormReportes
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
            this.ClinicaDataBaseDataSet = new MainMenu.ClinicaDataBaseDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClinicaDataBaseDataSet2 = new MainMenu.ClinicaDataBaseDataSet2();
            this.PATOLOGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PATOLOGIATableAdapter = new MainMenu.ClinicaDataBaseDataSet2TableAdapters.PATOLOGIATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaDataBaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PATOLOGIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClinicaDataBaseDataSet
            // 
            this.ClinicaDataBaseDataSet.DataSetName = "ClinicaDataBaseDataSet";
            this.ClinicaDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetPatologia";
            reportDataSource1.Value = this.PATOLOGIABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MainMenu.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 8);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(678, 412);
            this.reportViewer1.TabIndex = 0;
            // 
            // ClinicaDataBaseDataSet2
            // 
            this.ClinicaDataBaseDataSet2.DataSetName = "ClinicaDataBaseDataSet2";
            this.ClinicaDataBaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PATOLOGIABindingSource
            // 
            this.PATOLOGIABindingSource.DataMember = "PATOLOGIA";
            this.PATOLOGIABindingSource.DataSource = this.ClinicaDataBaseDataSet2;
            // 
            // PATOLOGIATableAdapter
            // 
            this.PATOLOGIATableAdapter.ClearBeforeFill = true;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 432);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicaDataBaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PATOLOGIABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ClinicaDataBaseDataSet ClinicaDataBaseDataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PATOLOGIABindingSource;
        private ClinicaDataBaseDataSet2 ClinicaDataBaseDataSet2;
        private ClinicaDataBaseDataSet2TableAdapters.PATOLOGIATableAdapter PATOLOGIATableAdapter;
    }
}