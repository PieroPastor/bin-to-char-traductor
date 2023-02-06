namespace traductorBinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.findArch = new System.Windows.Forms.Button();
            this.traducirBinario = new System.Windows.Forms.Button();
            this.traducirLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(699, 330);
            this.textBox1.TabIndex = 0;
            // 
            // findArch
            // 
            this.findArch.AutoSize = true;
            this.findArch.Location = new System.Drawing.Point(321, 361);
            this.findArch.Name = "findArch";
            this.findArch.Size = new System.Drawing.Size(177, 64);
            this.findArch.TabIndex = 1;
            this.findArch.Text = "Archivo";
            this.findArch.UseVisualStyleBackColor = true;
            this.findArch.Click += new System.EventHandler(this.findArch_Click);
            // 
            // traducirBinario
            // 
            this.traducirBinario.AutoSize = true;
            this.traducirBinario.Location = new System.Drawing.Point(55, 361);
            this.traducirBinario.Name = "traducirBinario";
            this.traducirBinario.Size = new System.Drawing.Size(177, 64);
            this.traducirBinario.TabIndex = 2;
            this.traducirBinario.Text = "Traducir a Binario";
            this.traducirBinario.UseVisualStyleBackColor = true;
            this.traducirBinario.Click += new System.EventHandler(this.traducirBinario_Click);
            // 
            // traducirLetras
            // 
            this.traducirLetras.AutoSize = true;
            this.traducirLetras.Location = new System.Drawing.Point(577, 361);
            this.traducirLetras.Name = "traducirLetras";
            this.traducirLetras.Size = new System.Drawing.Size(177, 64);
            this.traducirLetras.TabIndex = 3;
            this.traducirLetras.Text = "Traducir a Caracteres";
            this.traducirLetras.UseVisualStyleBackColor = true;
            this.traducirLetras.Click += new System.EventHandler(this.traducirLetras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.traducirLetras);
            this.Controls.Add(this.traducirBinario);
            this.Controls.Add(this.findArch);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(822, 506);
            this.Name = "Form1";
            this.Text = "Traductor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button findArch;
        private System.Windows.Forms.Button traducirBinario;
        private System.Windows.Forms.Button traducirLetras;
    }
}

