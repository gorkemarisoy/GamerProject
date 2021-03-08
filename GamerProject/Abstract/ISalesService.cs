using System;
using System.Collections.Generic;
using System.Text;
using GamerProject.Entities;

namespace GamerProject.Abstract
{
    public interface ISalesService
    {
        public void Sale(Gamer gamer, Game game);
        public void CampaignSale(Gamer gamer, Game game, Kampanya kampanya);
    }
}
