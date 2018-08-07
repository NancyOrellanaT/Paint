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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDDA = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelCoordenadaX = new System.Windows.Forms.Label();
            this.labelCoordenadaY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 763);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDDA
            // 
            this.btnDDA.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDDA.Location = new System.Drawing.Point(956, 450);
            this.btnDDA.Name = "btnDDA";
            this.btnDDA.Size = new System.Drawing.Size(218, 46);
            this.btnDDA.TabIndex = 1;
            this.btnDDA.Text = "Algoritmo DDA";
            this.btnDDA.UseVisualStyleBackColor = true;
            this.btnDDA.Click += new System.EventHandler(this.btnDDA_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(936, 126);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(75, 48);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinizar
            // 
            this.btnMinizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinizar.Image")));
            this.btnMinizar.Location = new System.Drawing.Point(1017, 126);
            this.btnMinizar.Name = "btnMinizar";
            this.btnMinizar.Size = new System.Drawing.Size(75, 48);
            this.btnMinizar.TabIndex = 3;
            this.btnMinizar.UseVisualStyleBackColor = true;
            this.btnMinizar.Click += new System.EventHandler(this.btnMinizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1025, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Paint";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(932, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Herramientas:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(1099, 126);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 48);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(959, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "x1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1072, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "y1:";
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(992, 372);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(69, 22);
            this.txtX1.TabIndex = 9;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(1105, 372);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(69, 22);
            this.txtY1.TabIndex = 10;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(1105, 400);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(69, 22);
            this.txtY2.TabIndex = 14;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(992, 400);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(69, 22);
            this.txtX2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1072, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "y2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(959, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "x2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(974, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ingrese las coodenadas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(936, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Algoritmos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(932, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Colores:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(936, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(963, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(959, 710);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "x:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1074, 710);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "y:";
            // 
            // labelCoordenadaX
            // 
            this.labelCoordenadaX.AutoSize = true;
            this.labelCoordenadaX.BackColor = System.Drawing.Color.Transparent;
            this.labelCoordenadaX.Location = new System.Drawing.Point(984, 710);
            this.labelCoordenadaX.Name = "labelCoordenadaX";
            this.labelCoordenadaX.Size = new System.Drawing.Size(0, 17);
            this.labelCoordenadaX.TabIndex = 23;
            // 
            // labelCoordenadaY
            // 
            this.labelCoordenadaY.AutoSize = true;
            this.labelCoordenadaY.BackColor = System.Drawing.Color.Transparent;
            this.labelCoordenadaY.Location = new System.Drawing.Point(1099, 710);
            this.labelCoordenadaY.Name = "labelCoordenadaY";
            this.labelCoordenadaY.Size = new System.Drawing.Size(0, 17);
            this.labelCoordenadaY.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(187)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(1282, 763);
            this.Controls.Add(this.labelCoordenadaY);
            this.Controls.Add(this.labelCoordenadaX);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMinizar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDDA);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDDA;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelCoordenadaX;
        private System.Windows.Forms.Label labelCoordenadaY;
    }
}

