using HomeWork5.Entities;
using HomeWork5.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5.Managers
{
    class CampaignManager : ICampaignManager
    {
        List<Campaign> campaignList = new List<Campaign>();
        public void Add(Campaign campaign)
        {
            campaignList.Add(campaign);
            Console.WriteLine("The campaign has been added.");
        }

        public void Delete(Campaign campaign)
        {
            campaignList.Remove(campaign);
            Console.WriteLine("The campaign has been deleted.");
        }

        public void GetAll()
        {
            foreach (var campaign in campaignList)
            {
              
                Console.WriteLine("--Campaign--");
                Console.WriteLine("Campaign Id: " + campaign.id);
                Console.WriteLine("Game: " + campaign.game.name);
                Console.WriteLine("Price" + campaign.game.price);
                Console.WriteLine("Discounted Price: " + campaign.discountedPrice);
                    
            }
        }

        public void GetCampaign(Game game)
        {
            foreach (var campaign in campaignList)
            {
                if(campaign.game.id == game.id)
                {
                    Console.WriteLine("--Campaign--");
                    Console.WriteLine("Discounted Price: " + campaign.discountedPrice);
                }
            }
        }
        public Campaign GetCampaign(int id)
        {
            Campaign campaign1 = new Campaign();
            foreach (var campaign in campaignList)
            {
                if (campaign.id == id)
                {
                    campaign1 = campaign;
                    Console.WriteLine("--Campaign--");
                    Console.WriteLine("Discounted Price: " + campaign.discountedPrice);
                }
            }
            return campaign1;
        }
        public void Update(Campaign lastCampaign, Campaign newCampaign)
        {
            campaignList.Remove(lastCampaign);
            campaignList.Add(newCampaign);
            Console.WriteLine("The campaign has been updated.");
        }

    }
}
