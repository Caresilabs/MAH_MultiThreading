using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// A writer class that writes a line of text to a buffer
    /// </summary>
    class Writer
    {
        public Buffer<char> Buffer { get; private set; }
        public string Line { get; set; }
        public int Index { get; private set; }
        public Random Random { get; set; }

        public Writer(Buffer<char> buffer, string line, Random random)
        {
            this.Random = random;
            this.Buffer = buffer;
            this.Line = line;
        }

        /// <summary>
        /// Write the text to a buffer til it's done.
        /// </summary>
        public void Write()
        {
            for (; Index < Line.Length; Index++)
            {
                bool isDone = false;
                while (!isDone)
                {
                    Thread.Sleep(Random.Next(200, 1000));

                    char data = Line[Index];

                    if (!Buffer.SetData(data))
                    {
                        Console.WriteLine("Error: Writing full buffer");
                        continue;
                    }

                    isDone = true;
                    Console.WriteLine("Write: " + data);
                }
            }

        }
    }
}
