
using JournalAdapter.Adapter;
using System;

namespace JournalAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start working");
            Journal journal = new WorkJournal();

            journal.Log("first record");
            System.Threading.Thread.Sleep(2000);
            journal.Log("second record");
            System.Threading.Thread.Sleep(3000);
            journal.Log("third record");
            System.Threading.Thread.Sleep(4000);
            journal.Log("Here I am. Will you send me an angel");

            Console.WriteLine(new string('-', 50));
            Console.WriteLine(journal.Read(DateTime.Now.Subtract(new TimeSpan(0, 0, 6))));

            Console.ReadKey();
        }
    }
}
