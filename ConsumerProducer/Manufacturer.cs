using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsumerProducer
{
    public class Manufacturer
    {
        Random random = new Random();
        public void AddProduct()
        {
            while (true)
            {
                if(StaticFunction.Product.Count < 20)
                {
                    StaticFunction.SemManufacture.WaitOne();
                    Console.WriteLine("Товаров на складе: " + StaticFunction.Product.Count.ToString());
                    ConsoleHelper.ProductionGood();
                    StaticFunction.Product.Enqueue(random.Next(0, 100));
                    Thread.Sleep(500);
                    StaticFunction.SemManufacture.Release();
                }
                if (StaticFunction.Product.Count >= 20)
                {
                    ConsoleHelper.WarehouseFull();
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
