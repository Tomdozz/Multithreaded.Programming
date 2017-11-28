using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment1
{
    class Text: MainThread
    {
        Font textFont;
        Random randomPoint = new Random();
        Graphics graphics;
        Point textPoint;

        int maxPointX, maxPointY;
        int fontSize;

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Text(Graphics graphics, int width, int height)
            : base(graphics, width, height)
        {
            this.graphics = graphics;
            this.maxPointX = width - fontSize;
            this.maxPointY = height - fontSize;
            textPoint = new Point(width, height);

            textFont = new Font("Times New Roman", 20);
            
        }
        /// <summary>
        /// While the thread is running i randomize a new point then calls the draw method
        /// </summary>
        public override void Update()
        {
            while(run ==true)
            {
                textPoint.X = randomPoint.Next(maxPointX);
                textPoint.Y = randomPoint.Next(maxPointY);
                Draw();
                Thread.Sleep(700);
            }   
        }

        /// <summary>
        /// Draws the text "Im here" whenever the draw method is called
        /// </summary>
        public override void Draw()
        {
            graphics.Clear(Color.White);
            graphics.DrawString("Im here", textFont, Brushes.Green, textPoint);           
        }
    }
}
