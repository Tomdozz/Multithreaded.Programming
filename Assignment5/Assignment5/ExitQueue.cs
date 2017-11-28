using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    class ExitQueue
    {
        Queue<Car> carQueue;
        
        Label l1;
        int delay, currentInQueue;
        ParkingHouse pHouse;
        Random rnd;
    
        /// <summary>
        /// Constructor for ExitQueue
        /// </summary>
        /// <param name="pHouse"></param>
        /// <param name="l1"></param>
        public ExitQueue(ParkingHouse pHouse, Label l1)
        {
            this.pHouse = pHouse;
            this.l1 = l1;
            currentInQueue = 0;       
            rnd = new Random();
            carQueue = new Queue<Car>();
        }

        /// <summary>
        /// While parkingHouse !empty it removes a car
        /// If the parking house are empty it calls the delay method
        /// </summary>
        public async void RemoveCar()
        {
            while (pHouse.Empty == false)
            {
                delay = pHouse.DelayInt;
                await Task.Delay(delay);

                pHouse.RemoveFromQueue();
                ++currentInQueue;

                l1.Invoke(new Action(delegate() { l1.Text = currentInQueue.ToString(); }));
            }
            Delay();
        }

        /// <summary>
        /// Puts a task in delay
        /// </summary>
        public async void Delay()
        {
            while (pHouse.Empty != false)
            {
                await Task.Delay(rnd.Next(1000, 1500));
            }
            RemoveCar();
        }
    }
}
