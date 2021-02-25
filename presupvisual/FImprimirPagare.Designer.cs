namespace presupvisual
{
    partial class FImprimirPagare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FImprimirPagare));
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPagare = new presupvisual.DataSetClientes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clientesTableAdapter = new presupvisual.DataSetClientesTableAdapters.clientesTableAdapter();
            this.Button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonPasar = new System.Windows.Forms.Button();
            this.pimporte = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPagare)).BeginInit();
            this.SuspendLayout();
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.DataSetPagare;
            // 
            // DataSetPagare
            // 
            this.DataSetPagare.DataSetName = "DataSetPagare";
            this.DataSetPagare.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.clientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "presupvisual.ReportPagare.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 70);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 380);
            this.reportViewer1.TabIndex = 0;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // Button1
            // 
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.Location = new System.Drawing.Point(729, 12);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(59, 57);
            this.Button1.TabIndex = 4;
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "PAGARE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Importe:";
            // 
            // BotonPasar
            // 
            this.BotonPasar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BotonPasar.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPasar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonPasar.Location = new System.Drawing.Point(496, 27);
            this.BotonPasar.Name = "BotonPasar";
            this.BotonPasar.Size = new System.Drawing.Size(112, 25);
            this.BotonPasar.TabIndex = 23;
            this.BotonPasar.Text = "PASAR DATOS";
            this.BotonPasar.UseVisualStyleBackColor = false;
            this.BotonPasar.Click += new System.EventHandler(this.BotonPasar_Click);
            // 
            // pimporte
            // 
            this.pimporte.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pimporte.Location = new System.Drawing.Point(158, 27);
            this.pimporte.Name = "pimporte";
            this.pimporte.Size = new System.Drawing.Size(108, 25);
            this.pimporte.TabIndex = 22;
            // 
            // FImprimirPagare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.BotonPasar);
            this.Controls.Add(this.pimporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FImprimirPagare";
            this.Text = "FImprimirPagare";
            this.Load += new System.EventHandler(this.FImprimirPagare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPagare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSetClientes DataSetPagare;
        private DataSetClientesTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonPasar;
        private System.Windows.Forms.TextBox pimporte;
    }
}