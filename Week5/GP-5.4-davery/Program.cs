/*******************************************************************
* Name: Devin Avery
* Date: 10/29/2024
* Assignment: SDC320 Week 5 PA – Concurrency
*
* Main application class.
*/
using System;
using System.Threading;

namespace devave9719_pa_concurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingBuffer buffer = new BlockingBuffer(5);

            Producer p1 = new Producer("P1", 2, 10, 16, buffer);
            Producer p2 = new Producer("P2", 3, 25, 29, buffer);
            Producer p3 = new Producer("P3", 1, 30, 39, buffer);

            Consumer c1 = new Consumer("C1", 3, 1, 9, buffer);
            Consumer c2 = new Consumer("C2", 2, 1, 13, buffer);

            Thread p1Thread = new Thread(p1.Run);
            Thread p2Thread = new Thread(p2.Run);
            Thread p3Thread = new Thread(p3.Run);

            Thread c1Thread = new Thread(c1.Run);
            Thread c2Thread = new Thread(c2.Run);

            p1Thread.Start();
            p2Thread.Start();
            p3Thread.Start();

            c1Thread.Start();
            c2Thread.Start();

            p1Thread.Join();
            p2Thread.Join();
            p3Thread.Join();

            c1Thread.Join();
            c2Thread.Join();
        }
    }
}