using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class Figura
    {
        List<Point> puntos;

        Color colorBorde;

        public Figura(List<Point> puntosFigura, Color color)
        {
            this.puntos = puntosFigura;
            this.colorBorde = color;
        }

        public List<Point> GetPuntos()
        {
            return this.puntos;
        }

        public Color GetColorBorde()
        {
            return this.colorBorde;
        }
    }
}
