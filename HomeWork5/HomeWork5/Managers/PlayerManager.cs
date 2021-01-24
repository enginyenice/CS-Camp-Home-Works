using HomeWork5.Entities;
using HomeWork5.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5.Managers
{
    class PlayerManager : IPlayerManager
    {
        List<Player> players = new List<Player>();
        public void Add(Player player)
        {
            EDevletServices eDevlet = new EDevletServices();
            eDevlet.IdentityCheck(player);
            players.Add(player);
            Console.WriteLine(player.firstName + " " + player.lastName + " was registered.");
        }
        public void Delete(Player player)
        {
            players.Remove(player);
            Console.WriteLine("The player has been deleted.");
        }

        public void GetAllPlayer()
        {
            foreach (var player in players)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Id: " + player.id);
                Console.WriteLine("First Name: " + player.firstName);
                Console.WriteLine("Last Name: " + player.lastName);
                Console.WriteLine("Birth Year: "+ player.birthYear);
                Console.WriteLine("TC Number: "+player.TCNumber);
            }
        }

        public Player GetPlayer(int id)
        {
            Player player1 = new Player();
            foreach (var player in players)
            {
                if(player.id == id) {
                player1 = player;
                Console.WriteLine("--------------------------------");
                Console.WriteLine("First Name: " + player.firstName);
                Console.WriteLine("Last Name: " + player.lastName);
                Console.WriteLine("Birth Year: " + player.birthYear);
                Console.WriteLine("TC Number: " + player.TCNumber);
                }
            }
            return player1;
        }

        public void Update(Player lastPlayer,Player newPlayer)
        {
            EDevletServices eDevlet = new EDevletServices();
            eDevlet.IdentityCheck(newPlayer);
            players.Remove(lastPlayer);
            players.Add(newPlayer);
            Console.WriteLine(newPlayer.firstName + " " + newPlayer.lastName + " has been updated.");
        }
    }
}
