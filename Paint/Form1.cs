﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Formulario : Form
    {
        int filas;
        int columnas;
        int contador;

        Point[] puntos;

        Lienzo lienzo;

        public Formulario()
        {
            InitializeComponent();
            this.contador = 0;
            this.filas = panelPrincipal.Width;
            this.columnas = panelPrincipal.Height;

            this.puntos = new Point[3];

            this.lienzo = new Lienzo(filas, columnas);

            this.panelPrincipal.MouseClick += new MouseEventHandler(panel1_MouseDown1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lienzo.DibujarCuadricula(e);
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lienzo.MaximizarCuadricula();
            panelPrincipal.Refresh();
        }

        private void btnMinizar_Click(object sender, EventArgs e)
        {
            lienzo.MinimizarCuadricula();
            panelPrincipal.Refresh();
        }

        private void panel1_MouseDown1(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Point mouseDownLocation = new Point(e.X, e.Y);

            double posicionX = e.X / Propiedades_Pixel.anchoPixel;
            double posicionY = e.Y / Propiedades_Pixel.altoPixel;

            labelCoordenadaX.Text = Convert.ToString(posicionX);
            labelCoordenadaY.Text = Convert.ToString(posicionY);

            int mouseX = Convert.ToInt32(Math.Floor(posicionX));
            int mouseY = Convert.ToInt32(Math.Floor(posicionY));

            if (contador < 3)
            {
                puntos[contador].X = mouseX;
                puntos[contador].Y = mouseY;

                if (contador == 0)
                {
                    txtX1.Text = Convert.ToString(puntos[0].X);
                    txtY1.Text = Convert.ToString(puntos[0].Y);
                }
                if (contador == 1)
                {
                    txtX2.Text = Convert.ToString(puntos[1].X);
                    txtY2.Text = Convert.ToString(puntos[1].Y);
                }
                else
                {
                    txtAncho.Text = Convert.ToString(puntos[2].X);
                    txtAlto.Text = Convert.ToString(puntos[2].Y);
                }
            }

            contador++;

            if (contador == 3)
            {
                contador = 0;
            }
        }

        private void btnDDA_Click(object sender, EventArgs e)
        {
            lienzo.LineaDDA(puntos[0].X, puntos[0].Y, puntos[1].X, puntos[1].Y);
            panelPrincipal.Refresh();
            btnLimpiarCoordenadas_Click(sender, e);
        }

        private void btnBresemham_Click(object sender, EventArgs e)
        {
            lienzo.LineaBresenham(puntos[0].X, puntos[0].Y, puntos[1].X, puntos[1].Y);
            panelPrincipal.Refresh();
            btnLimpiarCoordenadas_Click(sender, e);
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            lienzo.Circulo(puntos[0].X, puntos[0].Y, puntos[1].X, puntos[1].Y);
            panelPrincipal.Refresh();
            btnLimpiarCoordenadas_Click(sender, e);
        }

        private void btnElipse_Click(object sender, EventArgs e)
        {
            int dx1 = Math.Abs(Propiedades_Pixel.altoPixel * puntos[1].X - Propiedades_Pixel.anchoPixel * puntos[0].X);
            int dx2 = Math.Abs(Propiedades_Pixel.altoPixel * puntos[2].X - Propiedades_Pixel.anchoPixel * puntos[0].X);
            int dy1 = Math.Abs(Propiedades_Pixel.altoPixel * puntos[1].Y - Propiedades_Pixel.anchoPixel * puntos[0].Y);
            int dy2 = Math.Abs(Propiedades_Pixel.altoPixel * puntos[2].Y - Propiedades_Pixel.anchoPixel * puntos[0].Y);
            int ancho = (int) Math.Ceiling(Math.Sqrt(Math.Pow(dx1, 2) - Math.Pow(dy1, 2))) / Propiedades_Pixel.anchoPixel;
            int alto = (int) Math.Ceiling(Math.Sqrt(Math.Abs(Math.Pow(dx2, 2) - Math.Pow(dy2, 2)))) /  Propiedades_Pixel.altoPixel;

            lienzo.Elipse(puntos[0].X, puntos[0].Y, ancho, alto);
            panelPrincipal.Refresh();
            btnLimpiarCoordenadas_Click(sender, e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lienzo.LimpiarLienzo();
            panelPrincipal.Refresh();
            btnLimpiarCoordenadas_Click(sender, e);
            lienzo.BorrarObjetos();
            labelCoordenadaX.Text = "";
            labelCoordenadaY.Text = "";
        }

        private void BtnEncendidoApagado_Click(object sender, EventArgs e)
        {
            lienzo.EncendidoApagadoCuadricula();
            panelPrincipal.Refresh();
            btnLimpiarCoordenadas_Click(sender, e);
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            lienzo.boundaryFill4(puntos[0].X, puntos[0].Y, Propiedades_Pixel.colorFondo, lienzo.ColorPixel(puntos[0].X, puntos[0].Y));
            panelPrincipal.Refresh();
            btnLimpiarCoordenadas_Click(sender, e);
        }

        private void btnCafe_Click(object sender, EventArgs e)
        {
            Propiedades_Pixel.colorFondo = btnCafe.BackColor;
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            Propiedades_Pixel.colorFondo = btnRojo.BackColor;
        }

        private void btnNaranja_Click(object sender, EventArgs e)
        {
            Propiedades_Pixel.colorFondo = btnNaranja.BackColor;
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            Propiedades_Pixel.colorFondo = btnAzul.BackColor;
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            Propiedades_Pixel.colorFondo = btnVerde.BackColor;
        }

        private void BtnCeleste_Click(object sender, EventArgs e)
        {
            Propiedades_Pixel.colorFondo = BtnCeleste.BackColor;
        }

        private void btnRosa_Click(object sender, EventArgs e)
        {
            Propiedades_Pixel.colorFondo = btnRosa.BackColor;
        }

        private void btnAmarillo_Click(object sender, EventArgs e)
        {
            Propiedades_Pixel.colorFondo = btnAmarillo.BackColor;
        }

        private void btnBlanco_Click(object sender, EventArgs e)
        {
            Propiedades_Pixel.colorFondo = btnBlanco.BackColor;
        }

        private void btnNegro_Click(object sender, EventArgs e)
        {
            Propiedades_Pixel.colorFondo = btnNegro.BackColor;
        }

        private void btnTraslacion_Click(object sender, EventArgs e)
        {
            lienzo.ReconocimientoFigura(puntos[0].X , puntos[0].Y);
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            lienzo.TraslaciónDerecha();
            lienzo.ActualizarColores();
            panelPrincipal.Refresh();
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            lienzo.TraslaciónIzquierda();
            lienzo.ActualizarColores();
            panelPrincipal.Refresh();
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            lienzo.TraslaciónAbajo();
            lienzo.ActualizarColores();
            panelPrincipal.Refresh();
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            lienzo.TraslaciónArriba();
            lienzo.ActualizarColores();
            panelPrincipal.Refresh();
        }

        private void btnRotacion_Click(object sender, EventArgs e)
        {
            double angulo = Math.PI / 2;

            lienzo.Rotacion(puntos[1].X, puntos[1].Y, angulo);
            lienzo.ActualizarColores();
            panelPrincipal.Refresh();
        }

        private void btnLimpiarCoordenadas_Click(object sender, EventArgs e)
        {
            txtX1.Text = "0";
            txtY1.Text = "0";
            txtX2.Text = "0";
            txtY2.Text = "0";
            txtAncho.Text = "0";
            txtAlto.Text = "0";

            contador = 0;

            for (int i = 0; i < puntos.Length; i++)
            {
                puntos[i].X = 0;
                puntos[i].Y = 0;
            }
        }
    }
}
