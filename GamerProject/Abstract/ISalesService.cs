using System;
using System.Collections.Generic;
using System.Text;
using GamerProject.Entities;

namespace GamerProject.Abstract
{
    public interface ISalesService      //Sales için Sale ve CampaignSale işlemlerini tanımladığımız Interface
    {
        public void Sale(Gamer gamer, Game game);   //normal satışta satace Gamer ve Game
        public void CampaignSale(Gamer gamer, Game game, Kampanya kampanya); //kampanyalı satışta Kampanya'da parametreler arasında
    }
}
