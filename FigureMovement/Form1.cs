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
        private void Start()
        {
            Movemet.Move move = new Movemet.Move(Movemet.MoveInForm);
            
            Circle circle = new Circle(10, 10, 5);
            Square square = new Square(10, 10, 20);
            move.BeginInvoke(circle, 1, 1, null, null);
            move.BeginInvoke(square, 2, 1, null, null);
            Rhomb rhomb = new Rhomb(10, 10, 70, 40);
            move.BeginInvoke(rhomb, 1, 2, null, null);
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
