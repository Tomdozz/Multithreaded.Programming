using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment._3
{
    class Writer
    {
        Buffer buffer;
        ListBox inputListBox;

        bool encrypted;


        private delegate void DisplayDelegate(string s);

        List<string> stringList = new List<string>();

        public bool Encrypted
        {
            get { return encrypted; }
            set { encrypted = value; }
        }
        int bufferSize;


        /// <summary>
        /// Constructor for Writer
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="inputListBox"></param>
        /// <param name="stringList"></param>
        /// <param name="bufferSize"></param>
        public Writer(Buffer buffer, ListBox inputListBox, List<string> stringList, int bufferSize)
        {
            this.buffer = buffer;
            this.inputListBox = inputListBox;
            this.stringList = stringList;
            this.bufferSize = bufferSize;
        }

        /// <summary>
        /// Loops through the stringList and calls buffer.writer to add to buffer
        /// If the encrypter bool is false it print out the strings to a listbox
        /// </summary>
        public void WriteToBuffer() //tråd
        {
            for (int i = 0; i < stringList.Count; i++)
            {
                buffer.Write(stringList[i]);
                if (!encrypted)
                {

                    inputListBox.Invoke(new DisplayDelegate(DisplayString), new object[] { stringList[i] });
                }
            }
            Thread.Sleep(250);
        }

        /// <summary>
        ///  This method is used by the WriteToBuffer to print out via a delegate to a listBox.
        /// </summary>
        /// <param name="s"></param>
        private void DisplayString(string s)
        {
            inputListBox.Items.Add(s);
        }
    }
}
