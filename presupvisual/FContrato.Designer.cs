namespace presupvisual
{
    partial class FContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FContrato));
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetClientes = new presupvisual.DataSetClientes();
            this.clientesTableAdapter = new presupvisual.DataSetClientesTableAdapters.clientesTableAdapter();
            this.btsalir = new System.Windows.Forms.Button();
            this.DataSetContrato = new presupvisual.DataSetContrato();
            this.dataSetContratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetContratoBindingSource)).BeginInit();
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
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
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
            // DataSetContrato
            // 
            this.DataSetContrato.DataSetName = "DataSetContrato";
            this.DataSetContrato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetContratoBindingSource
            // 
            this.dataSetContratoBindingSource.DataSource = this.DataSetContrato;
            this.dataSetContratoBindingSource.Position = 0;
            // 
            // FContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btsalir);
            this.Name = "FContrato";
            this.Text = "FContrato";
            this.Load += new System.EventHandler(this.FContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetContratoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSetClientes DataSetClientes;
        private DataSetClientesTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Button btsalir;
        private DataSetContrato DataSetContrato;
        private System.Windows.Forms.BindingSource dataSetContratoBindingSource;
    }
}