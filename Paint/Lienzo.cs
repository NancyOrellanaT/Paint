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

        List<Figura> figuras;
        List<Point> figuraSeleccionada;

        Point punto;

        int filas;
        int columnas;

        Color colorFigura;

        public Lienzo(int filas, int columnas)
        {
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

            figuras = new List<Figura>();
            figuraSeleccionada = new List<Point>();

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

        //Algoritmos
        public void LineaDDA(int x1, int y1, int x2, int y2)
        {
            Color colorFondo = Propiedades_Pixel.colorFondo;
            List<Point> puntos = new List<Point>();

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

            puntos.Add(new Point(Convert.ToInt32(x), Convert.ToInt32(y)));

            for (int k = 0; k < pasos; k++)
            {
                x += xIncremento;
                y += yIncremento;
                pixeles[Convert.ToInt32(y), Convert.ToInt32(x)].setColorFondo(Propiedades_Pixel.colorFondo);
                puntos.Add(new Point(Convert.ToInt32(x), Convert.ToInt32(y)));
            }

            figuras.Add(new Figura(puntos, colorFondo, "LineaDDA"));

        }

        public void LineaBresenham(int x, int y, int x2, int y2)
        {
            Color colorFondo = Propiedades_Pixel.colorFondo;
            List<Point> puntos = new List<Point>();

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
                puntos.Add(punto = new Point(Convert.ToInt32(x), Convert.ToInt32(y)));
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

            figuras.Add(new Figura(puntos, colorFondo, "Linea Bresenham"));
        }

        public void Circulo(int xCentro, int yCentro, int xRadio, int yRadio)
        {
            Color colorFondo = Propiedades_Pixel.colorFondo;

            List<Point> listaPuntos = new List<Point>();

            int x = 0;
            double distancia = Math.Sqrt(Math.Pow((xRadio - xCentro), 2) + Math.Pow((yRadio - yCentro), 2));
            int radio = Convert.ToInt32(distancia);
            int y = radio;
            int p = 1 - radio;

            PuntosCirculo(xCentro, yCentro, x, y, listaPuntos);

            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                PuntosCirculo(xCentro, yCentro, x, y, listaPuntos);
            }

            figuras.Add(new Figura(listaPuntos, colorFondo, "Circulo"));

        }

        public void PuntosCirculo(int xCentro, int yCentro, int x, int y, List<Point> puntosCircunferencia)
        {

            try
            {
                pixeles[yCentro + y, xCentro + x].setColorFondo(Propiedades_Pixel.colorFondo);
                puntosCircunferencia.Add(punto = new Point(xCentro + x, yCentro + y));
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            try
            {
                pixeles[yCentro + y, xCentro - x].setColorFondo(Propiedades_Pixel.colorFondo);
                puntosCircunferencia.Add(punto = new Point(xCentro - x, yCentro + y));
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            try
            {
                pixeles[yCentro - y, xCentro + x].setColorFondo(Propiedades_Pixel.colorFondo);
                puntosCircunferencia.Add(punto = new Point(xCentro + x, yCentro - y));
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            try
            {
                pixeles[yCentro - y, xCentro - x].setColorFondo(Propiedades_Pixel.colorFondo);
                puntosCircunferencia.Add(punto = new Point(xCentro - x, yCentro - y));
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            try
            {
                pixeles[yCentro + x, xCentro + y].setColorFondo(Propiedades_Pixel.colorFondo);
                puntosCircunferencia.Add(punto = new Point(xCentro + y, yCentro + x));
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            try
            {
                pixeles[yCentro + x, xCentro - y].setColorFondo(Propiedades_Pixel.colorFondo);
                puntosCircunferencia.Add(punto = new Point(xCentro - y, yCentro + x));
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            try
            {
                pixeles[yCentro - x, xCentro + y].setColorFondo(Propiedades_Pixel.colorFondo);
                puntosCircunferencia.Add(punto = new Point(xCentro + y, yCentro - x));
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            try
            {
                pixeles[yCentro - x, xCentro - y].setColorFondo(Propiedades_Pixel.colorFondo);
                puntosCircunferencia.Add(punto = new Point(xCentro - y, yCentro - x));
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
        }

        public void Elipse(int xCentro, int yCentro, int rX, int rY)
        {
            Color colorFondo = Propiedades_Pixel.colorFondo;

            List<Point> listaPuntos = new List<Point>();

            int rX2 = rX * rX;
            int rY2 = rY * rY;
            int dosRx2 = 2 * rX2;
            int dosRy2 = 2 * rY2;
            int p;
            int x = 0;
            int y = rY;
            int px = 0;
            int py = dosRx2 * y;

            try
            {
                p = Convert.ToInt32(Math.Round(rY2 - (rX2 * rY) + (0.25 * rX2)));
                ElipsePuntos(xCentro, yCentro, x, y, listaPuntos);

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

                    ElipsePuntos(xCentro, yCentro, x, y, listaPuntos);
                }

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
                    ElipsePuntos(xCentro, yCentro, x, y, listaPuntos);
                }

                figuras.Add(new Figura(listaPuntos, colorFondo, "Elipse"));
            }
            catch (Exception e)
            {
                MessageBox.Show("Debes ingresar bien tus coordenadas");
            } 
        }

        private void ElipsePuntos(int xCentro, int yCentro, int x, int y, List<Point> puntosElipse)
        {
            try
            {
                pixeles[yCentro + y, xCentro + x].setColorFondo(Propiedades_Pixel.colorFondo);
                puntosElipse.Add(punto = new Point(xCentro + x, yCentro + y));
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            try
            {
                pixeles[yCentro + y, xCentro - x].setColorFondo(Propiedades_Pixel.colorFondo);
                puntosElipse.Add(punto = new Point(xCentro - x, yCentro + y));
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            try
            {
                pixeles[yCentro - y, xCentro + x].setColorFondo(Propiedades_Pixel.colorFondo);
                puntosElipse.Add(punto = new Point(xCentro + x, yCentro - y));
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            try
            {
                pixeles[yCentro - y, xCentro - x].setColorFondo(Propiedades_Pixel.colorFondo);
                puntosElipse.Add(punto = new Point(xCentro - x, yCentro - y));
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
        }

        public void boundaryFill4(int x, int y, Color fill, Color boundary)
        {
            try
            {
                Color current = pixeles[y, x].getColorFondo();

                if ((current == boundary) && (current != fill))
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
                Console.WriteLine("Indice fuera del rango");
            }
        }

        public Color ColorPixel(int x, int y)
        {
            return pixeles[x, y].getColorFondo();
        }

        public void ReconocimientoFigura(int x, int y)
        {
            Point puntoSeleccionado = new Point(x, y);

            bool figuraEncontrada = false;

            for (int i = figuras.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < figuras[i].GetPuntos().Count; j++)
                {
                    if (figuras[i].GetPuntos()[j].X == puntoSeleccionado.X && figuras[i].GetPuntos()[j].Y == puntoSeleccionado.Y)
                    {
                        figuraSeleccionada = figuras[i].GetPuntos();
                        colorFigura = figuras[i].GetColor();
                        figuraEncontrada = true;
                        break;
                    }
                }
                if (figuraEncontrada)
                {
                    break;
                }
            }
        }

        public void TraslaciónDerecha()
        {
            double operacion;

            for (int i = 0; i < figuraSeleccionada.Count; i++)
            {
                Point puntoAnterior = figuraSeleccionada[i];
                Point puntoNuevo = figuraSeleccionada[i];
                puntoNuevo.X = (puntoNuevo.X * Propiedades_Pixel.anchoPixel) + Propiedades_Pixel.anchoPixel;
                operacion = puntoNuevo.X / Propiedades_Pixel.anchoPixel;
                puntoNuevo.X = (int)Math.Floor(operacion);
                figuraSeleccionada[i] = puntoNuevo;

                try
                {
                    pixeles[puntoAnterior.Y, puntoAnterior.X].setColorFondo(Color.White);
                    pixeles[figuraSeleccionada[i].Y, figuraSeleccionada[i].X].setColorFondo(colorFigura);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Se salio del lienzo");
                }
                
            }
        }

        public void TraslaciónIzquierda()
        {
            double operacion;

            for (int i = 0; i < figuraSeleccionada.Count; i++)
            {
                Point puntoAnterior = figuraSeleccionada[i];
                Point puntoNuevo = figuraSeleccionada[i];
                puntoNuevo.X = (puntoNuevo.X * Propiedades_Pixel.anchoPixel) - Propiedades_Pixel.anchoPixel;
                operacion = puntoNuevo.X / Propiedades_Pixel.anchoPixel;
                puntoNuevo.X = (int)Math.Floor(operacion);
                figuraSeleccionada[i] = puntoNuevo;

                try
                {
                    pixeles[puntoAnterior.Y, puntoAnterior.X].setColorFondo(Color.White);
                    pixeles[figuraSeleccionada[i].Y, figuraSeleccionada[i].X].setColorFondo(colorFigura);
                }
                catch (Exception e) {
                    Console.WriteLine("Se salio del lienzo");
                }
   
            }
        }

        public void TraslaciónArriba()
        {
            double operacion;

            for (int i = 0; i < figuraSeleccionada.Count; i++)
            {
                Point puntoAnterior = figuraSeleccionada[i];
                Point puntoNuevo = figuraSeleccionada[i];
                puntoNuevo.Y = (puntoNuevo.Y * Propiedades_Pixel.altoPixel) - Propiedades_Pixel.altoPixel;
                operacion = puntoNuevo.Y / Propiedades_Pixel.altoPixel;
                puntoNuevo.Y = (int)Math.Floor(operacion);
                figuraSeleccionada[i] = puntoNuevo;

                try
                {
                    pixeles[puntoAnterior.Y, puntoAnterior.X].setColorFondo(Color.White);
                    pixeles[figuraSeleccionada[i].Y, figuraSeleccionada[i].X].setColorFondo(colorFigura);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Indicce fuera de la linea");
                }

            }
        }

        public void TraslaciónAbajo()
        {
            double operacion;

            for (int i = 0; i < figuraSeleccionada.Count; i++)
            {
                Point puntoAnterior = figuraSeleccionada[i];
                Point puntoNuevo = figuraSeleccionada[i];
                puntoNuevo.Y = (puntoNuevo.Y * Propiedades_Pixel.altoPixel) + Propiedades_Pixel.altoPixel;
                operacion = puntoNuevo.Y / Propiedades_Pixel.anchoPixel;
                puntoNuevo.Y = (int)Math.Floor(operacion);
                figuraSeleccionada[i] = puntoNuevo;

                try
                {
                    pixeles[puntoAnterior.Y, puntoAnterior.X].setColorFondo(Color.White);
                    pixeles[figuraSeleccionada[i].Y, figuraSeleccionada[i].X].setColorFondo(colorFigura);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Indice fuera del rango");
                }
                    
            }
        }

        public void Rotacion(int xCentro, int yCentro, double angulo)
        {
            for (int i = 0; i < figuraSeleccionada.Count; i++)
            {
                Point puntoInicial = figuraSeleccionada[i];
                puntoInicial.X = puntoInicial.X;
                puntoInicial.Y = puntoInicial.Y;
                Point puntosRotacion = new Point(0,0);
                puntosRotacion.X = (int) Math.Floor(((Math.Cos(angulo) * (puntoInicial.X - xCentro)) - (Math.Sin(angulo) * (puntoInicial.Y - yCentro)) + xCentro));
                puntosRotacion.Y = (int)(Math.Floor((Math.Sin(angulo) * (puntoInicial.X - xCentro)) + (Math.Cos(angulo) * (puntoInicial.Y - yCentro)) + yCentro));
                figuraSeleccionada[i] = puntosRotacion;

                try
                {
                    pixeles[puntoInicial.Y, puntoInicial.X].setColorFondo(Color.White);
                    pixeles[puntosRotacion.Y, puntosRotacion.X].setColorFondo(colorFigura);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Indice fuera del rango");
                }
            }
        }

        public void BorrarObjetos()
        {
            figuras.Clear();
            figuraSeleccionada.Clear();
        }

        public void ActualizarColores()
        {
            try
            {
                Color color;
                Point figurasCoordenadas = new Point(0, 0);

                for (int i = 0; i < figuras.Count; i++)
                {
                    color = figuras[i].GetColor();

                    for (int j = 0; j < figuras[i].GetPuntos().Count; j++)
                    {
                        figurasCoordenadas.X = figuras[i].GetPuntos()[j].X;
                        figurasCoordenadas.Y = figuras[i].GetPuntos()[j].Y;
                        pixeles[figurasCoordenadas.Y, figurasCoordenadas.X].setColorFondo(color);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice fuera del rango");
            }
            
        }
    }
}
