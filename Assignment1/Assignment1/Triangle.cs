using System;
using System.Drawing;

namespace Assignment1
{
    public class Triangle
    {
        private PointF[] vertices;
        private float angle;

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

            g.ScaleTransform(1 + (float)Math.Cos(angle/200f)/1f, 1+ (float)Math.Cos(angle/200f)/1f);
            g.TranslateTransform(g.VisibleClipBounds.Width / 2f, g.VisibleClipBounds.Height / 2f);

            angle += 10;
            g.RotateTransform(angle);

            g.DrawPolygon(new Pen(new SolidBrush(Color.Black), 3), vertices);
        }
    }
}
