using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Triangle
    {
        private PointF[] vertices;
        Matrix m = new Matrix();
        float angle;

        public Triangle(int size)
        {
            this.vertices = new PointF[3];
            vertices[0] = new PointF(0, -size/2f);
            vertices[1] = new PointF(-size/2f, size/2f);
            vertices[2] = new PointF(size / 2f, size / 2f);
        }

        public void Draw(Graphics g)
        {
            g.ResetTransform();
            m.Reset();

           

            //m.Rotate(angle);
            angle += 5;
            // m.Rotate(angle);

            //  m.Translate(g.VisibleClipBounds.Width / 2f, g.VisibleClipBounds.Height / 2f);


            g.TranslateTransform(g.VisibleClipBounds.Width / 2f, g.VisibleClipBounds.Height / 2f);
            g.RotateTransform(angle);
            g.DrawPolygon(new Pen(new SolidBrush(Color.Black), 3), vertices);
        }
    }
}
