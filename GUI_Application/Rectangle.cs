using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GUI_Application
{
    public class Rectangle: Shape
    {
        public int x, y, size, size1, lenght, breath;
        int texturestyle;
        Brush bb;
        Color c4;

        public Rectangle()
        {
        }

        public Rectangle(int v1, int v2, int v3, int v4)
        {
        }

        /// <summary>
        /// getting value of Graphics g
        /// </summary>
        /// <param name="g"></param>
        public override void draw(Graphics g)
        {
            Pen p = new Pen(c4, 5);
            if (texturestyle == 0)
            {
                g.DrawRectangle(p, x, y, size, size1);

            }
            else
            {
                g.FillRectangle(bb, x, y, size, size1);
            }
                
        }



        /// <summary>
        /// getting value in variable and use of getter setter
        /// </summary>
        /// <param name="texturestyle"></param>
        /// <param name="bb"></param>
        /// <param name="c4"></param>
        /// <param name="list"></param>
        public override void set(int texturestyle, Brush bb, Color c4, params int[] list)
        {
            this.texturestyle = texturestyle;
            this.bb = bb;
            this.c4 = c4;
            this.x = list[0];
            this.y = list[1];
            this.size = list[2];
            this.size1 = list[3];
        }
    }
}
