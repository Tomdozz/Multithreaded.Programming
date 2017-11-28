using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    class WaitingQueueAP
    {
        bool filled;
        bool empty;

        
        Queue<Customer> customerQueue;
        Label label;
        object myLock;

        int maxCapacity;
        int currentNrInQueue;

        Random rnd;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="maxCapacity"></param>
        /// <param name="label"></param>
        public WaitingQueueAP(int maxCapacity, Label label)
        {
           
            customerQueue = new Queue<Customer>();
            this.maxCapacity = maxCapacity;
            currentNrInQueue = 0;
            this.label = label;
            rnd = new Random();
            myLock = new object();
            filled = false;
            empty = true;
        }


        /// <summary>
        /// Used in reception to add customers to the queue
        /// </summary>
        /// <param name="c"></param>
        public void AddToQueue(Customer c)
        {
            customerQueue.Enqueue(c);
            ++currentNrInQueue;

            empty = false;
            if (currentNrInQueue >= maxCapacity) { filled = true; }
            else { filled = false; }

            label.Invoke(new Action(delegate () { label.Text = currentNrInQueue.ToString(); }));

            Thread.Sleep(rnd.Next(200, 500));
        }


        /// <summary>
        /// Used to remove people from the waitingQueue
        /// When called it will return a customer
        /// </summary>
        /// <returns></returns>
        public Customer RemoveFromQueue()
        {
            Customer temp;
            temp = customerQueue.Dequeue();
            --currentNrInQueue;

            filled = false;

            if (customerQueue.Count == 0) { empty = true; }
            else { empty = false; }

            label.Invoke(new Action(delegate () { label.Text = currentNrInQueue.ToString(); }));
            Thread.Sleep(rnd.Next(200, 500));
            return temp;           
        }
        /// <summary>
        /// Used to see if queue is full
        /// </summary>
        public bool Filled
        {
            get { return filled; }
        }

        /// <summary>
        /// Used to see if queue is empty 
        /// </summary>
        public bool Empty
        {
            get { return empty; }
            set { empty = value; }
        }
    }
}
