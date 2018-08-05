namespace Paint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPintar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 600);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnPintar
            // 
            this.btnPintar.Location = new System.Drawing.Point(777, 309);
            this.btnPintar.Name = "btnPintar";
            this.btnPintar.Size = new System.Drawing.Size(177, 46);
            this.btnPintar.TabIndex = 1;
            this.btnPintar.Text = "Pintar";
            this.btnPintar.UseVisualStyleBackColor = true;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Location = new System.Drawing.Point(777, 154);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(177, 46);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.Text = "Maximizar";
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinizar
            // 
            this.btnMinizar.Location = new System.Drawing.Point(777, 232);
            this.btnMinizar.Name = "btnMinizar";
            this.btnMinizar.Size = new System.Drawing.Size(177, 46);
            this.btnMinizar.TabIndex = 3;
            this.btnMinizar.Text = "Minimizar";
            this.btnMinizar.UseVisualStyleBackColor = true;
            this.btnMinizar.Click += new System.EventHandler(this.btnMinizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 633);
            this.Controls.Add(this.btnMinizar);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnPintar);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPintar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinizar;
    }
}

