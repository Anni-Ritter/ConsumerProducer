using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsumerProducer
{
    class Program
    {

        static void Main(string[] args)
        {
            Manufacturer manuf1 = new Manufacturer();
            Manufacturer manuf2 = new Manufacturer();
            Consumer con1 = new Consumer();
            Consumer con2 = new Consumer();
            Consumer con3 = new Consumer();                  

            Thread man1 = new Thread(manuf1.AddProduct);
            Thread man2 = new Thread(manuf2.AddProduct);
            Thread comsumer1 = new Thread(con1.RemoveProduct);
            Thread comsumer2 = new Thread(con2.RemoveProduct);
            Thread comsumer3 = new Thread(con3.RemoveProduct);

            man1.Start();
            comsumer1.Start();
            man2.Start();
            comsumer2.Start();
            comsumer3.Start();
            
        }
    }
}
