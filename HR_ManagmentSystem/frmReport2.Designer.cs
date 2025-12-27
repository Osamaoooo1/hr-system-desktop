namespace HR_ManagmentSystem
{
    partial class frmReport2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport2));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KxP_hrDataSetView = new HR_ManagmentSystem.KxP_hrDataSetView();
            this.AttenEmpViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AttenEmpViewTableAdapter = new HR_ManagmentSystem.KxP_hrDataSetViewTableAdapters.AttenEmpViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KxP_hrDataSetView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttenEmpViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.AttenEmpViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HR_ManagmentSystem.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(886, 477);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // KxP_hrDataSetView
            // 
            this.KxP_hrDataSetView.DataSetName = "KxP_hrDataSetView";
            this.KxP_hrDataSetView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AttenEmpViewBindingSource
            // 
            this.AttenEmpViewBindingSource.DataMember = "AttenEmpView";
            this.AttenEmpViewBindingSource.DataSource = this.KxP_hrDataSetView;
            // 
            // AttenEmpViewTableAdapter
            // 
            this.AttenEmpViewTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 477);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReport2";
            this.Text = "طباعة نتائج بحث الحضور";
            this.Load += new System.EventHandler(this.frmReport2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KxP_hrDataSetView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttenEmpViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AttenEmpViewBindingSource;
        private KxP_hrDataSetViewTableAdapters.AttenEmpViewTableAdapter AttenEmpViewTableAdapter;
        public KxP_hrDataSetView KxP_hrDataSetView;

    }
}