using System;
using Decorator.Solution;
using Facade.Solution;
using Facade.Solution.Dto;
using YouTubeLibrary;

namespace StructuralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            #region Adapter

            var cardInfo = new Adapter.Solution.CardInfo()
            {
                Id = Guid.NewGuid(),
                StartDate = DateTime.UtcNow
            };
            var cardManager = new Adapter.Solution.CardManager();
            cardManager.Issue(cardInfo);

            #endregion
            */

            /*
            #region Decorator

            var notificationOptions = new NotificationOptions()
            {
                SendToEmail = true,
                SendToSms = false,
                SendFBNotification = true
            };
            var decoratorCardManager = new Decorator.Solution.CardManager(notificationOptions);
            decoratorCardManager.Issue();

            #endregion
            */
            
            /*
            #region Facade


            var printFormDataService = new PrintFormDataService();
            var printFormTemplateService = new PrintFormTemplateService();
            var printFormGenerator = new PrintFormGenerator();
            var printService = new PrintFormService(printFormDataService, printFormTemplateService, printFormGenerator);
            var decoratorCardManager = new Facade.Solution.DocumentService(printService);
            var documentDto = new Facade.Solution.Dto.DocumentDto();
            var printForm = decoratorCardManager.GeneratePrintForm(documentDto);

            #endregion
            */
            
            /*
            #region Proxy

            var youTubeThirdPartyManager = new YouTubeThirdPartyManager();
            var youTubeThirdPartyManagerCached =
                new Proxy.Solution.YouTubeThirdPartyManagerCached(youTubeThirdPartyManager);
            var youTubeManager = new Proxy.Solution.YouTubeManager(youTubeThirdPartyManagerCached);
            youTubeManager.RenderVideoPage(1);
            youTubeManager.RenderVideoPage(1);

            #endregion
            */
            /*
            #region Bridge

            var device = new Bridge.Solution.Tv();
            var remote = new Bridge.Solution.Remote(device);
            remote.TogglePower();

            #endregion
            */
            
            /*
            #region Flyweight

            var forest = new Flyweight.Solution.Forest();
            forest.PlantTree(1,1, "Ель", 100, 303);
            forest.PlantTree(3,5, "Яблоня", 100, 303);
            forest.PlantTree(30,50, "Яблоня", 100, 303);
            forest.Draw(344);

            #endregion
            */
            
            /*   
            #region Composite

            var pie = new Composite.Solution.Pie(10);
            var container = new Composite.Solution.Container(1);
            container.AddProduct(pie);
            var price = container.GetPrice();

            #endregion
            */
        }
    }
}