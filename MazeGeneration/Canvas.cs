using System;
using System.Windows.Forms;

namespace MazeGeneration
{
    class Canvas : Panel
    {
        public Canvas()
        {
            //this.DoubleBuffered = true;
            //this.ResizeRedraw = true;
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);

        }
    }
}
