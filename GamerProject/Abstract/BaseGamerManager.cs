using System;
using System.Collections.Generic;
using System.Text;
using GamerProject.Entities;

namespace GamerProject.Abstract
{
    public abstract class BaseGamerManager:IGamerService
    {
        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+"   DB'e kaydedildi");
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "   DB'de güncellendi");
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "   DB'den silindi");
        }
    }
}
