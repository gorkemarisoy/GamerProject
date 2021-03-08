using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using GamerProject.Abstract;
using GamerProject.Entities;

namespace GamerProject.Concrete
{
    class CampaignManager:ICampaignService
    {
        public void Add(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Eklendi    :" + kampanya.CampName);
        }

        public void Delete(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Silindi    :" + kampanya.CampName);
        }

        public void Update(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya Güncellendi    :" + kampanya.CampName);
        }

      
    }
}
