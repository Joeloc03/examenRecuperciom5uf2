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
            this.btAnimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMenjar
            // 
            this.btMenjar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btMenjar.Location = new System.Drawing.Point(203, 224);
            this.btMenjar.Name = "btMenjar";
            this.btMenjar.Size = new System.Drawing.Size(133, 50);
            this.btMenjar.TabIndex = 0;
            this.btMenjar.Text = "menjar";
            this.btMenjar.UseVisualStyleBackColor = false;
            this.btMenjar.Click += new System.EventHandler(this.btMenjar_Click);
            // 
            // btViatje
            // 
            this.btViatje.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btViatje.Location = new System.Drawing.Point(447, 224);
            this.btViatje.Name = "btViatje";
            this.btViatje.Size = new System.Drawing.Size(152, 50);
            this.btViatje.TabIndex = 1;
            this.btViatje.Text = "viatge";
            this.btViatje.UseVisualStyleBackColor = false;
            this.btViatje.Click += new System.EventHandler(this.btViatje_Click);
            // 
            // btAnimal
            // 
            this.btAnimal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAnimal.Location = new System.Drawing.Point(338, 99);
            this.btAnimal.Name = "btAnimal";
            this.btAnimal.Size = new System.Drawing.Size(133, 50);
            this.btAnimal.TabIndex = 2;
            this.btAnimal.Text = "animal";
            this.btAnimal.UseVisualStyleBackColor = false;
            this.btAnimal.Click += new System.EventHandler(this.btAnimal_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAnimal);
            this.Controls.Add(this.btViatje);
            this.Controls.Add(this.btMenjar);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMenjar;
        private System.Windows.Forms.Button btViatje;
        private System.Windows.Forms.Button btAnimal;
    }
}

