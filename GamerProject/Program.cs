using System;
using GamerProject.Abstract;
using GamerProject.Adapters;
using GamerProject.Concrete;
using GamerProject.Entities;

namespace GamerProject
{
    class Program           //Program kısmında sadece gamer yönetimi, game yönetimi ve sales yönetimi var
    {
        static void Main(string[] args)
        {
            BaseGamerManager gamerManager = new GamerManager(new MernisServiceAdapter()); // gameManager newledik ama Mernis servisi ile

            Gamer gamer1 = new Gamer()  //gamer1 tanımlama
            {
                FirstName = "Abdurrahman Görkem",
                LastName = "ARISOY",
                BirthDate = new DateTime(1988,4,9),
                NationalIdNumber = "38422550582",
                Id = 1
            };

            gamerManager.Save(gamer1);          //gamerManager kullanımı
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);

            Game game1 = new Game()     //game1 tanımlama
            {
                GameName = "Clash of Clans",
                GameDescription = "Mühteşem bir oyun",
                GameId = 1,
                GamePrice = 25
            };

            GameManager gameManager = new GameManager();        //gameManager newledik.
            gameManager.Add(game1);
            gameManager.Update(game1);      //gameManager kullanımı
            gameManager.Delete(game1);

            Kampanya kampanya1 = new Kampanya()     //kampanya1 tanımlama
            {
                CampName = "Büyük Kampanya",
                CampDiscount = 25,
                CampId = 1
            };

            CampaignManager campaignManager = new CampaignManager();    //campaignManager newledik
            campaignManager.Add(kampanya1);
            campaignManager.Update(kampanya1);  //campaignManager kullanımı
            campaignManager.Delete(kampanya1);

            SalesManager salesManager = new SalesManager();     //salesManager Newledik
            salesManager.Sale(gamer1,game1);
            salesManager.CampaignSale(gamer1,game1,kampanya1);  //kullanımı

            Console.ReadLine();

        }
    }
}
