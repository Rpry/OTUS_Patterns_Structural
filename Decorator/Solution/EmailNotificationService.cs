using System;

namespace Decorator.Solution
{
    public class EmailNotificationService : BaseExternalSystemNotifier
    {
        public EmailNotificationService(INotificationService notificationService) : base(notificationService)
        {
        }
        
        public override void Notify()
        {
            Console.WriteLine("Notify Email pre action");
            base.Notify();
            Console.WriteLine("Notify Email post action");
        }
    }
}