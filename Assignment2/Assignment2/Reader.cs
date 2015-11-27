using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// A reader class that reads from a buffer.
    /// </summary>
    class Reader
    {
        public string Line { get; private set; }
        public Buffer<char> Buffer { get; private set; }
        public int Count { get; private set; }
        public Random Random { get; set; }

        public Reader(Buffer<char> buffer, int count, Random random)
        {
            this.Random = random;
            this.Buffer = buffer;
            this.Line = String.Empty;
            this.Count = count;
        }

        /// <summary>
        /// Read from the buffer til it's done.
        /// </summary>
        public void Read()
        {
            while (Line.Length < Count)
            {
                bool isDone = false;
                char data = default(char);

                while (!isDone)
                {
                    Thread.Sleep(Random.Next(200, 1000));

                    if (!Buffer.GetData(out data))
                    {
                        Console.WriteLine("Error: Reading empty buffer");
                        continue;
                    }
                    else
                    {
                        isDone = true;
                    }
                }

                Line += data;

                Console.WriteLine("Read: " + data);

            }

           
        }
       

    }
}
