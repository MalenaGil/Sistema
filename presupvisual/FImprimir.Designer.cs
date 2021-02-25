namespace presupvisual
{
    partial class FImprimir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FImprimir));
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetClientes = new presupvisual.DataSetClientes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btsalir = new System.Windows.Forms.Button();
            this.pclaveclte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonBusca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.prfcclte = new System.Windows.Forms.TextBox();
            this.BotonBuscaRFC = new System.Windows.Forms.Button();
            this.BotonBuscaRazon = new System.Windows.Forms.Button();
            this.prazonclte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clientesTableAdapter = new presupvisual.DataSetClientesTableAdapters.clientesTableAdapter();
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
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.clientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "presupvisual.ReportClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(791, 380);
            this.reportViewer1.TabIndex = 0;
            // 
            // btsalir
            // 
            this.btsalir.BackColor = System.Drawing.Color.Silver;
            this.btsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btsalir.Font = new System.Drawing.Font("Arial", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalir.ForeColor = System.Drawing.Color.Blue;
            this.btsalir.Image = ((System.Drawing.Image)(resources.GetObject("btsalir.Image")));
            this.btsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btsalir.Location = new System.Drawing.Point(723, 12);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(65, 51);
            this.btsalir.TabIndex = 9;
            this.btsalir.Text = "SALIR";
            this.btsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btsalir.UseVisualStyleBackColor = false;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // pclaveclte
            // 
            this.pclaveclte.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pclaveclte.Location = new System.Drawing.Point(380, 20);
            this.pclaveclte.Name = "pclaveclte";
            this.pclaveclte.Size = new System.Drawing.Size(159, 25);
            this.pclaveclte.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dame las primeras letras de la clave del cliente:";
            // 
            // BotonBusca
            // 
            this.BotonBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BotonBusca.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBusca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonBusca.Location = new System.Drawing.Point(545, 20);
            this.BotonBusca.Name = "BotonBusca";
            this.BotonBusca.Size = new System.Drawing.Size(147, 25);
            this.BotonBusca.TabIndex = 12;
            this.BotonBusca.Text = "BUSCA POR CLAVE";
            this.BotonBusca.UseVisualStyleBackColor = false;
            this.BotonBusca.Click += new System.EventHandler(this.BotonBusca_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dame las primeras letras del RFC del cliente:";
            // 
            // prfcclte
            // 
            this.prfcclte.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prfcclte.Location = new System.Drawing.Point(380, 46);
            this.prfcclte.Name = "prfcclte";
            this.prfcclte.Size = new System.Drawing.Size(159, 25);
            this.prfcclte.TabIndex = 14;
            // 
            // BotonBuscaRFC
            // 
            this.BotonBuscaRFC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BotonBuscaRFC.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBuscaRFC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonBuscaRFC.Location = new System.Drawing.Point(545, 46);
            this.BotonBuscaRFC.Name = "BotonBuscaRFC";
            this.BotonBuscaRFC.Size = new System.Drawing.Size(147, 25);
            this.BotonBuscaRFC.TabIndex = 15;
            this.BotonBuscaRFC.Text = "BUSCA POR RFC";
            this.BotonBuscaRFC.UseVisualStyleBackColor = false;
            this.BotonBuscaRFC.Click += new System.EventHandler(this.BotonBuscaRFC_Click);
            // 
            // BotonBuscaRazon
            // 
            this.BotonBuscaRazon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BotonBuscaRazon.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBuscaRazon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonBuscaRazon.Location = new System.Drawing.Point(545, 72);
            this.BotonBuscaRazon.Name = "BotonBuscaRazon";
            this.BotonBuscaRazon.Size = new System.Drawing.Size(147, 25);
            this.BotonBuscaRazon.TabIndex = 18;
            this.BotonBuscaRazon.Text = "BUSCA POR RAZON";
            this.BotonBuscaRazon.UseVisualStyleBackColor = false;
            this.BotonBuscaRazon.Click += new System.EventHandler(this.BotonBuscaRazon_Click);
            // 
            // prazonclte
            // 
            this.prazonclte.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prazonclte.Location = new System.Drawing.Point(380, 72);
            this.prazonclte.Name = "prazonclte";
            this.prazonclte.Size = new System.Drawing.Size(159, 25);
            this.prazonclte.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Dame las primeras letras de la Razón del cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Reporte de Clientes";
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // FImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BotonBuscaRazon);
            this.Controls.Add(this.prazonclte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BotonBuscaRFC);
            this.Controls.Add(this.prfcclte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BotonBusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pclaveclte);
            this.Controls.Add(this.btsalir);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FImprimir";
            this.Text = "FImprimir";
            this.Load += new System.EventHandler(this.FImprimir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSetClientes DataSetClientes;
        private DataSetClientesTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Button btsalir;
        private System.Windows.Forms.TextBox pclaveclte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonBusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prfcclte;
        private System.Windows.Forms.Button BotonBuscaRFC;
        private System.Windows.Forms.Button BotonBuscaRazon;
        private System.Windows.Forms.TextBox prazonclte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}