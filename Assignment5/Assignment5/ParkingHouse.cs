using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    class ParkingHouse
    {
        int currentInQueue;
        int maxCapacity;        

        Queue<Car> carQueue;
        EntryQueue nEntryQueue, sEntryQueue, eEntryQueue, wEntryQueue;
        Label l1, l2;
        Random rnd;

        bool filled;
        bool empty;
        object myLock;

        /// <summary>
        /// Constructor for ParkingHouse
        /// </summary>
        /// <param name="maxCapacity"></param>
        /// <param name="nEntryQueue"></param>
        /// <param name="sEntryQueue"></param>
        /// <param name="eEntryQueue"></param>
        /// <param name="wEntryQueue"></param>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        public ParkingHouse(int maxCapacity, EntryQueue nEntryQueue, EntryQueue sEntryQueue, EntryQueue eEntryQueue, EntryQueue wEntryQueue, Label l1, Label l2)
        {
            this.maxCapacity = maxCapacity;
            this.nEntryQueue = nEntryQueue;
            this.sEntryQueue = sEntryQueue;
            this.eEntryQueue = eEntryQueue;
            this.wEntryQueue = wEntryQueue;
            this.l1 = l1;
            this.l2 = l2;


            currentInQueue = 0;
            filled = false;
            empty = true;
            rnd = new Random();
            carQueue = new Queue<Car>();
            myLock = new object();
        }

        /// <summary>
        /// Takes a car as parameter and adds it to the queue
        /// </summary>
        /// <param name="c"></param>
        public void AddCar(Car c)
        {
            //while (!filled)
            //{
            //if (nEntryQueue.Empty == true || sEntryQueue.Empty == true
            //    || eEntryQueue.Empty == true || wEntryQueue.Empty == true)
            //{
            //    break;
            //}

            Monitor.Enter(myLock);

            while (carQueue.Count >= maxCapacity)
            {
                Monitor.Wait(myLock);
            }

            Monitor.PulseAll(myLock);
            carQueue.Enqueue(c);
            Monitor.PulseAll(myLock);

            ++currentInQueue;

            if (currentInQueue >= maxCapacity) { filled = true; }
            empty = false;

            l1.Invoke(new Action(delegate () { l1.Text = currentInQueue.ToString(); }));

            Monitor.PulseAll(myLock);
            Monitor.Exit(myLock);          
        }

        /// <summary>
        /// These are the four tasks that takes from their own entry queue and adds to the parkingHouse
        /// If the queue that we try to take from is empty it calls the delay method 
        /// </summary>
        public async void AddFromNorth()
        {
            while (nEntryQueue.Empty == false)
            {
                if (nEntryQueue.Empty == true) { break; }

                Car temp = nEntryQueue.RemoveFromQueue();
                AddCar(temp);
                await Task.Delay(rnd.Next(200, 500));
            }
            Delay(1);
        }

        public async void AddFromSouth()
        {
            while (sEntryQueue.Empty == false)
            {
                if (sEntryQueue.Empty == true) { break; }

                Car temp = sEntryQueue.RemoveFromQueue();
                AddCar(temp);
                await Task.Delay(rnd.Next(100, 500));
            }
            Delay(2);
        }

        public async void AddFromEast()
        {
            while (eEntryQueue.Empty == false)
            {
                if (eEntryQueue.Empty == true) { break; }

                Car temp = eEntryQueue.RemoveFromQueue();
                AddCar(temp);
                await Task.Delay(rnd.Next(100, 500));
            }
            Delay(3);
        }

        public async void AddFromWest()
        {
            while (wEntryQueue.Empty == false)
            {
                if (wEntryQueue.Empty == true) { break; }

                Car temp = wEntryQueue.RemoveFromQueue();
                AddCar(temp);
                await Task.Delay(rnd.Next(100, 500));
            }
            Delay(4);
        }

        /// <summary>
        /// This method is used to put a thread in delay
        /// </summary>
        /// <param name="queue"></param>
        public async void Delay(int queue)
        {
            await Task.Delay(rnd.Next(50, 200));

            if (queue == 1)
            {
                AddFromNorth();
            }
            else if (queue == 2)
            {
                AddFromSouth();
            }
            else if (queue == 3)
            {
                AddFromEast();
            }
            else if (queue == 4)
            {
                AddFromWest();
            }
        }


        /// <summary>
        /// Removes a car from the queue
        /// </summary>
        public void RemoveFromQueue()
        {
            Monitor.Enter(myLock);

            while (carQueue.Count() == 0)
            {
                Monitor.Wait(myLock);
            }

            carQueue.Dequeue();
            --currentInQueue;

            if (carQueue.Count() == 0) { empty = true; }
            else { empty = false; }
            l1.Invoke(new Action(delegate () { l1.Text = currentInQueue.ToString(); }));

            Monitor.PulseAll(myLock);
            Monitor.Exit(myLock);

            //Thread.Sleep(rnd.Next(100, 400));
        }

        /// <summary>
        /// Property for the bool filled 
        /// </summary>
        public bool Filled
        {
            get { return filled; }
            set { filled = value; }
        }

        /// <summary>
        /// Property for the bool empty
        /// </summary>
        public bool Empty
        {
            get { return empty; }
        }

        /// <summary>
        /// Returns a random int value, used in exitQueue
        /// </summary>
        public int DelayInt
        {
            get { return rnd.Next(1000, 5000); }
        }
    }
}
