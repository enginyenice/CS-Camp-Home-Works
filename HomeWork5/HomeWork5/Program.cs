using HomeWork5.Entities;
using HomeWork5.Managers;
using System;

namespace HomeWork5
{
    class Program
    {
        public static PlayerManager playerManager = new PlayerManager();
        public static GameManager gameManager = new GameManager();
        public static CampaignManager campaignManager = new CampaignManager();
        static void Main(string[] args)
        {
            while (true)
            {
                string menu = "";
                Console.WriteLine("General Menu");
                Console.WriteLine("1- Player");
                Console.WriteLine("2- Game");
                Console.WriteLine("3- Campaign");
                Console.WriteLine("4- Sale");
                menu = Console.ReadLine();

                
                switch (Int32.Parse(menu))
                {
                    case 1:
                        PlayerMenu();
                        break;
                    case 2:
                        GameMenu();
                        break;
                    case 3:
                        CampaignMenu();
                        break;
                    case 4:
                        Sale();
                        break;
                    default:
                        break;
                }
            }
        }

        static void PlayerMenu()
        {
            Console.Clear();
            string menu = "";
            Console.WriteLine("Player Menu");
            Console.WriteLine("1- Add");
            Console.WriteLine("2- Update");
            Console.WriteLine("3- Delete");
            menu = Console.ReadLine();


            switch (Int32.Parse(menu))
            {
                case 1:
                    PlayerAdd();
                    break;
                case 2:
                    PlayerUpdate();
                    break;
                case 3:
                    PlayerDelete();
                    break;
                default:
                    break;
            }


        }
        static void GameMenu()
        {
            Console.Clear();
            string menu = "";
            Console.WriteLine("Game Menu");
            Console.WriteLine("1- Add");
            Console.WriteLine("2- Update");
            Console.WriteLine("3- Delete");
            menu = Console.ReadLine();


            switch (Int32.Parse(menu))
            {
                case 1:
                    GameAdd();
                    break;
                case 2:
                    GameUpdate();
                    break;
                case 3:
                    GameDelete();
                    break;
                default:
                    break;
            }
        }
        static void CampaignMenu()
        {
            Console.Clear();
            string menu = "";
            Console.WriteLine("Campaign Menu");
            Console.WriteLine("1- Add");
            Console.WriteLine("2- Update");
            Console.WriteLine("3- Delete");
            menu = Console.ReadLine();


            switch (Int32.Parse(menu))
            {
                case 1:
                    CampaignAdd();
                    break;
                case 2:
                    CampaignUpdate();
                    break;
                case 3:
                    CampaignDelete();
                    break;
                default:
                    break;
            }
        }
       
        static void PlayerAdd()
        {
            Player player = new Player();

            Console.WriteLine("Id");
            player.id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First Name");
            player.firstName = Console.ReadLine();

            Console.WriteLine("Last Name");
            player.lastName = Console.ReadLine();

            Console.WriteLine("TC Number");
            player.TCNumber = Console.ReadLine();

            Console.WriteLine("Birth Year");
            player.birthYear= Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            playerManager.Add(player);
            Console.ReadKey();
            Console.Clear();
        }
        static void PlayerUpdate()
        {

            Console.WriteLine("-----Player List-----");
            playerManager.GetAllPlayer();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Edit Player Id");
            int id = -1;
            id = Convert.ToInt32(Console.ReadLine());

            Player lastPlayer = playerManager.GetPlayer(id);

            
            Player player = new Player();

            Console.WriteLine("Id");
            player.id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First Name");
            player.firstName = Console.ReadLine();

            Console.WriteLine("Last Name");
            player.lastName = Console.ReadLine();

            Console.WriteLine("TC Number");
            player.TCNumber = Console.ReadLine();

            Console.WriteLine("Birth Year");
            player.birthYear = Convert.ToInt32(Console.ReadLine());


            Console.Clear();
            playerManager.Update(lastPlayer,player);
            Console.ReadKey();
            Console.Clear();

        }
        static void PlayerDelete()
        {
            Console.WriteLine("-----Player List-----");
            playerManager.GetAllPlayer();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Delete Player Id");
            int id = -1;
            id = Convert.ToInt32(Console.ReadLine());

            Player player = playerManager.GetPlayer(id);
            Console.Clear();
            playerManager.Delete(player);
            Console.ReadKey();
            Console.Clear();
        }

