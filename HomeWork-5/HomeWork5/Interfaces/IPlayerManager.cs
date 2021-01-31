using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5.Entities
{
    interface IPlayerManager
    {
        void Add(Player player);
        void Update(Player lastPlayer, Player newPlayer);
        void Delete(Player player);
        Player GetPlayer(int id);
        void GetAllPlayer();

    }
}
