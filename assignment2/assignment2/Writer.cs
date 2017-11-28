using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    /// <summary>
    /// Transmitter
    /// </summary>
    class Writer
    {
        private CharacterBuffer buffer;
        private Random rnd;
        private string stringToWrite;
        private bool sync, ready;

        private Label displayResult;

        private delegate void DisplayDelgate(string s);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="chb"></param>
        /// <param name="r"></param>
        /// <param name="s"></param>
        /// <param name="l"></param>
        public Writer(CharacterBuffer chb, Random r, string s, Label l)
        {
            rnd = r;
            buffer = chb;
            stringToWrite = s;
            sync = false;
            displayResult = l;

        }

        /// <summary>
        /// Used to set sunc bool in form1
        /// </summary>
        public bool Sync
        {      
            set { sync = value; }
        }

        public bool Ready
        {
            set { ready = value; }
        }

        /// <summary>
        /// Writes chars to the buffer
        /// Depending on the bool sync it calls asyncwrite or syncwrite
        /// </summary>
        public void WriteChar()
        {
            for (int i = 0; i < stringToWrite.Length; i++)
            {
                if (sync == false)
                {
                    buffer.AsyncReadWrite = stringToWrite[i];
                }

                if (sync == true)
                {
                    ready = false;
                    while (!ready)
                    {
                        ready = buffer.SyncWrite(stringToWrite[i]);
                        //buffer.SyncReadWrite = stringToWrite[i];
                        //ready = true;
                    }
                }
                Thread.Sleep(rnd.Next(100, 200));
            }
            displayResult.Invoke(new DisplayDelgate(DisplayString), new object[] { stringToWrite });
        }

        /// <summary>
        /// This method is used by WriteChar to send a text to a listbox
        /// </summary>
        /// <param name="s"></param>
        private void DisplayString(string s)
        {
            displayResult.Text = s;
        }
    }
}
