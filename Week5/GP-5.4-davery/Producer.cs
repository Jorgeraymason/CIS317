/*******************************************************************
* Name: Devin Avery
* Date: 10/29/2024
* Assignment: SDC320 Week 5 GP – Concurrency
*
* Producer class used to produce items and place them in the buffer.
*/
using System;
using System.Threading;

namespace devave9719_pa_concurrency
{
    public class Producer
    {
        private string Name;
        private int SleepTime;
        private int StartProducing;
        private int StopProducing;
        private BlockingBuffer buffer;

        public Producer(string name, int sleepTime, int startProducing, int stopProducing, BlockingBuffer buf)
        {
            Name = name;
            SleepTime = sleepTime;
            StartProducing = startProducing;
            StopProducing = stopProducing;
            buffer = buf;
        }

        public void Run()
        {
            for (int i = StartProducing; i <= StopProducing; i++)
            {
                buffer.BlockingPut(i, Name);
                Thread.Sleep(SleepTime * 1000);
            }
        }
    }
}