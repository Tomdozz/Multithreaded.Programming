using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment5
{
    class CarReception
    {
        int maxCapacity;
        int queue, eQueue, delay;
        int carId;

        bool open;
        bool filled;

        EntryQueue nEntryQueue, sEntryQueue, eEntryQueue, wEntryQueue;
        Random rnd;
        
        /// <summary>
        /// Constructor for carReception
        /// </summary>
        /// <param name="open"></param>
        /// <param name="maxCapacity"></param>
        /// <param name="nEntryQueue"></param>
        /// <param name="sEntryQueue"></param>
        /// <param name="eEntryQueue"></param>
        /// <param name="wEntryQueue"></param>
        public CarReception(bool open, int maxCapacity, EntryQueue nEntryQueue, EntryQueue sEntryQueue, EntryQueue eEntryQueue, EntryQueue wEntryQueue)
        {
            this.maxCapacity = maxCapacity;
            this.nEntryQueue = nEntryQueue;
            this.eEntryQueue = eEntryQueue;
            this.sEntryQueue = sEntryQueue;
            this.wEntryQueue = wEntryQueue;
            this.open = open;
        
            carId = 0;
            eQueue = 0;
            rnd = new Random();
        }

        /// <summary>
        /// Add cars to one of the entrys
        /// </summary>
        public async void SelectEntry()
        {
            while (open == true)
            {
                eQueue = rnd.Next(0, 5);               
                AddCars(eQueue);                
                await Task.Delay(300);

            }
            Delay();
        }

        /// <summary>
        /// Adds cars to waiting queue
        /// </summary>
        /// <param name="queue"></param>
        public void AddCars(int queue)
        {
            carId = carId + 2;
            Car car = new Car(carId);

            if (eQueue == 1 && nEntryQueue.Filled == false)//north
            {
                //filled = false;
                nEntryQueue.AddToQueue(car);
            }
            else if (eQueue == 2 && eEntryQueue.Filled == false)//east
            {
                //filled = false;
                eEntryQueue.AddToQueue(car);
            }
            else if (eQueue == 3 && sEntryQueue.Filled == false)//soth
            {
                //filled = false;
                sEntryQueue.AddToQueue(car);
            }
            else if (eQueue == 4 && wEntryQueue.Filled == false)//west
            {
               //filled = false;
                wEntryQueue.AddToQueue(car);
            }

            Thread.Sleep(rnd.Next(100, 200));
            SelectEntry();         
        }

        /// <summary>
        /// If !open it puts the thread on delay 
        /// </summary>
        public async void Delay()
        {
            while (open == false)
            {
                await Task.Delay(rnd.Next(100,500));
            }
            SelectEntry();
        }

        /// <summary>
        /// Property for the bool open
        /// </summary>
        public bool Open
        {
            get { return open; }
            set { open = value; }
        }
    }
}
