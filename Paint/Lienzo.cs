using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    class Lienzo
    {
        Pixel[,] pixeles;

        int filas;
        int columnas;

        public Lienzo(int filas, int columnas) {

            this.filas = filas;
            this.columnas = columnas;
          
            pixeles = new Pixel[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    pixeles[i, j] = new Pixel(Propiedades_Pixel.coordenadaInicioX, Propiedades_Pixel.coordenadaInicioY, Propiedades_Pixel.anchoPixel, Propiedades_Pixel.altoPixel);
                    Propiedades_Pixel.coordenadaInicioX += Propiedades_Pixel.anchoPixel;
                }
                Propiedades_Pixel.coordenadaInicioX = 0;
                Propiedades_Pixel.coordenadaInicioY += Propiedades_Pixel.altoPixel;
            }
        }

        public void DibujarCuadricula(PaintEventArgs e)
        {
            for (int i = 0; i < filas / Propiedades_Pixel.anchoPixel; i++)
            {
                for (int j = 0; j < columnas / Propiedades_Pixel.altoPixel; j++)
                {
                    pixeles[i, j].dibujarPixel(e);
                }
            }
        }

        public void MaximizarCuadricula()
        {
            Propiedades_Pixel.altoPixel += 15;
            Propiedades_Pixel.anchoPixel += 15;

            Propiedades_Pixel.coordenadaInicioY = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    pixeles[i, j].setTamaño(Propiedades_Pixel.anchoPixel, Propiedades_Pixel.altoPixel);
                    pixeles[i, j].setPunto(Propiedades_Pixel.coordenadaInicioX, Propiedades_Pixel.coordenadaInicioY);
                    pixeles[i, j].setColorBorde(Propiedades_Pixel.colorBorde);
                    Propiedades_Pixel.coordenadaInicioX += Propiedades_Pixel.anchoPixel;
                }
                Propiedades_Pixel.coordenadaInicioX = 0;
                Propiedades_Pixel.coordenadaInicioY += Propiedades_Pixel.altoPixel;
            }
        }

        public void MinimizarCuadricula()
        {

            Propiedades_Pixel.altoPixel -= 5;
            Propiedades_Pixel.anchoPixel -= 5;

            Propiedades_Pixel.coordenadaInicioY = 0;

            if (Propiedades_Pixel.altoPixel > 5 && Propiedades_Pixel.anchoPixel > 5)
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        pixeles[i, j].setPunto(Propiedades_Pixel.coordenadaInicioX, Propiedades_Pixel.coordenadaInicioY);
                        pixeles[i, j].setTamaño(Propiedades_Pixel.anchoPixel, Propiedades_Pixel.altoPixel);
                        pixeles[i, j].setColorBorde(Propiedades_Pixel.colorBorde);
                        Propiedades_Pixel.coordenadaInicioX += Propiedades_Pixel.anchoPixel;
                    }
                    Propiedades_Pixel.coordenadaInicioX = 0;
                    Propiedades_Pixel.coordenadaInicioY += Propiedades_Pixel.altoPixel;
                }    
            }
            else
            {
                Propiedades_Pixel.altoPixel = 10;
                Propiedades_Pixel.anchoPixel = 10;
                MessageBox.Show("Superaste el tamaño mínimo de los pixeles :(", "¡Advertencia!");
            }
        }

        public void LimpiarLienzo()
        {
            Propiedades_Pixel.colorFondo = Color.White;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    pixeles[i, j].setColorFondo(Propiedades_Pixel.colorFondo);
                }
            }
        }

        public void EncendidoApagadoCuadricula()
        {
            if (Propiedades_Pixel.colorBorde == Color.Black)
            {
                Propiedades_Pixel.colorBorde = Color.White;
                for (int i = 0; i < filas / Propiedades_Pixel.anchoPixel; i++)
                {
                    for (int j = 0; j < columnas / Propiedades_Pixel.altoPixel; j++)
                    {
                        pixeles[i, j].setColorBorde(Propiedades_Pixel.colorBorde);
                    }
                }
            }
            else
            {
                Propiedades_Pixel.colorBorde = Color.Black;
                for (int i = 0; i < filas / Propiedades_Pixel.anchoPixel; i++)
                {
                    for (int j = 0; j < columnas / Propiedades_Pixel.altoPixel; j++)
                    {
                        pixeles[i, j].setColorBorde(Propiedades_Pixel.colorBorde);
                    }
                }
            }
        }

        //Algoritmos-------------------------------------------------------------------------------
        public void LineaDDA(int x1, int y1, int x2, int y2)
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

            pixeles[Convert.ToInt32(y), Convert.ToInt32(x)].setColorFondo(Propiedades_Pixel.colorFondo);

            for (int k = 0; k < pasos; k++)
            {
                x += xIncremento;
                y += yIncremento;
                pixeles[Convert.ToInt32(y), Convert.ToInt32(x)].setColorFondo(Propiedades_Pixel.colorFondo);
            }
        }

        public void LineaBresenham(int x1, int y1, int x2, int y2)
        {
            int dx = Math.Abs(x1 - x2);
            int dy = Math.Abs(y1 - y2);
            int p = 2 * dy - dx;
            int dosDy = 2 * dy, dosDyDx = 2 * (dy - dx);
            int x, y, xFinal;

            //Calculo de la pendiente
            //double pendiente = (y2 -y1) / (x2 - x1);

            if (x1 > x2)
            {
                x = x2;
                y = y2;
                xFinal = x1;
            }
            else
            {
                x = x1;
                y = y1;
                xFinal = x2;
            }
            pixeles[y, x].setColorFondo(Propiedades_Pixel.colorFondo);

            while (x < xFinal)
            {
                x++;
                if (p < 0)
                {
                    p += dosDy;
                }
                else
                {
                    y++;
                    p += dosDyDx;
                }
                pixeles[y, x].setColorFondo(Propiedades_Pixel.colorFondo);
            }
        }

        public void circulo(int xCentro, int yCentro, int xRadio, int yRadio)
        {
            int x = 0;
            double distancia = Math.Sqrt(Math.Pow((xRadio - xCentro),2) + Math.Pow((yRadio - yCentro),2));
            int radio = Convert.ToInt32(distancia);
            int y = radio;
            int p = 1 - radio;

            puntosCirculo(xCentro, yCentro, x, y);

         while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                } else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                puntosCirculo(xCentro, yCentro, x , y);
            }
        }

        public void puntosCirculo(int xCentro, int yCentro, int x, int y)
        {
            pixeles[yCentro + y, xCentro + x].setColorFondo(Propiedades_Pixel.colorFondo);
            pixeles[yCentro + y, xCentro - x].setColorFondo(Propiedades_Pixel.colorFondo);
            pixeles[yCentro - y, xCentro + x].setColorFondo(Propiedades_Pixel.colorFondo);
            pixeles[yCentro - y, xCentro - x].setColorFondo(Propiedades_Pixel.colorFondo);
            pixeles[yCentro + x, xCentro + y].setColorFondo(Propiedades_Pixel.colorFondo);
            pixeles[yCentro + x, xCentro - y].setColorFondo(Propiedades_Pixel.colorFondo);
            pixeles[yCentro - x, xCentro + y].setColorFondo(Propiedades_Pixel.colorFondo);
            pixeles[yCentro - x, xCentro - y].setColorFondo(Propiedades_Pixel.colorFondo);
        }
    }
}
