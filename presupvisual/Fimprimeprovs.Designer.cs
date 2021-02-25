namespace presupvisual
{
    partial class Fimprimeprovs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fimprimeprovs));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btsalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonBuscaRazon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BotonBuscaRFC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BotonBusca = new System.Windows.Forms.Button();
            this.pclaveprove = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.prfcprove = new System.Windows.Forms.TextBox();
            this.prazonprove = new System.Windows.Forms.TextBox();
            this.provsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSproveedores = new presupvisual.DSproveedores();
            this.provsTableAdapter = new presupvisual.DSproveedoresTableAdapters.provsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.provsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSproveedores)).BeginInit();
            this.SuspendLayout();
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
            this.btsalir.TabIndex = 10;
            this.btsalir.Text = "SALIR";
            this.btsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btsalir.UseVisualStyleBackColor = false;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(377, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Reporte de Proveedores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Dame las primeras letras de la clav.e del proveedor:\r\n";
            // 
            // BotonBuscaRazon
            // 
            this.BotonBuscaRazon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BotonBuscaRazon.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBuscaRazon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonBuscaRazon.Location = new System.Drawing.Point(570, 72);
            this.BotonBuscaRazon.Name = "BotonBuscaRazon";
            this.BotonBuscaRazon.Size = new System.Drawing.Size(147, 25);
            this.BotonBuscaRazon.TabIndex = 29;
            this.BotonBuscaRazon.Text = "BUSCA POR RAZON";
            this.BotonBuscaRazon.UseVisualStyleBackColor = false;
            this.BotonBuscaRazon.Click += new System.EventHandler(this.BotonBuscaRazon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Dame las primeras letras de la Razón del proveedor:";
            // 
            // BotonBuscaRFC
            // 
            this.BotonBuscaRFC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BotonBuscaRFC.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBuscaRFC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonBuscaRFC.Location = new System.Drawing.Point(570, 46);
            this.BotonBuscaRFC.Name = "BotonBuscaRFC";
            this.BotonBuscaRFC.Size = new System.Drawing.Size(147, 25);
            this.BotonBuscaRFC.TabIndex = 26;
            this.BotonBuscaRFC.Text = "BUSCA POR RFC";
            this.BotonBuscaRFC.UseVisualStyleBackColor = false;
            this.BotonBuscaRFC.Click += new System.EventHandler(this.BotonBuscaRFC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Dame las primeras letras del RFC del proveedor:\r\n";
            // 
            // BotonBusca
            // 
            this.BotonBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BotonBusca.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBusca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonBusca.Location = new System.Drawing.Point(570, 20);
            this.BotonBusca.Name = "BotonBusca";
            this.BotonBusca.Size = new System.Drawing.Size(147, 25);
            this.BotonBusca.TabIndex = 23;
            this.BotonBusca.Text = "BUSCA POR CLAVE";
            this.BotonBusca.UseVisualStyleBackColor = false;
            this.BotonBusca.Click += new System.EventHandler(this.BotonBusca_Click);
            // 
            // pclaveprove
            // 
            this.pclaveprove.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pclaveprove.Location = new System.Drawing.Point(406, 20);
            this.pclaveprove.Name = "pclaveprove";
            this.pclaveprove.Size = new System.Drawing.Size(159, 25);
            this.pclaveprove.TabIndex = 22;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DSProveedores";
            reportDataSource1.Value = this.provsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "presupvisual.ReportProveedores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 102);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 337);
            this.reportViewer1.TabIndex = 30;
            // 
            // prfcprove
            // 
            this.prfcprove.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prfcprove.Location = new System.Drawing.Point(406, 46);
            this.prfcprove.Name = "prfcprove";
            this.prfcprove.Size = new System.Drawing.Size(159, 25);
            this.prfcprove.TabIndex = 31;
            // 
            // prazonprove
            // 
            this.prazonprove.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prazonprove.Location = new System.Drawing.Point(406, 72);
            this.prazonprove.Name = "prazonprove";
            this.prazonprove.Size = new System.Drawing.Size(159, 25);
            this.prazonprove.TabIndex = 32;
            // 
            // provsBindingSource
            // 
            this.provsBindingSource.DataMember = "provs";
            this.provsBindingSource.DataSource = this.DSproveedores;
            // 
            // DSproveedores
            // 
            this.DSproveedores.DataSetName = "DSproveedores";
            this.DSproveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provsTableAdapter
            // 
            this.provsTableAdapter.ClearBeforeFill = true;
            // 
            // Fimprimeprovs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prazonprove);
            this.Controls.Add(this.prfcprove);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.BotonBuscaRazon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BotonBuscaRFC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BotonBusca);
            this.Controls.Add(this.pclaveprove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btsalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fimprimeprovs";
            this.Text = "Fimprimeprovs";
            this.Load += new System.EventHandler(this.Fimprimeprovs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.provsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSproveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btsalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonBuscaRazon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BotonBuscaRFC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BotonBusca;
        private System.Windows.Forms.TextBox pclaveprove;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource provsBindingSource;
        private DSproveedores DSproveedores;
        private DSproveedoresTableAdapters.provsTableAdapter provsTableAdapter;
        private System.Windows.Forms.TextBox prfcprove;
        private System.Windows.Forms.TextBox prazonprove;
    }
}