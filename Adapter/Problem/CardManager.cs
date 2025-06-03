using CardLibrary;

namespace Problem
{
    public class CardManager
    {
        public void Issue(CardInfo cardInfo)
        {
            var cardIssueService = new CardIssueService();
            var theirsModel = new Message(){Content = " сформировать сериализацией "};
            cardIssueService.Issue(theirsModel);
        }
    }
}