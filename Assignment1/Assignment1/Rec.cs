using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment1
{
    class Rec : MainThread
    {
        Point recPoint;
        Rectangle rect;
        Graphics graphics;

        int angle;
        int width, height;

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Rec(Graphics graphics, int width, int height)
            : base(graphics, width, height)
        {
            this.width = width;
            this.height = height;
            this.graphics = graphics;
            rect = new Rectangle(width / 2, height / 2, 50, 50);

            angle = 0;
        }

        /// <summary>
        /// While run is true i add 10 to angle and if the angle is 360 i reset it to one
        /// </summary>
        public override void Update()
        {
            while(run ==true)
            {
                Draw();
                angle = angle + 10;

                if (angle== 360)
                {
                    angle = 1;
                }
                Thread.Sleep(500);

            }

            //throw new NotImplementedException();
        }

        /// <summary>
        /// Draws the rectangle with a rotation
        /// Draw() is called in update
        /// </summary>
        public override void Draw()
        {
            graphics.Clear(Color.White);
            Matrix matrix = new Matrix();

            //matrix.RotateAt(angle, new PointF(width / 2, height / 2));

            matrix.RotateAt(angle, new Point(rect.Left + (rect.Width / 2), rect.Top + (rect.Height / 2)));

            graphics.Transform = matrix;
            graphics.DrawRectangle(Pens.Green, rect);
            graphics.ResetTransform();
            //throw new NotImplementedException();
        }
    }
}
