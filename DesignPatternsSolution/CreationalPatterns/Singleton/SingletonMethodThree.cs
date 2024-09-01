using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsSolution.CreationalPatterns.Singleton
{
    public class SingletonMethodThree
    {
        private static readonly Lazy<SingletonMethodThree> _singleton = new Lazy<SingletonMethodThree>();

        private static int _instanceCreationCount = 0;
        public string Name { get; set; }

        private SingletonMethodThree()
        {
            _instanceCreationCount++;
            Name = $"Testing Singleton - {DateTime.Now}";
        }

        public static SingletonMethodThree Instance => _singleton.Value;

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
                var testingSingleton = Instance;
                Console.WriteLine($"Processing item {testingSingleton} on thread {Task.CurrentId}");
            });

            GetInstanceCreationCount();
        }
    }
}
