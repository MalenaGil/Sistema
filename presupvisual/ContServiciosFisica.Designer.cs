namespace presupvisual
{
    partial class ContServiciosFisica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContServiciosFisica));
            this.provsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSproveedores = new presupvisual.DSproveedores();
            this.btsalir = new System.Windows.Forms.Button();
            this.provsTableAdapter = new presupvisual.DSproveedoresTableAdapters.provsTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.pfechacontrato = new System.Windows.Forms.TextBox();
            this.preplegal = new System.Windows.Forms.TextBox();
            this.ptestigo1 = new System.Windows.Forms.TextBox();
            this.ptestigo2 = new System.Windows.Forms.TextBox();
            this.btnWord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.provsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSproveedores)).BeginInit();
            this.SuspendLayout();
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
            this.btsalir.TabIndex = 11;
            this.btsalir.Text = "SALIR";
            this.btsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btsalir.UseVisualStyleBackColor = false;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // provsTableAdapter
            // 
            this.provsTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Contrato SUMINISTROS (Persona Física)";
            // 
            // pfechacontrato
            // 
            this.pfechacontrato.Location = new System.Drawing.Point(34, 96);
            this.pfechacontrato.Name = "pfechacontrato";
            this.pfechacontrato.Size = new System.Drawing.Size(170, 20);
            this.pfechacontrato.TabIndex = 22;
            // 
            // preplegal
            // 
            this.preplegal.Location = new System.Drawing.Point(34, 145);
            this.preplegal.Name = "preplegal";
            this.preplegal.Size = new System.Drawing.Size(170, 20);
            this.preplegal.TabIndex = 23;
            // 
            // ptestigo1
            // 
            this.ptestigo1.Location = new System.Drawing.Point(472, 145);
            this.ptestigo1.Name = "ptestigo1";
            this.ptestigo1.Size = new System.Drawing.Size(170, 20);
            this.ptestigo1.TabIndex = 24;
            // 
            // ptestigo2
            // 
            this.ptestigo2.Location = new System.Drawing.Point(458, 96);
            this.ptestigo2.Name = "ptestigo2";
            this.ptestigo2.Size = new System.Drawing.Size(170, 20);
            this.ptestigo2.TabIndex = 25;
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(146, 238);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(153, 63);
            this.btnWord.TabIndex = 26;
            this.btnWord.Text = "button1";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click_1);
            // 
            // ContServiciosFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.ptestigo2);
            this.Controls.Add(this.ptestigo1);
            this.Controls.Add(this.preplegal);
            this.Controls.Add(this.pfechacontrato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btsalir);
            this.Name = "ContServiciosFisica";
            this.Text = "ContServiciosFisica";
            ((System.ComponentModel.ISupportInitialize)(this.provsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSproveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btsalir;
        private System.Windows.Forms.BindingSource provsBindingSource;
        private DSproveedores DSproveedores;
        private DSproveedoresTableAdapters.provsTableAdapter provsTableAdapter;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox pfechacontrato;
        public System.Windows.Forms.TextBox preplegal;
        public System.Windows.Forms.TextBox ptestigo1;
        public System.Windows.Forms.TextBox ptestigo2;
        private System.Windows.Forms.Button btnWord;
    }
}