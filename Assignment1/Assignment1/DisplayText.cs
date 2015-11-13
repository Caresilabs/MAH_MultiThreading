using System;
using System.Drawing;

namespace Assignment1
{
    public class DisplayText
    {
        private string text;

        public DisplayText(string text)
        {
            this.text = text;
        }

        public void Draw(Graphics g)
        {
            g.ResetTransform();

            var rnd = new Random();
            g.TranslateTransform((float)rnd.NextDouble() * g.VisibleClipBounds.Width, (float)rnd.NextDouble() * g.VisibleClipBounds.Height / 2f);
            g.DrawString(text, new Font("Comic Sans", 14), new SolidBrush(Color.Black), 0,0);
        }
    }


}
