using HomeWork5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5.Managers
{
    class GameManager : IGameManager
    {
        List<Game> gameList = new List<Game>();
        public void Add(Game game)
        {
            gameList.Add(game);
            Console.WriteLine(game.name + " has been added.");
        }

        public void Delete(Game game)
        {
            gameList.Remove(game);
            Console.WriteLine("Game has been deleted.");
        }

        public void GetAll(CampaignManager campaignManager)
        {
            foreach (var game in gameList)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Game: " + game.id);
                Console.WriteLine("Game: " + game.name);
                Console.WriteLine("Price: " + game.price);
                Console.WriteLine("Stock: " + game.stock);
                campaignManager.GetCampaign(game);
            }
        }

        public Game GetGame(int id)
        {
            Game game1 = new Game();
            foreach (var game in gameList)
            {
                if(game.id == id) {
                game1 = game;
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Id: " + game.id);
                Console.WriteLine("Game: " + game.name);
                Console.WriteLine("Price: " + game.price);
                Console.WriteLine("Stock: " + game.stock);
                }
            }
            return game1;
        }

        public void Sales(Game game, Player player,CampaignManager campaignManager)
        {
            campaignManager.GetCampaign(game);
            Console.WriteLine(game.name + " game was sold to " + player.firstName + " " + player.lastName +".");
        }

        public void Update(Game lastGame, Game newGame)
        {
            gameList.Remove(lastGame);
            gameList.Add(newGame);
            Console.WriteLine(newGame.name + " has been updated.");
        }
    }
}
