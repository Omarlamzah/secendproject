
namespace gestionabcense
{
    partial class Form3
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
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ds = new gestionabcense.ds();
            this.ddsabsentDiagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ddsabsentDiagTableAdapter = new gestionabcense.dsTableAdapters.ddsabsentDiagTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddsabsentDiagBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // guna2TrackBar1
            // 
            this.guna2TrackBar1.Location = new System.Drawing.Point(12, 289);
            this.guna2TrackBar1.Maximum = 2050;
            this.guna2TrackBar1.Minimum = 1050;
            this.guna2TrackBar1.Name = "guna2TrackBar1";
            this.guna2TrackBar1.Size = new System.Drawing.Size(300, 23);
            this.guna2TrackBar1.TabIndex = 0;
            this.guna2TrackBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.guna2TrackBar1.Value = 1050;
            this.guna2TrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ddsabsentDiagBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "gestionabcense.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(371, 253);
            this.reportViewer1.TabIndex = 3;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ddsabsentDiagBindingSource
            // 
            this.ddsabsentDiagBindingSource.DataMember = "ddsabsentDiag";
            this.ddsabsentDiagBindingSource.DataSource = this.ds;
            // 
            // ddsabsentDiagTableAdapter
            // 
            this.ddsabsentDiagTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2TrackBar1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddsabsentDiagBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ddsabsentDiagBindingSource;
        private ds ds;
        private dsTableAdapters.ddsabsentDiagTableAdapter ddsabsentDiagTableAdapter;
    }
}