﻿using raul.Models.Db;
using raul.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaulWebApi.Services
{
    public partial class GameService : GenericService
    {

        public Game getNextGame (Competition competition)
        {
            //Game nextGame = this.dbContext.Game.FirstOrDefault(c => c.CompetitionName == competition.ComptName && c.IsOver == true);
            return new Game(1,new Team(), 2, new Team());
        }

        public void persistGame (Game game)
        {
            //dbContext.Game.Add(game);
        }
    }
}
