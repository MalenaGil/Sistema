namespace presupvisual
{
    partial class FImprimirContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FImprimirContrato));
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetClientes = new presupvisual.DataSetClientes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clientesTableAdapter = new presupvisual.DataSetClientesTableAdapters.clientesTableAdapter();
            this.BotonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.DataSetClientes;
            // 
            // DataSetClientes
            // 
            this.DataSetClientes.DataSetName = "DataSetClientes";
            this.DataSetClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetContratos";
            reportDataSource1.Value = this.clientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "presupvisual.ReportContratos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
         //   this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // BotonSalir
            // 
            this.BotonSalir.BackColor = System.Drawing.Color.Silver;
            this.BotonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BotonSalir.Font = new System.Drawing.Font("Arial", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonSalir.ForeColor = System.Drawing.Color.Blue;
            this.BotonSalir.Image = ((System.Drawing.Image)(resources.GetObject("BotonSalir.Image")));
            this.BotonSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotonSalir.Location = new System.Drawing.Point(735, 0);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(65, 51);
            this.BotonSalir.TabIndex = 9;
            this.BotonSalir.Text = "SALIR";
            this.BotonSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonSalir.UseVisualStyleBackColor = false;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // FImprimirContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonSalir);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FImprimirContrato";
            this.Text = "FImprimirContrato";
            this.Load += new System.EventHandler(this.FImprimirContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSetClientes DataSetClientes;
        private DataSetClientesTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Button BotonSalir;
    }
}