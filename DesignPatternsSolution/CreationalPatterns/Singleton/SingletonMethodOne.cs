using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsSolution.CreationalPatterns.Singleton
{
    public class SingletonMethodOne
    {
        public string Name { get; set; }
        private static int _instanceCreationCount = 0;
        public static SingletonMethodOne _singleton = null;

        private SingletonMethodOne() { }

        public  static SingletonMethodOne Singleton
        {
            get
            {
                if (_singleton == null)
                {
                    _instanceCreationCount++;
                    _singleton = new SingletonMethodOne { Name = $"Testing Singleton - {DateTime.Now}" };
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
