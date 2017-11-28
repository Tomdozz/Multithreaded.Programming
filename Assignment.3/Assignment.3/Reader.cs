using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment._3
{
    class Reader
    {
        int count;
        Buffer buffer;
        ListBox outputListBox;

        private delegate void DisplayDelegate(string s);  

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="outputListBox"></param>
        /// <param name="count"></param>
        public Reader(Buffer buffer, ListBox outputListBox, int count)
        {
            this.buffer = buffer;
            this.outputListBox = outputListBox;     
            this.count = count;
        }

        /// <summary>
        /// Reads the encrypted string and prints it to a listbox
        /// </summary>
        public void Read() //tråd
        {
            for (int i = 0; i < count; i++)
            {
                //buffer.Read();
                buffer.Reader();

                outputListBox.Invoke(new DisplayDelegate(DisplayString), new object[] { buffer.output});
                Thread.Sleep(350);
            }         
        }
        /// <summary>
        /// This method is used by the DisplayDelegate for printing in a Listbox.
        /// </summary>
        /// <param name="s"></param>
        private void DisplayString(string s)
        {
            outputListBox.Items.Add(s);
        }
    }
}
