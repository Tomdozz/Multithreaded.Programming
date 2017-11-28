using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class Form1 : Form
    {
        private CharacterBuffer buffer;     //shared buffer
        private Writer writerClass;         //Writerclass
        private Reader readerClass;         //RederClass
        private Random rnd;
        private Thread writerThread;        //WriterThread
        private Thread readerThread;        //ReaderThread
        private string textData;            

        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            buffer = new CharacterBuffer(listBoxWrite, listBoxRead);
            rnd = new Random();
            TransmittedString.Text = " ";
            RecivedString.Text = " ";
            syncMode.Text = " ";
        }

        /// <summary>
        /// To check if textbox is empty or not
        /// </summary>
        /// <returns></returns>
        private bool ReadDataToTransfer()
        {
            if (string.IsNullOrWhiteSpace(StringToEnter.Text))
            {
                MessageBox.Show("Imput error"); //fix
            }

            else
                textData = StringToEnter.Text;

            return true;
        }

        /// <summary>
        /// Runs the 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Run_Click(object sender, EventArgs e)
        {
            //There must be a string
            if (!ReadDataToTransfer())
                return;
   
            //create transmitter and reciver
            CreateWriterAndReaderObj();
            CreateAndStartWriterAndReaderThreads();
            DisplayFinalResult();
            Clear.Enabled = true;
        }

        /// <summary>
        /// Creates read and write objects
        /// </summary>
        private void CreateWriterAndReaderObj()
        {
            writerClass = new Writer(buffer, rnd, textData, TransmittedString);
            readerClass = new Reader(buffer, rnd, textData.Length, RecivedString);

            if (SynchronizedMode.Checked == true)
            {
                writerClass.Sync = true;
                readerClass.Sync = true;
                syncMode.Text = "Synchronized Mode";
            }

            else if (AsynchronizedMode.Checked == true)
            {
                writerClass.Sync = false;
                readerClass.Sync = false;
                syncMode.Text = "Asynchronized Mode";
            }
        }

        /// <summary>
        /// Creates and starts the threads (one write, one read)
        /// </summary>
        private void CreateAndStartWriterAndReaderThreads()
        {

            writerThread = new Thread(writerClass.WriteChar);
            readerThread = new Thread(readerClass.ReadChar);

            writerThread.Start();
            readerThread.Start();
        }

        /// <summary>
        /// Change color of the box, green if it sucseed and red if it fails
        /// It also write out succsess or fair depending on the result
        /// </summary>
        private void DisplayFinalResult()
        {            
            if (SynchronizedMode.Checked == true)
            {
                RunningStatus.BackColor = Color.Green;
                resultLabel.Text = "Success";
            }
            if (AsynchronizedMode.Checked == true)
            {
                RunningStatus.BackColor = Color.Red;
                resultLabel.Text = "Fail";
            }
        }

        /// <summary>
        /// Button to clear all
        /// Calls the ClearAll method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        /// <summary>
        /// Method used to clear all
        /// </summary>
        private void ClearAll()
        {          
            listBoxRead.Items.Clear();
            listBoxWrite.Items.Clear();
            TransmittedString.Text = " ";
            RecivedString.Text = " ";
            syncMode.Text = " ";
            writerThread.Abort();
            readerThread.Abort();
            RunningStatus.BackColor = Color.White;
            textData = string.Empty;
            buffer.Filled = false;
            Clear.Enabled = false;
            Run.Enabled = true;
        }


        /// <summary>
        /// Checkbox to set synchronized mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SynchronizedMode_CheckedChanged(object sender, EventArgs e)
        {
            if (SynchronizedMode.Checked == true)
            {
                AsynchronizedMode.Checked = false;
            }
        }

        /// <summary>
        /// Checkbox to set asynchronized mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AsynchronizedMode_CheckedChanged(object sender, EventArgs e)
        {
            if (AsynchronizedMode.Checked == true)
            {
                SynchronizedMode.Checked = false;
            }
        }

        private void RunningStatus_Click(object sender, EventArgs e)
        {

        }

        private void StringToEnter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
