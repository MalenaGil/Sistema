namespace presupvisual
{
    partial class Fimprimecontratos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fimprimecontratos));
            this.btsalir = new System.Windows.Forms.Button();
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
            this.btsalir.Location = new System.Drawing.Point(726, 9);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(65, 51);
            this.btsalir.TabIndex = 30;
            this.btsalir.Text = "SALIR";
            this.btsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btsalir.UseVisualStyleBackColor = false;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // Fimprimecontratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btsalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fimprimecontratos";
            this.Text = "Fimprimecontratos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btsalir;
    }
}