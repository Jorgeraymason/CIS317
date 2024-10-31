/*******************************************************************
* Name: Devin Avery
* Date: 10/29/2024
* Assignment: SDC320 Week 5 GP – Concurrency
*
* Consumer class used to use (or consume) items that the producer
* places in the buffer.
*/
using System;
using System.Threading;

namespace devave9719_pa_concurrency
{
    public class Consumer
    {
        private string Name;
        private int SleepTime;
        private int StartConsuming;
        private int StopConsuming;
        private BlockingBuffer buffer;

        public Consumer(string name, int sleepTime, int startConsuming, int stopConsuming, BlockingBuffer buf)
        {
            Name = name;
            SleepTime = sleepTime;
            StartConsuming = startConsuming;
            StopConsuming = stopConsuming;
            buffer = buf;
        }

        public void Run()
        {
            for (int i = StartConsuming; i <= StopConsuming; i++)
            {
                int data = buffer.BlockingGet(Name);
                Thread.Sleep(SleepTime * 1000);
            }
        }
    }
}