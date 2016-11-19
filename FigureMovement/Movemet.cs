using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FigureMovement
{
    class Movemet
    {
        /// <summary>
        /// Перемещает фигуру по заданым смещениям dx и dy
        /// </summary>
        /// <param name="figure"></param>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        public static void MoveInForm(Figure figure, double dx, double dy)
        {
            var form = Form1.ActiveForm;
            var c = form.BackColor;
            while (true)
            {
                try
                {
                    figure.Movement(form.CreateGraphics(), c, dx, dy);
                    if (figure.x <= 0 || figure.x >= form.ClientSize.Width)
                        dx = -dx;
                    if (figure.y <= 0 || figure.y >= form.ClientSize.Height)
                        dy = -dy;
                }
                finally
                {
                    Thread.Sleep(10);
                }

                
            }
        }
        public delegate void Move(Figure figure, double dx, double dy);
    }
}
