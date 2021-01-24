

using HomeWork5.Entities;
using System;

namespace HomeWork5.Services
{
    class EDevletServices : IEDevletServices
    {
        public void IdentityCheck(Player player)
        {
            Console.WriteLine("E Devlet Services: "+player.firstName + " " + player.lastName + "'s information is correct.");
        }
    }
}
