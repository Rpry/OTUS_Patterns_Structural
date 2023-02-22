using System;

namespace Decorator.Solution
{
    public class SmsNotificationService : BaseExternalSystemNotifier
    {
        public SmsNotificationService(INotificationService notificationService) : base(notificationService)
        {
        }
        
        public override void Notify()
        {
            Console.WriteLine("Notify Sms pre action");
            base.Notify();
            Console.WriteLine("Notify Sms post action");
        }
    }
}