using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    class CharacterBuffer
    {

        private char ch;

        private char c;
        private bool filled;

        private ListBox lstWriter;
        private ListBox lstReader;

        private delegate void DisplayDelgate(string s, ListBox listBox);

        object myLock = new object(); //used for locking sync of threads

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="writeListBox"></param>
        /// <param name="readerLisBox"></param>
        public CharacterBuffer(ListBox writeListBox, ListBox readerListBox)
        {
            lstReader = readerListBox;
            lstWriter = writeListBox;
            filled = false; //kolla denna //hur ska den användas
        }

        public bool Filled
        {
            set { filled = value; }
        }
        /// <summary>
        /// get: log "reading" in the dedicated listbox, and then return
        /// set: log "writing" in the dedicated listbox, and save value in ch
        /// </summary>
        public Char AsyncReadWrite
        {
            get
            {
                if (filled == true)
                {

                    lstReader.Invoke(new DisplayDelgate(DisplayString), new object[] { "Reading " + ch, lstReader });
                    return ch;
                }
                return ch;
            }

            set
            {
                ch = value;

                filled = true;
                lstWriter.Invoke(new DisplayDelgate(DisplayString), new object[] { "Writing " + ch, lstWriter });
            }
        }

        /// <summary>
        /// Critical section
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool SyncWrite(Char c)
        {
            bool succ = false;
            lock (myLock)
            {
                if (!filled)
                {
                    filled = true;
                    ch = c;
                    succ = true;
                    lstWriter.Invoke(new DisplayDelgate(DisplayString), new object[] { "Writing " + ch, lstWriter });

                }
                // lstWriter.Invoke(new DisplayDelegate(DisplayString), new object[] { "Writing " + ch, WriterListBox });

            }
            return succ; 
        }

        /// <summary>
        /// Critical section
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool SyncRead(out Char c)
        {
            c = 'o';
            bool succ = false;
            lock (myLock)
            {
                if (filled)
                {
                    filled = false;
                    c = ch;
                    succ = true;
                    lstReader.Invoke(new DisplayDelgate(DisplayString), new object[] { "Reading " + ch, lstReader });
                }
            }
            return succ;
        }

        /// <summary>
        /// Adds in a given listbox through a delegate
        /// </summary>
        /// <param name="s"></param>
        /// <param name="lb"></param>
        private void DisplayString(string s, ListBox lb)
        {
            lb.Items.Add(s);
        }
    }
}
