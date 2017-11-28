using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    abstract class MainThread
    {
        public bool run;
        Graphics graphics;
        int width, height;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public MainThread(Graphics graphics, int width, int height)
        {
            this.graphics = graphics;
            this.width = width;
            this.height = height;
        }

        /// <summary>
        /// this method start is used to start the update method
        /// </summary>
        public void Start()
        {
            run = true;
        }

        /// <summary>
        /// this method start is used to stop the update method
        /// </summary>
        public void Stop()
        {
            run = false;
        }

        //abstract methods that will be used in both text and rec
        public abstract void Update();
        public abstract void Draw();

    }
}
