using System;
using System.Collections.Generic;
using System.Text;
using GamerProject.Entities;

namespace GamerProject.Abstract
{
    public interface ICampaignService
    {
        public void Add(Kampanya kampanya);
        public void Delete(Kampanya kampanya);
        public void Update(Kampanya kampanya);
    }
}
