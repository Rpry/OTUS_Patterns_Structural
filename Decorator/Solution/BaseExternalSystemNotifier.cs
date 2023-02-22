namespace Decorator.Solution
{
    public class BaseExternalSystemNotifier : INotificationService
    {
        private readonly INotificationService _notificationService;

        protected BaseExternalSystemNotifier(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        
        public virtual void Notify()
        {
            _notificationService.Notify();
        }
    }
}