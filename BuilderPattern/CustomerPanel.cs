using BuilderPattern.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuilderPattern
{
    public class CustomPanel : Panel
    {
        Pen pen = new Pen(new SolidBrush(Color.Black), 3);
        public Weapon weapon;
        public Helmet helmet;
        public Shoes shoes;
        public CustomPanel()
        {
            DoubleBuffered = true;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //for (int i = 0; i < lstObj.Count; i++)
            //{
            //    lstObj[i].Draw(e.Graphics);
            //}

            // draw character
            // head
            e.Graphics.DrawEllipse(pen, Size.Width/2-25,Size.Height/4-25, 50, 50);
            e.Graphics.DrawLine(pen, Size.Width / 2+5 - 25 / 2, Size.Height / 4, Size.Width / 2+5 - 25, Size.Height / 4-5);
            e.Graphics.DrawLine(pen, Size.Width / 2-5 + 25 / 2, Size.Height / 4, Size.Width / 2-5 + 25, Size.Height / 4 - 5);
            e.Graphics.DrawLine(pen, Size.Width / 2 - 5, Size.Height / 4 +15, Size.Width / 2 + 5, Size.Height / 4+15);
            //body 
            e.Graphics.DrawLine(pen, Size.Width / 2, Size.Height / 4 + 25, Size.Width / 2, Size.Height / 4 + 25 + 100);
            //hand
            e.Graphics.DrawLine(pen, Size.Width / 2, Size.Height / 4 + 30  , Size.Width / 2 - 50, Size.Height / 4 + 30 +  50);
            e.Graphics.DrawLine(pen, Size.Width / 2, Size.Height / 4 + 30 , Size.Width / 2 + 50, Size.Height / 4 + 30 +  50);
            //leg
            e.Graphics.DrawLine(pen, Size.Width / 2, Size.Height / 4 + 25 + 100, Size.Width / 2 - 50, Size.Height / 4 + 25 + 100 + 50);
            e.Graphics.DrawLine(pen, Size.Width / 2, Size.Height / 4 + 25 + 100, Size.Width / 2 + 50, Size.Height / 4 + 25 + 100 + 50);
            // shoes
            //   e.Graphics.DrawEllipse(pen, Size.Width / 2 - 50-10, Size.Height / 4 + 25 + 100 + 50-10, 20, 20);
            // e.Graphics.DrawEllipse(pen, Size.Width / 2 + 50-10, Size.Height / 4 + 25 + 100 + 50-10, 20, 20);
            //weapon
            //  e.Graphics.DrawEllipse(pen, Size.Width / 2 - 50-10, Size.Height / 4 + 30 + 50-10, 20, 20);
            //helmet
            // e.Graphics.DrawEllipse(pen, Size.Width / 2 - 25, Size.Height / 4 - 40, 50, 25);
            if (helmet != null)
                helmet.draw(e.Graphics, Size);
            if (weapon != null)
                weapon.draw(e.Graphics, Size);
            if (shoes != null)
                shoes.draw(e.Graphics, Size);
        }

    }
}
