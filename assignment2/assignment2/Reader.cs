using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    class Reader
    {

        private CharacterBuffer buffer;
        private Random rnd;
        private string stringToFill;
        private int count;
        private bool sync, ready;

        private Label displayResult;

        private delegate void DisplayDelegate(string s);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="chb"></param>
        /// <param name="r"></param>
        /// <param name="cnt"></param>
        /// <param name="l"></param>
        public Reader(CharacterBuffer chb, Random r, int cnt, Label l)
        {
            rnd = r;
            buffer = chb;
            count = cnt;
            stringToFill = string.Empty;
            sync = false;
            displayResult = l;
        }

        /// <summary>
        /// Used to set the sync bool in form1
        /// </summary>
        public bool Sync
        {
            set { sync = value; }
        }

        /// <summary>
        /// Reading one character at a time with random time between attempts
        /// Depending on the bool sync it calls asyncReadwrite or syncRead
        public void ReadChar()
        {
            char tmp = 'x';
            for (int i = 0; i < count; i++)
            {
                if (sync == false)
                {
                    stringToFill += buffer.AsyncReadWrite;
                }

                if (sync == true)
                {
                    ready = false;
                    while (!ready) ready = buffer.SyncRead(out tmp);
                    stringToFill += tmp;                   
                }

                Thread.Sleep(rnd.Next(100, 200));
            }
            displayResult.Invoke(new DisplayDelegate(DisplayString), new object[] { stringToFill });

        }

        /// <summary>
        /// This method is used by readChar to send a text to a listbox
        /// </summary>
        /// <param name="s"></param>
        private void DisplayString(string s)
        {
            displayResult.Text = s;
        }
    }
}
