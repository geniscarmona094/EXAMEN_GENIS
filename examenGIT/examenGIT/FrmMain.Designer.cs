namespace examenGIT
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btBlau = new System.Windows.Forms.Button();
            this.btVerd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBlau
            // 
            this.btBlau.BackColor = System.Drawing.Color.Blue;
            this.btBlau.ForeColor = System.Drawing.Color.White;
            this.btBlau.Location = new System.Drawing.Point(121, 125);
            this.btBlau.Name = "btBlau";
            this.btBlau.Size = new System.Drawing.Size(143, 63);
            this.btBlau.TabIndex = 0;
            this.btBlau.Text = "BLAU";
            this.btBlau.UseVisualStyleBackColor = false;
            this.btBlau.Click += new System.EventHandler(this.btBlau_Click);
            // 
            // btVerd
            // 
            this.btVerd.BackColor = System.Drawing.Color.Green;
            this.btVerd.ForeColor = System.Drawing.Color.White;
            this.btVerd.Location = new System.Drawing.Point(431, 124);
            this.btVerd.Name = "btVerd";
            this.btVerd.Size = new System.Drawing.Size(132, 64);
            this.btVerd.TabIndex = 1;
            this.btVerd.Text = "VERD";
            this.btVerd.UseVisualStyleBackColor = false;
            this.btVerd.Click += new System.EventHandler(this.btVerd_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btVerd);
            this.Controls.Add(this.btBlau);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBlau;
        private System.Windows.Forms.Button btVerd;
    }
}

