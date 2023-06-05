namespace WindowsFormsApp1
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
            this.btMenjar = new System.Windows.Forms.Button();
            this.btViatje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMenjar
            // 
            this.btMenjar.Location = new System.Drawing.Point(203, 224);
            this.btMenjar.Name = "btMenjar";
            this.btMenjar.Size = new System.Drawing.Size(133, 50);
            this.btMenjar.TabIndex = 0;
            this.btMenjar.Text = "menjar";
            this.btMenjar.UseVisualStyleBackColor = true;
            // 
            // btViatje
            // 
            this.btViatje.Location = new System.Drawing.Point(447, 224);
            this.btViatje.Name = "btViatje";
            this.btViatje.Size = new System.Drawing.Size(152, 50);
            this.btViatje.TabIndex = 1;
            this.btViatje.Text = "viatge";
            this.btViatje.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btViatje);
            this.Controls.Add(this.btMenjar);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMenjar;
        private System.Windows.Forms.Button btViatje;
    }
}

