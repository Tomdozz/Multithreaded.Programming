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
    class CommonPool
    {
        Queue<Customer> customerQueue;
        Label label1, label2;
        PictureBox p1;
        Random rnd;

        WaitingQueueAP wQueueAP;
        WaitingQueueCP wQueueCP;
        AdventurePool apClass;


        bool filled;
        bool empty;


        object myLock;
        int currentNumberOfVisitors;
        int maxCapacity;
        int selectCustomerFrom;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="maxCapacity"></param>
        /// <param name="wQueueAP"></param>
        /// <param name="wQueueCP"></param>
        /// <param name="label1"></param>
        /// <param name="label2"></param>
        public CommonPool(int maxCapacity, AdventurePool adventurePool,WaitingQueueAP wQueueAP, WaitingQueueCP wQueueCP, Label label1, Label label2, PictureBox p1)
        {
            this.wQueueAP = wQueueAP;
            this.wQueueCP = wQueueCP;
            this.maxCapacity = maxCapacity;
            this.label1 = label1;
            this.label2 = label2;
            this.p1 = p1;

            apClass = adventurePool;

            myLock = new object();
            rnd = new Random();

            filled = false;
            empty = true;

            customerQueue = new Queue<Customer>();
        }

        /// <summary>
        /// Adds people from waiting queue
        /// It can also take people from the adventure pool
        /// If the pool are full it calls wait method
        /// </summary>
        public void FillPool()
        {
            while (!filled)
            {
                if (wQueueCP.Empty == true)
                {
                    break;
                }

                selectCustomerFrom = rnd.Next(1, 3);

                if (selectCustomerFrom == 1)//common pool
                {
                    Monitor.Enter(myLock);
                    p1.Invoke(new Action(delegate () { p1.BackColor = Color.Green; }));
                    while (customerQueue.Count >= maxCapacity)
                    {
                        Monitor.Wait(myLock);
                        p1.Invoke(new Action(delegate () { p1.BackColor = Color.DarkRed; }));
                        //poolfärg röd
                    }

                    Monitor.PulseAll(myLock);

                    Customer temp = wQueueCP.RemoveFromQueue();
                    customerQueue.Enqueue(temp);
                    ++currentNumberOfVisitors;

                    if (currentNumberOfVisitors >= maxCapacity) { filled = true; }
                    empty = false;
                    label1.Invoke(new Action(delegate () { label1.Text = currentNumberOfVisitors.ToString(); }));


                    Monitor.PulseAll(myLock);
                    Monitor.Exit(myLock);

                    Thread.Sleep(rnd.Next(150, 500));
                }

                else if (selectCustomerFrom == 2)//from adventure pool
                {
                    Monitor.Enter(myLock);
                    label2.Invoke(new Action(delegate () { label2.Text = "Ready to move from CommonPool to AdventurePool "; }));
                    while (customerQueue.Count >= maxCapacity)
                    {
                        Monitor.Wait(myLock);
                    }

                    Monitor.PulseAll(myLock);

                    Customer temp = apClass.RemoveFromPool();
                    customerQueue.Enqueue(temp);
                    ++currentNumberOfVisitors;

                    if (currentNumberOfVisitors >= maxCapacity) { filled = true; }
                    empty = false;

                    label2.Invoke(new Action(delegate () { label2.Text = "Moved one "; }));
                    label1.Invoke(new Action(delegate () { label1.Text = currentNumberOfVisitors.ToString(); }));


                    Thread.Sleep(rnd.Next(150, 500));
                    Monitor.PulseAll(myLock);
                    Monitor.Exit(myLock);

                    label2.Invoke(new Action(delegate () { label2.Text = "Waiting to move from Common Pool "; }));
                }
            }
            Wait();
            //if (currentNumberOfVisitors >= maxCapacity) { filled = true; }
            //else { filled = false; }
        }


        /// <summary>
        /// Dequeue a customer from the queue
        /// When called it will return a customer
        /// </summary>
        /// <returns></returns>
        public Customer RemoveFromPool()
        {
            Monitor.Enter(myLock);

            while (customerQueue.Count == 0)
            {
                Monitor.Wait(myLock);
            }

            Monitor.PulseAll(myLock);


            Customer temp = customerQueue.Dequeue();
            --currentNumberOfVisitors;

            if (customerQueue.Count <= 0) { empty = true; }
            filled = false;
            label1.Invoke(new Action(delegate () { label1.Text = currentNumberOfVisitors.ToString(); }));
            Monitor.PulseAll(myLock);
            Monitor.Exit(myLock);

            Thread.Sleep(rnd.Next(150, 500));

            return temp;
        }

        /// <summary>
        /// while cp are full and waitingQueue are empty the thread sleeps
        /// </summary>
        private void Wait()
        {
            while (filled == true || wQueueCP.Empty == true)
            {
                Thread.Sleep(rnd.Next(150, 500));
            }
            FillPool();
        }

        /// <summary>
        /// Used to see if CP are full
        /// </summary>
        public bool Filled
        {
            get { return filled; }
            set { filled = value; }
        }

        /// <summary>
        /// Used to see if CP are empty
        /// </summary>
        public bool Empty
        {
            get { return empty; }
        }
    }
}
