using System;
using System.Collections.Generic;
using System.Text;
using GamerProject.Abstract;

namespace GamerProject.Entities
{
    public class Game:IEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int GamePrice { get; set; }
        public string GameDescription { get; set; }

    }
}
