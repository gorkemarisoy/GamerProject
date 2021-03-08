using System;
using System.Collections.Generic;
using System.Text;
using GamerProject.Entities;

namespace GamerProject.Abstract
{
    public interface IGamerService
    {
        public void Save(Gamer gamer); // Gamer için Save,Update ve Delete işlemlerini tanımladığımız interface
        public void Update(Gamer gamer);    //metotların parametresi Gamer tipinde gamer bilgileri
        public void Delete(Gamer gamer);
    }
}
