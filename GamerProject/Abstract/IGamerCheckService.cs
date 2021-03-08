using System;
using System.Collections.Generic;
using System.Text;
using GamerProject.Entities;

namespace GamerProject.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer); //true yada false döndür
    }
}
