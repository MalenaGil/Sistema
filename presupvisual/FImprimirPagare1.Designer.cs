namespace presupvisual
{
    partial class FImprimirPagare1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FImprimirPagare1));
            this.dataSetPagareBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPagare = new presupvisual.DataSetPagare();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new presupvisual.DataSetClientesTableAdapters.clientesTableAdapter();
            this.dataSetPagareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetClientes1 = new presupvisual.DataSetClientes();
            this.BotonPasar = new System.Windows.Forms.Button();
            this.pimporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.NombrePagare = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPagareBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPagare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPagareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClientes1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetPagareBindingSource1
            // 
            this.dataSetPagareBindingSource1.DataSource = this.dataSetPagare;
            this.dataSetPagareBindingSource1.Position = 0;
            // 
            // dataSetPagare
            // 
            this.dataSetPagare.DataSetName = "DataSetPagare";
            this.dataSetPagare.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataSetPagareBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "presupvisual.ReportPagare.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 110);
            this.reportViewer1.Name = "reportViewer1";
          //  this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 282);
            this.reportViewer1.TabIndex = 0;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetPagareBindingSource
            // 
            this.dataSetPagareBindingSource.DataSource = this.dataSetPagare;
            this.dataSetPagareBindingSource.Position = 0;
            // 
            // dataSetClientes1
            // 
            this.dataSetClientes1.DataSetName = "DataSetPagare";
            this.dataSetClientes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BotonPasar
            // 
            this.BotonPasar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BotonPasar.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPasar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonPasar.Location = new System.Drawing.Point(455, 36);
            this.BotonPasar.Name = "BotonPasar";
            this.BotonPasar.Size = new System.Drawing.Size(112, 25);
            this.BotonPasar.TabIndex = 28;
            this.BotonPasar.Text = "PASAR DATOS";
            this.BotonPasar.UseVisualStyleBackColor = false;
            this.BotonPasar.Click += new System.EventHandler(this.BotonPasar_Click);
            // 
            // pimporte
            // 
            this.pimporte.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pimporte.Location = new System.Drawing.Point(117, 36);
            this.pimporte.Name = "pimporte";
            this.pimporte.Size = new System.Drawing.Size(108, 25);
            this.pimporte.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Importe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "PAGARE";
            // 
            // Button1
            // 
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.Location = new System.Drawing.Point(688, 21);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(59, 57);
            this.Button1.TabIndex = 24;
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // NombrePagare
            // 
            this.NombrePagare.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombrePagare.Location = new System.Drawing.Point(117, 57);
            this.NombrePagare.Name = "NombrePagare";
            this.NombrePagare.Size = new System.Drawing.Size(239, 25);
            this.NombrePagare.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre:";
            // 
            // FImprimirPagare1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NombrePagare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BotonPasar);
            this.Controls.Add(this.pimporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FImprimirPagare1";
            this.Text = "FImprimirPagare1";
            this.Load += new System.EventHandler(this.FImprimirPagare1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPagareBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPagare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPagareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClientes1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSetClientesTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource dataSetPagareBindingSource;
        private DataSetPagare dataSetPagare;
        private System.Windows.Forms.BindingSource dataSetPagareBindingSource1;
        private DataSetClientes dataSetClientes1;
        private System.Windows.Forms.Button BotonPasar;
        private System.Windows.Forms.TextBox pimporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox NombrePagare;
        private System.Windows.Forms.Label label2;
    }
}