
namespace gestionabcense
{
    partial class fps
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
            this.infoabsentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new gestionabcense.ds();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dattablefoncBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dattablefoncTableAdapter = new gestionabcense.dsTableAdapters.dattablefoncTableAdapter();
            this.infoabsentTableAdapter = new gestionabcense.dsTableAdapters.infoabsentTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.infoabsentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dattablefoncBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // infoabsentBindingSource
            // 
            this.infoabsentBindingSource.DataMember = "infoabsent";
            this.infoabsentBindingSource.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(667, 17);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(121, 34);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "طبع ااسفسار";
            this.toolTip1.SetToolTip(this.guna2Button1, "طبع استفسار مع حفض البيانات");
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "info";
            // 
            // dattablefoncBindingSource
            // 
            this.dattablefoncBindingSource.DataMember = "dattablefonc";
            this.dattablefoncBindingSource.DataSource = this.ds;
            // 
            // dattablefoncTableAdapter
            // 
            this.dattablefoncTableAdapter.ClearBeforeFill = true;
            // 
            // infoabsentTableAdapter
            // 
            this.infoabsentTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.infoabsentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "gestionabcense.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 57);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(659, 246);
            this.reportViewer1.TabIndex = 4;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(295, 13);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(322, 36);
            this.guna2DateTimePicker1.TabIndex = 5;
            this.guna2DateTimePicker1.Value = new System.DateTime(2022, 3, 25, 19, 54, 2, 778);
            // 
            // fps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 397);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.guna2Button1);
            this.Name = "fps";
            this.Text = "fps";
            this.Load += new System.EventHandler(this.fps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoabsentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dattablefoncBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dattablefoncBindingSource;
        private ds ds;
        private dsTableAdapters.dattablefoncTableAdapter dattablefoncTableAdapter;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource infoabsentBindingSource;
        private dsTableAdapters.infoabsentTableAdapter infoabsentTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
    }
}