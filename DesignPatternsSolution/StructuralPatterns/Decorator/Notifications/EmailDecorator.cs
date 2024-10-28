using DesignPatternsSolution.StructuralPatterns.Decorator.Interface;
using System;

namespace DesignPatternsSolution.StructuralPatterns.Decorator
{
    public class EmailDecorator : NotificationDecorator
    {
        public EmailDecorator(INotify notification) : base(notification) { }

        public override void SendNotification(string message)
        {
            base.SendNotification(message);
            Console.WriteLine("Enviando notificação por E-mail: " + message);
        }
    }
}
