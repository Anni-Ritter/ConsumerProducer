using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsumerProducer
{
    public static class StaticFunction
    {

        public static Queue<int> Product = new Queue<int>();

        public static Semaphore SemManufacture = new Semaphore(2, 2);
        public static Semaphore SemConsumer = new Semaphore(2, 2);

    }
}
