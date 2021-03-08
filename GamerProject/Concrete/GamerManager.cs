using System;
using System.Collections.Generic;
using System.Text;
using GamerProject.Abstract;
using GamerProject.Entities;

namespace GamerProject.Concrete
{
    public class GamerManager:BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService; //IGamerCheckService interfaceini kullanarak bir _gamerCheckService tanımladık.

        public GamerManager(IGamerCheckService gamerCheckService)   //IgamerCheckService tipinde gelen gamerCheckService geliyor
        {
            _gamerCheckService = gamerCheckService; //bunun referansını _gamerCheckService e tutturuyoruz

        }

        public override void Save(Gamer gamer)  //BaseGamerManager'da Save işlemini ovverride ettik.
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                Console.WriteLine("Not a valid person");
            }
            
        }

    }
}
