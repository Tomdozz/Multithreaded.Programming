using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment._3
{
    public partial class Form1 : Form
    {
        Buffer buffer;
        Writer writerClass;
        Reader readerClass;
        Encrypter encrypterClass;

        List<string> inputString = new List<string>();

        Thread writerThread;
        Thread readerThread;
        Thread encrypterThread;


        int bufferSize = 5;

        /// <summary>
        /// Constuctor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            ConvertToString();
            CreateObjects();
            CreateThreads();
        }

        /// <summary>
        /// Reads a from a textfil and adds it to the inputString List
        /// </summary>
        private void ConvertToString()
        {           
            StreamReader streamReader = new StreamReader(@"TextFile.txt");
            while (!streamReader.EndOfStream)
            {
                inputString.Add(streamReader.ReadLine());
            }
            streamReader.Close();
        }

        /// <summary>
        /// Create all objects needed
        /// </summary>
        private void CreateObjects()
        {
            buffer = new Buffer(bufferSize);
            writerClass = new Writer(buffer,plainTextBox, inputString, bufferSize);
            readerClass = new Reader(buffer, encryptedTextBox, inputString.Count);
            encrypterClass = new Encrypter(buffer, inputString.Count);
        }

        /// <summary>
        /// Create all threads and start writer and reader thread
        /// </summary>
        private void CreateThreads()
        {
            writerThread = new Thread(writerClass.WriteToBuffer);
            readerThread = new Thread(readerClass.Read);
            encrypterThread = new Thread(encrypterClass.EncryptText);

            readerThread.Name = "Reader";
            writerThread.Name = "Writer";
            encrypterThread.Name = "Encrypter";

            writerThread.Start();
            readerThread.Start();
        
        }

        /// <summary>
        /// This method is used to decrypt the text
        /// </summary>
        void CreateDecryption()
        {
            writerClass = new Writer(buffer, encryptedTextBox, buffer.EncryptedList, bufferSize);
            writerClass.Encrypted = true;
            writerThread = new Thread(writerClass.WriteToBuffer);
            encrypterThread = new Thread(encrypterClass.EncryptText);
            readerThread = new Thread(readerClass.Read);

            readerThread.Name = "DecryptReader";
            writerThread.Name = "DecryptWriter";
            encrypterThread.Name = "Decrypter";
            writerThread.Start();
            readerThread.Start();
            encrypterThread.Start();
        }

        /// <summary>
        /// Starts the encrypter thread
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Encrypt_Click(object sender, EventArgs e)
        {
            Encrypt.Enabled = false;
            encrypterThread.Start();
        }


        /// <summary>
        /// Calls the decrypt method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Decrypt_Click(object sender, EventArgs e)
        {
            Decrypt.Enabled = false;
            CreateDecryption();
        }

        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }
    }
}
