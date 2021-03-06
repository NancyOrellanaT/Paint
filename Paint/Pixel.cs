﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    class Pixel
    {
        Point punto;

        Size tamaño;

        Rectangle rectangulo;

        Pen lapiz;

        Color colorBorde;

        SolidBrush pincel;

        public Pixel(int coordenadaX, int coordenadaY, int ancho, int alto)
        {
            this.punto = new Point(coordenadaX, coordenadaY);
            this.tamaño = new Size(ancho, alto);
            this.rectangulo = new Rectangle(punto, tamaño);
            this.colorBorde = Color.Black;
            this.lapiz = new Pen(colorBorde, Propiedades_Pixel.tamañoBorde);
            this.pincel = new SolidBrush(Propiedades_Pixel.colorFondo);
        }

        public void dibujarPixel(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(lapiz, rectangulo);
            g.FillRectangle(pincel, rectangulo);  
        }

        public Point getPunto()
        {
            return punto;
        }

        public Size getTamaño()
        {
            return tamaño;
        }

        public void setPunto(int x, int y)
        {
            this.punto.X = x;
            this.punto.Y = y;
            this.rectangulo.X = x;
            this.rectangulo.Y = y;
        }

        public void setTamaño(int ancho, int alto)
        {
            this.tamaño.Width = ancho;
            this.tamaño.Height = alto;
            this.rectangulo.Size = tamaño;
        }

        public void setColorFondo(Color color)
        {
            try
            {
                this.pincel.Color = color;
            }
            catch (Exception e)
            {
                Console.WriteLine("Indice muy grande");
            }
        } 

        public void setColorBorde(Color color)
        {
            this.lapiz.Color = color; 
        }

        public void setTamañoBorde(int tamaño)
        {
            this.lapiz.Width = tamaño;
        }

        public Color getColorBorde()
        {
            return lapiz.Color;
        }

        public Color getColorFondo()
        {
            return pincel.Color;
        }
    }
}
