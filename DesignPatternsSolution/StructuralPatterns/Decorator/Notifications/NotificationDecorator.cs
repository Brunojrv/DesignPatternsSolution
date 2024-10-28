using DesignPatternsSolution.StructuralPatterns.Decorator.Interface;

namespace DesignPatternsSolution.StructuralPatterns.Decorator
{
    public class NotificationDecorator : INotify
    {
        protected INotify _notification;

        public NotificationDecorator(INotify notification)
        {
            _notification = notification;
        }

        public virtual void SendNotification(string message)
        {
            _notification.SendNotification(message);
        }
    }
}