        static void GameAdd()
        {
            Game game = new Game();

            Console.WriteLine("Id");
            game.id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Game Name");
            game.name = Console.ReadLine();

            Console.WriteLine("Price");
            game.price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Stock");
            game.stock = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            gameManager.Add(game);
            Console.ReadKey();
            Console.Clear();

        }
        static void GameUpdate()
        {
            Console.WriteLine("Game List");
            gameManager.GetAll(campaignManager);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Edit Game Id");
            int id = -1;
            id = Convert.ToInt32(Console.ReadLine());

            Game lastGame = gameManager.GetGame(id);


            Game game = new Game();

            Console.WriteLine("Id");
            game.id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Game Name");
            game.name = Console.ReadLine();

            Console.WriteLine("Price");
            game.price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Stock");
            game.stock = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            gameManager.Update(lastGame, game);
            Console.ReadKey();
            Console.Clear();

        }
        static void GameDelete()
        {
            Console.WriteLine("Game List");
            gameManager.GetAll(campaignManager);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Delete Game Id");
            int id = -1;
            id = Convert.ToInt32(Console.ReadLine());

            Game game= gameManager.GetGame(id);
           
            Console.Clear();
            gameManager.Delete(game);
            Console.ReadKey();
            Console.Clear();
        }
        static void CampaignAdd()
        {
            Console.Clear();
            Console.WriteLine("Game List");
            gameManager.GetAll(campaignManager);
            Console.WriteLine("-----------------------");
            Campaign campaign= new Campaign();

            Console.WriteLine("Id");
            campaign.id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Game Id");
            int gameid = -1;
            gameid = Convert.ToInt32(Console.ReadLine());
            campaign.game = gameManager.GetGame(gameid);

            Console.WriteLine("Discounted Price");
            campaign.discountedPrice = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            campaignManager.Add(campaign);
            Console.ReadKey();
            Console.Clear();
        }
        static void CampaignUpdate()
        {
            campaignManager.GetAll();
            Console.WriteLine("Edit Campaign Id");
            int id = -1;
            id = Convert.ToInt32(Console.ReadLine());

            Campaign lastCampaign = campaignManager.GetCampaign(id);


            Campaign campaign = new Campaign();

            Console.WriteLine("Id");
            campaign.id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Game Id");
            int campaignId = -1;
            campaignId = Convert.ToInt32(Console.ReadLine());

            campaign.game = gameManager.GetGame(campaignId);

            Console.WriteLine("Discounted Price");
            campaign.discountedPrice = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            campaignManager.Update(lastCampaign, campaign);
            Console.ReadKey();
            Console.Clear();

        }
        static void CampaignDelete()
        {
            campaignManager.GetAll();
            Console.WriteLine("Delete Campaign Id");
            int id = -1;
            id = Convert.ToInt32(Console.ReadLine());

            Campaign campaign = campaignManager.GetCampaign(id);

            Console.Clear();
            campaignManager.Delete(campaign);
            Console.ReadKey();
            Console.Clear();
        }
        static void Sale()
        {
            Console.Clear();
            Console.WriteLine("Game List");
            gameManager.GetAll(campaignManager);
            Console.WriteLine("-----------------------");

            

            Console.WriteLine("Game Id");
            int gameId = -1;
            gameId = Convert.ToInt32(Console.ReadLine());

            Game selectedGame = gameManager.GetGame(gameId);
            Console.Clear();
            Console.WriteLine("Player List");
            playerManager.GetAllPlayer();
            Console.WriteLine("-----------------------");

            Console.WriteLine("Player Id");
            int playerId = -1;
            playerId = Convert.ToInt32(Console.ReadLine());

            Player selectedPlayer = playerManager.GetPlayer(playerId);
            Console.Clear();
            gameManager.Sales(selectedGame,selectedPlayer,campaignManager);
            Console.ReadKey();
            Console.Clear();

        }
    }
}
