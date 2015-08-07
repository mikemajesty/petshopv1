namespace View.Enum.UI.Relatorio
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            this.scalarQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatorios = new View.Enum.Relatorios();
            this.pnlRelatorio = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ptbComprar = new System.Windows.Forms.PictureBox();
            this.scalarQueryTableAdapter = new View.Enum.RelatoriosTableAdapters.ScalarQueryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.scalarQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorios)).BeginInit();
            this.pnlRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbComprar)).BeginInit();
            this.SuspendLayout();
            // 
            // scalarQueryBindingSource
            // 
            this.scalarQueryBindingSource.DataMember = "ScalarQuery";
            this.scalarQueryBindingSource.DataSource = this.relatorios;
            // 
            // relatorios
            // 
            this.relatorios.DataSetName = "Relatorios";
            this.relatorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlRelatorio
            // 
            this.pnlRelatorio.Controls.Add(this.reportViewer1);
            this.pnlRelatorio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRelatorio.Location = new System.Drawing.Point(0, 83);
            this.pnlRelatorio.Name = "pnlRelatorio";
            this.pnlRelatorio.Size = new System.Drawing.Size(610, 255);
            this.pnlRelatorio.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Compras";
            reportDataSource1.Value = this.scalarQueryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "View.Enum.UI.Relatorio.rpvCompras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(610, 255);
            this.reportViewer1.TabIndex = 1;
            // 
            // ptbComprar
            // 
            this.ptbComprar.Image = ((System.Drawing.Image)(resources.GetObject("ptbComprar.Image")));
            this.ptbComprar.Location = new System.Drawing.Point(46, 2);
            this.ptbComprar.Name = "ptbComprar";
            this.ptbComprar.Size = new System.Drawing.Size(522, 75);
            this.ptbComprar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbComprar.TabIndex = 2;
            this.ptbComprar.TabStop = false;
            // 
            // scalarQueryTableAdapter
            // 
            this.scalarQueryTableAdapter.ClearBeforeFill = true;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 338);
            this.Controls.Add(this.ptbComprar);
            this.Controls.Add(this.pnlRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompras";
            this.Text = "Relatorio de Compras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scalarQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorios)).EndInit();
            this.pnlRelatorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbComprar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Relatorios relatorios;
        private System.Windows.Forms.BindingSource scalarQueryBindingSource;
        private RelatoriosTableAdapters.ScalarQueryTableAdapter scalarQueryTableAdapter;
        private System.Windows.Forms.Panel pnlRelatorio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.PictureBox ptbComprar;
    }
}