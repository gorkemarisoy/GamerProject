using System;
using System.Collections.Generic;
using System.Text;
using GamerProject.Abstract;
using GamerProject.Entities;

namespace GamerProject.Concrete
{
    public class GameManager:IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+"    GameDB'e eklendi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "    GameDB'de güncellendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "    GameDB'den silindi");
        }
    }
}
