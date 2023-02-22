using System;

namespace Decorator.Solution
{
    public class FaceBookNotificationService : BaseExternalSystemNotifier
    {
        public FaceBookNotificationService(INotificationService notificationService) 
            : base(notificationService)
        {
        }
        
        public override void Notify()
        {
            Console.WriteLine("Notify Facebook pre action");
            base.Notify();
            Console.WriteLine("Notify Facebook post action");
        }
    }
}