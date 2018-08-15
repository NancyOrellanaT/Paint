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
                    pixeles[i, j].setTamañoBorde(Propiedades_Pixel.tamañoBorde);
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
                        pixeles[i, j].setTamañoBorde(Propiedades_Pixel.tamañoBorde);
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

            if (Propiedades_Pixel.tamañoBorde > 0)
            {
                Propiedades_Pixel.colorBorde = Color.White;
                Propiedades_Pixel.tamañoBorde = 0;

                for (int i = 0; i < filas / Propiedades_Pixel.anchoPixel; i++)
                {
                    for (int j = 0; j < columnas / Propiedades_Pixel.altoPixel; j++)
                    {
                        pixeles[i, j].setTamañoBorde(Propiedades_Pixel.tamañoBorde);
                        pixeles[i, j].setColorBorde(Propiedades_Pixel.colorBorde);
                    }
                }
            }
            else
            {
                Propiedades_Pixel.colorBorde = Color.Black;
                Propiedades_Pixel.tamañoBorde = 2;
                for (int i = 0; i < filas / Propiedades_Pixel.anchoPixel; i++)
                {
                    for (int j = 0; j < columnas / Propiedades_Pixel.altoPixel; j++)
                    {
                        pixeles[i, j].setTamañoBorde(Propiedades_Pixel.tamañoBorde);
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

        public void LineaBresenham(int x, int y, int x2, int y2)
        {
            int w = x2 - x;
            int h = y2 - y;
            int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0;
            if (w < 0) dx1 = -1; else if (w > 0) dx1 = 1;
            if (h < 0) dy1 = -1; else if (h > 0) dy1 = 1;
            if (w < 0) dx2 = -1; else if (w > 0) dx2 = 1;
            int longest = Math.Abs(w);
            int shortest = Math.Abs(h);
            if (!(longest > shortest))
            {
                longest = Math.Abs(h);
                shortest = Math.Abs(w);
                if (h < 0) dy2 = -1; else if (h > 0) dy2 = 1;
                dx2 = 0;
            }
            int numerator = longest >> 1;
            for (int i = 0; i <= longest; i++)
            {
                pixeles[y, x].setColorFondo(Propiedades_Pixel.colorFondo);
                numerator += shortest;
                if (!(numerator < longest))
                {
                    numerator -= longest;
                    x += dx1;
                    y += dy1;
                }
                else
                {
                    x += dx2;
                    y += dy2;
                }
            }
        }

        public void Circulo(int xCentro, int yCentro, int xRadio, int yRadio)
        {
            int x = 0;
            double distancia = Math.Sqrt(Math.Pow((xRadio - xCentro),2) + Math.Pow((yRadio - yCentro),2));
            int radio = Convert.ToInt32(distancia);
            int y = radio;
            int p = 1 - radio;

            PuntosCirculo(xCentro, yCentro, x, y);

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
                PuntosCirculo(xCentro, yCentro, x , y);
            }
        }

        public void PuntosCirculo(int xCentro, int yCentro, int x, int y)
        {
            try
            {
                pixeles[yCentro + y, xCentro + x].setColorFondo(Propiedades_Pixel.colorFondo);
            } catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            try
            {
                pixeles[yCentro + y, xCentro - x].setColorFondo(Propiedades_Pixel.colorFondo);
            } catch(Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            try
            {
                pixeles[yCentro - y, xCentro + x].setColorFondo(Propiedades_Pixel.colorFondo);
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            try
            {
                pixeles[yCentro - y, xCentro - x].setColorFondo(Propiedades_Pixel.colorFondo);
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            try
            {
                pixeles[yCentro + x, xCentro + y].setColorFondo(Propiedades_Pixel.colorFondo);
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            try
            {
                pixeles[yCentro + x, xCentro - y].setColorFondo(Propiedades_Pixel.colorFondo);
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            try
            {
                pixeles[yCentro - x, xCentro + y].setColorFondo(Propiedades_Pixel.colorFondo);
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            try
            {
                pixeles[yCentro - x, xCentro - y].setColorFondo(Propiedades_Pixel.colorFondo);
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");

            }               
        }
    
        public void Elipse(int xCentro, int yCentro, int rX, int rY) {
 
            int rX2 = rX * rX;
            int rY2 = rY * rY;
            int dosRx2 = 2 * rX2;
            int dosRy2 = 2 * rY2;
            int p;
            int x = 0;
            int y = rY;
            int px = 0;
            int py = dosRx2 * y;

            ElipsePuntos(xCentro, yCentro, x, y);

            p = Convert.ToInt32(Math.Round(rY2 - (rX2 * rY) + (0.25 * rX2)));

            //Region 1
            while (px < py)
            {
                x++;
                px += dosRy2;
                if (p < 0)
                {
                    p += rY2 + px;
                }
                else
                {
                    y--;
                    py -= dosRx2;
                    p += rY2 + px - py;
                }
                
                ElipsePuntos(xCentro, yCentro, x, y);
            }

            //Region 2
            p = Convert.ToInt32(Math.Round(rY2 * (x + 0.5) * (x + 0.5) + rX2 * (y - 1) * (y - 1) - rX2 * rY2));
            while (y > 0)
            {
                y--;
                py -= dosRx2;
                if (p > 0)
                {
                    p += rX2 - py;
                }
                else
                {
                    x++;
                    px += dosRy2;
                    p += rX2 - py + px;
                }
                ElipsePuntos(xCentro, yCentro, x, y);
            }
        }

        private void ElipsePuntos(int xCentro, int yCentro, int x, int y)
        {
            try
            {
                pixeles[yCentro + y, xCentro + x].setColorFondo(Propiedades_Pixel.colorFondo);
            } catch(Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            try
            {
                pixeles[yCentro + y, xCentro - x].setColorFondo(Propiedades_Pixel.colorFondo);
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            try
            {
                pixeles[yCentro - y, xCentro + x].setColorFondo(Propiedades_Pixel.colorFondo);
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            try
            {
                Console.WriteLine("Indice fuera del rango");
                pixeles[yCentro - y, xCentro - x].setColorFondo(Propiedades_Pixel.colorFondo);
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
        }

        public void boundaryFill4(int x, int y, Color fill, Color boundary)
        {
            try {
                Color current = pixeles[y, x].getColorFondo();
               
                if ((current != boundary) && (current != fill))
                {
                    Propiedades_Pixel.colorFondo = fill;
                    pixeles[y, x].setColorFondo(fill);
                    boundaryFill4(x + 1, y, fill, boundary);
                    boundaryFill4(x - 1, y, fill, boundary);
                    boundaryFill4(x, y + 1, fill, boundary);
                    boundaryFill4(x, y - 1, fill, boundary);
                }
            }
            catch (Exception e)
            {
                
            }
            
        }
    }
}
