using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureMovement
{
    public static class GraphicsExtentions
    {
        public static void DrawCircle(this Graphics g, float x, float y, float radius)
        {
            g.DrawEllipse(new Pen(Color.Black), x - radius, y - radius, radius + radius, radius + radius);
        }
        public static void DrawCircle(this Graphics g, Pen pen, float x, float y, float radius)
        {
            g.DrawEllipse(pen, x - radius, y - radius, radius + radius, radius + radius);
        }


        public static void DrawSquare(this Graphics g, float x, float y, float sideLength)
        {
            g.DrawRectangle(new Pen(Color.Black), x - sideLength / 2, y - sideLength / 2, sideLength, sideLength);
        }
        public static void DrawSquare(this Graphics g, Pen pen, float x, float y, float sideLength)
        {
            g.DrawRectangle(pen, x - sideLength / 2, y - sideLength / 2, sideLength, sideLength);
        }


        public static void DrawRhomb(this Graphics g, float x, float y, float horDiagLen, float vertDiagLen)
        {
            PointF[] points =
             {
                 new PointF(x - horDiagLen/2,  y),
                 new PointF(x, y + vertDiagLen/2),
                 new PointF(x + horDiagLen/2,  y),
                 new PointF(x, y - vertDiagLen/2),
                 new PointF(x - horDiagLen/2,  y)
             };

            g.DrawLines(new Pen(Color.Black), points);
        }
        public static void DrawRhomb(this Graphics g, Pen pen, float x, float y, float horDiagLen, float vertDiagLen)
        {
            PointF[] points =
             {
                 new PointF(x - horDiagLen/2,  y),
                 new PointF(x, y + vertDiagLen/2),
                 new PointF(x + horDiagLen/2,  y),                 
                 new PointF(x, y - vertDiagLen/2),
                 new PointF(x - horDiagLen/2,  y)
             };

            g.DrawLines(pen, points);
        }
    }
}
