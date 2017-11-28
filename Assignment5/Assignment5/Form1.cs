using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {        
        EntryQueue nEntryQueue, sEntryQueue, eEntryQueue, wEntryQueue;
        ExitQueue nExitQueue, sExitQueue, eExitQueue, wExitQueue;
        ParkingHouse pHouse;
        CarReception cReception;
        int sizeOfQueue;
        bool open = false;

        private void label8_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            sizeOfQueue = 60;
            CreateObj();
            CreateTasks();
        }

        /// <summary>
        /// Button to open/close the parking house
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openPHouse_Click(object sender, EventArgs e)
        {
            if (open == false)
            {
                open = true;
                cReception.Open = true;
                openPHouse.Text = "Open";

            }

            else if(open == true)
            {
                open = false;
                cReception.Open = false;
                openPHouse.Text = "Close";

            }
        }

        /// <summary>
        /// Method used to create all objects
        /// </summary>
        public void CreateObj()
        {
            nEntryQueue = new EntryQueue(sizeOfQueue, northQ);
            sEntryQueue = new EntryQueue(sizeOfQueue, southQ);
            eEntryQueue = new EntryQueue(sizeOfQueue, eastQ);
            wEntryQueue = new EntryQueue(sizeOfQueue, westQ);

            pHouse = new ParkingHouse(200, nEntryQueue, sEntryQueue, eEntryQueue,wEntryQueue, pHouseStatus, parkingQStatus);
            cReception = new CarReception(open, 500, nEntryQueue, sEntryQueue, eEntryQueue, wEntryQueue);

            nExitQueue = new ExitQueue(pHouse, northE);
            sExitQueue = new ExitQueue(pHouse,  southExit);
            eExitQueue = new ExitQueue(pHouse, eastExit);
            wExitQueue = new ExitQueue(pHouse, westExit);
        }

        /// <summary>
        /// Method used to create all tasks
        /// </summary>
        public void CreateTasks()
        {           
            var t1 = Task.Factory.StartNew(() => cReception.SelectEntry());

            var enterNorth = Task.Factory.StartNew(() => pHouse.AddFromNorth());
            var enterSouth = Task.Factory.StartNew(() => pHouse.AddFromSouth());
            var enterEast = Task.Factory.StartNew(() => pHouse.AddFromEast());
            var enterWest = Task.Factory.StartNew(() => pHouse.AddFromWest());

            var exitNorth = Task.Factory.StartNew(() => nExitQueue.RemoveCar());
            var exitSouth = Task.Factory.StartNew(() => sExitQueue.RemoveCar());
            var exitEast = Task.Factory.StartNew(() => eExitQueue.RemoveCar());
            var exitWest = Task.Factory.StartNew(() => wExitQueue.RemoveCar());
        }

        /// <summary>
        /// Button that close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
