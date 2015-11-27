using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment2
{
    class MainMenu
    {
        public Reader Reader { get; set; }
        public Writer Writer { get; set; }
        public Buffer<char> Buffer { get; set; }

        /// <summary>
        /// Start main application
        /// </summary>
        /// <returns>If it was successfull</returns>
        public bool Start()
        {
            Console.WriteLine("Enter a string:");
            string line = Console.ReadLine();

            Console.WriteLine("Synchronized? (Y/N)");

            bool sync = Console.ReadLine().ToLower() == "y";

            // What kind of buffer should we create?
            if (sync)
            {
                Buffer = new SyncBuffer<char>();
            }
            else
            {
                Buffer = new AsyncBuffer<char>();
            }

            Random random = new Random();

            // Create the reader and writer.
            Reader = new Reader(Buffer, line.Length, random);
            Writer = new Writer(Buffer, line, random);

            Thread readerThread = new Thread(new ThreadStart(Reader.Read));
            Thread writerThread = new Thread(new ThreadStart(Writer.Write));

            // Start the threads.
            readerThread.Start();
            writerThread.Start();

            // Wait on main thread for them to complete.
            readerThread.Join();
            writerThread.Join();

            // Print result
            Console.WriteLine("The Write String: " + Writer.Line);
            Console.WriteLine("The Read String: " + Reader.Line);

            Console.WriteLine();

            return true;

        }
    }
}
