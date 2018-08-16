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

        Color color;

        String nombreFigura;

        public Figura(List<Point> puntosFigura, Color color, String nombreFigura)
        {
            this.puntos = puntosFigura;
            this.color = color;
            this.nombreFigura = nombreFigura;
        }

        public List<Point> GetPuntos()
        {
            return this.puntos;
        }

        public Color GetColor()
        {
            return this.color;
        }

        public String GetNombre()
        {
            return this.nombreFigura;
        }
    }
}
