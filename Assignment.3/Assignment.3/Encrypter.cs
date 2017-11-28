using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment._3
{
    class Encrypter
    {
        int count;
        Buffer buffer;

        /// <summary>
        /// Constructor for Encrypter
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="count"></param>
        public Encrypter(Buffer buffer, int count)
        {
            this.buffer = buffer;
            this.count = count;
        }
        /// <summary>
        /// Encrypts from the buffer
        /// </summary>
        public void EncryptText()
        {
            for (int i = 0; i < count; i++)
            {
                buffer.Encrypt();
                Thread.Sleep(400);
            }
        }


    }
}
