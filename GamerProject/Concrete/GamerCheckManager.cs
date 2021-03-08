using System;
using System.Collections.Generic;
using System.Text;
using GamerProject.Abstract;
using GamerProject.Entities;

namespace GamerProject.Concrete
{
    public class GamerCheckManager:IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)  //public bool tanımladık gamer parametreli
        {
            return true; //bu manuel test için kullanacağımız manager
        }
    }
}
