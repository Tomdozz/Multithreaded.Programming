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

namespace Assignment4
{
    public partial class Form1 : Form
    {
        private AdventurePool apPool;
        private CommonPool cpPool;
        private WaitingQueueAP wQueueAP;
        private WaitingQueueCP wQueueCP;
        private Reception reception;
        private ExitQueue exitQueue;

        private Thread receptionThread;
        private Thread apThread;
        private Thread cpThread;
        private Thread exitThread;

        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            CreateObj();
            CreateTherads();
            //StartThreads();
        }

        /// <summary>
        /// Open/Close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void open_Click(object sender, EventArgs e)
        {
            if (reception.Open == true)
            {
                reception.Open = false;
                open.Invoke(new Action(delegate () { open.Text = "Open"; }));
               
            }

            else if (reception.Open == false)
            {
                reception.Open = true;
                open.Invoke(new Action(delegate () { open.Text = "Close"; }));
            }
        }

        /// <summary>
        /// Create all objects 
        /// </summary>
        private void CreateObj()
        {
            //waitingCP.Text = " ";
            //waitingAPlable.Text = " ";

            wQLabelAP.Text = " ";
            wQLabelCP.Text = " ";
            visitorLabelAP.Text = " ";
            visitorLabelCP.Text = " ";
            exitAP.Text = " ";
            exitCP.Text = " ";

            wQueueAP = new WaitingQueueAP(10, wQLabelAP);
            wQueueCP = new WaitingQueueCP(10, wQLabelCP);
            
            reception = new Reception(10,wQueueCP,wQueueAP);

            apPool = new AdventurePool(10, wQueueAP, visitorLabelAP, apPictureBox);
            cpPool = new CommonPool(10, apPool, wQueueAP, wQueueCP, visitorLabelCP, moveFromCPLabel, cpPictureBox);

            exitQueue = new ExitQueue(apPool, cpPool, exitCP, exitAP);

            apPictureBox.BackColor = Color.Green;
            cpPictureBox.BackColor = Color.Green;

        }

        /// <summary>
        /// Creates and starts all threads
        /// </summary>
        private void CreateTherads()
        {
            receptionThread = new Thread(reception.SelectQueue);
            apThread = new Thread(apPool.FillPool);
            cpThread = new Thread(cpPool.FillPool);
            exitThread = new Thread(exitQueue.RemoveCustomer);

            receptionThread.Start();
            apThread.Start();
            cpThread.Start();
            exitThread.Start();


        }
  
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
