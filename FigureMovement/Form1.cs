using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureMovement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Action(Start).BeginInvoke(null, null);
            //Start();
        }
        private void MoveCircle()
        {
            Circle circle = new Circle(10, 10, 5);
            Movemet.MoveInForm(circle, 2, 1);
        }
        private void MoveSquare()
        {
            Square square = new Square(10, 10, 20);
            Movemet.MoveInForm(square, 3, 2);
        }
        private void MoveRhomb()
        {
            Rhomb rhomb = new Rhomb(10, 10, 70, 40);
            Movemet.MoveInForm(rhomb, 1, 0.5);
        }
        private void Start()
        {
            new Action(MoveRhomb).BeginInvoke(null, null);
            new Action(MoveCircle).BeginInvoke(null, null);
            new Action(MoveSquare).BeginInvoke(null, null);
            

            //Graphics g;
            //g = this.CreateGraphics();
            //Circle circle = new Circle(10, 10, 5);
            //Square square = new Square(10, 10, 20);
            //Rhomb rhomb = new Rhomb(10, 10, 40, 40);
            //double dx = 1, dy = 1;
            //while (true)
            //{
            //    circle.Movement(g, this.BackColor, dx, dy);
            //    square.Movement(g, this.BackColor, dx, dy);
            //    rhomb.Movement(g, this.BackColor, dx, dy);
            //    if (circle.x == 0 || circle.x == ClientSize.Width)
            //        dx = -dx;
            //    if (circle.y == 0 || circle.y == ClientSize.Height)
            //        dy = -dy;

            //    Thread.Sleep(10);
            //}
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
                              
        }
        
        
    }
}
