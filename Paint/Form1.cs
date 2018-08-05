using System;
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
    public partial class Form1 : Form
    {
        int anchoPixel;
        int altoPixel;
        int coordenadaInicioX;
        int coordenadaInicioY;
        int filas;
        int columnas;
        int contador;

        Point [] puntos;

        Pixel[,] pixeles;

        public Form1()
        {
            InitializeComponent();
            this.coordenadaInicioX = 0;
            this.coordenadaInicioY = 0;
            this.anchoPixel = 30;
            this.altoPixel = 30;

            this.contador = 0;

            this.filas = panel1.Width;
            this.columnas = panel1.Height;

            this.puntos = new Point[2];

            //this.panel1.MouseClick += new MouseEventHandler(panel1_MouseDown);

            this.panel1.MouseClick += new MouseEventHandler(panel1_MouseDown1);

            pixeles = new Pixel[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    pixeles[i, j] = new Pixel(coordenadaInicioX, coordenadaInicioY, anchoPixel, altoPixel);
                    coordenadaInicioX += anchoPixel;
                }
                coordenadaInicioX = 0;
                coordenadaInicioY += altoPixel;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            dibujarCuadricula(e);
        }

        
        /*private void panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Point mouseDownLocation = new Point(e.X, e.Y);

            Color colorFondo = Color.Yellow;

            double posicionX  = e.X / anchoPixel;
            double posicionY = e.Y / altoPixel;

            int mouse1 = Convert.ToInt32(Math.Floor(posicionX));
            int mouse2 = Convert.ToInt32(Math.Floor(posicionY));

            pixeles[mouseY, mouseX].setColorFondo(colorFondo);
            //pixeles[indiceX, indiceY].colorearPixel();
            panel1.Refresh();
        }*/
        

        public void dibujarCuadricula(PaintEventArgs e)
        {
            for (int i = 0; i < filas / anchoPixel; i++)
            {
                for (int j = 0; j < columnas / altoPixel; j++)
                {
                    pixeles[i, j].dibujarPixel(e);
                }
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            altoPixel += 15;
            anchoPixel += 15;

            coordenadaInicioY = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    pixeles[i, j].setTamaño(anchoPixel, altoPixel);
                    pixeles[i, j].setPunto(coordenadaInicioX, coordenadaInicioY);
                    coordenadaInicioX += anchoPixel;
                }
                coordenadaInicioX = 0;
                coordenadaInicioY += altoPixel;
            }

            panel1.Refresh();
        }

        private void btnMinizar_Click(object sender, EventArgs e)
        {
            altoPixel -= 5;
            anchoPixel -= 5;

            coordenadaInicioY = 0;

            if (altoPixel > 5 && anchoPixel > 5)
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        pixeles[i, j].setPunto(coordenadaInicioX, coordenadaInicioY);
                        pixeles[i, j].setTamaño(anchoPixel, altoPixel);
                        coordenadaInicioX += anchoPixel;
                    }
                    coordenadaInicioX = 0;
                    coordenadaInicioY += altoPixel;
                }

                panel1.Refresh();

            }
            else
            {
                altoPixel = 10;
                anchoPixel = 10;
                MessageBox.Show("Superaste el tamaño mínimo de los pixeles :(", "¡Advertencia!");
            }
        }

        public void lineaDDA(int x1, int y1, int x2, int y2)
        {

            int dx = x2 - x1, dy = y2 - y1, pasos;
            float xIncremento, yIncremento, x = x1, y = y1;

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                pasos = Math.Abs(dx);
            }
            else
            {
                pasos = Math.Abs(dy);
            }

            xIncremento = dx / (float)pasos;
            yIncremento = dy / (float)pasos;

            pixeles[Convert.ToInt32(y), Convert.ToInt32(x)].setColorFondo(Color.Blue);

            for (int k = 0; k < pasos; k++)
            {
                x += xIncremento;
                y += yIncremento;
                pixeles[Convert.ToInt32(y), Convert.ToInt32(x)].setColorFondo(Color.Blue);
            }

        }

        private void btnDDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presiona click en el primer y último pixel de la línea que deseas realizar", "Algoritmo DDA");
            //lineaDDA(Convert.ToInt32(txtX1.Text), Convert.ToInt32(txtY1.Text), Convert.ToInt32(txtX2.Text), Convert.ToInt32(txtY2.Text));
            //panel1.Refresh();
        }

        private void panel1_MouseDown1(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Point mouseDownLocation = new Point(e.X, e.Y);

            double posicionX = e.X / anchoPixel;
            double posicionY = e.Y / altoPixel;

            int mouseX = Convert.ToInt32(Math.Floor(posicionX));
            int mouseY = Convert.ToInt32(Math.Floor(posicionY));

            if (contador < 2)
            {
                puntos[contador].X = mouseX;
                puntos[contador].Y = mouseY;
            }

            contador++;

            if (contador == 2)
            {
                lineaDDA(puntos[0].X, puntos[0].Y, puntos[1].X, puntos[1].Y);
                panel1.Refresh();
                contador = 0;
            }

        }

    }
}
