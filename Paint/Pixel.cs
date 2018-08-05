using System;
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

        public Pixel(int coordenadaX, int coordenadaY, int ancho, int alto)
        {
            this.punto = new Point(coordenadaX, coordenadaY);
            this.tamaño = new Size(ancho, alto);
            this.rectangulo = new Rectangle(punto, tamaño);
            this.lapiz = new Pen(Color.Black, 2);
        }

        public void dibujarPixel(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(lapiz, rectangulo);
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

        public void colorPixel(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            e.Graphics.FillRectangle(blueBrush, rectangulo);
        }
        
    }
}
