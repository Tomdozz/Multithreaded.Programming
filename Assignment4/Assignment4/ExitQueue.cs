using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    class ExitQueue
    {
        Queue<Customer> exitQueue;
        Random rnd;
        AdventurePool adPool;
        CommonPool cpPool;
        Label label1;
        Label label2;


        int currentInExitQueue;
        int selectPool;

        int exitCP, exitAP;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="adPool"></param>
        /// <param name="cpPool"></param>
        /// <param name="label1"></param>
        /// <param name="label2"></param>
        public ExitQueue(AdventurePool adPool, CommonPool cpPool, Label label1, Label label2)
        {
            this.adPool = adPool;
            this.cpPool = cpPool;
            this.label1 = label1;
            this.label2 = label2;

            rnd = new Random();
            exitQueue = new Queue<Customer>();
        }

        /// <summary>
        /// Select whether to take from AP or CP
        /// If both pools are empty wait method is called
        /// </summary>
        public void RemoveCustomer()
        {

            selectPool = rnd.Next(1, 3);
            Thread.Sleep(rnd.Next(100, 200));


            if (selectPool == 1 && cpPool.Empty == false)//take from cp
            {
                Customer temp = cpPool.RemoveFromPool();
                exitQueue.Enqueue(temp);
                ++currentInExitQueue;
                ++exitAP;

                label1.Invoke(new Action(delegate () { label1.Text = exitCP.ToString(); }));

                Thread.Sleep(rnd.Next(200, 500));
            }
            else if (selectPool == 2 && adPool.Empty == false)//take from ap
            {
                Customer temp = adPool.RemoveFromPool();
                exitQueue.Enqueue(temp);
                ++currentInExitQueue;
                ++exitCP;

                label2.Invoke(new Action(delegate () { label2.Text = exitAP.ToString(); }));

                Thread.Sleep(rnd.Next(200, 500));
            }
            Wait();
        }

        /// <summary>
        /// While ap and cp are full and waitingQueue are empty the thread sleeps
        /// </summary>
        public void Wait()
        {
            while (cpPool.Empty == true || adPool.Empty == true)
            {
                Thread.Sleep(700);
            }

            RemoveCustomer();
        }

    }
}
