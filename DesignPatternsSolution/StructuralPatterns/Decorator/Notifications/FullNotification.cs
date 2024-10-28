using DesignPatternsSolution.StructuralPatterns.Decorator.Interface;
using System;

namespace DesignPatternsSolution.StructuralPatterns.Decorator.Notifications
{
    public class FullNotification : INotify
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Enviando notificação Completa: {message}");
        }
    }
}
