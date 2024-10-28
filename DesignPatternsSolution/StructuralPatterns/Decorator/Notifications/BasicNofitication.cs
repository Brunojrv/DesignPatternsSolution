using DesignPatternsSolution.StructuralPatterns.Decorator.Interface;
using System;

namespace DesignPatternsSolution.StructuralPatterns.Decorator
{
    public class BasicNofitication : INotify
    {
        public void SendNotification(string message)
        {
                Console.WriteLine("Enviando notificação Basic: " + message);
        }
    }
}
