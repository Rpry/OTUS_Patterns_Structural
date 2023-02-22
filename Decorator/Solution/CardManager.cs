using CardLibrary;

namespace Decorator.Solution
{
    public class CardManager
    {
        private CardIssueService _cardIssueService;
        private NotificationOptions _notificationOptions;

        public CardManager(NotificationOptions notificationOptions)
        {
            _cardIssueService = new CardIssueService();
            _notificationOptions = notificationOptions;
        }
        
        public void Issue()
        {
            _cardIssueService.Issue(new Message());
            INotificationService notificationService = new ApplicationNotifier();
            if (_notificationOptions.SendFBNotification)
            {
                notificationService = new FaceBookNotificationService(notificationService);
            }

            if (_notificationOptions.SendToSms)
            {
                notificationService = new SmsNotificationService(notificationService);
            }

            if (_notificationOptions.SendToEmail)
            {
                notificationService = new EmailNotificationService(notificationService);
            }
            
            notificationService.Notify();
        }
    }
}