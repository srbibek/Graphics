using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GUI_Application
{
    /// <summary>
    /// exdending shape class
    /// </summary>

    public class Circle : Shape
    {
        /// <summary>
        /// getting value in variable for ellipse
        /// </summary>
       public int x, y, size, size1;
        Color c4;
        int texturestyle;
        Brush bru;
        public override void draw(Graphics g)
        {
            Pen p = new Pen(c4, 5);
            if (texturestyle == 0)
            {
                g.DrawEllipse(p, x, y, size, size1);
            }
            else
            {
                g.FillEllipse(bru, x, y, size, size1);
            }


        }

        /// <summary>
        /// getting value of starting coordinates, color, texture and radius
        /// </summary>
        /// <param name="texturestyle"></param>
        /// <param name="bru"></param>
        /// <param name="c4"></param>
        /// <param name="list"></param>
        public override void set(int texturestyle, Brush bru, Color c4, params int[] list)
        {
            this.texturestyle = texturestyle;
            this.bru = bru;
            this.c4 = c4;
            this.x = list[0];
            this.y = list[1];
            this.size = list[2];
            this.size1 = list[3];
        }
    }
}
