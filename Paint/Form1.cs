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

        int mouseX;
        int mouseY;

        Pixel[,] pixeles;

        public Form1()
        {
            InitializeComponent();
            this.coordenadaInicioX = 0;
            this.coordenadaInicioY = 0;
            this.anchoPixel = 30;
            this.altoPixel = 30;

            this.mouseX = 0;
            this.mouseY = 0;

            this.filas = panel1.Width;
            this.columnas = panel1.Height;

            this.panel1.MouseClick += new MouseEventHandler(panel1_MouseDown);

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

        private void panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Point mouseDownLocation = new Point(e.X, e.Y);

            Color colorFondo = Color.Yellow;

            double posicionX  = e.X / anchoPixel;
            double posicionY = e.Y / altoPixel;

            mouseX = Convert.ToInt32(Math.Floor(posicionX));
            mouseY = Convert.ToInt32(Math.Floor(posicionY));

            MessageBox.Show("Pixel en la posicion: " + mouseX + ", " + mouseY);

            pixeles[mouseY, mouseX].setColorFondo(colorFondo);
            //pixeles[indiceX, indiceY].colorearPixel();
            panel1.Refresh();
        }

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
                for(int j = 0; j < columnas; j++)
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

            coordenadaInicioY = 0;

            if (altoPixel > 10 && anchoPixel > 10)
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

            } else {
                MessageBox.Show("Superaste el tamaño mínimo de los pixeles :(", "¡Advertencia!");
            } 
        }

    }
}
