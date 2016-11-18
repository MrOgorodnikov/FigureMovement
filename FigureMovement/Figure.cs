using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureMovement
{
    public abstract class Figure
    {
        public double x;
        public double y;
        public Figure(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract void DrawBlack(Graphics g);
        public abstract void HideDrawingBackGround(Graphics g, Color color);
        public void Movement(Graphics g, Color backgroundColor, double dx, double dy)
        {
            HideDrawingBackGround(g, backgroundColor);
            x += dx;
            y += dy;
            DrawBlack(g);
        }

    }

    public class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(double x, double y, double Radius) : base(x,y)
        {
            this.Radius = Radius;
        }

        public override void DrawBlack(Graphics g)
        {
            g.DrawCircle((float)x, (float)y, (float)Radius);
        }
        public override void HideDrawingBackGround(Graphics g, Color color)
        {
            g.DrawCircle(new Pen(color), (float)x, (float)y, (float)Radius);
        }
    }

    public class Square : Figure
    {
        public Square(double x, double y, double SideLength) : base(x, y)
        {
            this.SideLength = SideLength;
        }

        public double SideLength { get; set; }

        public override void DrawBlack(Graphics g)
        {
            
            g.DrawSquare((float)x, (float)y, (float)SideLength);
        }
        public override void HideDrawingBackGround(Graphics g, Color color)
        {
            g.DrawSquare(new Pen(color), (float)x, (float)y, (float)SideLength);
        }
    }

    public class Rhomb : Figure
    {
        double HorDiagLen { get; set; }
        double VertDiagLen { get; set; }
        public Rhomb(double x, double y, double HorDiagLen, double VertDiagLen) : base(x, y)
        {
            this.HorDiagLen = HorDiagLen;
            this.VertDiagLen = VertDiagLen;
        }

        public override void DrawBlack(Graphics g)
        {
            g.DrawRhomb((float)x, (float)y, (float)HorDiagLen, (float)VertDiagLen);
        }

        public override void HideDrawingBackGround(Graphics g, Color color)
        {
            g.DrawRhomb(new Pen(color), (float)x, (float)y, (float)HorDiagLen, (float)VertDiagLen);
        }
    }

}
