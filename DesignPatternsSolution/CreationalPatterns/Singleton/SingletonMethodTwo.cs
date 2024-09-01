using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace DesignPatternsSolution.CreationalPatterns.Singleton
{
    public class SingletonMethodTwo
    {
        private string Name { get; set; }
        private static int _instanceCreationCount = 0;
        public static SingletonMethodTwo _singleton = null;
        private static readonly object _lock = new object();

        private SingletonMethodTwo() { }

        public static SingletonMethodTwo Singleton
        {
            get
            {
                if (_singleton == null)
                {
                    lock (_lock)
                    {
                        if (_singleton == null)
                        {
                            _instanceCreationCount++;
                            _singleton = new SingletonMethodTwo { Name = $"Testing Singleton - {DateTime.Now}" };
                        }
                    }
                }
                return _singleton;
            }
        }

        public static int GetInstanceCreationCount()
        {
            Console.WriteLine($"Número de instâncias criadas: {_instanceCreationCount}");
            return _instanceCreationCount;
        }

        public static void TestingSingletonInParallel()
        {
            var listNumbers = Enumerable.Range(1, 3);
            Parallel.ForEach(listNumbers, new ParallelOptions { MaxDegreeOfParallelism = 3 }, item =>
            {
                var testingSingleton = Singleton;
                Console.WriteLine($"Processing item {testingSingleton} on thread {Task.CurrentId}");
            });

            GetInstanceCreationCount();
        }
    }
}
