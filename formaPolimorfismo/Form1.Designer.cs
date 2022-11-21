namespace formaPolimorfismo
{
    partial class Form1
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
            this.btnGuitarra = new System.Windows.Forms.Button();
            this.btnPiano = new System.Windows.Forms.Button();
            this.btnViolin = new System.Windows.Forms.Button();
            this.btnPeon = new System.Windows.Forms.Button();
            this.btnTorre = new System.Windows.Forms.Button();
            this.btnCaballo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuitarra
            // 
            this.btnGuitarra.Location = new System.Drawing.Point(176, 102);
            this.btnGuitarra.Name = "btnGuitarra";
            this.btnGuitarra.Size = new System.Drawing.Size(138, 23);
            this.btnGuitarra.TabIndex = 0;
            this.btnGuitarra.Text = "Ejecutar Guitarra.Afinar()";
            this.btnGuitarra.UseVisualStyleBackColor = true;
            // 
            // btnPiano
            // 
            this.btnPiano.Location = new System.Drawing.Point(176, 167);
            this.btnPiano.Name = "btnPiano";
            this.btnPiano.Size = new System.Drawing.Size(138, 23);
            this.btnPiano.TabIndex = 1;
            this.btnPiano.Text = "Ejecutar Piano.Afinar()";
            this.btnPiano.UseVisualStyleBackColor = true;
            // 
            // btnViolin
            // 
            this.btnViolin.Location = new System.Drawing.Point(176, 223);
            this.btnViolin.Name = "btnViolin";
            this.btnViolin.Size = new System.Drawing.Size(138, 23);
            this.btnViolin.TabIndex = 2;
            this.btnViolin.Text = "Ejecutar Violin.Afinar()";
            this.btnViolin.UseVisualStyleBackColor = true;
            // 
            // btnPeon
            // 
            this.btnPeon.Location = new System.Drawing.Point(442, 102);
            this.btnPeon.Name = "btnPeon";
            this.btnPeon.Size = new System.Drawing.Size(156, 23);
            this.btnPeon.TabIndex = 3;
            this.btnPeon.Text = "Ejecutar Peon.Mover()";
            this.btnPeon.UseVisualStyleBackColor = true;
            // 
            // btnTorre
            // 
            this.btnTorre.Location = new System.Drawing.Point(442, 167);
            this.btnTorre.Name = "btnTorre";
            this.btnTorre.Size = new System.Drawing.Size(156, 23);
            this.btnTorre.TabIndex = 4;
            this.btnTorre.Text = "Ejecutar Torre.Mover()";
            this.btnTorre.UseVisualStyleBackColor = true;
            // 
            // btnCaballo
            // 
            this.btnCaballo.Location = new System.Drawing.Point(442, 223);
            this.btnCaballo.Name = "btnCaballo";
            this.btnCaballo.Size = new System.Drawing.Size(156, 23);
            this.btnCaballo.TabIndex = 5;
            this.btnCaballo.Text = "Ejecutar Caballo.Mover()";
            this.btnCaballo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCaballo);
            this.Controls.Add(this.btnTorre);
            this.Controls.Add(this.btnPeon);
            this.Controls.Add(this.btnViolin);
            this.Controls.Add(this.btnPiano);
            this.Controls.Add(this.btnGuitarra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuitarra;
        private System.Windows.Forms.Button btnPiano;
        private System.Windows.Forms.Button btnViolin;
        private System.Windows.Forms.Button btnPeon;
        private System.Windows.Forms.Button btnTorre;
        private System.Windows.Forms.Button btnCaballo;
    }
}

