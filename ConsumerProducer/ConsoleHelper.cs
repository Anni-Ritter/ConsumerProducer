using System;
using System.Threading;

namespace ConsumerProducer
{
    public static class ConsoleHelper
    {
        public static object LockObject = new object();

        public static void ProductionGood()
        {
            lock (LockObject)
            {
                Console.WriteLine($"Производитель {Thread.CurrentThread.ManagedThreadId} производит товар.");
            }
        }

        public static void NoProduct()
        {
            lock (LockObject)
            {
                Console.WriteLine($"Покупатель {Thread.CurrentThread.ManagedThreadId} ждет товар.");
            }
        }

        public static void WarehouseFull()
        {
            lock(LockObject)
            {
                Console.WriteLine("Склад заполнен.");
                Console.WriteLine($"Производитель {Thread.CurrentThread.ManagedThreadId} ждет свободное место.");
            }
        }

        public static void ProductBuy()
        {
            lock(LockObject)
            {
                Console.WriteLine($"Потребитель {Thread.CurrentThread.ManagedThreadId} купил товар");
            }
        }
    }
}
