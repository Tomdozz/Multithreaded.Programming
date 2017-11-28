using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {

       //create two threads
        Thread thread1, thread2;

        //create two intanses
        MainThread textClass, recClass;

        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
             
           
            recClass = new Rec(panel1.CreateGraphics(), panel1.Width, panel1.Height);
            textClass = new Text(panel2.CreateGraphics(), panel2.Width, panel2.Height);
        }


        /// <summary>
        /// start cube thread
        /// Creates a new thread with rec update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (recClass.run != true)
            {
               
                recClass.Start();
                thread1 = new Thread(recClass.Update);
                thread1.Start();
            }
        }


        /// <summary>
        /// stop the cube thread (stop the update method) 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            recClass.Stop();
        }


        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        /// <summary>
        /// Start text thread
        /// Works the same way as cubeStartbotton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (textClass.run != true)
            {

                textClass.Start();
                thread2 = new Thread(textClass.Update);
                thread2.Start();
            }
        }


        /// <summary>
        /// Stops the cube thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            textClass.Stop();
        }


    }
}
