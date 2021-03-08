﻿using System;
using System.Collections.Generic;
using System.Text;
using GamerProject.Entities;

namespace GamerProject.Abstract
{
  public  interface IGameService
  {
      public void Add(Game game);
      public void Update(Game game);
      public void Delete(Game game);

  }
}
