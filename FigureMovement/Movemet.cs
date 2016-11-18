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
        public static void MoveInForm(Figure figure, double dx, double dy)
        {
            while (true)
            {
                try
                {
                    figure.Movement(Form1.ActiveForm.CreateGraphics(), Form1.ActiveForm.BackColor, dx, dy);
                    if (figure.x <= 0 || figure.x >= Form1.ActiveForm.ClientSize.Width)
                        dx = -dx;
                    if (figure.y <= 0 || figure.y >= Form1.ActiveForm.ClientSize.Height)
                        dy = -dy;
                }
                finally
                {
                    Thread.Sleep(10);
                }

                
            }
        }
    }
}
