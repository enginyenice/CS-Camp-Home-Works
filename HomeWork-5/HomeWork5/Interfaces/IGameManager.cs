using HomeWork5.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5.Entities
{
    interface IGameManager
    {
        public void Add(Game game);
        public void Update(Game lastGame, Game newGame);
        public void Delete(Game game);
        public void GetAll(CampaignManager campaignManager);
        public Game GetGame(int id);
        public void Sales(Game game, Player player,CampaignManager campaignManager);
    }
}
