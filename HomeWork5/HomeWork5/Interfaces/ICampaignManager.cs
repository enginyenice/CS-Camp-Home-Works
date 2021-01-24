using HomeWork5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5.Interfaces
{
    interface ICampaignManager
    {
        void Add(Campaign campaign);
        void Update(Campaign lastCampaign, Campaign newCampaign);
        void Delete(Campaign campaign);
        Campaign GetCampaign(int id);
        void GetCampaign(Game game);

        void GetAll();
    }
}
