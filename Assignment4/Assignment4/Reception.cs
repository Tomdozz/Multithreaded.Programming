using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment4
{
    class Reception
    {
       
        int maxCapacity;
        WaitingQueueAP wQueueAP;
        WaitingQueueCP wQueueCP;
       
        int queue;
        int vip;

        bool open, receptionFull;
        bool vipBool;

        //Randommiza mellan 1 och två för att bvestämma vilken kö
        Random rnd = new Random();
        Random rndVip = new Random();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="maxCapacity"></param>
        /// <param name="wQueueCP"></param>
        /// <param name="wQueueAP"></param>
        public Reception(int maxCapacity, WaitingQueueCP wQueueCP, WaitingQueueAP wQueueAP)
        {
            this.maxCapacity = maxCapacity;
            this.wQueueAP = wQueueAP;
            this.wQueueCP = wQueueCP;
            receptionFull = false;
            open = false;

            rnd = new Random();
        }

        /// <summary>
        /// Selects a queue and creats a customer to add to the selected queue
        /// If receptionFull is true the wait method is called
        /// </summary>
        public void SelectQueue()
        {
            while (open == true && receptionFull == false)
            {

                queue = rnd.Next(1, 3);
                vip = rndVip.Next(1, 3);

                if (vip == 1) { vipBool = true; }
                if (vip == 2) { vipBool = false; }

                Customer customer = new Customer(queue, vipBool);

                if (queue == 1 && wQueueAP.Filled == false) //&& bool för ap=false
                {
                    receptionFull = false;
                    wQueueAP.AddToQueue(customer);
                    Thread.Sleep(rnd.Next(100, 400));
                }
                if (queue == 2 && wQueueCP.Filled == false)//&& bool för cp=false
                {
                    receptionFull = false;
                    wQueueCP.AddToQueue(customer);
                    Thread.Sleep(rnd.Next(100, 400));
                }
                if (wQueueAP.Filled == true && wQueueCP.Filled == true) //båda är fulla
                {
                    receptionFull = true;
                    Thread.Sleep(rnd.Next(100, 400));
                }

            }

            Wait();

        }

        /// <summary>
        /// If called, the queue are full and the thread are going to sleep untill cpQueue or apQueue are not full anymore
        /// </summary>
        private void Wait()
        {
            while (open == false || receptionFull == true)
            {
                Thread.Sleep(1000);

                if (wQueueCP.Filled == false || wQueueAP.Filled == false)
                {
                    receptionFull = false;
                    break;
                }
            }
            SelectQueue();
        }

        /// <summary>
        /// Used to see if pools are open and to set the pools to open
        /// </summary>
        public bool Open
        {
            get { return open; }
            set { open = value; }
        }
    }
}
