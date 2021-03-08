using System;
using GamerProject.Abstract;
using GamerProject.Adapters;
using GamerProject.Concrete;
using GamerProject.Entities;

namespace GamerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager gamerManager = new GamerManager(new MernisServiceAdapter());

            Gamer gamer1 = new Gamer()
            {
                FirstName = "Abdurrahman Görkem",
                LastName = "ARISOY",
                BirthDate = new DateTime(1988,4,9),
                NationalIdNumber = "38422550582",
                Id = 1
            };

            gamerManager.Save(gamer1);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);

            Game game1 = new Game()
            {
                GameName = "Clash of Clans",
                GameDescription = "Mühteşem bir oyun",
                GameId = 1,
                GamePrice = 25
            };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Update(game1);
            gameManager.Delete(game1);

            Kampanya kampanya1 = new Kampanya()
            {
                CampName = "Büyük Kampanya",
                CampDiscount = 25,
                CampId = 1
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(kampanya1);
            campaignManager.Update(kampanya1);
            campaignManager.Delete(kampanya1);

            SalesManager salesManager = new SalesManager();
            salesManager.Sale(gamer1,game1);
            salesManager.CampaignSale(gamer1,game1,kampanya1);

            Console.ReadLine();

        }
    }
}
