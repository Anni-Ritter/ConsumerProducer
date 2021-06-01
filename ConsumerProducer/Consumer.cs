using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsumerProducer
{
    public class Consumer
    {
        public void RemoveProduct()
        {

            while (true)
            {
                if (StaticFunction.Product.Count > 0)
                {
                    StaticFunction.SemConsumer.WaitOne();

                    ConsoleHelper.ProductBuy();
                    Thread.Sleep(1000);
                    StaticFunction.Product.Dequeue();

                    StaticFunction.SemConsumer.Release();                
                }
                if (StaticFunction.Product.Count == 0)
                {
                    ConsoleHelper.NoProduct();
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
