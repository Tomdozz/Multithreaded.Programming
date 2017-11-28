using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment._3
{
    class Buffer
    {
        int count;
        public string output;

        //Outputlist
        List<string> outputL;

        //InputQueue, OutputQueue
        Queue<string> inputQueue, outputQueue;

        public List<string> EncryptedList
        {
            get { return outputL; }
            set { outputL = value; }
        }

        //semaphores and mutex 
        Mutex access = new Mutex();
        Semaphore writerSemaphore;
        Semaphore readerSemaphore;
        Semaphore encrypterSemaphore;


        public string Output
        {
            get { return output; }
            set { output = value; }
        }

        /// <summary>
        /// Constuctor for buffer
        /// </summary>
        /// <param name="count"></param>
        public Buffer(int count)
        {
            this.count = count;

            inputQueue = new Queue<string>();
            outputQueue = new Queue<string>();
            outputL = new List<string>();

            //Uses count(buffersize) as maximumCount for all and as initialcount for writer since it is counting down 
            writerSemaphore = new Semaphore(initialCount: count, maximumCount: count);
            readerSemaphore = new Semaphore(initialCount: 0, maximumCount: count);
            encrypterSemaphore = new Semaphore(initialCount: 0, maximumCount: count);

        }

        /// <summary>
        /// Takes in a string and enqueue it to inputQueue
        /// </summary>
        /// <param name="s"></param>
        public void Write(string s)
        {
            writerSemaphore.WaitOne();
            access.WaitOne();

            inputQueue.Enqueue(s); //Critical secion

            access.ReleaseMutex();
            encrypterSemaphore.Release();
        }

        /// <summary>
        /// Reads from outputqueue and adds to the outputList
        /// </summary>
        public void Reader()
        {
            readerSemaphore.WaitOne();
            access.WaitOne();
           
            output = outputQueue.Dequeue(); //Critical section
            outputL.Add(output); //Critical section

            access.ReleaseMutex();
            writerSemaphore.Release();
        }

        /// <summary>
        /// Encrypt the text with help of the method ReverseString, and adds it to the outputqueue
        /// </summary>
        public void Encrypt()
        {
            encrypterSemaphore.WaitOne();
            access.WaitOne();

            outputQueue.Enqueue(ReverseString(inputQueue.Dequeue())); //Critical section

            access.ReleaseMutex();
            readerSemaphore.Release();
        }

        /// <summary>
        /// Encrypt the string that is passed
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static string ReverseString(string s)
        {
            char[] charArray = s.ToArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
