namespace presupvisual
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.Button1 = new System.Windows.Forms.Button();
            this.fondo = new System.Windows.Forms.PictureBox();
            this.labelPresupuestos = new System.Windows.Forms.Label();
            this.labelOrdenesTrabajo = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownClientes = new System.Windows.Forms.ToolStripDropDownButton();
            this.labelOrdenesCompra = new System.Windows.Forms.Label();
            this.labelRemisiones = new System.Windows.Forms.Label();
            this.labelFacturas = new System.Windows.Forms.Label();
            this.labelNotasCredito = new System.Windows.Forms.Label();
            this.labelContrarecibos = new System.Windows.Forms.Label();
            this.labelCobranzas = new System.Windows.Forms.Label();
            this.labelDepositos = new System.Windows.Forms.Label();
            this.labelCheques = new System.Windows.Forms.Label();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.Location = new System.Drawing.Point(649, 40);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(78, 78);
            this.Button1.TabIndex = 2;
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // fondo
            // 
            this.fondo.BackColor = System.Drawing.Color.Transparent;
            this.fondo.Image = ((System.Drawing.Image)(resources.GetObject("fondo.Image")));
            this.fondo.InitialImage = null;
            this.fondo.Location = new System.Drawing.Point(1, 2);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(800, 600);
            this.fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fondo.TabIndex = 3;
            this.fondo.TabStop = false;
            // 
            // labelPresupuestos
            // 
            this.labelPresupuestos.AutoSize = true;
            this.labelPresupuestos.BackColor = System.Drawing.Color.White;
            this.labelPresupuestos.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresupuestos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.labelPresupuestos.ImageKey = "(ninguno)";
            this.labelPresupuestos.Location = new System.Drawing.Point(66, 138);
            this.labelPresupuestos.Name = "labelPresupuestos";
            this.labelPresupuestos.Size = new System.Drawing.Size(98, 13);
            this.labelPresupuestos.TabIndex = 0;
            this.labelPresupuestos.Text = "PRESUPUESTOS";
            this.labelPresupuestos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPresupuestos.Click += new System.EventHandler(this.labelPresupuestos_Click);
            this.labelPresupuestos.MouseLeave += new System.EventHandler(this.LabelPresupuestos_MouseLeave);
            this.labelPresupuestos.MouseHover += new System.EventHandler(this.LabelPresupuestos_MouseHover);
            // 
            // labelOrdenesTrabajo
            // 
            this.labelOrdenesTrabajo.AutoSize = true;
            this.labelOrdenesTrabajo.BackColor = System.Drawing.Color.White;
            this.labelOrdenesTrabajo.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdenesTrabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.labelOrdenesTrabajo.Location = new System.Drawing.Point(45, 167);
            this.labelOrdenesTrabajo.Name = "labelOrdenesTrabajo";
            this.labelOrdenesTrabajo.Size = new System.Drawing.Size(136, 13);
            this.labelOrdenesTrabajo.TabIndex = 10;
            this.labelOrdenesTrabajo.Text = "ORDENES DE TRABAJO";
            this.labelOrdenesTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOrdenesTrabajo.Click += new System.EventHandler(this.LabelOrdenesTrabajo_Click);
            this.labelOrdenesTrabajo.MouseLeave += new System.EventHandler(this.LabelOrdenesTrabajo_MouseLeave);
            this.labelOrdenesTrabajo.MouseHover += new System.EventHandler(this.LabelOrdenesTrabajo_MouseHover);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownClientes,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(861, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownClientes
            // 
            this.toolStripDropDownClientes.BackColor = System.Drawing.Color.Transparent;
            this.toolStripDropDownClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownClientes.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownClientes.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripDropDownClientes.Name = "toolStripDropDownClientes";
            this.toolStripDropDownClientes.Size = new System.Drawing.Size(79, 22);
            this.toolStripDropDownClientes.Text = "CLIENTES";
            this.toolStripDropDownClientes.Click += new System.EventHandler(this.ToolStripDropDownClientes_Click);
            // 
            // labelOrdenesCompra
            // 
            this.labelOrdenesCompra.AutoSize = true;
            this.labelOrdenesCompra.BackColor = System.Drawing.Color.White;
            this.labelOrdenesCompra.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdenesCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.labelOrdenesCompra.Location = new System.Drawing.Point(46, 195);
            this.labelOrdenesCompra.Name = "labelOrdenesCompra";
            this.labelOrdenesCompra.Size = new System.Drawing.Size(134, 13);
            this.labelOrdenesCompra.TabIndex = 12;
            this.labelOrdenesCompra.Text = "ORDENES DE COMPRA";
            this.labelOrdenesCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOrdenesCompra.Click += new System.EventHandler(this.LabelOrdenesCompra_Click);
            this.labelOrdenesCompra.MouseLeave += new System.EventHandler(this.LabelOrdenesCompra_MouseLeave);
            this.labelOrdenesCompra.MouseHover += new System.EventHandler(this.LabelOrdenesCompra_MouseHover);
            // 
            // labelRemisiones
            // 
            this.labelRemisiones.AutoSize = true;
            this.labelRemisiones.BackColor = System.Drawing.Color.White;
            this.labelRemisiones.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemisiones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.labelRemisiones.Location = new System.Drawing.Point(73, 223);
            this.labelRemisiones.Name = "labelRemisiones";
            this.labelRemisiones.Size = new System.Drawing.Size(77, 13);
            this.labelRemisiones.TabIndex = 13;
            this.labelRemisiones.Text = "REMISIONES";
            this.labelRemisiones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRemisiones.Click += new System.EventHandler(this.LabelRemisiones_Click);
            this.labelRemisiones.MouseLeave += new System.EventHandler(this.LabelRemisiones_MouseLeave);
            this.labelRemisiones.MouseHover += new System.EventHandler(this.LabelRemisiones_MouseHover);
            // 
            // labelFacturas
            // 
            this.labelFacturas.AutoSize = true;
            this.labelFacturas.BackColor = System.Drawing.Color.White;
            this.labelFacturas.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacturas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(71)))));
            this.labelFacturas.Location = new System.Drawing.Point(78, 253);
            this.labelFacturas.Name = "labelFacturas";
            this.labelFacturas.Size = new System.Drawing.Size(67, 13);
            this.labelFacturas.TabIndex = 14;
            this.labelFacturas.Text = "FACTURAS";
            this.labelFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFacturas.Click += new System.EventHandler(this.LabelFacturas_Click);
            this.labelFacturas.MouseLeave += new System.EventHandler(this.LabelFacturas_MouseLeave);
            this.labelFacturas.MouseHover += new System.EventHandler(this.LabelFacturas_MouseHover);
            // 
            // labelNotasCredito
            // 
            this.labelNotasCredito.AutoSize = true;
            this.labelNotasCredito.BackColor = System.Drawing.Color.White;
            this.labelNotasCredito.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotasCredito.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelNotasCredito.Location = new System.Drawing.Point(55, 283);
            this.labelNotasCredito.Name = "labelNotasCredito";
            this.labelNotasCredito.Size = new System.Drawing.Size(116, 13);
            this.labelNotasCredito.TabIndex = 15;
            this.labelNotasCredito.Text = "NOTAS DE CREDITO";
            this.labelNotasCredito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNotasCredito.Click += new System.EventHandler(this.LabelNotasCredito_Click);
            this.labelNotasCredito.MouseLeave += new System.EventHandler(this.LabelNotasCredito_MouseLeave);
            this.labelNotasCredito.MouseHover += new System.EventHandler(this.LabelNotasCredito_MouseHover);
            // 
            // labelContrarecibos
            // 
            this.labelContrarecibos.AutoSize = true;
            this.labelContrarecibos.BackColor = System.Drawing.Color.White;
            this.labelContrarecibos.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrarecibos.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelContrarecibos.Location = new System.Drawing.Point(61, 311);
            this.labelContrarecibos.Name = "labelContrarecibos";
            this.labelContrarecibos.Size = new System.Drawing.Size(105, 13);
            this.labelContrarecibos.TabIndex = 16;
            this.labelContrarecibos.Text = "CONTRARECIBOS";
            this.labelContrarecibos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelContrarecibos.Click += new System.EventHandler(this.LabelContrarecibos_Click);
            this.labelContrarecibos.MouseLeave += new System.EventHandler(this.LabelContrarecibos_MouseLeave);
            this.labelContrarecibos.MouseHover += new System.EventHandler(this.LabelContrarecibos_MouseHover);
            // 
            // labelCobranzas
            // 
            this.labelCobranzas.AutoSize = true;
            this.labelCobranzas.BackColor = System.Drawing.Color.White;
            this.labelCobranzas.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCobranzas.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelCobranzas.Location = new System.Drawing.Point(74, 340);
            this.labelCobranzas.Name = "labelCobranzas";
            this.labelCobranzas.Size = new System.Drawing.Size(78, 13);
            this.labelCobranzas.TabIndex = 17;
            this.labelCobranzas.Text = "COBRANZAS";
            this.labelCobranzas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCobranzas.Click += new System.EventHandler(this.LabelCobranzas_Click);
            this.labelCobranzas.MouseLeave += new System.EventHandler(this.LabelCobranzas_MouseLeave);
            this.labelCobranzas.MouseHover += new System.EventHandler(this.LabelCobranzas_MouseHover);
            // 
            // labelDepositos
            // 
            this.labelDepositos.AutoSize = true;
            this.labelDepositos.BackColor = System.Drawing.Color.White;
            this.labelDepositos.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepositos.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelDepositos.Location = new System.Drawing.Point(77, 370);
            this.labelDepositos.Name = "labelDepositos";
            this.labelDepositos.Size = new System.Drawing.Size(72, 13);
            this.labelDepositos.TabIndex = 18;
            this.labelDepositos.Text = "DEPOSITOS";
            this.labelDepositos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDepositos.Click += new System.EventHandler(this.LabelDepositos_Click);
            this.labelDepositos.MouseLeave += new System.EventHandler(this.LabelDepositos_MouseLeave);
            this.labelDepositos.MouseHover += new System.EventHandler(this.LabelDepositos_MouseHover);
            // 
            // labelCheques
            // 
            this.labelCheques.AutoSize = true;
            this.labelCheques.BackColor = System.Drawing.Color.White;
            this.labelCheques.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheques.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelCheques.Location = new System.Drawing.Point(83, 399);
            this.labelCheques.Name = "labelCheques";
            this.labelCheques.Size = new System.Drawing.Size(61, 13);
            this.labelCheques.TabIndex = 19;
            this.labelCheques.Text = "CHEQUES";
            this.labelCheques.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCheques.Click += new System.EventHandler(this.LabelCheques_Click);
            this.labelCheques.MouseLeave += new System.EventHandler(this.LabelCheques_MouseLeave);
            this.labelCheques.MouseHover += new System.EventHandler(this.LabelCheques_MouseHover);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(114, 22);
            this.toolStripDropDownButton1.Text = "PROVEEDORES";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 538);
            this.Controls.Add(this.labelCheques);
            this.Controls.Add(this.labelDepositos);
            this.Controls.Add(this.labelCobranzas);
            this.Controls.Add(this.labelContrarecibos);
            this.Controls.Add(this.labelNotasCredito);
            this.Controls.Add(this.labelFacturas);
            this.Controls.Add(this.labelRemisiones);
            this.Controls.Add(this.labelOrdenesCompra);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelOrdenesTrabajo);
            this.Controls.Add(this.labelPresupuestos);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.fondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Litografia Gil";
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.PictureBox fondo;
        private System.Windows.Forms.Label labelPresupuestos;
        private System.Windows.Forms.Label labelOrdenesTrabajo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownClientes;
        private System.Windows.Forms.Label labelOrdenesCompra;
        private System.Windows.Forms.Label labelRemisiones;
        private System.Windows.Forms.Label labelFacturas;
        private System.Windows.Forms.Label labelNotasCredito;
        private System.Windows.Forms.Label labelContrarecibos;
        private System.Windows.Forms.Label labelCobranzas;
        private System.Windows.Forms.Label labelDepositos;
        private System.Windows.Forms.Label labelCheques;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
    }
}