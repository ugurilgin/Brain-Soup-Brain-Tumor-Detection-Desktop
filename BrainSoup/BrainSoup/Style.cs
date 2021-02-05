using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainSoup
{
    class Style
    {
    }
    class Draggable
    {
        public static Point lastLocation { get; set; }
        public static bool mouseDown { get; set; }
        public static void MouseMove(Point lastLocation, bool mouseDown, Form frm, MouseEventArgs e)
        {
            if (mouseDown)
            {
                frm.Location = new Point(
                    (frm.Location.X - lastLocation.X) + e.X, (frm.Location.Y - lastLocation.Y) + e.Y);

                frm.Update();
            }
        }
    }

}
