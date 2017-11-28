using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    class AdventurePool
    {
        Queue<Customer> customerQueue;
        Label label1;
        PictureBox p1;
        WaitingQueueAP wQueueAP;
        Random rnd;
        
        bool filled;
        bool empty;

        int currentNumberOfVisitors;
        int maxCapacity;

        object myLock;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="maxCapacity"></param>
        /// <param name="wQueueAP"></param>
        /// <param name="label1"></param>
        public AdventurePool(int maxCapacity, WaitingQueueAP wQueueAP, Label label1, PictureBox p1)
        {
            this.maxCapacity = maxCapacity;
            this.wQueueAP = wQueueAP;
            this.label1 = label1;
            this.p1 = p1;

            myLock = new object();

            filled = false;
            empty = true;

            rnd = new Random();

            customerQueue = new Queue<Customer>();
        }

        /// <summary>
        /// Adds customers from waiting queue
        /// If the pool are full it calls wait method
        /// </summary>
        public void FillPool()
        {
            
            while (!filled)
            {
                if (wQueueAP.Empty == true)
                {
                    break;
                }

                Monitor.Enter(myLock);
                p1.Invoke(new Action(delegate () { p1.BackColor = Color.Green; }));
                while (customerQueue.Count >= maxCapacity)
                {
                    Monitor.Wait(myLock);
                    p1.Invoke(new Action(delegate () { p1.BackColor = Color.Red; }));
                }
                Monitor.PulseAll(myLock);

                Customer temp = wQueueAP.RemoveFromQueue();
                customerQueue.Enqueue(temp);
                ++currentNumberOfVisitors;

                if (currentNumberOfVisitors >= maxCapacity) { filled = true; }
                empty = false;
                label1.Invoke(new Action(delegate () { label1.Text = currentNumberOfVisitors.ToString(); }));

                Thread.Sleep(rnd.Next(150, 500));

                Monitor.PulseAll(myLock);
                Monitor.Exit(myLock);

            }
            Wait();
        }

        /// <summary>
        /// While ap are full and waitingQueue are empty the thread sleeps
        /// </summary>
        private void Wait()
        {
            while (filled == true || wQueueAP.Empty == true)
            {
                Thread.Sleep(700);
            }
            FillPool();
        }

        /// <summary>
        /// Dequeue a customer from the queue
        /// When called it will return a customer
        /// </summary>
        /// <returns></returns>
        public Customer RemoveFromPool()
        {
            Monitor.Enter(myLock);
            p1.Invoke(new Action(delegate () { p1.BackColor = Color.Green; }));
            while (customerQueue.Count == 0)
            {
                Monitor.Wait(myLock);
            }

            Monitor.PulseAll(myLock);

            Customer temp;
            temp = customerQueue.Dequeue();
            currentNumberOfVisitors--;

            if(currentNumberOfVisitors == 0) { empty = true; }
            else { empty = false; }

            label1.Invoke(new Action(delegate () { label1.Text = currentNumberOfVisitors.ToString(); }));
            Monitor.PulseAll(myLock);
            Monitor.Exit(myLock);

            Thread.Sleep(rnd.Next(150, 500));

            return temp;
        }

        /// <summary>
        /// Used to see if Ap are full
        /// </summary>
        public bool Filled
        {
            get { return filled; }
            set { filled = value; }
        }

        /// <summary>
        /// Used to see if Ap are empty
        /// </summary>
        public bool Empty
        {
            get { return empty; }
        }
    }
}
