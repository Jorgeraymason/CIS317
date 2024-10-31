/*******************************************************************
* Name: Devin Avery
* Date: 10/29/2024
* Assignment: SDC320 Week 5 GP – Concurrency
*
* BlockingBuffer class that acts as the warehouse where the producer
* stores items produced and the consumer retrieves (or reads) items
* to consume.
*/
using System.Collections.Concurrent;
using System;

namespace devave9719_pa_concurrency
{
    public class BlockingBuffer
    {
        private BlockingCollection<int> buffer;

        public BlockingBuffer(int size)
        {
            buffer = new BlockingCollection<int>(size);
        }

        public void BlockingPut(int data, string name)
        {
            buffer.Add(data);
            Console.WriteLine($"{name} added: {data}");
        }

        public int BlockingGet(string name)
        {
            int data = buffer.Take();
            Console.WriteLine($"{name} retrieved: {data}");
            return data;
        }
    }
}