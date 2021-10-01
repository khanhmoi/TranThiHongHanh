
namespace Quản_lý_điểm_sinh_vien_CNTT
{
    partial class rpDiemTK
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
            this.DSDiemTK = new Quản_lý_điểm_sinh_vien_CNTT.DSDiemTK();
            this.tblKET_QUABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblKET_QUATableAdapter = new Quản_lý_điểm_sinh_vien_CNTT.DSDiemTKTableAdapters.tblKET_QUATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSDiemTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKET_QUABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSDiemTK";
            reportDataSource1.Value = this.tblKET_QUABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quản_lý_điểm_sinh_vien_CNTT.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1179, 692);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSDiemTK
            // 
            this.DSDiemTK.DataSetName = "DSDiemTK";
            this.DSDiemTK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKET_QUABindingSource
            // 
            this.tblKET_QUABindingSource.DataMember = "tblKET_QUA";
            this.tblKET_QUABindingSource.DataSource = this.DSDiemTK;
            // 
            // tblKET_QUATableAdapter
            // 
            this.tblKET_QUATableAdapter.ClearBeforeFill = true;
            // 
            // rpDiemTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 692);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rpDiemTK";
            this.Text = "rpDiemTK";
            this.Load += new System.EventHandler(this.rpDiemTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSDiemTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKET_QUABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblKET_QUABindingSource;
        private DSDiemTK DSDiemTK;
        private DSDiemTKTableAdapters.tblKET_QUATableAdapter tblKET_QUATableAdapter;
    }
}