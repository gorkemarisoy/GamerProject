using System;
using System.Collections.Generic;
using System.Text;
using GamerProject.Abstract;
using GamerProject.Entities;

namespace GamerProject.Concrete
{
    class SalesManager:ISalesService
    {
        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName+"'e  "+ game.GameName+ "  adlı oyun satıldı");
        }

        public void CampaignSale(Gamer gamer, Game game, Kampanya kampanya)
        {
            Console.WriteLine(gamer.FirstName + "'e  " + game.GameName + "  adlı oyun yüzde "+ kampanya.CampDiscount+"  indirimle satıldı.");
        }
    }
}
