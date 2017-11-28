using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    class EntryQueue
    {

        bool filled;
        bool empty;

        Queue<Car> carQueue;

        int maxCapacity;
        int currentNrQueue;

        Random rnd;
        Label l1;


        /// <summary>
        /// Constructor for EntryQueue
        /// </summary>
        /// <param name="maxCapacity"></param>
        /// <param name="l1"></param>
        public EntryQueue(int maxCapacity, Label l1)
        {
            this.maxCapacity = maxCapacity;
            this.l1 = l1;
            currentNrQueue = 0;
            empty = true;

            rnd = new Random();
            carQueue = new Queue<Car>();
        }

        /// <summary>
        /// Takes a car as parameter and adds it to the queue
        /// </summary>
        /// <param name="c"></param>
        public void AddToQueue(Car c)
        {
            carQueue.Enqueue(c);
            ++currentNrQueue;

            empty = false;
            if (currentNrQueue >= maxCapacity) { filled = true; }
            else { filled = false; }

            l1.Invoke(new Action(delegate () { l1.Text = currentNrQueue.ToString(); }));

            //Thread.Sleep(rnd.Next(200, 500));
        }

        /// <summary>
        /// Removes a car from the queue and returns it
        /// </summary>
        /// <returns></returns>
        public Car RemoveFromQueue()
        {
            if (carQueue.Count() == 0)
            {
                Delay();
            }
            Car temp = carQueue.Dequeue();
            --currentNrQueue;

            filled = false;
            l1.Invoke(new Action(delegate () { l1.Text = currentNrQueue.ToString(); }));

            if (carQueue.Count == 0) { empty = true; }
            else { empty = false; }

            //Thread.Sleep(rnd.Next(200, 500));
            return temp;
        }

        /// <summary>
        /// When called it puts a task in delay for a random time
        /// </summary>
        public async void Delay()
        {
            await Task.Delay(rnd.Next(100, 200));
            RemoveFromQueue();
        }
        /// <summary>
        /// Property for filled
        /// </summary>
        public bool Filled
        {
            get { return filled; }
            set { filled = value; }
        }

        /// <summary>
        /// Property for empty
        /// </summary>
        public bool Empty
        {
            get { return empty; }
            set { empty = value; }
        }
    }
}
