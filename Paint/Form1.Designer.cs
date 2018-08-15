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
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnNaranja = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelCoordenadaX = new System.Windows.Forms.Label();
            this.labelCoordenadaY = new System.Windows.Forms.Label();
            this.btnBresemham = new System.Windows.Forms.Button();
            this.BtnEncendidoApagado = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.BtnCeleste = new System.Windows.Forms.Button();
            this.btnAmarillo = new System.Windows.Forms.Button();
            this.btnNegro = new System.Windows.Forms.Button();
            this.btnBlanco = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnElipse = new System.Windows.Forms.Button();
            this.btnRellenar = new System.Windows.Forms.Button();
            this.btnLimpiarCoordenadas = new System.Windows.Forms.Button();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCafe = new System.Windows.Forms.Button();
            this.btnRosa = new System.Windows.Forms.Button();
            this.btnTraslacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 953);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDDA
            // 
            this.btnDDA.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDDA.Location = new System.Drawing.Point(1085, 436);
            this.btnDDA.Name = "btnDDA";
            this.btnDDA.Size = new System.Drawing.Size(266, 49);
            this.btnDDA.TabIndex = 1;
            this.btnDDA.Text = "DDA";
            this.btnDDA.UseVisualStyleBackColor = true;
            this.btnDDA.Click += new System.EventHandler(this.btnDDA_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1016, 123);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(75, 56);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinizar
            // 
            this.btnMinizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinizar.Image")));
            this.btnMinizar.Location = new System.Drawing.Point(1099, 123);
            this.btnMinizar.Name = "btnMinizar";
            this.btnMinizar.Size = new System.Drawing.Size(75, 56);
            this.btnMinizar.TabIndex = 3;
            this.btnMinizar.UseVisualStyleBackColor = true;
            this.btnMinizar.Click += new System.EventHandler(this.btnMinizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1163, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Paint";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1012, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Herramientas:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(1180, 123);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 56);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1100, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "x1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1234, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "y1:";
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(1133, 303);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(69, 22);
            this.txtX1.TabIndex = 9;
            this.txtX1.Text = "0";
            this.txtX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(1267, 303);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(69, 22);
            this.txtY1.TabIndex = 10;
            this.txtY1.Text = "0";
            this.txtY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(1267, 331);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(69, 22);
            this.txtY2.TabIndex = 14;
            this.txtY2.Text = "0";
            this.txtY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(1133, 331);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(69, 22);
            this.txtX2.TabIndex = 13;
            this.txtX2.Text = "0";
            this.txtX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1234, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "y2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1100, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "x2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1144, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ingrese las coodenadas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1037, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Algoritmos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1015, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Colores:";
            // 
            // btnRojo
            // 
            this.btnRojo.BackColor = System.Drawing.Color.Red;
            this.btnRojo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRojo.Location = new System.Drawing.Point(1070, 223);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(32, 32);
            this.btnRojo.TabIndex = 18;
            this.btnRojo.UseVisualStyleBackColor = false;
            this.btnRojo.Click += new System.EventHandler(this.btnRojo_Click);
            // 
            // btnNaranja
            // 
            this.btnNaranja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNaranja.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaranja.Location = new System.Drawing.Point(1108, 223);
            this.btnNaranja.Name = "btnNaranja";
            this.btnNaranja.Size = new System.Drawing.Size(32, 32);
            this.btnNaranja.TabIndex = 19;
            this.btnNaranja.UseVisualStyleBackColor = false;
            this.btnNaranja.Click += new System.EventHandler(this.btnNaranja_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1158, 808);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "x:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1273, 808);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "y:";
            // 
            // labelCoordenadaX
            // 
            this.labelCoordenadaX.AutoSize = true;
            this.labelCoordenadaX.BackColor = System.Drawing.Color.Transparent;
            this.labelCoordenadaX.Location = new System.Drawing.Point(1183, 808);
            this.labelCoordenadaX.Name = "labelCoordenadaX";
            this.labelCoordenadaX.Size = new System.Drawing.Size(0, 17);
            this.labelCoordenadaX.TabIndex = 23;
            // 
            // labelCoordenadaY
            // 
            this.labelCoordenadaY.AutoSize = true;
            this.labelCoordenadaY.BackColor = System.Drawing.Color.Transparent;
            this.labelCoordenadaY.Location = new System.Drawing.Point(1298, 808);
            this.labelCoordenadaY.Name = "labelCoordenadaY";
            this.labelCoordenadaY.Size = new System.Drawing.Size(0, 17);
            this.labelCoordenadaY.TabIndex = 24;
            // 
            // btnBresemham
            // 
            this.btnBresemham.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBresemham.Location = new System.Drawing.Point(1085, 491);
            this.btnBresemham.Name = "btnBresemham";
            this.btnBresemham.Size = new System.Drawing.Size(266, 49);
            this.btnBresemham.TabIndex = 25;
            this.btnBresemham.Text = "Bresemham";
            this.btnBresemham.UseVisualStyleBackColor = true;
            this.btnBresemham.Click += new System.EventHandler(this.btnBresemham_Click);
            // 
            // BtnEncendidoApagado
            // 
            this.BtnEncendidoApagado.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEncendidoApagado.Image = ((System.Drawing.Image)(resources.GetObject("BtnEncendidoApagado.Image")));
            this.BtnEncendidoApagado.Location = new System.Drawing.Point(1261, 123);
            this.BtnEncendidoApagado.Name = "BtnEncendidoApagado";
            this.BtnEncendidoApagado.Size = new System.Drawing.Size(75, 56);
            this.BtnEncendidoApagado.TabIndex = 26;
            this.BtnEncendidoApagado.UseVisualStyleBackColor = true;
            this.BtnEncendidoApagado.Click += new System.EventHandler(this.BtnEncendidoApagado_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(113)))), ((int)(((byte)(163)))));
            this.btnAzul.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzul.Location = new System.Drawing.Point(1222, 223);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(32, 32);
            this.btnAzul.TabIndex = 27;
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(73)))));
            this.btnVerde.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerde.Location = new System.Drawing.Point(1184, 223);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(32, 32);
            this.btnVerde.TabIndex = 28;
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // BtnCeleste
            // 
            this.BtnCeleste.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BtnCeleste.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCeleste.Location = new System.Drawing.Point(1260, 223);
            this.BtnCeleste.Name = "BtnCeleste";
            this.BtnCeleste.Size = new System.Drawing.Size(32, 32);
            this.BtnCeleste.TabIndex = 29;
            this.BtnCeleste.UseVisualStyleBackColor = false;
            this.BtnCeleste.Click += new System.EventHandler(this.BtnCeleste_Click);
            // 
            // btnAmarillo
            // 
            this.btnAmarillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnAmarillo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmarillo.Location = new System.Drawing.Point(1146, 223);
            this.btnAmarillo.Name = "btnAmarillo";
            this.btnAmarillo.Size = new System.Drawing.Size(32, 32);
            this.btnAmarillo.TabIndex = 30;
            this.btnAmarillo.UseVisualStyleBackColor = false;
            this.btnAmarillo.Click += new System.EventHandler(this.btnAmarillo_Click);
            // 
            // btnNegro
            // 
            this.btnNegro.BackColor = System.Drawing.Color.Black;
            this.btnNegro.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegro.Location = new System.Drawing.Point(1374, 223);
            this.btnNegro.Name = "btnNegro";
            this.btnNegro.Size = new System.Drawing.Size(32, 32);
            this.btnNegro.TabIndex = 31;
            this.btnNegro.UseVisualStyleBackColor = false;
            this.btnNegro.Click += new System.EventHandler(this.btnNegro_Click);
            // 
            // btnBlanco
            // 
            this.btnBlanco.BackColor = System.Drawing.Color.White;
            this.btnBlanco.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlanco.Location = new System.Drawing.Point(1336, 223);
            this.btnBlanco.Name = "btnBlanco";
            this.btnBlanco.Size = new System.Drawing.Size(32, 32);
            this.btnBlanco.TabIndex = 32;
            this.btnBlanco.UseVisualStyleBackColor = false;
            this.btnBlanco.Click += new System.EventHandler(this.btnBlanco_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1037, 806);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 19);
            this.label12.TabIndex = 33;
            this.label12.Text = "Pixel número:";
            // 
            // btnCirculo
            // 
            this.btnCirculo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCirculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCirculo.Location = new System.Drawing.Point(1085, 546);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(266, 49);
            this.btnCirculo.TabIndex = 34;
            this.btnCirculo.Text = "Circulo";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnElipse
            // 
            this.btnElipse.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElipse.Image = ((System.Drawing.Image)(resources.GetObject("btnElipse.Image")));
            this.btnElipse.Location = new System.Drawing.Point(1085, 601);
            this.btnElipse.Name = "btnElipse";
            this.btnElipse.Size = new System.Drawing.Size(266, 49);
            this.btnElipse.TabIndex = 35;
            this.btnElipse.UseVisualStyleBackColor = true;
            this.btnElipse.Click += new System.EventHandler(this.btnElipse_Click);
            // 
            // btnRellenar
            // 
            this.btnRellenar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRellenar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRellenar.Image = ((System.Drawing.Image)(resources.GetObject("btnRellenar.Image")));
            this.btnRellenar.Location = new System.Drawing.Point(1342, 123);
            this.btnRellenar.Name = "btnRellenar";
            this.btnRellenar.Size = new System.Drawing.Size(74, 56);
            this.btnRellenar.TabIndex = 36;
            this.btnRellenar.UseVisualStyleBackColor = true;
            this.btnRellenar.Click += new System.EventHandler(this.btnRellenar_Click);
            // 
            // btnLimpiarCoordenadas
            // 
            this.btnLimpiarCoordenadas.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCoordenadas.Location = new System.Drawing.Point(1085, 711);
            this.btnLimpiarCoordenadas.Name = "btnLimpiarCoordenadas";
            this.btnLimpiarCoordenadas.Size = new System.Drawing.Size(266, 49);
            this.btnLimpiarCoordenadas.TabIndex = 37;
            this.btnLimpiarCoordenadas.Text = "Limpiar coordenadas";
            this.btnLimpiarCoordenadas.UseVisualStyleBackColor = true;
            this.btnLimpiarCoordenadas.Click += new System.EventHandler(this.btnLimpiarCoordenadas_Click);
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(1133, 359);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(69, 22);
            this.txtAncho.TabIndex = 38;
            this.txtAncho.Text = "0";
            this.txtAncho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAlto
            // 
            this.txtAlto.Location = new System.Drawing.Point(1267, 359);
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(69, 22);
            this.txtAlto.TabIndex = 39;
            this.txtAlto.Text = "0";
            this.txtAlto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1101, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 17);
            this.label13.TabIndex = 40;
            this.label13.Text = "x3:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1234, 362);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 17);
            this.label14.TabIndex = 41;
            this.label14.Text = "y3:";
            // 
            // btnCafe
            // 
            this.btnCafe.BackColor = System.Drawing.Color.Brown;
            this.btnCafe.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCafe.Location = new System.Drawing.Point(1032, 223);
            this.btnCafe.Name = "btnCafe";
            this.btnCafe.Size = new System.Drawing.Size(32, 32);
            this.btnCafe.TabIndex = 42;
            this.btnCafe.UseVisualStyleBackColor = false;
            this.btnCafe.Click += new System.EventHandler(this.btnCafe_Click);
            // 
            // btnRosa
            // 
            this.btnRosa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(58)))), ((int)(((byte)(123)))));
            this.btnRosa.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRosa.Location = new System.Drawing.Point(1298, 223);
            this.btnRosa.Name = "btnRosa";
            this.btnRosa.Size = new System.Drawing.Size(32, 32);
            this.btnRosa.TabIndex = 43;
            this.btnRosa.UseVisualStyleBackColor = false;
            this.btnRosa.Click += new System.EventHandler(this.btnRosa_Click);
            // 
            // btnTraslacion
            // 
            this.btnTraslacion.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraslacion.Location = new System.Drawing.Point(1085, 656);
            this.btnTraslacion.Name = "btnTraslacion";
            this.btnTraslacion.Size = new System.Drawing.Size(266, 49);
            this.btnTraslacion.TabIndex = 44;
            this.btnTraslacion.Text = "Traslación";
            this.btnTraslacion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(187)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(1477, 877);
            this.Controls.Add(this.btnLimpiarCoordenadas);
            this.Controls.Add(this.btnTraslacion);
            this.Controls.Add(this.btnRosa);
            this.Controls.Add(this.btnCafe);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAlto);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.btnRellenar);
            this.Controls.Add(this.btnElipse);
            this.Controls.Add(this.btnCirculo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnBlanco);
            this.Controls.Add(this.btnNegro);
            this.Controls.Add(this.btnAmarillo);
            this.Controls.Add(this.BtnCeleste);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.BtnEncendidoApagado);
            this.Controls.Add(this.btnBresemham);
            this.Controls.Add(this.labelCoordenadaY);
            this.Controls.Add(this.labelCoordenadaX);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnNaranja);
            this.Controls.Add(this.btnRojo);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnNaranja;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelCoordenadaX;
        private System.Windows.Forms.Label labelCoordenadaY;
        private System.Windows.Forms.Button btnBresemham;
        private System.Windows.Forms.Button BtnEncendidoApagado;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button BtnCeleste;
        private System.Windows.Forms.Button btnAmarillo;
        private System.Windows.Forms.Button btnNegro;
        private System.Windows.Forms.Button btnBlanco;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnElipse;
        private System.Windows.Forms.Button btnRellenar;
        private System.Windows.Forms.Button btnLimpiarCoordenadas;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCafe;
        private System.Windows.Forms.Button btnRosa;
        private System.Windows.Forms.Button btnTraslacion;
    }
}

