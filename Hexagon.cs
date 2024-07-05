using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phantom
{
    public class Hexagon
    {
        public Point[] hexagonPoints = {
            new Point(50, 0),
            new Point(150, 0),
            new Point(200, 100),
            new Point(150, 200),
            new Point(50, 200),
            new Point(0, 100)
        };

        public void Draw(Graphics g)
        {
            Color semiTransparentWhite = Color.FromArgb(128, Color.White);
            Pen pen = new Pen(Color.White);
            Brush b = new SolidBrush(semiTransparentWhite);
            g.FillPolygon(b, hexagonPoints);
            
            b.Dispose();
            g.Dispose();

            

        }
        

    }
}
