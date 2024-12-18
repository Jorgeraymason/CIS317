﻿/*******************************************************************
* Name: Devin Avery
* Date: 10/29/2024
* Assignment: SDC320 Week 5 GP – Concurrency
*
* Main application class.
*/
public class AsyncDemo
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("\nDevin Avery, Week 5 Concurrrency GP\n");
        BlockingBuffer sharedLocation = new BlockingBuffer();
        Task producer = new Producer(sharedLocation).Run();
        Task consumer = new Consumer(sharedLocation).Run();
        await producer;
        await consumer;
    }
}
